using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITJobb.Models
{
    public class Malsida
    {
        public int MalsidaId { get; set; }
        public string MalsidaNamn { get; set; }
        public string MalsidaUrl { get; set; }

        public Malsida()
        {
            this.Annonser = new HashSet<ForetagsAnnons>();
        }
        public virtual ICollection<ForetagsAnnons> Annonser { get; set; }
    }
}