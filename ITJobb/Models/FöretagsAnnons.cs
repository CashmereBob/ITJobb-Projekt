using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITJobb.Models
{
    public class FöretagsAnnons : Annons
    {
        public string AnnonsURL { get; set; }
        public int? MålsidaRefId { get; set; }
        [ForeignKey("MålsidaRefId")]
        public Målsida Målsida { get; set; }

        public int? RekryterareRefId { get; set; }
        [ForeignKey("RekryterareRefId")]
        public Rekryterare Rekryterare { get; set; }

        public virtual ICollection<Användare> Användares { get; set; }
        public FöretagsAnnons()
        {
            this.Användares = new HashSet<Användare>();
        }
    }
}