using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Model;

namespace Controller
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICLivroAutor" in both code and config file together.
    [ServiceContract]
    public interface ICLivroAutor
    {
        [OperationContract]
        void InserirNpraN(LIVRO oLivro, int Autor1, int Autor2);

        [OperationContract]
        List<AUTOR> ListarAutores(int idLivro);
    }
}
