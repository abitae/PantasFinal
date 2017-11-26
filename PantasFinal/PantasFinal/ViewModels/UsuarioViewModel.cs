using GalaSoft.MvvmLight.Command;
using PantasFinal.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PantasFinal.ViewModels
{
   public class UsuarioViewModel :INotifyPropertyChanged
    {
       private NavigationService navigationService;
        private DialogService dialogService;
        private ApiService apiService;
        private bool isRunning;
        public event PropertyChangedEventHandler PropertyChanged;

        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Pasword { get; set; }
        public bool IsRemembered { get; set; }
        public bool IsRunning
        {
            set {
                if (isRunning != value)
                {
                    isRunning = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsRunning"));
                };
            }
            get { return isRunning; }
        }
        public UsuarioViewModel()
        {
            navigationService = new NavigationService();
            dialogService = new DialogService();
            apiService = new ApiService();
            IsRemembered = true;
        }

        public ICommand LoginCommand { get { return new RelayCommand(Login);} }

        private async void Login()
        {
            navigationService.SetMainPage();// momentanio mientras se implemta login
            if (string.IsNullOrEmpty(Usuario)) 
            {
               await dialogService.ShowMessage("Error!","Ingrese Usuario");
                return;
            }
            if (string.IsNullOrEmpty(Pasword))
            {
                await dialogService.ShowMessage("Error!", "Ingrese Contraseña");
                return;
            }
            IsRunning = true;
            var response = await apiService.Login(Usuario, Pasword);
            IsRunning = false;
            if (!response.IsSuccess)
            {
                await dialogService.ShowMessage("Error!",response.Message);
                return;
            }
               // navigationService.SetMainPage();
        }
    }
}
