using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITJobb.Models
{
    public class Ort
    {
        public Ort()
        {
            this.Annonser = new HashSet<Annons>();
        }
        public int OrtId { get; set; }
        public string OrtNamn { get; set; }

        public virtual ICollection<Annons> Annonser { get; set; }
    }
}