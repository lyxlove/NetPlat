﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VehicleForNetWebService.TmriOutAccess {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TmriOutAccess.TmriOutAccessSoap")]
    public interface TmriOutAccessSoap {
        
        // CODEGEN: Generating message contract since element name xtlb from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/writeObjectOut", ReplyAction="*")]
        VehicleForNetWebService.TmriOutAccess.writeObjectOutResponse writeObjectOut(VehicleForNetWebService.TmriOutAccess.writeObjectOutRequest request);
        
        // CODEGEN: Generating message contract since element name xtlb from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/queryObjectOut", ReplyAction="*")]
        VehicleForNetWebService.TmriOutAccess.queryObjectOutResponse queryObjectOut(VehicleForNetWebService.TmriOutAccess.queryObjectOutRequest request);
        
        // CODEGEN: Generating message contract since element name xtlb from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/URLEncode", ReplyAction="*")]
        VehicleForNetWebService.TmriOutAccess.URLEncodeResponse URLEncode(VehicleForNetWebService.TmriOutAccess.URLEncodeRequest request);
        
        // CODEGEN: Generating message contract since element name xtlb from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/URLDecode", ReplyAction="*")]
        VehicleForNetWebService.TmriOutAccess.URLDecodeResponse URLDecode(VehicleForNetWebService.TmriOutAccess.URLDecodeRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class writeObjectOutRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="writeObjectOut", Namespace="http://tempuri.org/", Order=0)]
        public VehicleForNetWebService.TmriOutAccess.writeObjectOutRequestBody Body;
        
        public writeObjectOutRequest() {
        }
        
        public writeObjectOutRequest(VehicleForNetWebService.TmriOutAccess.writeObjectOutRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class writeObjectOutRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string xtlb;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string jkxlh;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string jkid;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string xmlDoc;
        
        public writeObjectOutRequestBody() {
        }
        
        public writeObjectOutRequestBody(string xtlb, string jkxlh, string jkid, string xmlDoc) {
            this.xtlb = xtlb;
            this.jkxlh = jkxlh;
            this.jkid = jkid;
            this.xmlDoc = xmlDoc;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class writeObjectOutResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="writeObjectOutResponse", Namespace="http://tempuri.org/", Order=0)]
        public VehicleForNetWebService.TmriOutAccess.writeObjectOutResponseBody Body;
        
        public writeObjectOutResponse() {
        }
        
        public writeObjectOutResponse(VehicleForNetWebService.TmriOutAccess.writeObjectOutResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
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
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="queryObjectOut", Namespace="http://tempuri.org/", Order=0)]
        public VehicleForNetWebService.TmriOutAccess.queryObjectOutRequestBody Body;
        
        public queryObjectOutRequest() {
        }
        
        public queryObjectOutRequest(VehicleForNetWebService.TmriOutAccess.queryObjectOutRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class queryObjectOutRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string xtlb;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string jkxlh;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string jkid;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string xmlDoc;
        
        public queryObjectOutRequestBody() {
        }
        
        public queryObjectOutRequestBody(string xtlb, string jkxlh, string jkid, string xmlDoc) {
            this.xtlb = xtlb;
            this.jkxlh = jkxlh;
            this.jkid = jkid;
            this.xmlDoc = xmlDoc;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class queryObjectOutResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="queryObjectOutResponse", Namespace="http://tempuri.org/", Order=0)]
        public VehicleForNetWebService.TmriOutAccess.queryObjectOutResponseBody Body;
        
        public queryObjectOutResponse() {
        }
        
        public queryObjectOutResponse(VehicleForNetWebService.TmriOutAccess.queryObjectOutResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
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
    public partial class URLEncodeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="URLEncode", Namespace="http://tempuri.org/", Order=0)]
        public VehicleForNetWebService.TmriOutAccess.URLEncodeRequestBody Body;
        
        public URLEncodeRequest() {
        }
        
        public URLEncodeRequest(VehicleForNetWebService.TmriOutAccess.URLEncodeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class URLEncodeRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string xtlb;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string jkxlh;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string data;
        
        public URLEncodeRequestBody() {
        }
        
        public URLEncodeRequestBody(string xtlb, string jkxlh, string data) {
            this.xtlb = xtlb;
            this.jkxlh = jkxlh;
            this.data = data;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class URLEncodeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="URLEncodeResponse", Namespace="http://tempuri.org/", Order=0)]
        public VehicleForNetWebService.TmriOutAccess.URLEncodeResponseBody Body;
        
        public URLEncodeResponse() {
        }
        
        public URLEncodeResponse(VehicleForNetWebService.TmriOutAccess.URLEncodeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class URLEncodeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string URLEncodeResult;
        
        public URLEncodeResponseBody() {
        }
        
        public URLEncodeResponseBody(string URLEncodeResult) {
            this.URLEncodeResult = URLEncodeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class URLDecodeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="URLDecode", Namespace="http://tempuri.org/", Order=0)]
        public VehicleForNetWebService.TmriOutAccess.URLDecodeRequestBody Body;
        
        public URLDecodeRequest() {
        }
        
        public URLDecodeRequest(VehicleForNetWebService.TmriOutAccess.URLDecodeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class URLDecodeRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string xtlb;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string jkxlh;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string data;
        
        public URLDecodeRequestBody() {
        }
        
        public URLDecodeRequestBody(string xtlb, string jkxlh, string data) {
            this.xtlb = xtlb;
            this.jkxlh = jkxlh;
            this.data = data;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class URLDecodeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="URLDecodeResponse", Namespace="http://tempuri.org/", Order=0)]
        public VehicleForNetWebService.TmriOutAccess.URLDecodeResponseBody Body;
        
        public URLDecodeResponse() {
        }
        
        public URLDecodeResponse(VehicleForNetWebService.TmriOutAccess.URLDecodeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class URLDecodeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string URLDecodeResult;
        
        public URLDecodeResponseBody() {
        }
        
        public URLDecodeResponseBody(string URLDecodeResult) {
            this.URLDecodeResult = URLDecodeResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TmriOutAccessSoapChannel : VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TmriOutAccessSoapClient : System.ServiceModel.ClientBase<VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoap>, VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoap {
        
        public TmriOutAccessSoapClient() {
        }
        
        public TmriOutAccessSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TmriOutAccessSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TmriOutAccessSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TmriOutAccessSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VehicleForNetWebService.TmriOutAccess.writeObjectOutResponse VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoap.writeObjectOut(VehicleForNetWebService.TmriOutAccess.writeObjectOutRequest request) {
            return base.Channel.writeObjectOut(request);
        }
        
        public string writeObjectOut(string xtlb, string jkxlh, string jkid, string xmlDoc) {
            VehicleForNetWebService.TmriOutAccess.writeObjectOutRequest inValue = new VehicleForNetWebService.TmriOutAccess.writeObjectOutRequest();
            inValue.Body = new VehicleForNetWebService.TmriOutAccess.writeObjectOutRequestBody();
            inValue.Body.xtlb = xtlb;
            inValue.Body.jkxlh = jkxlh;
            inValue.Body.jkid = jkid;
            inValue.Body.xmlDoc = xmlDoc;
            VehicleForNetWebService.TmriOutAccess.writeObjectOutResponse retVal = ((VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoap)(this)).writeObjectOut(inValue);
            return retVal.Body.writeObjectOutResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VehicleForNetWebService.TmriOutAccess.queryObjectOutResponse VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoap.queryObjectOut(VehicleForNetWebService.TmriOutAccess.queryObjectOutRequest request) {
            return base.Channel.queryObjectOut(request);
        }
        
        public string queryObjectOut(string xtlb, string jkxlh, string jkid, string xmlDoc) {
            VehicleForNetWebService.TmriOutAccess.queryObjectOutRequest inValue = new VehicleForNetWebService.TmriOutAccess.queryObjectOutRequest();
            inValue.Body = new VehicleForNetWebService.TmriOutAccess.queryObjectOutRequestBody();
            inValue.Body.xtlb = xtlb;
            inValue.Body.jkxlh = jkxlh;
            inValue.Body.jkid = jkid;
            inValue.Body.xmlDoc = xmlDoc;
            VehicleForNetWebService.TmriOutAccess.queryObjectOutResponse retVal = ((VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoap)(this)).queryObjectOut(inValue);
            return retVal.Body.queryObjectOutResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VehicleForNetWebService.TmriOutAccess.URLEncodeResponse VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoap.URLEncode(VehicleForNetWebService.TmriOutAccess.URLEncodeRequest request) {
            return base.Channel.URLEncode(request);
        }
        
        public string URLEncode(string xtlb, string jkxlh, string data) {
            VehicleForNetWebService.TmriOutAccess.URLEncodeRequest inValue = new VehicleForNetWebService.TmriOutAccess.URLEncodeRequest();
            inValue.Body = new VehicleForNetWebService.TmriOutAccess.URLEncodeRequestBody();
            inValue.Body.xtlb = xtlb;
            inValue.Body.jkxlh = jkxlh;
            inValue.Body.data = data;
            VehicleForNetWebService.TmriOutAccess.URLEncodeResponse retVal = ((VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoap)(this)).URLEncode(inValue);
            return retVal.Body.URLEncodeResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VehicleForNetWebService.TmriOutAccess.URLDecodeResponse VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoap.URLDecode(VehicleForNetWebService.TmriOutAccess.URLDecodeRequest request) {
            return base.Channel.URLDecode(request);
        }
        
        public string URLDecode(string xtlb, string jkxlh, string data) {
            VehicleForNetWebService.TmriOutAccess.URLDecodeRequest inValue = new VehicleForNetWebService.TmriOutAccess.URLDecodeRequest();
            inValue.Body = new VehicleForNetWebService.TmriOutAccess.URLDecodeRequestBody();
            inValue.Body.xtlb = xtlb;
            inValue.Body.jkxlh = jkxlh;
            inValue.Body.data = data;
            VehicleForNetWebService.TmriOutAccess.URLDecodeResponse retVal = ((VehicleForNetWebService.TmriOutAccess.TmriOutAccessSoap)(this)).URLDecode(inValue);
            return retVal.Body.URLDecodeResult;
        }
    }
}
