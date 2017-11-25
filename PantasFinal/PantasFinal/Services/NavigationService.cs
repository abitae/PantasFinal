using PantasFinal.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PantasFinal.Services
{
    public class NavigationService
    {
        public async Task Navigate(string pageName)
        {
            App.Master.IsPresented = false;
            switch (pageName)
            {
                case "HierbasPage":
                  await  App.Navigator.PushAsync(new HierbasPage());
                    break;
                case "ConsultasPage":
                    await App.Navigator.PushAsync(new ConsultasPage());
                    break;
                case "UbicacionPage":
                    await App.Navigator.PushAsync(new UbicacionPage());
                    break;
                case "ConfPage":
                    await App.Navigator.PushAsync(new ConfPage());
                    break;
                case "SyncPage":
                    await App.Navigator.PushAsync(new SyncPage());
                    break;
                case "MainPage":
                    await App.Navigator.PopToRootAsync();
                    break;
                default:
                    break;
            }
        }

        internal void SetMainPage()
        {
            App.Current.MainPage = new MasterPage();
        }
    }
}
