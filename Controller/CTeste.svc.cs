using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Model;

namespace Controller
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CTeste" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CTeste.svc or CTeste.svc.cs at the Solution Explorer and start debugging.
    public class CTeste : ICTeste
    {
        public List<ALUNO> ListaAlunos()
        {
            return TesteMetod.ListaAlunos();
        }
    }
}
