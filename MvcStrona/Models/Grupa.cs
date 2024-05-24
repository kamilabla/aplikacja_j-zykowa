using System.ComponentModel.DataAnnotations;

namespace MvcStrona.Models
{
    public class Grupa
    {
        [Key]
        [Display(Name = "Id grupy")]
        public int IDgrupy { get; set; }
        [Display(Name = "Nazwa grupy")]
        public string Nazwa { get; set; }
        [Display(Name = "Prowadzący")]
        public string Nauczyciel { get; set; }
        public string Jezyk { get; set; }
        public int LiczbaUczestnikow { get; set; }
        public DateTime DataRozpoczecia { get; set; }
    }
}

