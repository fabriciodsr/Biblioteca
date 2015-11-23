using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Model;

namespace Controller
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CRelatorioLivro" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CRelatorioLivro.svc or CRelatorioLivro.svc.cs at the Solution Explorer and start debugging.
    public class CRelatorioLivro : ICRelatorioLivro
    {
        public List<LIVRO> GerarRelatorioID()
        {
            return RelatoriosLivroMetod.GerarRelatorioID();
        }

        public List<LIVRO> GerarRelatorioTitulo()
        {
            return RelatoriosLivroMetod.GerarRelatorioTitulo();
        }
    }
}
