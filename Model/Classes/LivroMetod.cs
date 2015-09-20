using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class LivroMetod
    {


        ///CADASTRAR



        public static bool Cadastrar(LIVRO oLivro)
        {
            using (BibliotecaVirtualEntities oDB = new BibliotecaVirtualEntities())
            {

                var ConsultaLivro = (from seleciona in oDB.LIVRO
                                     where seleciona.ID_LIVRO == oLivro.ID_LIVRO
                                     select seleciona).SingleOrDefault();


                if (ConsultaLivro == null)
                {
                    try
                    {
                        oDB.LIVRO.Add(oLivro);
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
        /// 



        public static bool Alterar(LIVRO pLIVRO)
        {
            var oDB = new BibliotecaVirtualEntities();

            //String de Seleção do usuário
            var ConsultaLIVRO = (from seleciona in oDB.LIVRO
                                   where seleciona.ID_LIVRO == pLIVRO.ID_LIVRO
                                   select seleciona).SingleOrDefault();

            //Se a consulta não retorna NULA ele atualiza o usuário    
            if (ConsultaLIVRO != null)
            {
                try
                {
                    /*ConsultaLIVRO.TITULO = pLIVRO.TITULO;
                    ConsultaLIVRO.QTD_DISP_EMPR = pLIVRO.QTD_DISP_EMPR;
                    ConsultaLIVRO.QTD_EXMPLARES = pLIVRO.QTD_EXMPLARES;
                    ConsultaLIVRO.SUMARIO = pLIVRO.SUMARIO;
                    ConsultaLIVRO.VOLUME = pLIVRO.VOLUME;
                    ConsultaLIVRO.DATA_PUBLIC = pLIVRO.DATA_PUBLIC;
                    ConsultaLIVRO.ID_EDITORA = pLIVRO.ID_EDITORA;
                    ConsultaLIVRO.VOLUME = pLIVRO.VOLUME;
                    ConsultaLIVRO.Emprestimo = pLIVRO.Emprestimo;
                    ConsultaLIVRO.RESERVA = pLIVRO.RESERVA;*/






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









        ///SELECIONAR PELA CHAVE















        ///SELECIONAR PELO TITULO
        /// 










        ///DELETAR




    }





}
