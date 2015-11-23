using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Model
{
    public class RelatoriosLivroMetod
    {
        public static List<LIVRO> GerarRelatorioID()
        {
            using (BibliotecaVirtualEntities oDB = new BibliotecaVirtualEntities())
            {
                var RelatorioPorID = (from CA in oDB.LIVRO
                                      orderby CA.ID_LIVRO
                                      select CA).ToList<LIVRO>();

                return RelatorioPorID;
            }
        }

        public static List<LIVRO> GerarRelatorioTitulo()
        {
            using (BibliotecaVirtualEntities oDB = new BibliotecaVirtualEntities())
            {

                var RelatorioPorTitulo = (from CA in oDB.LIVRO
                                        orderby CA.TITULO
                                        select CA).ToList<LIVRO>();

                return RelatorioPorTitulo;
            }
        }
    }
}
