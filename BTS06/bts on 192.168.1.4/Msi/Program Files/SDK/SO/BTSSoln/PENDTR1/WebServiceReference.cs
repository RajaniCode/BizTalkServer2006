﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2032
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 1.1.4322.2032.
// 
namespace Microsoft.Samples.BizTalk.WoodgroveBank.PendingTransactionsCall.PendingTransactionsWS {
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Web.Services;
    
    
	using Microsoft.Samples.BizTalk.WoodgroveBank.SchemaClasses;    

    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="PendingTransactionsWebServiceSoap", Namespace="http://Microsoft.Samples.Biztalk.WoodgroveBank.CustomerService/PendingTransaction" +
"s")]
    public class PendingTransactionsWebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public PendingTransactionsWebService() {
            this.Url = "http://kovai/Microsoft.Samples.BizTalk.WoodgroveBank.PendingTransactions/PendTransWS.asmx";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://Microsoft.Samples.Biztalk.WoodgroveBank.CustomerService/PendingTransaction" +
"s/GetPendingTransactions", RequestNamespace="http://Microsoft.Samples.Biztalk.WoodgroveBank.CustomerService/PendingTransaction" +
"s", ResponseNamespace="http://Microsoft.Samples.Biztalk.WoodgroveBank.CustomerService/PendingTransaction" +
"s", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("PendingTransactionsResponse", Namespace="http://Microsoft.Samples.BizTalk.WoodgroveBank.Schemas.PendingTransactionsResponse" +
"")]
        public PendingTransactionsResponse GetPendingTransactions([System.Xml.Serialization.XmlElementAttribute(Namespace="http://Microsoft.Samples.BizTalk.WoodgroveBank.Schemas.PendingTransactionsRequest")] PendingTransactionsRequest PendingTransactionsRequest) {
		
			object[] results = this.Invoke("GetPendingTransactions", new object[] {
                        PendingTransactionsRequest});
            return ((PendingTransactionsResponse)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetPendingTransactions(PendingTransactionsRequest PendingTransactionsRequest, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetPendingTransactions", new object[] {
                        PendingTransactionsRequest}, callback, asyncState);
        }
        
        /// <remarks/>
        public PendingTransactionsResponse EndGetPendingTransactions(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((PendingTransactionsResponse)(results[0]));
        }
    }
}