﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PruebaAsp.net.WCFUsuarios {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFUsuarios.IUsuario")]
    public interface IUsuario {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuario/GetInsertarUsuario", ReplyAction="http://tempuri.org/IUsuario/GetInsertarUsuarioResponse")]
        bool GetInsertarUsuario(string[] oent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuario/GetInsertarUsuario", ReplyAction="http://tempuri.org/IUsuario/GetInsertarUsuarioResponse")]
        System.Threading.Tasks.Task<bool> GetInsertarUsuarioAsync(string[] oent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuario/GetVerificarUsuario", ReplyAction="http://tempuri.org/IUsuario/GetVerificarUsuarioResponse")]
        System.Data.DataSet GetVerificarUsuario(string[] oent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuario/GetVerificarUsuario", ReplyAction="http://tempuri.org/IUsuario/GetVerificarUsuarioResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetVerificarUsuarioAsync(string[] oent);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUsuarioChannel : PruebaAsp.net.WCFUsuarios.IUsuario, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UsuarioClient : System.ServiceModel.ClientBase<PruebaAsp.net.WCFUsuarios.IUsuario>, PruebaAsp.net.WCFUsuarios.IUsuario {
        
        public UsuarioClient() {
        }
        
        public UsuarioClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UsuarioClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuarioClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuarioClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool GetInsertarUsuario(string[] oent) {
            return base.Channel.GetInsertarUsuario(oent);
        }
        
        public System.Threading.Tasks.Task<bool> GetInsertarUsuarioAsync(string[] oent) {
            return base.Channel.GetInsertarUsuarioAsync(oent);
        }
        
        public System.Data.DataSet GetVerificarUsuario(string[] oent) {
            return base.Channel.GetVerificarUsuario(oent);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetVerificarUsuarioAsync(string[] oent) {
            return base.Channel.GetVerificarUsuarioAsync(oent);
        }
    }
}
