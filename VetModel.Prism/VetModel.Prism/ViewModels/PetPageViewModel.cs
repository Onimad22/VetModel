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

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            if (parameters.ContainsKey("Pet"))
            {
                _pet = parameters.GetValue<PetResponse>("Pet");
                Title = _pet.Name;
            }
        }
    }
}
