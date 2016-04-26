using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITJobb.Models
{
    public class YrkesTitel
    {
        public int YrkesTitelId { get; set; }
        public string YrkesNamn { get; set; }
        public decimal MedelLön { get; set; }

        public YrkesTitel()
        {
            this.Annonser = new HashSet<Annons>();
        }
        public virtual ICollection<Annons> Annonser { get; set; }
    }
}