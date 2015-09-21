using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Model;

namespace Controller
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CEditora" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CEditora.svc or CEditora.svc.cs at the Solution Explorer and start debugging.
    public class CEditora : ICEditora
    {
        public bool Alterar(EDITORA oEDITORA)
        {
            if (EditoraMetod.Alterar(oEDITORA))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Cadastrar(EDITORA oEDITORA)
        {
            if (EditoraMetod.Cadastrar(oEDITORA))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Deletar(int idEDITORA)
        {
            return EditoraMetod.Deletar(idEDITORA);

        }

        public EDITORA Selecionar(int idEDITORA)
        {
            return EditoraMetod.Selecionar(idEDITORA);
        }

        public EDITORA SelecionarNome(string EDITORANome)
        {
            return EditoraMetod.SelecionarNome(EDITORANome);
        }


        public List<EDITORA> ListaTodasEditoras()
        {
            return EditoraMetod.ListaTodasEditoras();
        }

    }
}
