using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleWare.Servicio.CargaMasiva.BE
{
    public class EProveedor
    {

        private int idProveedor;
        private int idEmpresa;
        private String nomProveedor;
        private String desProveedor;
        private String rucProveedor;
        private String urlProveedor;
        private String numTelefono;
        private String imgProveedor;

        private String srcImgProveedor;
        private List<EContacto> contactos;
        private List<ELocal> locales;
    }
}
