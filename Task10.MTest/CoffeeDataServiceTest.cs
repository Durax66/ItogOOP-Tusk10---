using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proect_10.App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task10.DAL;
using Task10.MTest.Mocks;


namespace Task10.MTest
{
    [TestClass]
    public class CoffeeDataServiceTest
    {

        private ICoffeeRepository _repository;

        [TestInitialize]
        public void Init()
        {
            _repository = new MockRepository();
        }

        [TestMethod]
        public void GetCoffeeDetailTest()
        {
            var service = new CoffeeDataService(_repository);

            var coffee = service.GetCoffeeDetail(0);

            Assert.IsNotNull(coffee);
        }
    }
}
