using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Atividade
    {
        [Key]
        public int idAtividade { get; set; }

        [Required, StringLength(50)]
        public string tituloAtividade { get; set; }

        [Required, StringLength(100)]
        public string descricaoAtividade { get; set; }

        [Required]
        public string statusAtividade { get; set; }

        [Required]
        public string dependenciaAtividade { get; set; }
    }
}
