using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITJobb.Models
{
    public class PersonAnnons : Annons
    {
        public string Titel { get; set; }
        public string Beskrivning { get; set; }

        public int? AnvandareRefId { get; set; }
        [ForeignKey("AnvandareRefId")]
        public Anvandare Anvandare { get; set; }


    }
}