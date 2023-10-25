using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Lab_3___App.Models.Contact
{
    static public class EnumExtension
    {
        static public string GetDisplayName(this Enum e)
        {
            return e.GetType()
                .GetMember(e.ToString())
                .First()
                .GetCustomAttribute<DisplayAttribute>()
                .GetName();
        }

    }

    public enum Priority
    {
        [Display(Name = "Niski")]
        Low,
        [Display(Name = "Zwykły")]
        Normal,
        [Display(Name = "Pilny")]
        Urgent
    }

    public class Contact
    {
        public Priority Priority { get; set; }
        [HiddenInput]
        public int Id { get; set; }
        [Display(Name = "Imię")]
        [Required(ErrorMessage = "Musisz podać imię!")]
        [StringLength(maximumLength: 50, ErrorMessage = "Imię zbyt dłupie. Maksymalnie 50 znaków.")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Musisz podać poprawny email!")]
        public string Email { get; set; }
        [Display(Name = "Telefon")]
        [Phone(ErrorMessage = "Numer telefonu musi zawierać cyfry")]
        public string Phone { get; set; }
        [Display(Name = "Data urodzenia")]
        [DataType(DataType.Date)]
        public DateTime?
            Birth
        { get; set; }

    }
}
