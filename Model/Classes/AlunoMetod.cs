using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Model
{
    public class AlunoMetod
    {

        ///CADASTRAR


        public static bool Cadastrar(ALUNO pAluno)
        {
            //var oDB = new BibliotecaVirtualEntities();
            using (BibliotecaVirtualEntities oDB = new BibliotecaVirtualEntities())
            {



                //String de Seleção do usuário
                var ConsultaUsuario = (from cu in oDB.ALUNO
                                       where cu.CPF == pAluno.CPF
                                       select cu).SingleOrDefault();

                //Se a consulta retorna NULA ele cadastra o usuário    
                if (ConsultaUsuario == null)
                {
                    try
                    {
                        oDB.ALUNO.Add(pAluno);
                        oDB.SaveChanges();
                        oDB.Dispose();
                    }
                    catch (Exception EX)
                    {
                        throw new Exception(EX.Message);
                    }
                    return true;
                }

                else
                {
                    return false;
                }
            }
        }




        ///ALTERAR



        public static bool Alterar(ALUNO pAluno)
        {
            var oDB = new BibliotecaVirtualEntities();

            //String de Seleção do usuário
            var ConsultaUsuario = (from cu in oDB.ALUNO
                                   where cu.CPF == pAluno.CPF
                                   select cu).SingleOrDefault();

            //Se a consulta não retorna NULA ele atualiza o usuário    
            if (ConsultaUsuario != null)
            {
                try
                {
                    ConsultaUsuario.NOME = pAluno.NOME;
                    ConsultaUsuario.SOBRENOME = pAluno.SOBRENOME;
                    ConsultaUsuario.NASC = pAluno.NASC;
                    ConsultaUsuario.CPF = pAluno.CPF;
                    ConsultaUsuario.ENDERECO = pAluno.ENDERECO;
                    ConsultaUsuario.BAIRRO = pAluno.BAIRRO;
                    ConsultaUsuario.CIDADE = pAluno.CIDADE;
                    ConsultaUsuario.UF = pAluno.UF;
                    ConsultaUsuario.PAIS = pAluno.PAIS;
                    ConsultaUsuario.CEP = pAluno.CEP;
                    ConsultaUsuario.TEL_RES = pAluno.TEL_RES;
                    ConsultaUsuario.TEL_CEL = pAluno.TEL_CEL;
                    ConsultaUsuario.EMAIL = pAluno.EMAIL;

                    oDB.SaveChanges();
                    oDB.Dispose();
                }
                catch (Exception)
                {
                    throw;
                }
                return true;
            }
            else
            {
                return false;
            }
        }



        ///DELETAR




        public static bool Deletar(int IDAluno)
        {

            var oDB = new BibliotecaVirtualEntities();

            ALUNO oAluno = (from Seleciona in oDB.ALUNO where Seleciona.ID_ALUNO == IDAluno select Seleciona).SingleOrDefault();

            oDB.ALUNO.Remove(oAluno);
            oDB.SaveChanges();
            oDB.Dispose();

            return true;
        }




        ///SELECIONAR





        public static ALUNO Selecionar(int IDAluno)
        {
            var oDB = new BibliotecaVirtualEntities();

            //String de Seleção do usuário
            var ConsultaUsuario = (from cu in oDB.ALUNO
                                   where cu.ID_ALUNO == IDAluno
                                   select cu).SingleOrDefault();

            if (ConsultaUsuario == null)
            {
                return null;
            }
            //Se a consulta retorna um usuário, atualiza ele com os dados da tela    
            else
            {

                return ConsultaUsuario;
            }
        }







        ///SELECIONAR POR CPF

        public static ALUNO SelecionarCPF(string CPFAluno)
        {
            var oDB = new BibliotecaVirtualEntities();

            //String de Seleção do usuário
            var ConsultaUsuario = (from cu in oDB.ALUNO
                                   where cu.CPF == CPFAluno
                                   select cu).SingleOrDefault();

            if (ConsultaUsuario == null)
            {
                return null;
            }
            //Se a consulta retorna um usuário, atualiza ele com os dados da tela    
            else
            {

               
                return ConsultaUsuario;
            }
        }


        ///SELECIONAR TODOS
        public static List<ALUNO> SelecionarTodos()
        {
            try
            {
                List<ALUNO> alunoLista = new List<ALUNO>();

                using (var oDB = new BibliotecaVirtualEntities())
                {
                    var alunoSelecionado = from a in oDB.ALUNO
                                           select a;

                    if (alunoSelecionado.Count() > 0)
                    {
                        foreach (ALUNO item in alunoSelecionado)
                        {
                            alunoLista.Add(item);
                        }
                    }
                }
                return alunoLista;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        ///SELECIONAR POR NOME

        public static ALUNO SelecionarNome(string Alunome)
        {
            var oDB = new BibliotecaVirtualEntities();

            //String de Seleção do usuário
            var ConsultaUsuario = (from cu in oDB.ALUNO
                                   where cu.NOME == Alunome
                                   select cu).SingleOrDefault();

            if (ConsultaUsuario == null)
            {
                return null;
            }
            //Se a consulta retorna um usuário, atualiza ele com os dados da tela    
            else
            {


                return ConsultaUsuario;
            }
        }


        public static List<ALUNO> ListaTodosAlunos()
        {
            using (BibliotecaVirtualEntities oDB = new BibliotecaVirtualEntities())
            {

                IEnumerable<ALUNO> Lista = (from p in oDB.ALUNO select p);

                return Lista.ToList();


            }
        }
    }
}
