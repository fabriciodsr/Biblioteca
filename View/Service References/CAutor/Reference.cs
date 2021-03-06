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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICAutor/SelecionarNome", ReplyAction="http://tempuri.org/ICAutor/SelecionarNomeResponse")]
        Model.AUTOR SelecionarNome(string AutorNome);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICAutor/SelecionarNome", ReplyAction="http://tempuri.org/ICAutor/SelecionarNomeResponse")]
        System.Threading.Tasks.Task<Model.AUTOR> SelecionarNomeAsync(string AutorNome);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICAutor/Deletar", ReplyAction="http://tempuri.org/ICAutor/DeletarResponse")]
        bool Deletar(int idAutor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICAutor/Deletar", ReplyAction="http://tempuri.org/ICAutor/DeletarResponse")]
        System.Threading.Tasks.Task<bool> DeletarAsync(int idAutor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICAutor/ListaTodosAutores", ReplyAction="http://tempuri.org/ICAutor/ListaTodosAutoresResponse")]
        Model.AUTOR[] ListaTodosAutores();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICAutor/ListaTodosAutores", ReplyAction="http://tempuri.org/ICAutor/ListaTodosAutoresResponse")]
        System.Threading.Tasks.Task<Model.AUTOR[]> ListaTodosAutoresAsync();
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
        
        public Model.AUTOR SelecionarNome(string AutorNome) {
            return base.Channel.SelecionarNome(AutorNome);
        }
        
        public System.Threading.Tasks.Task<Model.AUTOR> SelecionarNomeAsync(string AutorNome) {
            return base.Channel.SelecionarNomeAsync(AutorNome);
        }
        
        public bool Deletar(int idAutor) {
            return base.Channel.Deletar(idAutor);
        }
        
        public System.Threading.Tasks.Task<bool> DeletarAsync(int idAutor) {
            return base.Channel.DeletarAsync(idAutor);
        }
        
        public Model.AUTOR[] ListaTodosAutores() {
            return base.Channel.ListaTodosAutores();
        }
        
        public System.Threading.Tasks.Task<Model.AUTOR[]> ListaTodosAutoresAsync() {
            return base.Channel.ListaTodosAutoresAsync();
        }
    }
}
