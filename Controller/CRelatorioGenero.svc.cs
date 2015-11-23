using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Model;

namespace Controller
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CRelatorioGenero" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CRelatorioGenero.svc or CRelatorioGenero.svc.cs at the Solution Explorer and start debugging.
    public class CRelatorioGenero : ICRelatorioGenero
    {
        public List<GENERO> GerarRelatorioID()
        {
            return RelatoriosGeneroMetod.GerarRelatorioID();
        }

        public List<GENERO> GerarRelatorioDescricao()
        {
            return RelatoriosGeneroMetod.GerarRelatorioDescricao();
        }
    }
}
