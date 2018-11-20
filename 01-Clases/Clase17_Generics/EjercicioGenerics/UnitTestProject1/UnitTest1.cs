using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //
            MiLista<int> lista = new MiLista<int>();

            //


            //asert
            
        }

        [TestMethod]
        public void TestAdd()
        {
            MiLista<int> lista = new MiLista<int>();
            MiLista<string> listaS = new MiLista<string>();                        

            lista.Add(3);
            lista.Add(23);

            listaS.Add("asdf");
            listaS.Add("asdfs");
            listaS.Add("asdfsds");

            Assert.IsTrue(lista.Count == 2);
            Assert.IsTrue(listaS.Count == 3);
        }
    }
}
