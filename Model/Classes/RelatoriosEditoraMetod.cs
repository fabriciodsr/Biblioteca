using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Model
{
    public class RelatoriosEditoraMetod
    {
        public static List<EDITORA> GerarRelatorioID()
        {
            using (BibliotecaVirtualEntities oDB = new BibliotecaVirtualEntities())
            {
                var RelatorioPorID = (from CA in oDB.EDITORA
                                      orderby CA.ID_EDITORA
                                      select CA).ToList<EDITORA>();

                return RelatorioPorID;
            }
        }

        public static List<EDITORA> GerarRelatorioNome()
        {
            using (BibliotecaVirtualEntities oDB = new BibliotecaVirtualEntities())
            {

                var RelatorioPorNome = (from CA in oDB.EDITORA
                                        orderby CA.NOME
                                        select CA).ToList<EDITORA>();

                return RelatorioPorNome;
            }
        }
    }
}
