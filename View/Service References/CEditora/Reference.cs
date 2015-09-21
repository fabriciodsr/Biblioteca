﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace View.CEditora {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CEditora.ICEditora")]
    public interface ICEditora {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICEditora/Cadastrar", ReplyAction="http://tempuri.org/ICEditora/CadastrarResponse")]
        bool Cadastrar(Model.EDITORA oEDITORA);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICEditora/Cadastrar", ReplyAction="http://tempuri.org/ICEditora/CadastrarResponse")]
        System.Threading.Tasks.Task<bool> CadastrarAsync(Model.EDITORA oEDITORA);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICEditora/Alterar", ReplyAction="http://tempuri.org/ICEditora/AlterarResponse")]
        bool Alterar(Model.EDITORA oEDITORA);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICEditora/Alterar", ReplyAction="http://tempuri.org/ICEditora/AlterarResponse")]
        System.Threading.Tasks.Task<bool> AlterarAsync(Model.EDITORA oEDITORA);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICEditora/Selecionar", ReplyAction="http://tempuri.org/ICEditora/SelecionarResponse")]
        Model.EDITORA Selecionar(int idEDITORA);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICEditora/Selecionar", ReplyAction="http://tempuri.org/ICEditora/SelecionarResponse")]
        System.Threading.Tasks.Task<Model.EDITORA> SelecionarAsync(int idEDITORA);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICEditora/SelecionarNome", ReplyAction="http://tempuri.org/ICEditora/SelecionarNomeResponse")]
        Model.EDITORA SelecionarNome(string EDITORANome);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICEditora/SelecionarNome", ReplyAction="http://tempuri.org/ICEditora/SelecionarNomeResponse")]
        System.Threading.Tasks.Task<Model.EDITORA> SelecionarNomeAsync(string EDITORANome);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICEditora/Deletar", ReplyAction="http://tempuri.org/ICEditora/DeletarResponse")]
        bool Deletar(int idEDITORA);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICEditora/Deletar", ReplyAction="http://tempuri.org/ICEditora/DeletarResponse")]
        System.Threading.Tasks.Task<bool> DeletarAsync(int idEDITORA);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICEditora/ListaTodasEditoras", ReplyAction="http://tempuri.org/ICEditora/ListaTodasEditorasResponse")]
        Model.EDITORA[] ListaTodasEditoras();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICEditora/ListaTodasEditoras", ReplyAction="http://tempuri.org/ICEditora/ListaTodasEditorasResponse")]
        System.Threading.Tasks.Task<Model.EDITORA[]> ListaTodasEditorasAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICEditoraChannel : View.CEditora.ICEditora, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CEditoraClient : System.ServiceModel.ClientBase<View.CEditora.ICEditora>, View.CEditora.ICEditora {
        
        public CEditoraClient() {
        }
        
        public CEditoraClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CEditoraClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CEditoraClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CEditoraClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Cadastrar(Model.EDITORA oEDITORA) {
            return base.Channel.Cadastrar(oEDITORA);
        }
        
        public System.Threading.Tasks.Task<bool> CadastrarAsync(Model.EDITORA oEDITORA) {
            return base.Channel.CadastrarAsync(oEDITORA);
        }
        
        public bool Alterar(Model.EDITORA oEDITORA) {
            return base.Channel.Alterar(oEDITORA);
        }
        
        public System.Threading.Tasks.Task<bool> AlterarAsync(Model.EDITORA oEDITORA) {
            return base.Channel.AlterarAsync(oEDITORA);
        }
        
        public Model.EDITORA Selecionar(int idEDITORA) {
            return base.Channel.Selecionar(idEDITORA);
        }
        
        public System.Threading.Tasks.Task<Model.EDITORA> SelecionarAsync(int idEDITORA) {
            return base.Channel.SelecionarAsync(idEDITORA);
        }
        
        public Model.EDITORA SelecionarNome(string EDITORANome) {
            return base.Channel.SelecionarNome(EDITORANome);
        }
        
        public System.Threading.Tasks.Task<Model.EDITORA> SelecionarNomeAsync(string EDITORANome) {
            return base.Channel.SelecionarNomeAsync(EDITORANome);
        }
        
        public bool Deletar(int idEDITORA) {
            return base.Channel.Deletar(idEDITORA);
        }
        
        public System.Threading.Tasks.Task<bool> DeletarAsync(int idEDITORA) {
            return base.Channel.DeletarAsync(idEDITORA);
        }
        
        public Model.EDITORA[] ListaTodasEditoras() {
            return base.Channel.ListaTodasEditoras();
        }
        
        public System.Threading.Tasks.Task<Model.EDITORA[]> ListaTodasEditorasAsync() {
            return base.Channel.ListaTodasEditorasAsync();
        }
    }
}
