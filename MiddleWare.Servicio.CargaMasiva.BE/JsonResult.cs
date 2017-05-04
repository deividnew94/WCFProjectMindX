using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MiddleWare.Servicio.CargaMasiva.BE
{
    [DataContract]
    public class JsonResult
    {


        public JsonResult(string Descripcion, string Estado)
        {
            this.Descripcion = Descripcion;
            this.Estado = Estado;
        }


        [DataMember]
        public string Estado { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
    }
}
