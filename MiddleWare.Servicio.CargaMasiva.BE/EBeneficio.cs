using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MiddleWare.Servicio.CargaMasiva.BE
{
    public class EBeneficio
    {
        
        public EBeneficio()
        { }
        public EBeneficio(string json)
        {
            JObject jObject = JObject.Parse(json);
            JToken jUser = jObject;
            NomBeneficio = (string)jUser["NomBeneficio"];
            DesBeneficio = (string)jUser["DesBeneficio"];
        }

        [DataMember]
        private int idBeneficio;

        public int IdBeneficio
        {
            get { return idBeneficio; }
            set { idBeneficio = value; }
        }

        [DataMember]
        private int idEmpresa;

        public int IdEmpresa
        {
            get { return idEmpresa; }
            set { idEmpresa = value; }
        }

        [DataMember]
        private int idProveedor;

        public int IdProveedor
        {
            get { return idProveedor; }
            set { idProveedor = value; }
        }

        [DataMember]
        private int idCategoria;

        public int IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }

        [DataMember]
        private int idEje;

        public int IdEje
        {
            get { return idEje; }
            set { idEje = value; }
        }

        [DataMember]
        private String nomBeneficio;

        public String NomBeneficio
        {
            get { return nomBeneficio; }
            set { nomBeneficio = value; }
        }

        [DataMember]
        private String desBeneficio;

        public String DesBeneficio
        {
            get { return desBeneficio; }
            set { desBeneficio = value; }
        }

        [DataMember]
        private String fecInicio;

        public String FecInicio
        {
            get { return fecInicio; }
            set { fecInicio = value; }
        }

        [DataMember]
        private String fecFin;

        public String FecFin
        {
            get { return fecFin; }
            set { fecFin = value; }
        }

        [DataMember]
        private String fonBeneficio;

        public String FonBeneficio
        {
            get { return fonBeneficio; }
            set { fonBeneficio = value; }
        }

        [DataMember]
        private String imgBeneficio;

        public String ImgBeneficio
        {
            get { return imgBeneficio; }
            set { imgBeneficio = value; }
        }

        [DataMember]
        private double puntBeneficio;

        public double PuntBeneficio
        {
            get { return puntBeneficio; }
            set { puntBeneficio = value; }
        }

        [DataMember]
        private int porcDescuento;

        public int PorcDescuento
        {
            get { return porcDescuento; }
            set { porcDescuento = value; }
        }

        [DataMember]
        private String inNotificacion;

        public String InNotificacion
        {
            get { return inNotificacion; }
            set { inNotificacion = value; }
        }

        [DataMember]
        private String inPublicado;

        public String InPublicado
        {
            get { return inPublicado; }
            set { inPublicado = value; }
        }

        [DataMember]
        private String inActivo;

        public String InActivo
        {
            get { return inActivo; }
            set { inActivo = value; }
        }

        [DataMember]
        private String inFavorito;

        public String InFavorito
        {
            get { return inFavorito; }
            set { inFavorito = value; }
        }

        [DataMember]
        private int idFavorito;

        public int IdFavorito
        {
            get { return idFavorito; }
            set { idFavorito = value; }
        }

        [DataMember]
        private double numDistancia;

        public double NumDistancia
        {
            get { return numDistancia; }
            set { numDistancia = value; }
        }

        [DataMember]
        private int idBeneficiario;

        public int IdBeneficiario
        {
            get { return idBeneficiario; }
            set { idBeneficiario = value; }
        }

        [DataMember]
        private String numLatitud;

        public String NumLatitud
        {
            get { return numLatitud; }
            set { numLatitud = value; }
        }

        [DataMember]
        private String numLongitud;

        public String NumLongitud
        {
            get { return numLongitud; }
            set { numLongitud = value; }
        }



        [DataMember]
        private String fecPublicacion;

        public String FecPublicacion
        {
            get { return fecPublicacion; }
            set { fecPublicacion = value; }
        }

        [DataMember]
        private String inEstado;

        public String InEstado
        {
            get { return inEstado; }
            set { inEstado = value; }
        }
        [DataMember]
        private String usuCreacion;

        public String UsuCreacion
        {
            get { return usuCreacion; }
            set { usuCreacion = value; }
        }
        [DataMember]
        private String fecCreacion;

        public String FecCreacion
        {
            get { return fecCreacion; }
            set { fecCreacion = value; }
        }
        [DataMember]
        private String fecModificacion;

        public String FecModificacion
        {
            get { return fecModificacion; }
            set { fecModificacion = value; }
        }
        [DataMember]
        private String usuModificacion;

        public String UsuModificacion
        {
            get { return usuModificacion; }
            set { usuModificacion = value; }
        }
        //[DataMember]
        //private EEje eje;

        //[DataMember]
        //private ELocal local;

        //[DataMember]
        //private EProveedor proveedor;

        //[DataMember]
        //private List<EBeneficioImagen> imagenes;


    }
}
