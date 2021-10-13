using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VetModel.Web.Data.Entities
{
    public class Pet
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Name { get; set; }

        [Display(Name = "Imagen")]
        public string ImageUrl { get; set; }

        [Display(Name = "Raza")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Race { get; set; }

        [Display(Name = "Genero (M/H)")]
        [MaxLength(1, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Genero { get; set; }

        [Display(Name = "Castrado (si/no)")]
        [MaxLength(2, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Castrado { get; set; }


        [Display(Name = "Nacimiento")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
        public DateTime Born { get; set; }


        [Display(Name = "Notas")]
        public string Remarks { get; set; }

        //TODO: replace the correct URL for the image
        public string ImageFullPath => string.IsNullOrEmpty(ImageUrl)
            ? null
            : $"https://veterinariaandy.azurewebsites.net{ImageUrl.Substring(1)}";


        [Display(Name = "Nacimiento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BornLocal => Born.ToLocalTime();

        public PetType PetType { get; set; }

        public Owner Owner { get; set; }

        public ICollection<History> Histories { get; set; }

    }
}
