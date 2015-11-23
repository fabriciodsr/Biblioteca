using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Model
{
    public class RelatoriosGeneroMetod
    {
        public static List<GENERO> GerarRelatorioID()
        {
            using (BibliotecaVirtualEntities oDB = new BibliotecaVirtualEntities())
            {
                var RelatorioPorID = (from CA in oDB.GENERO
                                      orderby CA.ID_GENERO
                                      select CA).ToList<GENERO>();

                return RelatorioPorID;
            }
        }

        public static List<GENERO> GerarRelatorioDescricao()
        {
            using (BibliotecaVirtualEntities oDB = new BibliotecaVirtualEntities())
            {

                var RelatorioPorDescricao = (from CA in oDB.GENERO
                                        orderby CA.CORREDOR
                                        select CA).ToList<GENERO>();

                return RelatorioPorDescricao;
            }
        }
    }
}
