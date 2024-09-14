using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KonovalovVA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.KonovalovVA.Sprint0.Tast2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessegeValid()
        {
            var name = "Вова";
            var res = DataService.GetMessege(name);

            Assert.AreEqual("Привет, Вова", res);
        }
    }
}
