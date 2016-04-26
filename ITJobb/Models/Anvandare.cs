using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITJobb.Models
{
    public class Anvandare
    {
        public int AnvandareId { get; set; }
        public string ForNamn { get; set; }
        public string EfterNamn { get; set; }
        public string TelefonNummer { get; set; }
        public string MailAdress { get; set; }
        public string CVURL { get; set; }
        public string PersonligtBrevURL { get; set; }
        public Anvandare()
        {
            this.ForetagsAnnonser = new HashSet<ForetagsAnnons>();
        }
        public virtual ICollection<ForetagsAnnons> ForetagsAnnonser { get; set; }



    }
}