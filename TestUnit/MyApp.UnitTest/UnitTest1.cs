using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestUnit.ViewModels;

namespace MyApp.UnitTest
{
    [TestClass]
    public class MathUnitTest
    {
        [TestMethod]
        public void AddTest()
        {
            var vm = new MathViewModel();
            vm.ValueA = 8;
            vm.ValueB = 7;
            vm.AddCommand.Execute(null);
            Assert.IsTrue(vm.Result == 15, "vm.Result!=15 ");
        }
      
    }
}
