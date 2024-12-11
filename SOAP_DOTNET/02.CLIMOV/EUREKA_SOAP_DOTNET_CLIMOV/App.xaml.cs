using EUREKA_SOAP_DOTNET_CLIMOV.Views;

namespace EUREKA_SOAP_DOTNET_CLIMOV
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginView());
        }
    }
}
