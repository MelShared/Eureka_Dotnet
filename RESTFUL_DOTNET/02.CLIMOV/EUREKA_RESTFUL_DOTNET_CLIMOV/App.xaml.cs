using EUREKA_RESTFUL_DOTNET_CLIMOV.Views;
namespace EUREKA_RESTFUL_DOTNET_CLIMOV
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
