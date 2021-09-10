using Prism;
using Prism.Ioc;
using VetModel.Common.Services;
using VetModel.Prism.ViewModels;
using VetModel.Prism.Views;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace VetModel.Prism
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/LoginPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.Register<IApiService, ApiService>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<PetsPage, PetsPageViewModel>();
            containerRegistry.RegisterForNavigation<PetsPage, PetsPageViewModel>();
            containerRegistry.RegisterForNavigation<PetPage, PetPageViewModel>();
        }
    }
}
