using GalaSoft.MvvmLight.Command;
using PantasFinal.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PantasFinal.ViewModels
{
   public class UsuarioViewModel
    {
       private NavigationService navigationService;
        private DialogService dialogService;
        public int IdUsuario { get; set; }
        public string Usuario1 { get; set; }
        public string Pass { get; set; }
        public bool IsRemembered { get; set; }
        public UsuarioViewModel()
        {
            navigationService = new NavigationService();
            dialogService = new DialogService();
            IsRemembered = true;
        }

        public ICommand LoginCommand { get { return new RelayCommand(Login);} }

        private async void Login()
        {
            if (string.IsNullOrEmpty(Usuario1))
            {
               await dialogService.ShowMessage("Error!","Ingrese Usuario");
                return;
            }
            if (string.IsNullOrEmpty(Pass))
            {
                await dialogService.ShowMessage("Error!", "Ingrese Contraseña");
                return;
            }
            
                navigationService.SetMainPage();
        }
    }
}
