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
// This source code was auto-generated by xsd, Version=1.1.4322.2032.
// 
namespace Microsoft.Samples.BizTalk.WoodgroveBank.SchemaClasses {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://Microsoft.Samples.BizTalk.WoodgroveBank.Schemas.CustomerServiceRequest")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://Microsoft.Samples.BizTalk.WoodgroveBank.Schemas.CustomerServiceRequest", IsNullable=false)]
    public class CustomerServiceRequest {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CustomerServiceRequestBody Body;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RequestType;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RequestSource;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RequestID;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://Microsoft.Samples.BizTalk.WoodgroveBank.Schemas.CustomerServiceRequest")]
    public class CustomerServiceRequestBody {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AccountNumber;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AuthenticationInfo", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CustomerServiceRequestBodyAuthenticationInfo[] AuthenticationInfo;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://Microsoft.Samples.BizTalk.WoodgroveBank.Schemas.CustomerServiceRequest")]
    public class CustomerServiceRequestBodyAuthenticationInfo {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DataElementName;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DataElementValue;
    }
}