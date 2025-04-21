using Proect_10.App.Services;
using Proect_10.App.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task10.DAL;

namespace Proect_10.App
{
    public class ViewModelLocator
    {
        private static IDialogService _dialogService = new DialogService();
        private static ICoffeeDataService _coffeeDataService = new CoffeeDataService(new CoffeeRepository());

        private static CoffeeOverviewViewModel _coffeeOverviewViewModel = new CoffeeOverviewViewModel(_coffeeDataService, _dialogService);
        private static CoffeeDetailViewModel _coffeeDetailViewModel = new CoffeeDetailViewModel(_coffeeDataService, _dialogService);

        static ViewModelLocator()
        {
            try
            {
                _coffeeOverviewViewModel = new CoffeeOverviewViewModel(_coffeeDataService, _dialogService);
                _coffeeDetailViewModel = new CoffeeDetailViewModel(_coffeeDataService, _dialogService);
            }
            catch (Exception ex)
            {
                // Логирование ошибки
                Debug.WriteLine($"Ошибка инициализации ViewModel: {ex.Message}");
            }
        }

        public static CoffeeDetailViewModel CoffeeDetailViewModel
        { get => _coffeeDetailViewModel; }
        public static CoffeeOverviewViewModel CoffeeOverviewViewModel 
        { get => _coffeeOverviewViewModel; }
    }
}
