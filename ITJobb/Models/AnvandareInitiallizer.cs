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
                
            },

             new Anvandare
            {
                ForNamn           =  "Magnus",
                EfterNamn          = "Weidmar",
                TelefonNummer     = "0987654321",
                MailAdress        = "Magnus@hotmail.com",
                CVURL              = "Random",
                PersonligtBrevURL= "www.URL.se",

            },

             new Anvandare
             {
                 ForNamn = "Therese",
                 EfterNamn = "S",
                 TelefonNummer = "0987654321",
                 MailAdress = "Therese@hotmail.com",
                 CVURL = "www.CV.se",
                 PersonligtBrevURL = "www.URL.se",

             },
                          new Anvandare
             {
                 ForNamn = "Mikael",
                 EfterNamn = "Nilsson",
                 TelefonNummer = "042-160497",
                 MailAdress = "Mikael@hotmail.com",
                 CVURL = "www.CVadress.se",
                 PersonligtBrevURL = "www.URL.se",

             },
                          new Anvandare
                {
                    ForNamn            = "Jenny",
                    EfterNamn          = "Olsson",
                    TelefonNummer       = "042-125478",
                    MailAdress         = "Jenny@hotmail.com",
                    CVURL              = "www.CV.se",
                    PersonligtBrevURL = "www.URL.se",
                },
            new Anvandare
            {
                ForNamn           =  "Marie",
                EfterNamn          = "Snygg",
                TelefonNummer     = "0987s54321",
                MailAdress        = "Mari@hotmail.com",
                CVURL              = "EC Utbildning",
                PersonligtBrevURL= "www.URL.se",

            },

             new Anvandare
            {
                ForNamn           =  "Fredrik",
                EfterNamn          = "Falk",
                TelefonNummer     = "0987654321",
                MailAdress        = "Fredrik@hotmail.com",
                CVURL              = "www.Random.se",
                PersonligtBrevURL= "www.URL.se",

            },

             new Anvandare
             {
                 ForNamn = "Li",
                 EfterNamn = "Nilsson",
                 TelefonNummer = "042-162211",
                 MailAdress = "Li@hotmail.com",
                 CVURL = "www.CV.se",
                 PersonligtBrevURL = "www.URL.se",

             },
                          new Anvandare
             {
                 ForNamn = "Sven",
                 EfterNamn = "Nilsson",
                 TelefonNummer = "042-160497",
                 MailAdress = "Sven@hotmail.com",
                 CVURL = "www.CVadress.se",
                 PersonligtBrevURL = "www.URL.se",

             }

          };
            Anvandares.ForEach(c => context.Anvandares.Add(c));

            List<Ort> Ort = new List<Ort>
            {
                
            new Ort
             {
                 OrtNamn = "Helsingborg",
                
             },
             new Ort
             {
                 OrtNamn = "Stockholm",

             },
             new Ort
             {
                 OrtNamn = "Landskrona",

             },
             new Ort
             {
                 OrtNamn = "Bjuv",

             },
             new Ort
             {
                 OrtNamn = "Halmstad",

             },
             new Ort
             {
                 OrtNamn = "Varberg",

             },
             new Ort
             {
                 OrtNamn = "Malmö",

             },
             new Ort
             {
                 OrtNamn = "Kristianstad",

             },
             new Ort
             {
                 OrtNamn = "Uppsala",

             },
             new Ort
             {
                 OrtNamn = "Sundsvall",

             }

          };
            Ort.ForEach(c => context.Orts.Add(c));

            Anvandares.ForEach(c => context.Anvandares.Add(c));

            List<Malsida> Malsida = new List<Malsida>
            {

            new Malsida
             {
                 MalsidaNamn = "Arbetsformedlingen",
                 MalsidaUrl = "www.arbetsformedlingen.se"

             },
             new Malsida
             {
                 MalsidaNamn = "Monster",
                 MalsidaUrl = "www.monster.se"

             },
             new Malsida
             {
                 MalsidaNamn = "Blocket Jobb",
                 MalsidaUrl = "www.blocket.se/jobb"

             },
             new Malsida
             {
                 MalsidaNamn = "Jobb Safari",
                 MalsidaUrl = "www.jobbsafari.se"

             }
            

          };
            Malsida.ForEach(c => context.Malsidas.Add(c));

            List<Tag> Tag = new List<Tag>
            {

            new Tag
             {
                 TagNamn = ".NET"

             },
             new Tag
             {
                 TagNamn = "C#"

             },
             new Tag
             {
                 TagNamn = "ASP.NET"

             },
             new Tag
             {
                 TagNamn = "T-SQL"

             }


          };
            Tag.ForEach(c => context.Tages.Add(c));

            List<YrkesTitel> YrkesTitel = new List<YrkesTitel>
            {

            new YrkesTitel
             {
                 YrkesNamn = "Webbutvecklare",
                 MedelLon = 35000

             },
             new YrkesTitel
             {
                 YrkesNamn = "Systemutvecklare",
                 MedelLon = 40000

             },
             new YrkesTitel
             {
                 YrkesNamn = "Driftingenjör",
                 MedelLon = 30000
                 

             },
             new YrkesTitel
             {
                 YrkesNamn = "Mjukvarutestare",
                 MedelLon = 25000

             }
            


          };
            YrkesTitel.ForEach(c => context.Yrkestitels.Add(c));

            List<Rekryterare> Rekryterare = new List<Rekryterare>
            {

            new Rekryterare
             {
                 ForetagsNamn = "Cisco",
                 RekryterareURL = "www.Cisco.se",
                 MailAdress = "info@cisco.se"

             },
             new Rekryterare
             {
                 ForetagsNamn = "Microsoft",
                 RekryterareURL = "www.microsoft.se",
                 MailAdress = "info@microsoft.se"

             },
             new Rekryterare
             {
                 ForetagsNamn = "Proffice",
                 RekryterareURL = "www.proffice.se",
                 MailAdress = "info@proffice.se"

             },
             new Rekryterare
             {
                 ForetagsNamn = "AcademicWorks",
                 RekryterareURL = "www.academicworks.se",
                 MailAdress = "info@Academicworks.se"

             }


          };
            Rekryterare.ForEach(c => context.Rekryterares.Add(c));

            List<PersonAnnons> PersonAnnons = new List<PersonAnnons>
            {

            new PersonAnnons
             {
                 Titel = "Jobb i Helsingborg",
                 Beskrivning = "Lorum Porum",



             },
             new PersonAnnons
             {
                 Titel = "Jobb?",
                 Beskrivning = "Lorum Porum",



             },
             new PersonAnnons
             {
                 Titel = "Söker arbete som systemutvecklare!",
                 Beskrivning = "Lorum Porum",




             },
             new PersonAnnons
             {

                 Titel = "Ett Jobb till mig?",
                 Beskrivning = "Lorum Porum",




             },
             new PersonAnnons
             {
                 Titel = "Jag Söker Jobb",
                 Beskrivning = "Lorum Porum",



             }


          };
            PersonAnnons.ForEach(c => context.PersonAnnonses.Add(c));

            List<ForetagsAnnons> ForetagsAnnons = new List<ForetagsAnnons>
            {

            new ForetagsAnnons
             {

                 AnnonsURL = "www.lorumporum.se",


             },
             new ForetagsAnnons
             {

                 AnnonsURL = "www.lorumporum.se",


             },
             new ForetagsAnnons
             {

                 AnnonsURL = "www.lorumporum.se",


             },
             new ForetagsAnnons
             {

                 AnnonsURL = "www.lorumporum.se",


             },
             new ForetagsAnnons
             {

                 AnnonsURL = "www.lorumporum.se",


             }


          };
            ForetagsAnnons.ForEach(c => context.ForetagsAnnonses.Add(c));
        }
    }
}