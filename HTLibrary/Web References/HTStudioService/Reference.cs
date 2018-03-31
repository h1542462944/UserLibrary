﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.42000 版自动生成。
// 
#pragma warning disable 1591

namespace User.HTStudioService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IHTStudioService", Namespace="http://tempuri.org/")]
    public partial class HTStudioService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetDataOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetDataUsingDataContractOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetDownloadTaskFromFileOperationCompleted;
        
        private System.Threading.SendOrPostCallback DownloadOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetExtendedPathOperationCompleted;
        
        private System.Threading.SendOrPostCallback CheckUpdateOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetUpdateTaskOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public HTStudioService() {
            this.Url = global::User.Properties.Settings.Default.HTLibrary_HTStudioService_HTStudioService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetDataCompletedEventHandler GetDataCompleted;
        
        /// <remarks/>
        public event GetDataUsingDataContractCompletedEventHandler GetDataUsingDataContractCompleted;
        
        /// <remarks/>
        public event GetDownloadTaskFromFileCompletedEventHandler GetDownloadTaskFromFileCompleted;
        
        /// <remarks/>
        public event DownloadCompletedEventHandler DownloadCompleted;
        
        /// <remarks/>
        public event GetExtendedPathCompletedEventHandler GetExtendedPathCompleted;
        
        /// <remarks/>
        public event CheckUpdateCompletedEventHandler CheckUpdateCompleted;
        
        /// <remarks/>
        public event GetUpdateTaskCompletedEventHandler GetUpdateTaskCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHTStudioService/GetData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string GetData(int value, [System.Xml.Serialization.XmlIgnoreAttribute()] bool valueSpecified) {
            object[] results = this.Invoke("GetData", new object[] {
                        value,
                        valueSpecified});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetDataAsync(int value, bool valueSpecified) {
            this.GetDataAsync(value, valueSpecified, null);
        }
        
        /// <remarks/>
        public void GetDataAsync(int value, bool valueSpecified, object userState) {
            if ((this.GetDataOperationCompleted == null)) {
                this.GetDataOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDataOperationCompleted);
            }
            this.InvokeAsync("GetData", new object[] {
                        value,
                        valueSpecified}, this.GetDataOperationCompleted, userState);
        }
        
        private void OnGetDataOperationCompleted(object arg) {
            if ((this.GetDataCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDataCompleted(this, new GetDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHTStudioService/GetDataUsingDataContract", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public CompositeType GetDataUsingDataContract([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] CompositeType composite) {
            object[] results = this.Invoke("GetDataUsingDataContract", new object[] {
                        composite});
            return ((CompositeType)(results[0]));
        }
        
        /// <remarks/>
        public void GetDataUsingDataContractAsync(CompositeType composite) {
            this.GetDataUsingDataContractAsync(composite, null);
        }
        
        /// <remarks/>
        public void GetDataUsingDataContractAsync(CompositeType composite, object userState) {
            if ((this.GetDataUsingDataContractOperationCompleted == null)) {
                this.GetDataUsingDataContractOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDataUsingDataContractOperationCompleted);
            }
            this.InvokeAsync("GetDataUsingDataContract", new object[] {
                        composite}, this.GetDataUsingDataContractOperationCompleted, userState);
        }
        
        private void OnGetDataUsingDataContractOperationCompleted(object arg) {
            if ((this.GetDataUsingDataContractCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDataUsingDataContractCompleted(this, new GetDataUsingDataContractCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHTStudioService/GetDownloadTaskFromFile", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public DownloadTask GetDownloadTaskFromFile([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string rpath) {
            object[] results = this.Invoke("GetDownloadTaskFromFile", new object[] {
                        rpath});
            return ((DownloadTask)(results[0]));
        }
        
        /// <remarks/>
        public void GetDownloadTaskFromFileAsync(string rpath) {
            this.GetDownloadTaskFromFileAsync(rpath, null);
        }
        
        /// <remarks/>
        public void GetDownloadTaskFromFileAsync(string rpath, object userState) {
            if ((this.GetDownloadTaskFromFileOperationCompleted == null)) {
                this.GetDownloadTaskFromFileOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDownloadTaskFromFileOperationCompleted);
            }
            this.InvokeAsync("GetDownloadTaskFromFile", new object[] {
                        rpath}, this.GetDownloadTaskFromFileOperationCompleted, userState);
        }
        
        private void OnGetDownloadTaskFromFileOperationCompleted(object arg) {
            if ((this.GetDownloadTaskFromFileCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDownloadTaskFromFileCompleted(this, new GetDownloadTaskFromFileCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHTStudioService/Download", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public DownloadResult Download([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] DownloadTask task, int indexOf, [System.Xml.Serialization.XmlIgnoreAttribute()] bool indexOfSpecified) {
            object[] results = this.Invoke("Download", new object[] {
                        task,
                        indexOf,
                        indexOfSpecified});
            return ((DownloadResult)(results[0]));
        }
        
        /// <remarks/>
        public void DownloadAsync(DownloadTask task, int indexOf, bool indexOfSpecified) {
            this.DownloadAsync(task, indexOf, indexOfSpecified, null);
        }
        
        /// <remarks/>
        public void DownloadAsync(DownloadTask task, int indexOf, bool indexOfSpecified, object userState) {
            if ((this.DownloadOperationCompleted == null)) {
                this.DownloadOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDownloadOperationCompleted);
            }
            this.InvokeAsync("Download", new object[] {
                        task,
                        indexOf,
                        indexOfSpecified}, this.DownloadOperationCompleted, userState);
        }
        
        private void OnDownloadOperationCompleted(object arg) {
            if ((this.DownloadCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DownloadCompleted(this, new DownloadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHTStudioService/GetExtendedPath", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public ExtendedPath GetExtendedPath() {
            object[] results = this.Invoke("GetExtendedPath", new object[0]);
            return ((ExtendedPath)(results[0]));
        }
        
        /// <remarks/>
        public void GetExtendedPathAsync() {
            this.GetExtendedPathAsync(null);
        }
        
        /// <remarks/>
        public void GetExtendedPathAsync(object userState) {
            if ((this.GetExtendedPathOperationCompleted == null)) {
                this.GetExtendedPathOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetExtendedPathOperationCompleted);
            }
            this.InvokeAsync("GetExtendedPath", new object[0], this.GetExtendedPathOperationCompleted, userState);
        }
        
        private void OnGetExtendedPathOperationCompleted(object arg) {
            if ((this.GetExtendedPathCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetExtendedPathCompleted(this, new GetExtendedPathCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHTStudioService/CheckUpdate", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void CheckUpdate([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string softWareName, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string version, out UpdateType CheckUpdateResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool CheckUpdateResultSpecified) {
            object[] results = this.Invoke("CheckUpdate", new object[] {
                        softWareName,
                        version});
            CheckUpdateResult = ((UpdateType)(results[0]));
            CheckUpdateResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void CheckUpdateAsync(string softWareName, string version) {
            this.CheckUpdateAsync(softWareName, version, null);
        }
        
        /// <remarks/>
        public void CheckUpdateAsync(string softWareName, string version, object userState) {
            if ((this.CheckUpdateOperationCompleted == null)) {
                this.CheckUpdateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCheckUpdateOperationCompleted);
            }
            this.InvokeAsync("CheckUpdate", new object[] {
                        softWareName,
                        version}, this.CheckUpdateOperationCompleted, userState);
        }
        
        private void OnCheckUpdateOperationCompleted(object arg) {
            if ((this.CheckUpdateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CheckUpdateCompleted(this, new CheckUpdateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IHTStudioService/GetUpdateTask", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/HTStudioService")]
        public DownloadTask[] GetUpdateTask([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string softWareName, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string version) {
            object[] results = this.Invoke("GetUpdateTask", new object[] {
                        softWareName,
                        version});
            return ((DownloadTask[])(results[0]));
        }
        
        /// <remarks/>
        public void GetUpdateTaskAsync(string softWareName, string version) {
            this.GetUpdateTaskAsync(softWareName, version, null);
        }
        
        /// <remarks/>
        public void GetUpdateTaskAsync(string softWareName, string version, object userState) {
            if ((this.GetUpdateTaskOperationCompleted == null)) {
                this.GetUpdateTaskOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetUpdateTaskOperationCompleted);
            }
            this.InvokeAsync("GetUpdateTask", new object[] {
                        softWareName,
                        version}, this.GetUpdateTaskOperationCompleted, userState);
        }
        
        private void OnGetUpdateTaskOperationCompleted(object arg) {
            if ((this.GetUpdateTaskCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetUpdateTaskCompleted(this, new GetUpdateTaskCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/HTStudioService")]
    public partial class CompositeType {
        
        private bool boolValueField;
        
        private bool boolValueFieldSpecified;
        
        private string stringValueField;
        
        /// <remarks/>
        public bool BoolValue {
            get {
                return this.boolValueField;
            }
            set {
                this.boolValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BoolValueSpecified {
            get {
                return this.boolValueFieldSpecified;
            }
            set {
                this.boolValueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string StringValue {
            get {
                return this.stringValueField;
            }
            set {
                this.stringValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/HTStudioService")]
    public partial class DownloadResult {
        
        private byte[] dataField;
        
        private bool isSucceedField;
        
        private bool isSucceedFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", IsNullable=true)]
        public byte[] Data {
            get {
                return this.dataField;
            }
            set {
                this.dataField = value;
            }
        }
        
        /// <remarks/>
        public bool IsSucceed {
            get {
                return this.isSucceedField;
            }
            set {
                this.isSucceedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsSucceedSpecified {
            get {
                return this.isSucceedFieldSpecified;
            }
            set {
                this.isSucceedFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/HTStudioService")]
    public partial class ExtendedPath {
        
        private string lastField;
        
        private string middleField;
        
        private string rootField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Last {
            get {
                return this.lastField;
            }
            set {
                this.lastField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Middle {
            get {
                return this.middleField;
            }
            set {
                this.middleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Root {
            get {
                return this.rootField;
            }
            set {
                this.rootField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/HTStudioService")]
    public partial class DownloadTask {
        
        private ExtendedPath extendedPathField;
        
        private bool isEmptyField;
        
        private bool isEmptyFieldSpecified;
        
        private int numField;
        
        private bool numFieldSpecified;
        
        private long sizeField;
        
        private bool sizeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public ExtendedPath ExtendedPath {
            get {
                return this.extendedPathField;
            }
            set {
                this.extendedPathField = value;
            }
        }
        
        /// <remarks/>
        public bool IsEmpty {
            get {
                return this.isEmptyField;
            }
            set {
                this.isEmptyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsEmptySpecified {
            get {
                return this.isEmptyFieldSpecified;
            }
            set {
                this.isEmptyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int Num {
            get {
                return this.numField;
            }
            set {
                this.numField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumSpecified {
            get {
                return this.numFieldSpecified;
            }
            set {
                this.numFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public long Size {
            get {
                return this.sizeField;
            }
            set {
                this.sizeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SizeSpecified {
            get {
                return this.sizeFieldSpecified;
            }
            set {
                this.sizeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/HTStudioService")]
    public enum UpdateType {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        Download,
        
        /// <remarks/>
        Upload,
        
        /// <remarks/>
        Equal,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void GetDataCompletedEventHandler(object sender, GetDataCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void GetDataUsingDataContractCompletedEventHandler(object sender, GetDataUsingDataContractCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDataUsingDataContractCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetDataUsingDataContractCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public CompositeType Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CompositeType)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void GetDownloadTaskFromFileCompletedEventHandler(object sender, GetDownloadTaskFromFileCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDownloadTaskFromFileCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetDownloadTaskFromFileCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public DownloadTask Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((DownloadTask)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void DownloadCompletedEventHandler(object sender, DownloadCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DownloadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DownloadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public DownloadResult Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((DownloadResult)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void GetExtendedPathCompletedEventHandler(object sender, GetExtendedPathCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetExtendedPathCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetExtendedPathCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ExtendedPath Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ExtendedPath)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void CheckUpdateCompletedEventHandler(object sender, CheckUpdateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CheckUpdateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CheckUpdateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public UpdateType CheckUpdateResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((UpdateType)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool CheckUpdateResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void GetUpdateTaskCompletedEventHandler(object sender, GetUpdateTaskCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetUpdateTaskCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetUpdateTaskCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public DownloadTask[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((DownloadTask[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591