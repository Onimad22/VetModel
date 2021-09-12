using Prism.Navigation;
using System.Collections.ObjectModel;
using VetModel.Common.Models;

namespace VetModel.Prism.ViewModels
{
    public class HistoriesPageViewModel : ViewModelBase
    {
        private PetResponse _pet;
        private ObservableCollection<HistoryResponse> _histories;

        public HistoriesPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Histories";
        }

        public ObservableCollection<HistoryResponse> Histories
        {
            get => _histories;
            set => SetProperty(ref _histories, value);
        }


        public PetResponse Pet
        {
            get => _pet;
            set => SetProperty(ref _pet, value);
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            if (parameters.ContainsKey("pet"))
            {
                Pet = parameters.GetValue<PetResponse>("pet");
                Title = $"Histories of: {Pet.Name}";
                Histories = new ObservableCollection<HistoryResponse>(Pet.Histories);
            }
        }
    }
}
