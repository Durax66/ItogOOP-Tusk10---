using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task10.Model;

namespace Task10.DAL
{
    public class CoffeeRepository : ICoffeeRepository
    {
        private static List<Coffee> coffees;
        public CoffeeRepository()
        {
        }

        public Coffee GetACoffee()
        {
            if (coffees == null)
                LoadCoffees();
            return coffees.FirstOrDefault();
        }

        public List<Coffee> GetCoffees()
        {
            if (coffees == null)
                LoadCoffees();
            return coffees;
        }

        public Coffee GetCoffeeById(int id)
        {
            if (coffees == null)
                LoadCoffees();
            return coffees.Where(c => c.CoffeeId == id).FirstOrDefault();
        }

        public void DeleteCoffee(Coffee coffee)
        {
            coffees.Remove(coffee);
        }

        public void UpdateCoffee(Coffee coffee)
        {
            Coffee coffeeToUpdate = coffees.Where(c => c.CoffeeId == coffee.CoffeeId).FirstOrDefault();
            coffeeToUpdate = coffee;
        }

        private void LoadCoffees()
        {
            coffees = new List<Coffee>()
            {
                new Coffee()
                {
                    CoffeeId = 1,
                    CoffeeName = "Домашний латте",
                    Description = "Просто лучший латте в мире, с небольшим колличеством орехового сиропа",
                    ImageID = 1,
                    AmountInStock = 10,
                    InStock = true,
                    FirstAddedToStockDate = new DateTime(2022,1,3),
                    OriginCountry = Country.эфиопия,
                    Prise = 150
                },
                new Coffee()
                {
                    CoffeeId = 2,
                    CoffeeName = "Эспрессо",
                    Description = "Крепкий чёрный кофе, приготовленный путём пропускания через ароманые...",
                    ImageID = 2,
                    AmountInStock = 100,
                    InStock = true,
                    FirstAddedToStockDate = new DateTime(2022,10,3),
                    OriginCountry = Country.колумбия,
                    Prise = 170
                },
                new Coffee()
                {
                    CoffeeId = 3,
                    CoffeeName = "Кофе капучино",
                    Description = "Сочитание разных частей эспрессо, парного молока и ...",
                    ImageID = 3,
                    AmountInStock = 0,
                    InStock = true,
                    FirstAddedToStockDate = new DateTime(2022,5,5),
                    OriginCountry = Country.эквадория,
                    Prise = 180
                },
                new Coffee()
                {
                    CoffeeId = 4,
                    CoffeeName = "Американо",
                    Description = "Это 1 порция эспрессо, добавленная в чашу горячей воды.",
                    ImageID = 4,
                    AmountInStock = 200,
                    InStock = true,
                    FirstAddedToStockDate = new DateTime(2022,9,9),
                    OriginCountry = Country.индия,
                    Prise = 160
                },
                new Coffee()
                {
                    CoffeeId = 5,
                    CoffeeName = "Латте",
                    Description = "1 порция эспрессо на 3 части парного молока",
                    ImageID = 5,
                    AmountInStock = 0,
                    InStock = true,
                    FirstAddedToStockDate = new DateTime(2022,9,9),
                    OriginCountry = Country.индия,
                    Prise = 190
                },
                new Coffee()
                {
                    CoffeeId = 6,
                    CoffeeName = "Кофе с молоком",
                    Description = "Традиционный французский напиток похожи на латте , за искючением",
                    ImageID = 6,
                    AmountInStock = 8,
                    InStock = false,
                    FirstAddedToStockDate = new DateTime(2022,9,9),
                    OriginCountry = Country.индия,
                    Prise = 200
                },
                new Coffee()
                {
                    CoffeeId = 7,
                    CoffeeName = "Мокко",
                    Description = "Латте или капучино с добавлением шоколадного сиропа или порошка",
                    ImageID = 7,
                    AmountInStock = 1000,
                    InStock = true,
                    FirstAddedToStockDate = new DateTime(2022,9,9),
                    OriginCountry = Country.эфиопия,
                    Prise = 130
                },
                new Coffee()
                {
                    CoffeeId = 8,
                    CoffeeName = "Карамельный Макиато",
                    Description = "готовится разными способами в разных кофейнях",
                    ImageID = 8,
                    AmountInStock = 200,
                    InStock = true,
                    FirstAddedToStockDate = new DateTime(2022,9,9),
                    OriginCountry = Country.гондурас,
                    Prise = 180
                },
            };
        }

    }
}
