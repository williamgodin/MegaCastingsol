//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Megacasting.DBLib
{
    using System;
    using System.Collections.Generic;
    
    public partial class Métier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Métier()
        {
            this.Casting = new HashSet<Casting>();
        }
    
        public int Id_Metier { get; set; }
        public string Libelle { get; set; }
        public int Id_Domaine_metier { get; set; }
    
        public virtual Domaine_de_métier Domaine_de_métier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Casting> Casting { get; set; }
    }
}
