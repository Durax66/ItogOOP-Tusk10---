using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task10.Model;

namespace Proect_10.App.Services
{
    public interface ICoffeeDataService
    {
        void DeleteCoffee(Coffee coffee);
        List<Coffee> GetAllCoffees();
        Coffee GetCoffeeById(int cofffeeId);
        Coffee GetCoffeeDetail(int coffeeId);
        List<Coffee> GetCoffees();
        void UpdateCoffee(Coffee coffee);
    }
}
