using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITJobb.Models
{
    public class Tag
    {
        public Tag()
        {
            this.Annonser = new HashSet<Annons>();   
        }
        public int TagId { get; set; }
        public string TagNamn { get; set; }
        public virtual ICollection<Annons> Annonser { get; set; }
    }
}