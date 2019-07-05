using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            Scripts.Move(new DirectoryInfo(@"D:\\backup\\test\\Demo"), new DirectoryInfo(@"D:\\backup\\test\\Demo1"));
            //string path = "D:\\backup\\test\\测试";
            //Scripts.Reduce(new DirectoryInfo(path));
        }
    }
}
