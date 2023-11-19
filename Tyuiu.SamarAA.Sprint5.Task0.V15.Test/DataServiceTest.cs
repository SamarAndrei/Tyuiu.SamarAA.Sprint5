using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SamarAA.Sprint5.Task0.V15.Lib;
using System.IO;

namespace Tyuiu.SamarAA.Sprint5.Task0.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Андрей\source\repos\Tyuiu.SamarAA.Sprint5\Tyuiu.SamarAA.Sprint5.Task0.V15\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileex = fileinfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileex);
        }
    }
}
