﻿using Prism.Commands;
using Prism.Navigation;
using VetModel.Common.Models;

namespace VetModel.Prism.ViewModels
{
    public class PetItemViewModel : PetResponse
    {
        private readonly INavigationService _navigationService;
        private DelegateCommand _selectPetCommand;

        public PetItemViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public DelegateCommand SelectPetCommand => _selectPetCommand ?? (_selectPetCommand = new DelegateCommand(SelectPet));
private async void SelectPet()
        {
            var parameters = new NavigationParameters
            {
                { "Pet",this}
            };
            await _navigationService.NavigateAsync("PetPage", parameters);
        }
    }
}