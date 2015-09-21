using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Model;

namespace Controller
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICEditora" in both code and config file together.
    [ServiceContract]
    public interface ICEditora
    {
        [OperationContract]
        bool Cadastrar(EDITORA oEDITORA);

        [OperationContract]
        bool Alterar(EDITORA oEDITORA);

        [OperationContract]
        EDITORA Selecionar(int idEDITORA);

        [OperationContract]
        EDITORA SelecionarNome(string EDITORANome);

        [OperationContract]
        bool Deletar(int idEDITORA);

        [OperationContract]
        List<EDITORA> ListaTodasEditoras();
    }
}
