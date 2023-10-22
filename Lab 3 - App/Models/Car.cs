using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lab_3___App.Models
{
    public class Car
    {
        [HiddenInput]
        public int ID { get; set; }

        [MinLength(length: 3, ErrorMessage = "Nazwa modelu musi zawierać conajmniej 3 znaki!")]
        [Required(ErrorMessage = "Proszę podać model samochodu!")]
        public string CarModel {  get; set; }

        [Required(ErrorMessage = "Proszę podać nazwę producenta!")]
        public string Producent {  get; set; }

        public double? PojemnoscSilnika {  get; set; }

        public int? Moc { get; set;}

        public string? RodzajSilnika { get; set; }

        [Required(ErrorMessage = "Proszę podać numer rejestracyjny!")]
        public string NrRejestracyjny { get; set; }

        [Required(ErrorMessage = "Proszę podać imię i nazwisko właściciela!")]
        public string Wlasciciel {  get; set; }
    }
}
