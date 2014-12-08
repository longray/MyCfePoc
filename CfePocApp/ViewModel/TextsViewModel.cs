using GalaSoft.MvvmLight;
using CfePocApp.Model;

namespace CfePocApp.ViewModel
{
    using System;
    using System.Windows;
    using System.Windows.Input;

    using GalaSoft.MvvmLight.Command;

    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class TextsViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;

        public TextsModel TextsModel { get; set; }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public TextsViewModel(IDataService dataService)
        {
            this._dataService = dataService;
            this._dataService.GetData(
                (m, error) =>
                {
                    if (error != null)
                    {
                        // Report error here
                        return;
                    }
                    this.TextsModel = m;
                });
        }


        private ICommand changeFontSizeCommand;

        public ICommand ChangeFontSizeCommand
        {
            get
            {
                if (this.changeFontSizeCommand == null)
                {
                    this.changeFontSizeCommand = new RelayCommand(SaveExecuted, CanSaveExecute);
                }
                return this.changeFontSizeCommand;
            }
        }

        public bool CanSaveExecute()
        {
            return true;
        }

        public void SaveExecuted()
        {
            this.TextsModel.FontSize = this.TextsModel.FontSize > 13 ? 12 : 14;
        }
    }
}