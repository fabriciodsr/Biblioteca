using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Model;

namespace Controller
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CReserva" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CReserva.svc or CReserva.svc.cs at the Solution Explorer and start debugging.
    public class CReserva : ICReserva
    {
        

        public List<RESERVA> listaTodasReservasAluno(int idAluno)
        {
            return ReservaMethod.ListaTodasReservasAluno(idAluno);
        }

        public void Reservar(int idAluno, int idLivro)
        {
            ReservaMethod.Reservar(idAluno, idLivro);
        }
    }
}
