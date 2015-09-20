using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Model;

namespace Controller
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CLivro" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CLivro.svc or CLivro.svc.cs at the Solution Explorer and start debugging.
    public class CLivro : ICLivro
    {
        public bool Alterar(LIVRO oLivro)
        {
            return LivroMetod.Alterar(oLivro);
        }

        public bool Cadastrar(LIVRO oLivro)
        {
            return LivroMetod.Cadastrar(oLivro);
        }

        public bool Deletar(int IDLivro)
        {
            return LivroMetod.Deletar(IDLivro);
        }

        public LIVRO SelecionarID(int IDLivro)
        {
            return LivroMetod.SelecionarID(IDLivro);
        }

        public LIVRO SelecionarTitulo(string LivroTit)
        {
            return LivroMetod.SelecionarTitulo(LivroTit);
        }
    }
}
