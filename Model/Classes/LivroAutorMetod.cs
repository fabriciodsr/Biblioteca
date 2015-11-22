using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class LivroAutorMetod
    {
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
    }
}
