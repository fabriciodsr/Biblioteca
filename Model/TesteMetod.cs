using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Model
{
    public static class TesteMetod
    {
        public static List<ALUNO> ListaAlunos()
        {
            try
            {
                List<ALUNO> Listinha = new List<ALUNO>();

                using (var bancoDados = new BibliotecaVirtualEntities())
                {
                    var alunoSelecionado = from a in bancoDados.ALUNO
                                           select a;

                    if (alunoSelecionado.Count() > 0)
                    {
                        foreach (ALUNO item in alunoSelecionado)
                        {
                            Listinha.Add(item);
                        }
                    }
                }
                return Listinha;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
