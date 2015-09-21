using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Model
{
    public class EditoraMetod
    {


        ///CADASTRAR

        public static bool Cadastrar(EDITORA pEDITORA)
        {
            using (BibliotecaVirtualEntities oDB = new BibliotecaVirtualEntities())
            {


                //String de Seleção do usuário
                var ConsultaEDITORA = (from CA in oDB.EDITORA
                                     where CA.NOME == pEDITORA.NOME
                                     select CA).SingleOrDefault();

                //Se a consulta retorna NULA ele cadastra o usuário    
                if (ConsultaEDITORA == null)
                {
                    try
                    {
                        oDB.EDITORA.Add(pEDITORA);
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


        public static bool Alterar(EDITORA pEDITORA)
        {
            var oDB = new BibliotecaVirtualEntities();

            //String de Seleção do usuário
            var ConsultaEDITORA = (from CA in oDB.EDITORA
                                 where CA.NOME == pEDITORA.NOME
                                 select CA).SingleOrDefault();

            //Se a consulta não retorna NULA ele atualiza o usuário    
            if (ConsultaEDITORA != null)
            {
                try
                {
                    ConsultaEDITORA.NOME = pEDITORA.NOME;
                    ConsultaEDITORA.BAIRRO = pEDITORA.BAIRRO;
                    ConsultaEDITORA.CEP = pEDITORA.CEP;
                    ConsultaEDITORA.CIDADE = pEDITORA.CIDADE;
                    ConsultaEDITORA.EMAIL = pEDITORA.EMAIL;
                    ConsultaEDITORA.ENDERECO = pEDITORA.ENDERECO;
                    ConsultaEDITORA.TEL_1 = pEDITORA.TEL_1;
                    ConsultaEDITORA.TEL_2 = pEDITORA.TEL_2;
                    ConsultaEDITORA.PAIS = pEDITORA.PAIS;
                    ConsultaEDITORA.UF = pEDITORA.UF;


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


        public static bool Deletar(int IDEDITORA)
        {

            var oDB = new BibliotecaVirtualEntities();

            EDITORA oEDITORA = (from Seleciona in oDB.EDITORA where Seleciona.ID_EDITORA == IDEDITORA select Seleciona).SingleOrDefault();

            oDB.EDITORA.Remove(oEDITORA);
            oDB.SaveChanges();
            oDB.Dispose();

            return true;
        }





        ///SELECIONAR
        /// 


        public static EDITORA Selecionar(int IDEDITORA)
        {
            var oDB = new BibliotecaVirtualEntities();

            //String de Seleção do usuário
            var ConsultaEDITORA = (from CA in oDB.EDITORA
                                 where CA.ID_EDITORA == IDEDITORA
                                 select CA).SingleOrDefault();

            if (ConsultaEDITORA == null)
            {
                return null;
            }
            //Se a consulta retorna um usuário, atualiza ele com os dados da tela    
            else
            {
                return ConsultaEDITORA;
            }
        }




        ///SELECIONAR POR NOME





        public static EDITORA SelecionarNome(string EDITORANome)
        {
            var oDB = new BibliotecaVirtualEntities();

            //String de Seleção do EDITORA
            var ConsultaEDITORA = (from seleciona in oDB.EDITORA
                                 where seleciona.NOME == EDITORANome
                                 select seleciona).SingleOrDefault();

            if (ConsultaEDITORA == null)
            {
                return null;
            }
            //Se a consulta retorna um usuário, atualiza ele com os dados da tela    
            else
            {

                return ConsultaEDITORA;
            }
        }




        public static List<EDITORA> ListaTodasEditoras()
        {
            using (BibliotecaVirtualEntities oDB = new BibliotecaVirtualEntities())
            {

                IEnumerable<EDITORA> Lista = (from p in oDB.EDITORA select p);

                return Lista.ToList();


            }
        }

    }
}
