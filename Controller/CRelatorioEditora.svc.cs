using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Model;

namespace Controller
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CRelatorioEditora" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CRelatorioEditora.svc or CRelatorioEditora.svc.cs at the Solution Explorer and start debugging.
    public class CRelatorioEditora : ICRelatorioEditora
    {
        public List<EDITORA> GerarRelatorioID()
        {
            return RelatoriosEditoraMetod.GerarRelatorioID();
        }

        public List<EDITORA> GerarRelatorioNome()
        {
            return RelatoriosEditoraMetod.GerarRelatorioNome();
        }
    }
}
