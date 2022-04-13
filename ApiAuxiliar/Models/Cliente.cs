using System.ComponentModel.DataAnnotations;

namespace ApiAuxiliar.Models
{
    public class Cliente
    {   [Key]
        public int id { get; set; }

        public string Nome { get; set; }

        public string ip { get; set; }

        public string porta { get; set; }

        public string conector { get; set; }

        public string database { get; set; }

        public List<Assunto> Assuntos { get; set; }

    }
}
