using System.ComponentModel.DataAnnotations.Schema;

namespace SakuraTrip.Models
{
    public class Destino
    {
        public int ID { get; set; }
        public string? UF { get; set; }
        public string? Cidade { get; set; }
        public int ClienteID { get; set; }
        [ForeignKey("ClienteID")]
        public virtual Cliente cliente { get; set; }

    }
}
