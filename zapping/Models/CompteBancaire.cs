using System.ComponentModel.DataAnnotations;

namespace zapping.Models
{
    public class CompteBancaire
    {
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string? Nom { get; set; }

        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string? Prenom { get; set;}

        [Required(ErrorMessage = "Ce champ est obligatoire")]
        [DataType("Date")] //Enlever l'heure dans le DatePicker
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")] //Format d'affichage
        [Display(Name = "Date de Naissance")]
        public DateTime? DateNaissance { get; set; }

        [Required(ErrorMessage = "Ce champ est obligatoire")]
        [RegularExpression(@"^(\+\d{1, 2}\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$",
            ErrorMessage = "le numero doit etre XXX-XXX-XXXX.")]
        public string? NumeroDeTelephone { get; set; }

        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string? Adresse { get; set; }

        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string? Employeur { get; set; }

        [Range(0, double.MaxValue,
            ErrorMessage = "Le prix doit être un nombre positif.")]
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public decimal? Salaire { get; set; }

        [Range(0, double.MaxValue,
            ErrorMessage = "Le prix doit être un nombre positif.")]
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public decimal? MontantDepotInitial { get; set; }
    }
}
