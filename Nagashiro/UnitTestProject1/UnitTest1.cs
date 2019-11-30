using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nagashiro;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           
            //organizar
            Aritmetica.obj =  new Aritmetica();
            int valoresperado = 4;
            //Actuar
            int valorrespuesta= obj.Suma(2, 2);
            //Afirmar
            Assert.AreEqual(valoresperado, valorrespuesta);

        }
    }
}
