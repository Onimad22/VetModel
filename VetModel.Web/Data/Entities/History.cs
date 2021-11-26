using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VetModel.Web.Data.Entities
{
    public class History
    {
        public int Id { get; set; }

        [Display(Name = "Descripcion")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Description { get; set; }

        [Display(Name = "Fecha")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
        public DateTime Date { get; set; }

        [Display(Name = "Notas")]
        public string Remarks { get; set; }

        [Display(Name = "Fecha")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateLocal => Date.ToLocalTime();

        [Display(Name = "Hora")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Time { get; set; }

        [Display(Name = "Monto")]
        public double Monto { get; set; }

        [Display(Name = "Pago")]
        public bool Pago { get; set; }

        public String DateLocalString { get; set; }

        public ServiceType ServiceType { get; set; }

        public Pet Pet { get; set; }
    }
}
