using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VetModel.Web.Data.Entities;
using VetModel.Web.Models;

namespace VetModel.Web.Helpers
{
    public interface IConverterHelper
    {
        Task<Pet> ToPetAsync(PetViewModel model, string path, bool isNew);

        PetViewModel ToPetViewModel(Pet pet);
    }
}
