using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SamarAA.Sprint5.Task3.V18.Lib;

namespace Tyuiu.SamarAA.Sprint5.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Андрей\source\repos\Tyuiu.SamarAA.Sprint5\Tyuiu.SamarAA.Sprint5.Task3.V18\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileinfo = new FileInfo(path);
            bool fileex = fileinfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileex);
        }
    }
}
