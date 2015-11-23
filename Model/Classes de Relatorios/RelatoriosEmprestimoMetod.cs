using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Model
{
    public class RelatoriosEmprestimoMetod
    {
        public static List<EMPRESTIMO> GerarRelatorioID()
        {
            using (BibliotecaVirtualEntities oDB = new BibliotecaVirtualEntities())
            {
                var RelatorioPorID = (from CA in oDB.EMPRESTIMO
                                      orderby CA.ID_EMPRESTIMO
                                      select CA).ToList<EMPRESTIMO>();

                return RelatorioPorID;
            }
        }

        public static List<EMPRESTIMO> GerarRelatorioAluno()
        {
            using (BibliotecaVirtualEntities oDB = new BibliotecaVirtualEntities())
            {

                var RelatorioPorAluno = (from CA in oDB.EMPRESTIMO
                                         orderby CA.ID_ALUNO
                                        select CA).ToList<EMPRESTIMO>();

                return RelatorioPorAluno;
            }
        }
    }
}
