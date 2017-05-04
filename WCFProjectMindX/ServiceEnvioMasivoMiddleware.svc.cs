using IronSharp.Core;
using IronSharp.IronMQ;
using MiddleWare.Servicio.CargaMasiva.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Script.Serialization;

namespace WCFProjectMindX
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceEnvioMasivoMiddleware" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceEnvioMasivoMiddleware.svc o ServiceEnvioMasivoMiddleware.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceEnvioMasivoMiddleware : IServiceEnvioMasivoMiddleware
    {
        public string createBeneficio(EBeneficio inten)
        {
            string json = "";
            try
            {
                var iromMq = IronSharp.IronMQ.Client.New(new IronClientConfig { ProjectId = "590956e136ed58000f36374f", Token = "54akx0altcaL76dubkqn", Host = "mq-aws-eu-west-1-1.iron.io", Scheme = "http", Port = 80 });
                QueueClient queue = iromMq.Queue("ProyectoFinalDSD");
                string messageId = queue.Post(inten);
                json = new JavaScriptSerializer().Serialize(new JsonResult("Registro correcto de beneficio en cola, con el siguiente codigo: " + messageId, "Ok"));

            }
            catch (Exception e)
            {
                json = new JavaScriptSerializer().Serialize(new JsonResult("Error en registro de beneficio " + e.Message, "Error"));

            }
            return json;
        }
    }
}
