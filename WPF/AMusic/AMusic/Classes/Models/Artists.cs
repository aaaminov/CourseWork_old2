//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AMusic.Classes.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Artists
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Artists()
        {
            this.ArtistsInTracks = new HashSet<ArtistsInTracks>();
        }
    
        public int ID_artist { get; set; }
        public string name { get; set; }
        public string avatar_URL { get; set; }
        public int ID_country { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArtistsInTracks> ArtistsInTracks { get; set; }
        public virtual Countries Countries { get; set; }
    }
}