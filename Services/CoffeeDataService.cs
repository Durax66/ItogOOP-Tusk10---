using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task10.DAL;
using Task10.Model;

namespace Proect_10.App.Services
{
    public class CoffeeDataService : ICoffeeDataService
    {
        ICoffeeDataService _repository;
        private ICoffeeRepository repository;

        public CoffeeDataService(ICoffeeDataService repository)
        {
            _repository = repository;
        }

        public CoffeeDataService(CoffeeRepository coffeeRepository)
        {
        }

        public CoffeeDataService(ICoffeeRepository repository)
        {
            this.repository = repository;
        }

        public Coffee GetCoffeeDetail(int cofffeeId)
        {
            return _repository.GetCoffeeById(cofffeeId);
        }
        public List<Coffee> GetAllCoffees()
        {
            return _repository.GetCoffees();
        }
        public void DeleteCoffee(Coffee coffee)
        {
            _repository.DeleteCoffee(coffee);
        }

        public Coffee GetCoffeeById(int cofffeeId)
        {
            return _repository.GetCoffeeById(cofffeeId);
        }

        public List<Coffee> GetCoffees()
        {
            return _repository.GetCoffees();
        }

        public void UpdateCoffee(Coffee coffee)
        {
            _repository.UpdateCoffee(coffee);
        }
    }
}

