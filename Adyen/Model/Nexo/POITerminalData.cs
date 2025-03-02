﻿namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class POITerminalData
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string POICapabilities;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public POIProfile POIProfile;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public TerminalEnvironmentType TerminalEnvironment;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string POISerialNumber;
    }
}