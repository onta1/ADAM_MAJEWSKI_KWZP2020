//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dokumentacje
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dokumentacje()
        {
            this.Dokumentacja_Proces = new HashSet<Dokumentacja_Proces>();
        }
    
        public int ID_Dokumentacji { get; set; }
        public int ID_Rodzaj { get; set; }
        public int ID_Pracownika { get; set; }
        public System.DateTime Data_Wykonania { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dokumentacja_Proces> Dokumentacja_Proces { get; set; }
        public virtual Pracownicy Pracownicy { get; set; }
        public virtual Rodzaj_Dokumentacji Rodzaj_Dokumentacji { get; set; }
    }
}
