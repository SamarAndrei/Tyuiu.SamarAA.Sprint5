using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SamarAA.Sprint5.Task2.V29.Lib;


namespace Tyuiu.SamarAA.Sprint5.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Андрей\source\repos\Tyuiu.SamarAA.Sprint5\Tyuiu.SamarAA.Sprint5.Task2.V29\bin\Debug\OutPutFileTask2.csv";

            FileInfo fileinfo = new FileInfo(path);
            bool fileex = fileinfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileex);
        }
    }
}
