using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiddleWare.Servicio.CargaMasiva.BE;

namespace UnitTestProjectMindX
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            serviceEnvioMasivo.ServiceEnvioMasivoMiddlewareClient sEnvMas = new serviceEnvioMasivo.ServiceEnvioMasivoMiddlewareClient();

            EBeneficio eBen=null;

            sEnvMas.createBeneficio(eBen);

        }
    }
}
