using GalaSoft.MvvmLight;
using CfePocApp.Model;

namespace CfePocApp.ViewModel
{
    using System;
    using System.Collections.ObjectModel;
    using System.Windows;
    using System.Windows.Input;

    using GalaSoft.MvvmLight.Command;

    public class ModernDataGridViewModel : ViewModelBase
    {
        // ReSharper disable once PrivateFieldCanBeConvertedToLocalVariable
        private readonly IDataService _dataService;

        public ObservableCollection<Customer> Customers { get; set; }

        public ModernDataGridViewModel(IDataService dataService)
        {
            this._dataService = dataService;
            this._dataService.GetCustomers(
                (c, error) =>
                {
                    if (error != null)
                    {
                        // Report error here
                        return;
                    }
                    this.Customers = c;
                });
        }

    }
}