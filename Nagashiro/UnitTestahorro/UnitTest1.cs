using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nagashiro;

namespace UnitTestahorro
{
    [TestClass]
    public class UnitTest1
    {
        public object Person { get; private set; }

        [TestMethod]
        public void TestMethod1() 
        { 
            //organizar
            Person.obj= new Person ();
            int valoresperado = Name;
          // actuar
          int valorrespuesta = Savemoney;
          //afirmar
         Assert.AreEqual (valoresperado, valorrespuesta);
           
      }

    

    }
}
