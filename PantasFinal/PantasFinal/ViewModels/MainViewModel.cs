using System.Collections.ObjectModel;

namespace PantasFinal.ViewModels
{
    public class MainViewModel
    {

        public ObservableCollection<MenuItemViewModel> Menu { get; set; }
        public UsuarioViewModel NewLogin { get; set; }
        public MainViewModel()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();
            NewLogin = new UsuarioViewModel();
            LoadMenu();
        }

        private void LoadMenu()
        {
            Menu.Add(new MenuItemViewModel()
            {
                Icon = "ic_launcher.png",
                Title = "Enfermedades",
                PageName = "EnfermedadesPage"

            });
            Menu.Add(new MenuItemViewModel()
            {
                Icon = "ic_launcher.png",
                Title = "Hierbas",
                PageName = "HierbasPage"

            });
            Menu.Add(new MenuItemViewModel()
            {
                Icon = "ic_launcher.png",
                Title = "Consultas",
                PageName = "ConsultasPage"

            });
            Menu.Add(new MenuItemViewModel()
            {
                Icon = "ic_launcher.png",
                Title = "Ubicacion",
                PageName = "UbicacionPage"

            });
            Menu.Add(new MenuItemViewModel()
            {
                Icon = "ic_launcher.png",
                Title = "ConfPage",
                PageName = "ConfPage"

            });
            Menu.Add(new MenuItemViewModel()
            {
                Icon = "ic_launcher.png",
                Title = "SyncPage",
                PageName = "SyncPage"

            }); Menu.Add(new MenuItemViewModel()
            {
                Icon = "ic_launcher.png",
                Title = "Salir",
                PageName = "LogutPage"

            });


        }
    }

}