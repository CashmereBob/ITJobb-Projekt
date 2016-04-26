using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITJobb.Models
{
    public class Målsida
    {
        public int MålsidaId { get; set; }
        public string MålsidaNamn { get; set; }
        public string MålsidaUrl { get; set; }

        public Målsida()
        {
            this.Annonser = new HashSet<FöretagsAnnons>();
        }
        public virtual ICollection<FöretagsAnnons> Annonser { get; set; }
    }
}