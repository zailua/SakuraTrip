using System.ComponentModel.DataAnnotations.Schema;

namespace SakuraTrip.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
       

    }
}
