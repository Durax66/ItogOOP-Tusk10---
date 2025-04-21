using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task10.Model;

namespace Task10.DAL
{
    public interface ICoffeeRepository
    {
        void DeleteCoffee(Coffee coffee);
        Coffee GetACoffee();
        Coffee GetCoffeeById(int id);
        List<Coffee> GetCoffees();
        void UpdateCoffee(Coffee coffee);
    }
}
