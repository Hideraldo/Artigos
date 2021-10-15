namespace Artigos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tbl_artigos
    {
        public int Id { get; set; }

        [Display(Name = "Título")]
        public string titulo { get; set; }

        [Display(Name = "Texto")]
        public string texto { get; set; }

        [Display(Name = "Data do Cadastro")]
        public System.DateTime cadastro { get; set; }

        [Display(Name = "Ativo")]
        public string ativo { get; set; }

        [Display(Name = "Desenvolvedor")]
        public int desenvolvedor_id { get; set; }

        [Display(Name = "Desenvolvedor")]
        public virtual tbl_desenvolvedor tbl_desenvolvedor { get; set; }
    }
}
