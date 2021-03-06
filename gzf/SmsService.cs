﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.3615
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// 此源代码由 wsdl 自动生成, Version=2.0.50727.42。
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name="SmsServiceSOAP11Binding", Namespace="http://axis2.fax.uniproud.com")]
public partial class SmsService : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
    private System.Threading.SendOrPostCallback SendSmsToServerOperationCompleted;
    
    private System.Threading.SendOrPostCallback QueryResultForSmsTaskOperationCompleted;
    
    private System.Threading.SendOrPostCallback QueryRecvSmsTaskOperationCompleted;
    
    /// <remarks/>
    public SmsService() {
        this.Url = "http://www.35dxt.com/servlet/services/SmsService";
    }
    
    /// <remarks/>
    public event SendSmsToServerCompletedEventHandler SendSmsToServerCompleted;
    
    /// <remarks/>
    public event QueryResultForSmsTaskCompletedEventHandler QueryResultForSmsTaskCompleted;
    
    /// <remarks/>
    public event QueryRecvSmsTaskCompletedEventHandler QueryRecvSmsTaskCompleted;
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:SendSmsToServer", RequestNamespace="http://axis2.fax.uniproud.com", ResponseNamespace="http://axis2.fax.uniproud.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
    public string SendSmsToServer([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string msgStr) {
        object[] results = this.Invoke("SendSmsToServer", new object[] {
                    msgStr});
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginSendSmsToServer(string msgStr, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("SendSmsToServer", new object[] {
                    msgStr}, callback, asyncState);
    }
    
    /// <remarks/>
    public string EndSendSmsToServer(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void SendSmsToServerAsync(string msgStr) {
        this.SendSmsToServerAsync(msgStr, null);
    }
    
    /// <remarks/>
    public void SendSmsToServerAsync(string msgStr, object userState) {
        if ((this.SendSmsToServerOperationCompleted == null)) {
            this.SendSmsToServerOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendSmsToServerOperationCompleted);
        }
        this.InvokeAsync("SendSmsToServer", new object[] {
                    msgStr}, this.SendSmsToServerOperationCompleted, userState);
    }
    
    private void OnSendSmsToServerOperationCompleted(object arg) {
        if ((this.SendSmsToServerCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.SendSmsToServerCompleted(this, new SendSmsToServerCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:QueryResultForSmsTask", RequestNamespace="http://axis2.fax.uniproud.com", ResponseNamespace="http://axis2.fax.uniproud.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
    public string QueryResultForSmsTask([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string msgStr) {
        object[] results = this.Invoke("QueryResultForSmsTask", new object[] {
                    msgStr});
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginQueryResultForSmsTask(string msgStr, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("QueryResultForSmsTask", new object[] {
                    msgStr}, callback, asyncState);
    }
    
    /// <remarks/>
    public string EndQueryResultForSmsTask(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void QueryResultForSmsTaskAsync(string msgStr) {
        this.QueryResultForSmsTaskAsync(msgStr, null);
    }
    
    /// <remarks/>
    public void QueryResultForSmsTaskAsync(string msgStr, object userState) {
        if ((this.QueryResultForSmsTaskOperationCompleted == null)) {
            this.QueryResultForSmsTaskOperationCompleted = new System.Threading.SendOrPostCallback(this.OnQueryResultForSmsTaskOperationCompleted);
        }
        this.InvokeAsync("QueryResultForSmsTask", new object[] {
                    msgStr}, this.QueryResultForSmsTaskOperationCompleted, userState);
    }
    
    private void OnQueryResultForSmsTaskOperationCompleted(object arg) {
        if ((this.QueryResultForSmsTaskCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.QueryResultForSmsTaskCompleted(this, new QueryResultForSmsTaskCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:QueryRecvSmsTask", RequestNamespace="http://axis2.fax.uniproud.com", ResponseNamespace="http://axis2.fax.uniproud.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
    public string QueryRecvSmsTask([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string msgStr) {
        object[] results = this.Invoke("QueryRecvSmsTask", new object[] {
                    msgStr});
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginQueryRecvSmsTask(string msgStr, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("QueryRecvSmsTask", new object[] {
                    msgStr}, callback, asyncState);
    }
    
    /// <remarks/>
    public string EndQueryRecvSmsTask(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void QueryRecvSmsTaskAsync(string msgStr) {
        this.QueryRecvSmsTaskAsync(msgStr, null);
    }
    
    /// <remarks/>
    public void QueryRecvSmsTaskAsync(string msgStr, object userState) {
        if ((this.QueryRecvSmsTaskOperationCompleted == null)) {
            this.QueryRecvSmsTaskOperationCompleted = new System.Threading.SendOrPostCallback(this.OnQueryRecvSmsTaskOperationCompleted);
        }
        this.InvokeAsync("QueryRecvSmsTask", new object[] {
                    msgStr}, this.QueryRecvSmsTaskOperationCompleted, userState);
    }
    
    private void OnQueryRecvSmsTaskOperationCompleted(object arg) {
        if ((this.QueryRecvSmsTaskCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.QueryRecvSmsTaskCompleted(this, new QueryRecvSmsTaskCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    public new void CancelAsync(object userState) {
        base.CancelAsync(userState);
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
public delegate void SendSmsToServerCompletedEventHandler(object sender, SendSmsToServerCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class SendSmsToServerCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal SendSmsToServerCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
public delegate void QueryResultForSmsTaskCompletedEventHandler(object sender, QueryResultForSmsTaskCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class QueryResultForSmsTaskCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal QueryResultForSmsTaskCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
public delegate void QueryRecvSmsTaskCompletedEventHandler(object sender, QueryRecvSmsTaskCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class QueryRecvSmsTaskCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal QueryRecvSmsTaskCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
