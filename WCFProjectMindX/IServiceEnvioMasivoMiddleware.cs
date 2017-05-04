using MiddleWare.Servicio.CargaMasiva.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFProjectMindX
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceEnvioMasivoMiddleware" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceEnvioMasivoMiddleware
    {
        [OperationContract]
        string createBeneficio(EBeneficio inten);

    }
}
