using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITJobb.Models
{
    public class Användare
    {
        public int AnvändareId { get; set; }
        public string FörNamn { get; set; }
        public string EfterNamn { get; set; }
        public string TelefonNummer { get; set; }
        public string MailAdress { get; set; }
        public string CVURL { get; set; }
        public string PersonligtBrevURL { get; set; }
        public Användare()
        {
            this.FöretagsAnnonser = new HashSet<FöretagsAnnons>();
        }
        public virtual ICollection<FöretagsAnnons> FöretagsAnnonser { get; set; }



    }
}