using Prism.Navigation;
using VetModel.Common.Models;

namespace VetModel.Prism.ViewModels
{
    public class PetPageViewModel : ViewModelBase
    {
        private PetResponse _pet;

        public PetPageViewModel(
            INavigationService navigationService) : base(navigationService)
        {
        }
        public PetResponse Pet
        {
            get => _pet;
            set => SetProperty(ref _pet, value);
        }
        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            if (parameters.ContainsKey("Pet"))
            {
                Pet = parameters.GetValue<PetResponse>("Pet");
                Title = Pet.Name;
                
            }
        }
    }
}
