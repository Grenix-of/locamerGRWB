//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace locamerguu
{
    using System;
    using System.Collections.Generic;
    
    public partial class Emplacement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Emplacement()
        {
            this.EmplacementSejour = new HashSet<EmplacementSejour>();
        }
    
        public int codeEmplacement { get; set; }
        public double capaciteMob { get; set; }
        public bool terrasseCouv { get; set; }
        public int idTarif { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmplacementSejour> EmplacementSejour { get; set; }
        public virtual Tarif Tarif { get; set; }
    }
}