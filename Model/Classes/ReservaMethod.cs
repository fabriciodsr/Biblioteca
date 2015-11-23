using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ReservaMethod
    {



        public static bool Reservar(int idAluno, int idLivro)
        {
            using (var oDB = new BibliotecaVirtualEntities())
            {

                try
                {
                    RESERVA oReserva = new RESERVA();

                    oReserva.DATA_RESERVA = DateTime.Now;

                    oReserva.ID_ALUNO = idAluno;
                    oReserva.ID_LIVRO = idLivro;

                    var L = (from p in oDB.LIVRO
                             where p.ID_LIVRO == idLivro
                             select p).SingleOrDefault();

                    L.QTD_DISP = L.QTD_DISP - 1;


                    oDB.RESERVA.Add(oReserva);
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






        public static List<RESERVA> ListaTodasReservasAluno(int idAluno)
        {
            using (var oDB = new BibliotecaVirtualEntities())
            {


                var Lista = (from p in oDB.RESERVA
                             where p.ID_ALUNO == idAluno
                             select p);


                return Lista.ToList();


            }
        }



    }
}
