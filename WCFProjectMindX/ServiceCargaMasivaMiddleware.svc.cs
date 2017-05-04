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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceCargaMasivaMiddleware : IServiceCargaMasivaMiddleware
    {


        public string SendNotification(string deviceId, string message)
        {
            string SERVER_API_KEY = "AAAAG-Q9zzo:APA91bGtVwVGed8fnthFSJHPuDRRFNtOI-eHlzFRK2e6HX6H8XSr4VCH3-wHfPvlu68q1ulBwOy4PUhob4zL3HI5tZ9Z3F9GMlxR3tly1z_x7Y4Uhk9rib2UzCHvXD1_ST9Ac0hRar-J";
            var SENDER_ID = "119793372986";
            var value = message;
            WebRequest tRequest;
            tRequest = WebRequest.Create("https://android.googleapis.com/gcm/send");
            tRequest.Method = "post";
            tRequest.ContentType = " application/x-www-form-urlencoded;charset=UTF-8";
            tRequest.Headers.Add(string.Format("Authorization: key={0}", SERVER_API_KEY));

            tRequest.Headers.Add(string.Format("Sender: id={0}", SENDER_ID));

            string postData = "collapse_key=score_update&time_to_live=108&delay_while_idle=1&data.message=" + value + "&data.time=" + System.DateTime.Now.ToString() + "&registration_id=" + deviceId + "";
            Console.WriteLine(postData);
            Byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            tRequest.ContentLength = byteArray.Length;

            Stream dataStream = tRequest.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            WebResponse tResponse = tRequest.GetResponse();

            dataStream = tResponse.GetResponseStream();

            StreamReader tReader = new StreamReader(dataStream);

            String sResponseFromServer = tReader.ReadToEnd();


            tReader.Close();
            dataStream.Close();
            tResponse.Close();
            return sResponseFromServer;
        }

        public string sendMasiveBeneficio()
        {

            string msg = "";
            try
            {
                var iromMq = IronSharp.IronMQ.Client.New(new IronClientConfig { ProjectId = "590956e136ed58000f36374f", Token = "54akx0altcaL76dubkqn", Host = "mq-aws-eu-west-1-1.iron.io", Scheme = "http", Port = 80 });
                QueueClient q = iromMq.Queue("ProyectoFinalDSD");
                var queues = iromMq.Queues();
                QueueInfo info = q.Info();
                int? cantidad = info.TotalMessages;
                EBeneficio inten=null;
                int ContadorSi = 0, ContadorNo = 0;
                for (int i = 0; i <= info.Size - 1; i++)
                {
                    QueueMessage msg2;
                    if (i == 0)
                        msg2 = q.Reserve();
                    else
                        msg2 = q.Next();
                    if (msg2 != null)
                    {
                        inten = new EBeneficio(msg2.Body);
                    }
                    else
                        break;

                }

                SendNotification("dDW59sbYrxE:APA91bHN2Ib8_pQyIt_cyMe0W11JR9wbuLilRJH4VqRwXPa42mwfpqFxwOuQT85N21yle_K59WQVpn47OQmMv1nFdhUzMh5GD2BWqVh0XOf1mHhy3Bj3nMAWyhCvTTfHWE8JnKwoa7yV", "Beneficio de " + inten.NomBeneficio + " sobre " + inten.DesBeneficio);

                string json = "";
                json = new JavaScriptSerializer().Serialize(new JsonResult("Registro correcto de carga masiva de beneficios en cola", "Ok"));
                //string Message;
                //SqlConnection conn = new SqlConnection(Constants.connection);
                //conn.Open();
                //SqlCommand cmd = new SqlCommand("dbo.USP_INDICADOR_COLECTOR", conn);

                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("@COUNTSI", System.Data.SqlDbType.Int).Value = ContadorSi;
                //cmd.Parameters.Add("@COUNTNO", System.Data.SqlDbType.Int).Value = ContadorNo;

                //using (IDataReader dr = cmd.ExecuteReader())
                //{
                //    if (dr.Read())
                //    {
                //        json = new JavaScriptSerializer().Serialize(new ECount(dr[0].ToString(), dr[1].ToString()));
                //    }
                //}
                //conn.Close();
                q.Clear();

                msg = json;
            }
            catch (Exception e)
            {
                msg = new JavaScriptSerializer().Serialize(new JsonResult("Error en el conteo " + e.Message, "Error"));

            }
            return msg;
        }
    
    }
}
