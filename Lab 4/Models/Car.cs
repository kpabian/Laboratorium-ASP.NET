using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lab_4.Models
{

    
    public class Car
    {
        [HiddenInput]
        public int ID { get; set; }

        [MinLength(length: 3, ErrorMessage = "Nazwa modelu musi zawierać conajmniej 3 znaki!")]
        [Required(ErrorMessage = "Proszę podać model samochodu!")]
        [Display(Name = "Model")]
        public string CarModel {  get; set; }

        [Required(ErrorMessage = "Proszę podać nazwę producenta!")]
        public string Producent {  get; set; }

        [Display(Name = "Pojemność silnika")]
        public double? PojemnoscSilnika {  get; set; }

        public int? Moc { get; set;}

        [Display(Name = "Rodzaj silnika")]
        public string? RodzajSilnika { get; set; }

        [Required(ErrorMessage = "Proszę podać numer rejestracyjny!")]
        [Display(Name = "Numer rejestracyjny")]
        public string NrRejestracyjny { get; set; }

        [Required(ErrorMessage = "Proszę podać imię i nazwisko właściciela!")]
        [Display(Name = "Właściciel")]
        public string Wlasciciel {  get; set; }

        [Display(Name = "Priorytet")]
        public Priority Priority { get; set; }
    }
}
