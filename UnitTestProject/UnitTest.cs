using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            string path = "D:\\backup\\test\\测试";
            WindowsFormsApp.Scripts.Reduce(new DirectoryInfo(path));
        }
    }
}
