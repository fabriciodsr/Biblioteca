using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Model;

namespace Controller
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CGenero" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CGenero.svc or CGenero.svc.cs at the Solution Explorer and start debugging.
    public class CGenero : ICGenero
    {
        public bool Alterar(GENERO oGENERO)
        {
            if (GeneroMetod.Alterar(oGENERO))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Cadastrar(GENERO oGENERO)
        {
            if (GeneroMetod.Cadastrar(oGENERO))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Deletar(int idGENERO)
        {
            return GeneroMetod.Deletar(idGENERO);

        }

        public GENERO Selecionar(int idGENERO)
        {
            return GeneroMetod.Selecionar(idGENERO);
        }

        public GENERO SelecionarDescricao(string GENERODesc)
        {
            return GeneroMetod.SelecionarDescricao(GENERODesc);
        }

    }
}
