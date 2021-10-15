using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Artigos.Models
{
    public class ArtigoMetadado
    {
        [MetadataType(typeof(ArtigoMetadado))]

        public partial class Artigo
        {        }

        public class ArigoMetadado
        {
            [Required(ErrorMessage = "Obrigatório informar titulo")]
            public string titulo { get; set; }

            [Required(ErrorMessage = "Obrigatório conter um texto")]
            public string texto { get; set; }

            [Required(ErrorMessage = "Obrigatório informar a data do cadastro")]
            public DateTime data_nasc { get; set; }

            [Required(ErrorMessage = "Campo obrigatório")]
            public string ativo { get; set; }

            [Required(ErrorMessage = "Obrigatório informar desenvolvedor")]
            public int desenvolvedor_id { get; set; }

        }
    }
}