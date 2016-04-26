using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ITJobb.Models
{
    public class AnvandareInitiallizer : DropCreateDatabaseIfModelChanges<ITJobbDbContext>
    {
        protected override void Seed(ITJobbDbContext context)
        {
            List<Anvandare> Anvandares = new List<Anvandare>
            {
                new Anvandare
                {
                    ForNamn            = "Gad",
                    EfterNamn          = "Job",
                    TelefonNummer       = "EC Utbildning",
                    MailAdress         = "Jab@hotmail.com",
                    CVURL              = "1234567890",
                    PersonligtBrevURL = "URL",
                },
            new Anvandare
            {
                ForNamn           =  "May",
                EfterNamn          = "Kap",
                TelefonNummer     = "0987654321",
                MailAdress        = "May@hotmail.com",
                CVURL              = "EC Utbildning",
                PersonligtBrevURL= "www.URL.se",
                
            }
          };
            Anvandares.ForEach(c => context.Anvandares.Add(c));
        }
    }
}