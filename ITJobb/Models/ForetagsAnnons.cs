using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITJobb.Models
{
    public class ForetagsAnnons : Annons
    {
        public string AnnonsURL { get; set; }
        public int? MalsidaRefId { get; set; }
        [ForeignKey("MalsidaRefId")]
        public Malsida Malsida { get; set; }

        public int? RekryterareRefId { get; set; }
        [ForeignKey("RekryterareRefId")]
        public Rekryterare Rekryterare { get; set; }

        public virtual ICollection<Anvandare> Anvandares { get; set; }
        public ForetagsAnnons()
        {
            this.Anvandares = new HashSet<Anvandare>();
        }
    }
}