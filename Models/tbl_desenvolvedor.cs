namespace Artigos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tbl_desenvolvedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_desenvolvedor()
        {
            this.tbl_artigos = new HashSet<tbl_artigos>();
        }
    
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Display(Name = "Data Nasc.")]
        public Nullable<System.DateTime> data_nasc { get; set; }

        [Display(Name = "Nivel do Desenvolvedor")]
        public string nivel { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_artigos> tbl_artigos { get; set; }
    }
}
