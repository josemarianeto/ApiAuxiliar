using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiAuxiliar.Models
{
    public class Assunto 
    {
        [Key]
        public int AssuntoId { get; set; }
        public string Nome { get; set; }

        [ForeignKey("Clientes")]
        public  int ClienteID { get; set; }

      
    }
}
