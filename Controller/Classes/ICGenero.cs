using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Model;

namespace Controller
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICGenero" in both code and config file together.
    [ServiceContract]
    public interface ICGenero
    {
        [OperationContract]
        bool Cadastrar(GENERO oGENERO);

        [OperationContract]
        bool Alterar(GENERO oGENERO);

        [OperationContract]
        GENERO Selecionar(int idGENERO);

        [OperationContract]
        GENERO SelecionarDescricao(string GENERODesc);

        [OperationContract]
        bool Deletar(int idGENERO);
    }
}
