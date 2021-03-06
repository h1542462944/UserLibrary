﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using static User.IO.UsbCopyer.UsbWatcher;

namespace User.IO
{
    public class UsbCopyer
    {
        public static string TimeStamp() { DateTime t = DateTime.Now; return t.Year.ToString() + "_" + t.Month.ToString() + "_" + t.Day.ToString() + "_" + t.Hour.ToString() + "_" + t.Minute.ToString() + "_" + t.Second.ToString() + "_" + t.Millisecond.ToString(); }
        /// <summary>
        /// 托盘图标
        /// </summary>
        private NotifyIcon notifyIcon = new NotifyIcon
        {
            Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath),
        };
        /// <summary>
        /// 例:  "G:/",初始化为
        /// </summary>
        private string hackDrive = DriveInfo.GetDrives().Last().DriveType == DriveType.Removable ? DriveInfo.GetDrives().Last().Name : "";
        /// <summary>
        /// 不点击托盘,直接进行copy
        /// </summary>
        private bool isDirectCopy = false;
        public bool IsDirectCopy
        {
            get => isDirectCopy; set
            {
                isDirectCopy = value;

            }
        }

        private bool isUseNotifyIcon = false;
        public bool IsUseNotifyIcon { get => isUseNotifyIcon; set { isUseNotifyIcon = value; notifyIcon.Visible = isUseNotifyIcon; } }
        private string dirBackup = "";
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dirBackup">备份路径,Exp:"D:/temp/"</param>
        /// <param name="isDirectCopy">直接拷贝模式</param>
        /// <param name="isUseNotifyIcon">使用托盘</param>
        public UsbCopyer(string dirBackup, bool isDirectCopy, bool isUseNotifyIcon)
        {
            this.dirBackup = dirBackup;
            IsDirectCopy = isDirectCopy;
            if (isUseNotifyIcon)
            {
                notifyIcon.MouseClick += new MouseEventHandler((o, e) =>
                {
                    NotifyIcon_click();
                });
            }
            else
            {
                notifyIcon.Dispose();
                notifyIcon = null;
            }
            if (IsDirectCopy)
            {
                UsbWatcher watcher = new UsbWatcher();
                watcher.UsbDiskEnter += UsbDiskEnter;
            }

        }
        private void UsbDiskEnter(object sender, UsbDiskEnterEventArgs e)
        {
            hackDrive = e.Drive.Name;
            CopyUSB();
        }
        /// <summary>
        /// 释放所有资源
        /// </summary>
        public void Dispose()
        {
            notifyIcon.Dispose();
        }
        private void NotifyIcon_click()
        {
            hackDrive = DriveInfo.GetDrives().Last().Name;
            CopyUSB();
        }
        /// <summary>
        /// 封装后的拷贝
        /// </summary>
        /// <param name="dirSource">源文件夹路径</param>
        /// <param name="dirDestination">目标文件夹路径</param>
        public void CopyUSB(string dirSource, string dirDestination)
        {
            Task.Run(() =>
            {
                string timestamp = TimeStamp();
                try
                {
                    Console.WriteLine("Coying:HackDrive={0},Path={1}", dirSource, dirDestination + timestamp);
                    UserIO.CopyFolder(dirSource, dirDestination + timestamp);
                        //SyncDir.Sync(dirSource,dirDestination);
                    }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                Console.WriteLine("Copy:{0} finished", timestamp);
            });
        }

        public void CopyUSB()
        {
            CopyUSB(hackDrive, dirBackup);
        }
        public class UsbWatcher
        {
            public class UsbDiskEnterEventArgs : EventArgs
            {
                public DriveInfo Drive;
                public UsbDiskEnterEventArgs(DriveInfo drive) { Drive = drive; Console.WriteLine("UsbDiskEnter:{0}", drive); }
            }
            private DriveInfo[] lastDrives = DriveInfo.GetDrives();
            public UsbWatcher()
            {
                DispatcherTimer timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
                timer.Tick += Timer_Tick;
                timer.Start();
            }
            public event EventHandler<UsbDiskEnterEventArgs> UsbDiskEnter;
            private void Timer_Tick(object sender, EventArgs e)
            {
                var s = DriveInfo.GetDrives();
                if (s.Length > lastDrives.Length && s.Last().DriveType == DriveType.Removable)
                {
                    UsbDiskEnter(sender, new UsbDiskEnterEventArgs(s.Last()));
                }
                lastDrives = s;
            }
        }
    }
}
