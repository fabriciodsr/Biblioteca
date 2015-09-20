using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Controller
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICLivro" in both code and config file together.
    [ServiceContract]
    public interface ICLivro
    {
        [OperationContract]
        void DoWork();
    }
}
