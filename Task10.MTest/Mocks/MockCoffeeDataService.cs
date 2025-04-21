using Proect_10.App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task10.Model;

namespace Task10.MTest.Mocks
{
     public class MockCoffeeDataService : ICoffeeDataService
    {

        private MockRepository _reposition = new MockRepository();

        public void DeleteCoffees(Coffee coffee)
        {
            
        }

        public List<Coffee> GetAllCoffees()
        {
            return _reposition.GetCoffees();
        }

        public Coffee GetCoffeeDetail(int coffeeId)
        {
            Coffee coffee = _reposition.GetCoffeeById(coffeeId);
            return coffee;
        }

        public void UpdateCoffee(Coffee coffee)
        {

        }

    }
}
