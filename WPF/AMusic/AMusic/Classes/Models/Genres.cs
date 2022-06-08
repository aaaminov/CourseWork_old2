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
    using System.Linq;
    using System.Collections.Generic;

    public partial class Genres
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Genres()
        {
            this.Tracks = new HashSet<Tracks>();
        }
    
        public int ID_genre { get; set; }
        public string title { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tracks> Tracks { get; set; }


        public string item_background {
            get {
                int seed = 1;
                foreach (char l in title) {
                    seed += (int)l;
                }
                Random rnd = new Random(seed);
                ColorHelper.HSL hsl = new ColorHelper.HSL(rnd.Next(360), (byte)rnd.Next(50, 90), (byte)rnd.Next(20, 60));
                string hex = $"#{ColorHelper.ColorConverter.HslToHex(hsl).Value}";
                return hex;
            }
        }

        public string TopTrackFromGenre {
            get {
                if (Tracks.Count >= 1)
                    return System.IO.Directory.GetCurrentDirectory().Substring(0, System.IO.Directory.GetCurrentDirectory().Length - 9)
                    + Tracks.ToList().OrderByDescending(a => a.count_of_listenings).First().Albums.url_HQ_cover;
                else
                    return null;
            }
        }

        public System.Windows.Visibility IsExistsTracks {
            get {
                if (Tracks.Count >= 1)
                    return System.Windows.Visibility.Visible;
                else
                    return System.Windows.Visibility.Collapsed;
            }
        }
    }
}
