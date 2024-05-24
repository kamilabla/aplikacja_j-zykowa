using System.ComponentModel.DataAnnotations;


namespace MvcStrona.Models
{
    public class Nauczyciel
    {
        [Key]
        public int IDnauczyciela { get; set; }
        [Display(Name = "Imię")]
        public String Imie { get; set; }
        [Display(Name = "Nazwisko")]
        public String Nazwisko { get; set; }
        [Display(Name = "Płaca")]
        public decimal Placa { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data zatrudnienia")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataZatrudnienia { get; set; }

    }
}