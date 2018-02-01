namespace PantasFinal
{
    using PantasFinal.Pages;
    using Xamarin.Forms;
    public partial class App : Application
    {
        #region Properties
        public static NavigationPage Navigator { get; internal set; }
        public static MasterPage Master { get; internal set; }

        #endregion
        #region Constructor
        public App()
        {
            InitializeComponent();

            MainPage = new UsuarioPage();
        }

        #endregion
        #region Metodos
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        } 
        #endregion
    }
}
