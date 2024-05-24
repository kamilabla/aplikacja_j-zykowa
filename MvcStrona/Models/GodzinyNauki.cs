using System.ComponentModel.DataAnnotations;

namespace MvcStrona.Models
{
    public class GodzinyNauki
    {
        [Key]
        public int IDucznia { get; set; }
        public string Jezyk { get; set; }
        public int Godziny { get; set; }

    }
}
