﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace View.CAutor {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CAutor.ICAutor")]
    public interface ICAutor {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICAutor/Cadastrar", ReplyAction="http://tempuri.org/ICAutor/CadastrarResponse")]
        bool Cadastrar(Model.AUTOR oAutor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICAutor/Cadastrar", ReplyAction="http://tempuri.org/ICAutor/CadastrarResponse")]
        System.Threading.Tasks.Task<bool> CadastrarAsync(Model.AUTOR oAutor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICAutor/Alterar", ReplyAction="http://tempuri.org/ICAutor/AlterarResponse")]
        bool Alterar(Model.AUTOR oAutor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICAutor/Alterar", ReplyAction="http://tempuri.org/ICAutor/AlterarResponse")]
        System.Threading.Tasks.Task<bool> AlterarAsync(Model.AUTOR oAutor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICAutor/Selecionar", ReplyAction="http://tempuri.org/ICAutor/SelecionarResponse")]
        Model.AUTOR Selecionar(int idAutor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICAutor/Selecionar", ReplyAction="http://tempuri.org/ICAutor/SelecionarResponse")]
        System.Threading.Tasks.Task<Model.AUTOR> SelecionarAsync(int idAutor);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICAutorChannel : View.CAutor.ICAutor, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CAutorClient : System.ServiceModel.ClientBase<View.CAutor.ICAutor>, View.CAutor.ICAutor {
        
        public CAutorClient() {
        }
        
        public CAutorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CAutorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CAutorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CAutorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Cadastrar(Model.AUTOR oAutor) {
            return base.Channel.Cadastrar(oAutor);
        }
        
        public System.Threading.Tasks.Task<bool> CadastrarAsync(Model.AUTOR oAutor) {
            return base.Channel.CadastrarAsync(oAutor);
        }
        
        public bool Alterar(Model.AUTOR oAutor) {
            return base.Channel.Alterar(oAutor);
        }
        
        public System.Threading.Tasks.Task<bool> AlterarAsync(Model.AUTOR oAutor) {
            return base.Channel.AlterarAsync(oAutor);
        }
        
        public Model.AUTOR Selecionar(int idAutor) {
            return base.Channel.Selecionar(idAutor);
        }
        
        public System.Threading.Tasks.Task<Model.AUTOR> SelecionarAsync(int idAutor) {
            return base.Channel.SelecionarAsync(idAutor);
        }
    }
}