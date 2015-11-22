using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GeneroMetod
    {




        ///CADASTRAR

        public static bool Cadastrar(GENERO pGENERO)
        {
            using (BibliotecaVirtualEntities oDB = new BibliotecaVirtualEntities())
            {


                //String de Seleção do usuário
                var ConsultaGENERO = (from CA in oDB.GENERO
                                       where CA.DESCRICAO == pGENERO.DESCRICAO
                                       select CA).SingleOrDefault();

                //Se a consulta retorna NULA ele cadastra o usuário    
                if (ConsultaGENERO == null)
                {
                    try
                    {
                        oDB.GENERO.Add(pGENERO);
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


        public static bool Alterar(GENERO pGENERO)
        {
            var oDB = new BibliotecaVirtualEntities();

            //String de Seleção do usuário
            var ConsultaGENERO = (from CA in oDB.GENERO
                                   where CA.DESCRICAO == pGENERO.DESCRICAO
                                   select CA).SingleOrDefault();

            //Se a consulta não retorna NULA ele atualiza o usuário    
            if (ConsultaGENERO != null)
            {
                try
                {
                    ConsultaGENERO.DESCRICAO = pGENERO.DESCRICAO;
                    ConsultaGENERO.ANDAR = pGENERO.ANDAR;
                    ConsultaGENERO.CORREDOR = pGENERO.CORREDOR;
                    ConsultaGENERO.PRATELEIRA = pGENERO.PRATELEIRA;


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


        public static bool Deletar(int IDGENERO)
        {

            var oDB = new BibliotecaVirtualEntities();

            GENERO oGENERO = (from Seleciona in oDB.GENERO where Seleciona.ID_GENERO == IDGENERO select Seleciona).SingleOrDefault();

            oDB.GENERO.Remove(oGENERO);
            oDB.SaveChanges();
            oDB.Dispose();

            return true;
        }





        ///SELECIONAR
        /// 


        public static GENERO Selecionar(int IDGENERO)
        {
            var oDB = new BibliotecaVirtualEntities();

            //String de Seleção do usuário
            var ConsultaGENERO = (from CA in oDB.GENERO
                                   where CA.ID_GENERO == IDGENERO
                                   select CA).SingleOrDefault();

            if (ConsultaGENERO == null)
            {
                return null;
            }
            //Se a consulta retorna um usuário, atualiza ele com os dados da tela    
            else
            {
                return ConsultaGENERO;
            }
        }




        ///SELECIONAR POR NOME





        public static GENERO SelecionarDescricao(string GENERODesc)
        {
            var oDB = new BibliotecaVirtualEntities();

            //String de Seleção do GENERO
            var ConsultaGENERO = (from seleciona in oDB.GENERO
                                   where seleciona.DESCRICAO == GENERODesc
                                   select seleciona).SingleOrDefault();

            if (ConsultaGENERO == null)
            {
                return null;
            }
            //Se a consulta retorna um usuário, atualiza ele com os dados da tela    
            else
            {

                return ConsultaGENERO;
            }
        }



        public static List<GENERO> ListaTodosGeneros()
        {
            using (BibliotecaVirtualEntities oDB = new BibliotecaVirtualEntities())
            {

                IEnumerable<GENERO> Lista = (from p in oDB.GENERO select p);

                return Lista.ToList();

                
            }
        }


    }
}
