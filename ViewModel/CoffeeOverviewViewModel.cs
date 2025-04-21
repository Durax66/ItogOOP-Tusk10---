using Proect_10.App.Extensions;
using Proect_10.App.Messages;
using Proect_10.App.Services;
using Proect_10.App.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Task10.Model;

namespace Proect_10.App.ViewModel
{
    public class CoffeeOverviewViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ICoffeeDataService _coffeeDataService;
        private IDialogService _dialogService;

        private ObservableCollection<Coffee> _coffees;

        private ObservableCollection<Coffee> Coffee
        {
            get => _coffees;
            set
            {
                _coffees = value;
                RaisePropertyChanged();
            }
        }
        private Coffee _selectedCoffee;

        public Coffee SelectedCoffee
        {
            get => _selectedCoffee;
            set
            {
                _selectedCoffee = value;
                RaisePropertyChanged();
            }
        }

        public ICommand EditCommand { get; set; }
        public ObservableCollection<Coffee> Coffees { get; set; }

        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public CoffeeOverviewViewModel(ICoffeeDataService coffeeDataService, IDialogService dialogService)
        {
            _coffeeDataService = coffeeDataService;
            _dialogService = dialogService;

            LoadData();

            LoadCommands();

            Messenger.Default.Register<UpdateListMessage>(this, OnUpdateListMessageReceived);
        }

        private void OnUpdateListMessageReceived(UpdateListMessage message)
        {
            throw new NotImplementedException();
        }

        private void LoadCommands()
        {
            EditCommand = new CustomCommand(EditCoffee, CanEditCoffee);
        }

        private void OnUpdateListMessageReceived()
        {
            LoadData();
            _dialogService.CloseDetailDialog();
        }
        private void EditCoffee()
        {
            Messenger.Default.Send<Coffee>(_selectedCoffee);

            _dialogService.ShowDetailDealog();
        }

        private bool CanEditCoffee(object obj)
        {
            if (SelectedCoffee != null)
                return true;
            return false;
        }

        private void LoadData()
        {
            Coffee = _coffeeDataService.GetAllCoffees().ToObservableCollection();
        }
    }
}
