using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Model
{
    public class AutorMetod
    {


        ///CADASTRAR

        public static bool Cadastrar(AUTOR pAutor)
        {
            using (BibliotecaVirtualEntities oDB = new BibliotecaVirtualEntities())
            {


                //String de Seleção do usuário
                var ConsultaAutor = (from CA in oDB.AUTOR
                                     where CA.NOME == pAutor.NOME
                                     select CA).SingleOrDefault();

                //Se a consulta retorna NULA ele cadastra o usuário    
                if (ConsultaAutor == null)
                {
                    try
                    {
                        oDB.AUTOR.Add(pAutor);
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
        }





        ///ALTERAR


        public static bool Alterar(AUTOR pAutor)
        {
            var oDB = new BibliotecaVirtualEntities();

            //String de Seleção do usuário
            var ConsultaAutor = (from CA in oDB.AUTOR
                                 where CA.NOME == pAutor.NOME
                                 select CA).SingleOrDefault();

            //Se a consulta não retorna NULA ele atualiza o usuário    
            if (ConsultaAutor != null)
            {
                try
                {
                    ConsultaAutor.NOME = pAutor.NOME;
                    ConsultaAutor.SOBRENOME = pAutor.SOBRENOME;
                    ConsultaAutor.BIOGRAFIA = pAutor.BIOGRAFIA;
                    ConsultaAutor.SITE = pAutor.SITE;


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


        public static bool Deletar(int IDAutor)
        {

            var oDB = new BibliotecaVirtualEntities();

            AUTOR oAutor = (from Seleciona in oDB.AUTOR where Seleciona.ID_AUTOR == IDAutor select Seleciona).SingleOrDefault();

            oDB.AUTOR.Remove(oAutor);
            oDB.SaveChanges();
            oDB.Dispose();

            return true;
        }





        ///SELECIONAR
        /// 


        public static AUTOR Selecionar(int IDAutor)
        {
            var oDB = new BibliotecaVirtualEntities();

            //String de Seleção do usuário
            var ConsultaAutor = (from CA in oDB.AUTOR
                                   where CA.ID_AUTOR == IDAutor
                                   select CA).SingleOrDefault();

            if (ConsultaAutor == null)
            {
                return null;
            }
            //Se a consulta retorna um usuário, atualiza ele com os dados da tela    
            else
            {
                return ConsultaAutor;
            }
        }




        ///SELECIONAR POR NOME





        public static AUTOR SelecionarNome(string AutorNome)
        {
            var oDB = new BibliotecaVirtualEntities();

            //String de Seleção do autor
            var ConsultaAutor = (from seleciona in oDB.AUTOR
                                   where seleciona.NOME == AutorNome
                                   select seleciona).SingleOrDefault();

            if (ConsultaAutor == null)
            {
                return null;
            }
            //Se a consulta retorna um usuário, atualiza ele com os dados da tela    
            else
            {

                return ConsultaAutor;
            }
        }

    }
}
