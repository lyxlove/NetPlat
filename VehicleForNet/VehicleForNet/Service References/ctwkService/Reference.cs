﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VehicleForNetWebService.ctwkService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ctkjwebservice.org/", ConfigurationName="ctwkService.JcxlwServerSoap")]
    public interface JcxlwServerSoap {
        
        // CODEGEN: Generating message contract since element name xtlb from namespace http://ctkjwebservice.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://ctkjwebservice.org/writeObjectOut", ReplyAction="*")]
        VehicleForNetWebService.ctwkService.writeObjectOutResponse writeObjectOut(VehicleForNetWebService.ctwkService.writeObjectOutRequest request);
        
        // CODEGEN: Generating message contract since element name xtlb from namespace http://ctkjwebservice.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://ctkjwebservice.org/queryObjectOut", ReplyAction="*")]
        VehicleForNetWebService.ctwkService.queryObjectOutResponse queryObjectOut(VehicleForNetWebService.ctwkService.queryObjectOutRequest request);
        
        // CODEGEN: Generating message contract since element name jylsh from namespace http://ctkjwebservice.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://ctkjwebservice.org/VedioPlay", ReplyAction="*")]
        VehicleForNetWebService.ctwkService.VedioPlayResponse VedioPlay(VehicleForNetWebService.ctwkService.VedioPlayRequest request);
        
        // CODEGEN: Generating message contract since element name jkxlh from namespace http://ctkjwebservice.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://ctkjwebservice.org/TransVedio", ReplyAction="*")]
        VehicleForNetWebService.ctwkService.TransVedioResponse TransVedio(VehicleForNetWebService.ctwkService.TransVedioRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class writeObjectOutRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="writeObjectOut", Namespace="http://ctkjwebservice.org/", Order=0)]
        public VehicleForNetWebService.ctwkService.writeObjectOutRequestBody Body;
        
        public writeObjectOutRequest() {
        }
        
        public writeObjectOutRequest(VehicleForNetWebService.ctwkService.writeObjectOutRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ctkjwebservice.org/")]
    public partial class writeObjectOutRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string xtlb;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string jkxlh;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string jkid;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string XmlDoc;
        
        public writeObjectOutRequestBody() {
        }
        
        public writeObjectOutRequestBody(string xtlb, string jkxlh, string jkid, string XmlDoc) {
            this.xtlb = xtlb;
            this.jkxlh = jkxlh;
            this.jkid = jkid;
            this.XmlDoc = XmlDoc;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class writeObjectOutResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="writeObjectOutResponse", Namespace="http://ctkjwebservice.org/", Order=0)]
        public VehicleForNetWebService.ctwkService.writeObjectOutResponseBody Body;
        
        public writeObjectOutResponse() {
        }
        
        public writeObjectOutResponse(VehicleForNetWebService.ctwkService.writeObjectOutResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ctkjwebservice.org/")]
    public partial class writeObjectOutResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string writeObjectOutResult;
        
        public writeObjectOutResponseBody() {
        }
        
        public writeObjectOutResponseBody(string writeObjectOutResult) {
            this.writeObjectOutResult = writeObjectOutResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class queryObjectOutRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="queryObjectOut", Namespace="http://ctkjwebservice.org/", Order=0)]
        public VehicleForNetWebService.ctwkService.queryObjectOutRequestBody Body;
        
        public queryObjectOutRequest() {
        }
        
        public queryObjectOutRequest(VehicleForNetWebService.ctwkService.queryObjectOutRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ctkjwebservice.org/")]
    public partial class queryObjectOutRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string xtlb;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string jkxlh;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string jkid;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string XmlDoc;
        
        public queryObjectOutRequestBody() {
        }
        
        public queryObjectOutRequestBody(string xtlb, string jkxlh, string jkid, string XmlDoc) {
            this.xtlb = xtlb;
            this.jkxlh = jkxlh;
            this.jkid = jkid;
            this.XmlDoc = XmlDoc;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class queryObjectOutResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="queryObjectOutResponse", Namespace="http://ctkjwebservice.org/", Order=0)]
        public VehicleForNetWebService.ctwkService.queryObjectOutResponseBody Body;
        
        public queryObjectOutResponse() {
        }
        
        public queryObjectOutResponse(VehicleForNetWebService.ctwkService.queryObjectOutResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ctkjwebservice.org/")]
    public partial class queryObjectOutResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string queryObjectOutResult;
        
        public queryObjectOutResponseBody() {
        }
        
        public queryObjectOutResponseBody(string queryObjectOutResult) {
            this.queryObjectOutResult = queryObjectOutResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VedioPlayRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VedioPlay", Namespace="http://ctkjwebservice.org/", Order=0)]
        public VehicleForNetWebService.ctwkService.VedioPlayRequestBody Body;
        
        public VedioPlayRequest() {
        }
        
        public VedioPlayRequest(VehicleForNetWebService.ctwkService.VedioPlayRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ctkjwebservice.org/")]
    public partial class VedioPlayRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string jylsh;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string jyjgbh;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string jkxlh;
        
        public VedioPlayRequestBody() {
        }
        
        public VedioPlayRequestBody(string jylsh, string jyjgbh, string jkxlh) {
            this.jylsh = jylsh;
            this.jyjgbh = jyjgbh;
            this.jkxlh = jkxlh;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VedioPlayResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VedioPlayResponse", Namespace="http://ctkjwebservice.org/", Order=0)]
        public VehicleForNetWebService.ctwkService.VedioPlayResponseBody Body;
        
        public VedioPlayResponse() {
        }
        
        public VedioPlayResponse(VehicleForNetWebService.ctwkService.VedioPlayResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ctkjwebservice.org/")]
    public partial class VedioPlayResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VedioPlayResult;
        
        public VedioPlayResponseBody() {
        }
        
        public VedioPlayResponseBody(string VedioPlayResult) {
            this.VedioPlayResult = VedioPlayResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TransVedioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TransVedio", Namespace="http://ctkjwebservice.org/", Order=0)]
        public VehicleForNetWebService.ctwkService.TransVedioRequestBody Body;
        
        public TransVedioRequest() {
        }
        
        public TransVedioRequest(VehicleForNetWebService.ctwkService.TransVedioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ctkjwebservice.org/")]
    public partial class TransVedioRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string jkxlh;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public byte[] fileBt;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string jylsh;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string jyxm;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string jycs;
        
        public TransVedioRequestBody() {
        }
        
        public TransVedioRequestBody(string jkxlh, byte[] fileBt, string jylsh, string jyxm, string jycs) {
            this.jkxlh = jkxlh;
            this.fileBt = fileBt;
            this.jylsh = jylsh;
            this.jyxm = jyxm;
            this.jycs = jycs;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TransVedioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TransVedioResponse", Namespace="http://ctkjwebservice.org/", Order=0)]
        public VehicleForNetWebService.ctwkService.TransVedioResponseBody Body;
        
        public TransVedioResponse() {
        }
        
        public TransVedioResponse(VehicleForNetWebService.ctwkService.TransVedioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ctkjwebservice.org/")]
    public partial class TransVedioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string TransVedioResult;
        
        public TransVedioResponseBody() {
        }
        
        public TransVedioResponseBody(string TransVedioResult) {
            this.TransVedioResult = TransVedioResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface JcxlwServerSoapChannel : VehicleForNetWebService.ctwkService.JcxlwServerSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class JcxlwServerSoapClient : System.ServiceModel.ClientBase<VehicleForNetWebService.ctwkService.JcxlwServerSoap>, VehicleForNetWebService.ctwkService.JcxlwServerSoap {
        
        public JcxlwServerSoapClient() {
        }
        
        public JcxlwServerSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public JcxlwServerSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JcxlwServerSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JcxlwServerSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VehicleForNetWebService.ctwkService.writeObjectOutResponse VehicleForNetWebService.ctwkService.JcxlwServerSoap.writeObjectOut(VehicleForNetWebService.ctwkService.writeObjectOutRequest request) {
            return base.Channel.writeObjectOut(request);
        }
        
        public string writeObjectOut(string xtlb, string jkxlh, string jkid, string XmlDoc) {
            VehicleForNetWebService.ctwkService.writeObjectOutRequest inValue = new VehicleForNetWebService.ctwkService.writeObjectOutRequest();
            inValue.Body = new VehicleForNetWebService.ctwkService.writeObjectOutRequestBody();
            inValue.Body.xtlb = xtlb;
            inValue.Body.jkxlh = jkxlh;
            inValue.Body.jkid = jkid;
            inValue.Body.XmlDoc = XmlDoc;
            VehicleForNetWebService.ctwkService.writeObjectOutResponse retVal = ((VehicleForNetWebService.ctwkService.JcxlwServerSoap)(this)).writeObjectOut(inValue);
            return retVal.Body.writeObjectOutResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VehicleForNetWebService.ctwkService.queryObjectOutResponse VehicleForNetWebService.ctwkService.JcxlwServerSoap.queryObjectOut(VehicleForNetWebService.ctwkService.queryObjectOutRequest request) {
            return base.Channel.queryObjectOut(request);
        }
        
        public string queryObjectOut(string xtlb, string jkxlh, string jkid, string XmlDoc) {
            VehicleForNetWebService.ctwkService.queryObjectOutRequest inValue = new VehicleForNetWebService.ctwkService.queryObjectOutRequest();
            inValue.Body = new VehicleForNetWebService.ctwkService.queryObjectOutRequestBody();
            inValue.Body.xtlb = xtlb;
            inValue.Body.jkxlh = jkxlh;
            inValue.Body.jkid = jkid;
            inValue.Body.XmlDoc = XmlDoc;
            VehicleForNetWebService.ctwkService.queryObjectOutResponse retVal = ((VehicleForNetWebService.ctwkService.JcxlwServerSoap)(this)).queryObjectOut(inValue);
            return retVal.Body.queryObjectOutResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VehicleForNetWebService.ctwkService.VedioPlayResponse VehicleForNetWebService.ctwkService.JcxlwServerSoap.VedioPlay(VehicleForNetWebService.ctwkService.VedioPlayRequest request) {
            return base.Channel.VedioPlay(request);
        }
        
        public string VedioPlay(string jylsh, string jyjgbh, string jkxlh) {
            VehicleForNetWebService.ctwkService.VedioPlayRequest inValue = new VehicleForNetWebService.ctwkService.VedioPlayRequest();
            inValue.Body = new VehicleForNetWebService.ctwkService.VedioPlayRequestBody();
            inValue.Body.jylsh = jylsh;
            inValue.Body.jyjgbh = jyjgbh;
            inValue.Body.jkxlh = jkxlh;
            VehicleForNetWebService.ctwkService.VedioPlayResponse retVal = ((VehicleForNetWebService.ctwkService.JcxlwServerSoap)(this)).VedioPlay(inValue);
            return retVal.Body.VedioPlayResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VehicleForNetWebService.ctwkService.TransVedioResponse VehicleForNetWebService.ctwkService.JcxlwServerSoap.TransVedio(VehicleForNetWebService.ctwkService.TransVedioRequest request) {
            return base.Channel.TransVedio(request);
        }
        
        public string TransVedio(string jkxlh, byte[] fileBt, string jylsh, string jyxm, string jycs) {
            VehicleForNetWebService.ctwkService.TransVedioRequest inValue = new VehicleForNetWebService.ctwkService.TransVedioRequest();
            inValue.Body = new VehicleForNetWebService.ctwkService.TransVedioRequestBody();
            inValue.Body.jkxlh = jkxlh;
            inValue.Body.fileBt = fileBt;
            inValue.Body.jylsh = jylsh;
            inValue.Body.jyxm = jyxm;
            inValue.Body.jycs = jycs;
            VehicleForNetWebService.ctwkService.TransVedioResponse retVal = ((VehicleForNetWebService.ctwkService.JcxlwServerSoap)(this)).TransVedio(inValue);
            return retVal.Body.TransVedioResult;
        }
    }
}