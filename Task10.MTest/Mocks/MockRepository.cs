using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task10.DAL;
using Task10.Model;

namespace Task10.MTest.Mocks
{
    public class MockRepository : ICoffeeRepository
    {
        private List<Coffee> _coffees;

        public MockRepository()
        {
            _coffees = LoadMockCoffees();
        }

        private List<Coffee> LoadMockCoffees()
        {
            return new List<Coffee>();
        }

        public void DeleteCoffee(Coffee coffee)
        {
            throw new NotImplementedException();
        }
        public void UpdateCoffee(Coffee coffee)
        {
            throw new NotImplementedException();
        }

        public Coffee GetACoffee()
        {
            throw new NotImplementedException();
        }

        public Coffee GetCoffeeById(int coffeeId)
        {
            return _coffees.Where(c=>c.CoffeeId == coffeeId).FirstOrDefault();
        }

        public List<Coffee> GetCoffees()
        {
            return _coffees;
        }
    }
}
