using System.ComponentModel.DataAnnotations;

namespace MvcStrona.Models{
   
public class Student
    {
        [Key]
        public int IDucznia { get; set; }
        [Display(Name = "Imię")]
        public String Imie { get; set; }
        [Display(Name = "Nazwisko")]
        public String Nazwisko { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data dołączenia")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataDolaczenia { get; set; }
        public Grupa? Grupa { get; set; }  

    }
}

