using PantasFinal.ViewModels;

namespace PantasFinal.InstanceLocator
{
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
    }
}