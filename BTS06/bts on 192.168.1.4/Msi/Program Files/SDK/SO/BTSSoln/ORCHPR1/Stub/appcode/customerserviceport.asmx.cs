//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2032
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// Generated by "Microsoft.BizTalk.WebServices, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
// Product: Microsoft® BizTalk® Server 2004 3.0.4902.0
// File: Microsoft.BizTalk.WebServices.dll 3.0.4902.0
// 
namespace Microsoft.Samples.BizTalk.WoodgroveBank.Orchestrations.Stubbed
{
    
    
    // service "Microsoft.Samples.BizTalk.WoodgroveBank.Orchestrations.Stubbed.CustomerServiceNativeRequestResponse" port "CustomerServicePort"
    [System.Web.Services.WebServiceBindingAttribute(Name="Microsoft_Samples_BizTalk_WoodgroveBank_Orchestrations_Stubbed_CustomerServiceNat" +
"iveRequestResponse_CustomerServicePort", Namespace="http://Microsoft.Samples.BizTalk.WoodgroveBank.CustomerService")]
    [System.Web.Services.WebServiceAttribute(Name="Microsoft_Samples_BizTalk_WoodgroveBank_Orchestrations_Stubbed_CustomerServiceNat" +
"iveRequestResponse_CustomerServicePort", Namespace="http://Microsoft.Samples.BizTalk.WoodgroveBank.CustomerService", Description="BizTalk assembly \"Microsoft.Samples.BizTalk.WoodgroveBank.Orchestrations.Stubbed," +
" Version=1.0.0.0, Culture=neutral, PublicKeyToken=a1054514fc67bded\" published we" +
"b service.")]
    public sealed class Microsoft_Samples_BizTalk_WoodgroveBank_Orchestrations_Stubbed_CustomerServiceNativeRequestResponse_CustomerServicePort : Microsoft.BizTalk.WebServices.ServerProxy.ServerProxy
    {
        
        // operation "GetAccountInfo"
        [System.Web.Services.WebMethodAttribute()]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://Microsoft.Samples.BizTalk.WoodgroveBank.CustomerService/Microsoft_Samples_" +
"BizTalk_WoodgroveBank_Orchestrations_Stubbed_CustomerServiceNativeRequestRespons" +
"e_CustomerServicePort/GetAccountInfo", OneWay=false, Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Default)]
        [return: System.Xml.Serialization.XmlElementAttribute(Namespace="http://Microsoft.Samples.BizTalk.WoodgroveBank.Schemas.CustomerServiceResponse", ElementName="CustomerServiceResponse")]
        public Microsoft.Samples.BizTalk.WoodgroveBank.Orchestrations.Stubbed.XsdTypes1.CustomerServiceResponse GetAccountInfo([System.Xml.Serialization.XmlElementAttribute(Namespace="http://Microsoft.Samples.BizTalk.WoodgroveBank.Schemas.CustomerServiceRequest", ElementName="CustomerServiceRequest")] Microsoft.Samples.BizTalk.WoodgroveBank.Orchestrations.Stubbed.XsdTypes1.CustomerServiceRequest part)
        {
            System.Collections.ArrayList inHeaders = null;
            System.Collections.ArrayList inoutHeaders = null;
            System.Collections.ArrayList inoutHeaderResponses = null;
            System.Collections.ArrayList outHeaderResponses = null;
            System.Web.Services.Protocols.SoapUnknownHeader[] unknownHeaderResponses = null;
            // Parameter information
            object[] invokeParams = new object[] {
                    part};
            Microsoft.BizTalk.WebServices.ServerProxy.ParamInfo[] inParamInfos = new Microsoft.BizTalk.WebServices.ServerProxy.ParamInfo[] {
                    new Microsoft.BizTalk.WebServices.ServerProxy.ParamInfo(typeof(Microsoft.Samples.BizTalk.WoodgroveBank.Orchestrations.Stubbed.XsdTypes1.CustomerServiceRequest), "part")};
            Microsoft.BizTalk.WebServices.ServerProxy.ParamInfo[] outParamInfos = new Microsoft.BizTalk.WebServices.ServerProxy.ParamInfo[] {
                    new Microsoft.BizTalk.WebServices.ServerProxy.ParamInfo(typeof(Microsoft.Samples.BizTalk.WoodgroveBank.Orchestrations.Stubbed.XsdTypes1.CustomerServiceResponse), "part")};
            string bodyTypeAssemblyQualifiedName = "Microsoft.Samples.BizTalk.WoodgroveBank.Schemas.CustomerServiceRequest, Microsoft" +
".Samples.BizTalk.WoodgroveBank.Schemas, Version=1.0.0.0, Culture=neutral, Public" +
"KeyToken=a1054514fc67bded";
            // BizTalk invocation
            object[] invokeResults = this.Invoke("GetAccountInfo", invokeParams, inParamInfos, outParamInfos, 0, bodyTypeAssemblyQualifiedName, inHeaders, inoutHeaders, out inoutHeaderResponses, out outHeaderResponses, null, null, null, out unknownHeaderResponses, false, false);
            Microsoft.Samples.BizTalk.WoodgroveBank.Orchestrations.Stubbed.XsdTypes1.CustomerServiceResponse returnValue = ((Microsoft.Samples.BizTalk.WoodgroveBank.Orchestrations.Stubbed.XsdTypes1.CustomerServiceResponse)(invokeResults[0]));
            return returnValue;
        }
    }
}
