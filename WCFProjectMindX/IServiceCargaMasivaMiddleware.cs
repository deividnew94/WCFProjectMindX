using IronSharp.Core;
using IronSharp.IronMQ;
using MiddleWare.Servicio.CargaMasiva.BE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Script.Serialization;

namespace WCFProjectMindX
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceCargaMasivaMiddleware
    {

        [OperationContract]
        [WebInvoke(
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, Method = "GET")]
        string sendMasiveBeneficio();
        }

}
