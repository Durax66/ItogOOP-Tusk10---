using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proect_10.App.Services;
using Proect_10.App.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task10.Model;
using Task10.MTest.Mocks;

namespace Task10.MTest
{
    [TestClass]
    public class CoffeeOverviewViewModelTests
    {

        private ICoffeeDataService _coffeeDataService;
        private IDialogService _dialogService;

        private CoffeeOverviewViewModel GetViewModel()
        {
            return new CoffeeOverviewViewModel(this._coffeeDataService, this._dialogService);
        }

        [TestInitialize]
        public void Init()
        {
            _coffeeDataService = new MockCoffeeDataService();
            _dialogService = new MockDialogService();
        }

        [TestMethod]
        public void LoadAllCoffee()
        {
            ObservableCollection<Coffee> coffees = null;
            var expectedCoffees = _coffeeDataService.GetAllCoffees();

            var viewModel = GetViewModel();
            coffees = viewModel.Coffees;

            CollectionAssert.AreEqual(expectedCoffees, coffees);
        }

    }
}
