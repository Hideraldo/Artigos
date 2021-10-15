using System;
using System.ComponentModel.DataAnnotations;

namespace Artigos.Models
{
    public class DesenvolvedorMetadado
    {
        [MetadataType(typeof(DesenvolvedorMetadado))]
        public partial class Desenvolvedor
        {
        }
        public class MedicoMetadado
        {
            [Required(ErrorMessage = "Obrigatório informar o Nome do desenvolvedor")]
            public string Nome { get; set; }

            public DateTime data_nasc { get; set; }

            [Required(ErrorMessage = "Obrigatório informar o nivel")]
            [StringLength(100, ErrorMessage = "O nivel deve possuir no máximo 50 caracteres")]
            public string nivel { get; set; }

        }
    }
}