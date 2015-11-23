using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Model
{
    public class RelatoriosMetod
    {
        public static List<ALUNO> GerarRelatorioAlunoID()
        {
            BibliotecaVirtualEntities oDB = new BibliotecaVirtualEntities();
            
                var RelatorioPorID = (from CA in oDB.ALUNO
                                     orderby CA.ID_ALUNO
                                     select CA).ToList<ALUNO>();

                return RelatorioPorID;
        }

        public static List<ALUNO> GerarRelatorioAlunoNome()
        {
            using (BibliotecaVirtualEntities oDB = new BibliotecaVirtualEntities())
            {

                var RelatorioPorNome = (from CA in oDB.ALUNO
                                      orderby CA.NOME
                                      select CA).ToList<ALUNO>();

                return RelatorioPorNome;
            }
        }

     }
}
