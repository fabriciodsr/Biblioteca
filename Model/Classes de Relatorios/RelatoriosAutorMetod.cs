using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Model
{
    public class RelatoriosAutorMetod
    {
        public static List<AUTOR> GerarRelatorioID()
        {
            using (BibliotecaVirtualEntities oDB = new BibliotecaVirtualEntities())
            {
                var RelatorioPorID = (from CA in oDB.AUTOR
                                      orderby CA.ID_AUTOR
                                      select CA).ToList<AUTOR>();

                return RelatorioPorID;
            }
        }

        public static List<AUTOR> GerarRelatorioNome()
        {
            using (BibliotecaVirtualEntities oDB = new BibliotecaVirtualEntities())
            {

                var RelatorioPorNome = (from CA in oDB.AUTOR
                                        orderby CA.NOME
                                        select CA).ToList<AUTOR>();

                return RelatorioPorNome;
            }
        }
    }
}
