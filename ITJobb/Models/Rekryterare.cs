using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITJobb.Models
{
    public class Rekryterare
    {
        public int RekryterareId { get; set; }
        public string FöretagsNamn { get; set; }
        public string RekryterareURL { get; set; }
        public string MailAdress { get; set; }

        public Rekryterare()
        {
            this.Annonser = new HashSet<FöretagsAnnons>();
        }
        public virtual ICollection<FöretagsAnnons> Annonser { get; set; }
    }
}