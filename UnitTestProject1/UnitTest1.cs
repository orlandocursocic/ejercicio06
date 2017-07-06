using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ejercicio06;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        String texto;
        int numero1;
        int numero2;
        Mensaje mensaje;

        [TestInitialize]
        public void TestInit()
        {
            this.texto = "Dos numeros: ";
            this.numero1 = 1;
            this.numero2 = 2;
            this.mensaje = new Mensaje(texto, numero1, numero2);
            
        }

        [TestMethod]
        public void TestConcatenaMensaje()
        {
            Assert.AreEqual(Operaciones.concatenaMensaje(mensaje), texto + numero1 + numero2);
        }
    }
}
