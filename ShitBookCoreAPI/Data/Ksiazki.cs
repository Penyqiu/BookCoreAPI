using System.ComponentModel.DataAnnotations.Schema;

namespace ShitBookCoreAPI.Data
{
    [Table("Ksiazki")]
    public partial class Ksiazki
    {
        public int Id { get; set; }
        public string Tytul { get; set; }
        public int? Rok { get; set; }
        public string ISBN { get; set; }
        public string Opis { get; set; }
        public string Image { get; set; }
        public double Cena { get; set; }
        public int? IdAutora { get; set; }

        public virtual Autor Autor { get; set; }

    }
}