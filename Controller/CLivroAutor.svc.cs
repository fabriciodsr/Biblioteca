using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Model;

namespace Controller
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CLivroAutor" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CLivroAutor.svc or CLivroAutor.svc.cs at the Solution Explorer and start debugging.
    public class CLivroAutor : ICLivroAutor
    {
        public void InserirNpraN(LIVRO oLivro, int Autor1, int Autor2)
        {
            LivroAutorMetod.InsereNpraN(oLivro, Autor1, Autor2);
        }


        public List<AUTOR> ListarAutores(int idLivro)
        {
            try
            {
                return LivroAutorMetod.ListarAutores(idLivro);

            }
            catch
            {
                return null;
            }

        }
    }
}
