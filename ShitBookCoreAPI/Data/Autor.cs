using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShitBookCoreAPI.Data
{
    [Table("Autor") ]
    public partial class Autor
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Bio { get; set; }

        public virtual IList<Ksiazki> Ksiazki { get; set; }
    }
}