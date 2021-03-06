﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITJobb.Models
{
    public class Rekryterare
    {
        public int RekryterareId { get; set; }
        public string ForetagsNamn { get; set; }
        public string RekryterareURL { get; set; }
        public string MailAdress { get; set; }

        public Rekryterare()
        {
            this.Annonser = new HashSet<ForetagsAnnons>();
        }
        public virtual ICollection<ForetagsAnnons> Annonser { get; set; }
    }
}