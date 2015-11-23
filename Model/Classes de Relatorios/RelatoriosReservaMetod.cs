using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Model
{
    public class RelatoriosReservaMetod
    {
        public static List<RESERVA> GerarRelatorioID()
        {
            using (BibliotecaVirtualEntities oDB = new BibliotecaVirtualEntities())
            {
                var RelatorioPorID = (from CA in oDB.RESERVA
                                      orderby CA.ID_LIVRO
                                      select CA).ToList<RESERVA>();

                return RelatorioPorID;
            }
        }

        public static List<RESERVA> GerarRelatorioAluno()
        {
            using (BibliotecaVirtualEntities oDB = new BibliotecaVirtualEntities())
            {

                var RelatorioPorAluno = (from CA in oDB.RESERVA
                                         orderby CA.ID_ALUNO
                                          select CA).ToList<RESERVA>();

                return RelatorioPorAluno;
            }
        }
    }
}
