using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SamarAA.Sprint5.Task5.V9.Lib;
using System.IO;

namespace Tyuiu.SamarAA.Sprint5.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V9.txt";

            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
