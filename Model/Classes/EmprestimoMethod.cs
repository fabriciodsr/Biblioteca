using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EmprestimoMethod
    {


        public static bool Emprestar(int idAluno, int idLivro)
        {
            using (var oDB = new BibliotecaVirtualEntities())
            {

                try
                {
                    EMPRESTIMO oEmprestimo = new EMPRESTIMO();

                    oEmprestimo.DATA_DEVOL = DateTime.Now.AddDays(10);
                    oEmprestimo.DATA_EMP = DateTime.Now;
                    oEmprestimo.ID_ALUNO = idAluno;
                    oEmprestimo.ID_LIVRO = idLivro;
                    oEmprestimo.SITUACAO = "OK";

                    oDB.EMPRESTIMO.Add(oEmprestimo);
                    oDB.SaveChanges();
                    oDB.Dispose();

                    return true;
                }
                catch (Exception EX)
                {
                    throw new Exception(EX.Message);

                }

            }


        }
    }
}
