using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using System;
using PantasFinal.Pages;
using PantasFinal.Services;

namespace PantasFinal.ViewModels
{
    public class MenuItemViewModel
    {
        #region Atributos
        private NavigationService navigationService;
        #endregion
        public MenuItemViewModel()
        {
            navigationService = new NavigationService();
        }
        #region Propiedades
        public string Icon { get; set; }

        public string Title { get; set; }

        public string PageName { get; set; }
        #endregion

        #region Comandos

        public ICommand NavigateCommand { get { return new RelayCommand(Navigate); } }

        #endregion

        #region Metodos
        private async void Navigate()
        {
           await navigationService.Navigate(PageName);
        }
        #endregion
    }
}