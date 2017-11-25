using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using System;
using PantasFinal.Pages;
using PantasFinal.Services;

namespace PantasFinal.ViewModels
{
    public class MenuItemViewModel
    {
        private NavigationService navigationService;
        public MenuItemViewModel()
        {
            navigationService = new NavigationService();
        }

        public string Icon { get; set; }

        public string Title { get; set; }

        public string PageName { get; set; }

        public ICommand NavigateCommand { get { return new RelayCommand(Navigate); } }

        private async void Navigate()
        {
           await navigationService.Navigate(PageName);
        }
    }
}