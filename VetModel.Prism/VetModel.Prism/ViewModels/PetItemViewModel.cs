using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using VetModel.Common.Models;

namespace VetModel.Prism.ViewModels
{
    public class PetItemViewModel:PetResponse
    {
        private DelegateCommand _selectPetCommand;
    }
}
