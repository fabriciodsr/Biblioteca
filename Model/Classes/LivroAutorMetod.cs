using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class LivroAutorMetod
    {


        /// <summary>
        /// INSERE N PARA N
        /// </summary>
        



        public static void InsereNpraN(LIVRO oLivro, int Autor1, int Autor2)
        {
            using (BibliotecaVirtualEntities oDB = new BibliotecaVirtualEntities())
            {
                var ConsultaLivro = (from seleciona in oDB.LIVRO
                                     where seleciona.TITULO == oLivro.TITULO
                                     select seleciona).SingleOrDefault();

                if (ConsultaLivro != null)
                {
                    try
                    {
                        LIVROS_AUTORES oLivrosAutores = new LIVROS_AUTORES();
                        oLivrosAutores.ID_LIVRO = ConsultaLivro.ID_LIVRO;
                        oLivrosAutores.ID_AUTOR = Autor1;

                        LIVROS_AUTORES xLivrosAutores = new LIVROS_AUTORES();
                        xLivrosAutores.ID_LIVRO = ConsultaLivro.ID_LIVRO;
                        xLivrosAutores.ID_AUTOR = Autor2;
                        
                        oDB.LIVROS_AUTORES.Add(oLivrosAutores);
                        oDB.LIVROS_AUTORES.Add(xLivrosAutores);
                        oDB.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }
        }





        ///LISTAR AUTORES
        /// 



        public static List<AUTOR> ListarAutores(int idLivro)
        {
            var oDB = new BibliotecaVirtualEntities();


            
            var Consulta = (from CA in oDB.LIVROS_AUTORES
                            where CA.ID_LIVRO == idLivro
                            select CA).ToList();

            var autores = new List<int>();

            if(Consulta.Count() != 0)
            {
                autores.Add(Consulta[0].ID_AUTOR);

                if(Consulta.Count() > 1)
                {
                    autores.Add(Consulta[1].ID_AUTOR);
                }

            }
            else
            {
                return null;
            }

            int A1 = 0;

            int A2 = 0;

            var ConsultaAutores = new List<AUTOR>();

            if(autores.Count()==1)
            {
                A1 = autores[0];
            }
            else
            {
                A1 = autores[0];
                A2 = autores[1];

            }



            var oAut = (from A in oDB.AUTOR
                            where A.ID_AUTOR == A1
                            select A).SingleOrDefault();

            ConsultaAutores.Add(oAut);
                 
            //if(autores.Count()==2)
            //{

            if(autores.Count()>1)
            {
                var oAut2 = (from A in oDB.AUTOR
                             where A.ID_AUTOR == A2
                             select A).SingleOrDefault();

                ConsultaAutores.Add(oAut2);
            }

            

            //}
            


            if (ConsultaAutores == null)
            {
                return null;
            }

            else
            {
                return ConsultaAutores;
            }
        }


    }
}
