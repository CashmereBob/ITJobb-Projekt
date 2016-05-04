using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace ITJobb.Models
{
    public class AnvandareInitiallizer : DropCreateDatabaseIfModelChanges<ITJobbDbContext>
    {
        protected override void Seed(ITJobbDbContext context)
        {
            List<Anvandare> Anvandares = new List<Anvandare>();

            var anvandare1 = new Anvandare
            {
                ForNamn = "Gad",
                EfterNamn = "Job",
                TelefonNummer = "EC Utbildning",
                MailAdress = "Jab@hotmail.com",
                CVURL = "1234567890",
                PersonligtBrevURL = "URL",
            };

            Anvandares.Add(anvandare1);

            var anvandare2 = new Anvandare
            {
                ForNamn = "May",
                EfterNamn = "Kap",
                TelefonNummer = "0987654321",
                MailAdress = "May@hotmail.com",
                CVURL = "EC Utbildning",
                PersonligtBrevURL = "www.URL.se",

            };

            Anvandares.Add(anvandare2);

            var anvandare3 = new Anvandare
            {
                ForNamn = "Magnus",
                EfterNamn = "Weidmar",
                TelefonNummer = "0987654321",
                MailAdress = "Magnus@hotmail.com",
                CVURL = "Random",
                PersonligtBrevURL = "www.URL.se",

            };

            Anvandares.Add(anvandare3);

            var anvandare4 = new Anvandare
            {
                ForNamn = "Therese",
                EfterNamn = "S",
                TelefonNummer = "0987654321",
                MailAdress = "Therese@hotmail.com",
                CVURL = "www.CV.se",
                PersonligtBrevURL = "www.URL.se",

            };

            Anvandares.Add(anvandare4);

            var anvandare5 = new Anvandare
            {
                ForNamn = "Mikael",
                EfterNamn = "Nilsson",
                TelefonNummer = "042-160497",
                MailAdress = "Mikael@hotmail.com",
                CVURL = "www.CVadress.se",
                PersonligtBrevURL = "www.URL.se",

            };

            Anvandares.Add(anvandare5);

            var anvandare6 = new Anvandare
            {
                ForNamn = "Jenny",
                EfterNamn = "Olsson",
                TelefonNummer = "042-125478",
                MailAdress = "Jenny@hotmail.com",
                CVURL = "www.CV.se",
                PersonligtBrevURL = "www.URL.se",
            };

            Anvandares.Add(anvandare6);

            var anvandare7 = new Anvandare
            {
                ForNamn = "Marie",
                EfterNamn = "Snygg",
                TelefonNummer = "0987s54321",
                MailAdress = "Mari@hotmail.com",
                CVURL = "EC Utbildning",
                PersonligtBrevURL = "www.URL.se",

            };

            Anvandares.Add(anvandare7);

            var anvandare8 = new Anvandare
            {
                ForNamn = "Fredrik",
                EfterNamn = "Falk",
                TelefonNummer = "0987654321",
                MailAdress = "Fredrik@hotmail.com",
                CVURL = "www.Random.se",
                PersonligtBrevURL = "www.URL.se",

            };

            Anvandares.Add(anvandare8);

            var anvandare9 = new Anvandare
            {
                ForNamn = "Li",
                EfterNamn = "Nilsson",
                TelefonNummer = "042-162211",
                MailAdress = "Li@hotmail.com",
                CVURL = "www.CV.se",
                PersonligtBrevURL = "www.URL.se",

            };

            Anvandares.Add(anvandare9);

            var anvandare10 = new Anvandare
            {
                ForNamn = "Sven",
                EfterNamn = "Nilsson",
                TelefonNummer = "042-160497",
                MailAdress = "Sven@hotmail.com",
                CVURL = "www.CVadress.se",
                PersonligtBrevURL = "www.URL.se",

            };

            Anvandares.Add(anvandare10);


            Anvandares.ForEach(c => context.Anvandares.AddOrUpdate(c));

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
            Ort.ForEach(c => context.Orts.AddOrUpdate(c));


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
            Malsida.ForEach(c => context.Malsidas.AddOrUpdate(c));

            List<Tag> Tag = new List<Tag>();


            var tag1 = new Tag
            {
                TagNamn = ".NET"

            };

            Tag.Add(tag1);

            var tag2 = new Tag
            {
                TagNamn = "C#"

            };

            Tag.Add(tag2);

            var tag3 = new Tag
            {
                TagNamn = "ASP.NET"

            };

            Tag.Add(tag3);

            var tag4 = new Tag
            {
                TagNamn = "T-SQL"

            };

            Tag.Add(tag4);

            Tag.ForEach(c => context.Tages.AddOrUpdate(c));

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
            YrkesTitel.ForEach(c => context.Yrkestitels.AddOrUpdate(c));

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
            Rekryterare.ForEach(c => context.Rekryterares.AddOrUpdate(c));

            context.SaveChanges();

            List<PersonAnnons> PersonAnnons = new List<PersonAnnons>();

            var personannons1 = new PersonAnnons
            {
                YrkestitelRefId = 1,
                OrtRefId = 2,
                Titel = "Jobb i Helsingborg",
                Beskrivning = "Lorum Porum",
                AnvandareRefId = 2,
                PubliceringsDatum = new DateTime(2016, 03, 22)

            };

            PersonAnnons.Add(personannons1);

            var personannons2 = new PersonAnnons
            {
                YrkestitelRefId = 1,
                OrtRefId = 2,
                Titel = "Jobb?",
                Beskrivning = "Lorum Porum",
                AnvandareRefId = 2,
                PubliceringsDatum = new DateTime(2016, 03, 23)

            };

            PersonAnnons.Add(personannons2);

            var personannons3 = new PersonAnnons
            {
                YrkestitelRefId = 2,
                OrtRefId = 3,
                Titel = "Söker arbete som systemutvecklare!",
                Beskrivning = "Lorum Porum",
                AnvandareRefId = 3,
                PubliceringsDatum = new DateTime(2016, 03, 24)

            };

            PersonAnnons.Add(personannons3);

            var personannons4 = new PersonAnnons
            {
                YrkestitelRefId = 3,
                OrtRefId = 4,
                Titel = "Ett Jobb till mig?",
                Beskrivning = "Lorum Porum",
                AnvandareRefId = 4,
                PubliceringsDatum = new DateTime(2016, 03, 25)

            };

            PersonAnnons.Add(personannons4);

            var personannons5 = new PersonAnnons
            {
                YrkestitelRefId = 4,
                OrtRefId = 5,
                Titel = "Jag Söker Jobb",
                Beskrivning = "Lorum Porum",
                AnvandareRefId = 5,
                PubliceringsDatum = new DateTime(2016, 03, 26)

            };

            PersonAnnons.Add(personannons5);

            PersonAnnons.ForEach(c => context.PersonAnnonses.AddOrUpdate(c));

            List<ForetagsAnnons> ForetagsAnnons = new List<ForetagsAnnons>();

            var foretagsannons1 = new ForetagsAnnons
            {
                YrkestitelRefId = 1,
                OrtRefId = 1,
                AnnonsURL = "www.lorumporum.se",
                RekryterareRefId = 1,
                MalsidaRefId = 4,
                PubliceringsDatum = new DateTime(2016, 03, 18)

            };

            ForetagsAnnons.Add(foretagsannons1);

            var foretagsannons2 = new ForetagsAnnons
            {
                YrkestitelRefId = 1,
                OrtRefId = 2,
                AnnonsURL = "www.lorumporum.se",
                RekryterareRefId = 2,
                MalsidaRefId = 4,
                PubliceringsDatum = new DateTime(2016, 03, 19)

            };

            ForetagsAnnons.Add(foretagsannons2);

            var foretagsannons3 = new ForetagsAnnons
            {
                YrkestitelRefId = 2,
                OrtRefId = 3,
                AnnonsURL = "www.lorumporum.se",
                RekryterareRefId = 3,
                MalsidaRefId = 3,
                PubliceringsDatum = new DateTime(2016, 03, 20)

            };

            ForetagsAnnons.Add(foretagsannons3);

            var foretagsannons4 = new ForetagsAnnons
            {
                YrkestitelRefId = 3,
                OrtRefId = 4,
                AnnonsURL = "www.lorumporum.se",
                RekryterareRefId = 4,
                MalsidaRefId = 2,
                PubliceringsDatum = new DateTime(2016, 03, 21)

            };

            ForetagsAnnons.Add(foretagsannons4);

            var foretagsannons5 = new ForetagsAnnons
            {
                YrkestitelRefId = 4,
                OrtRefId = 5,
                AnnonsURL = "www.lorumporum.se",
                RekryterareRefId = 4,
                MalsidaRefId = 1,
                PubliceringsDatum = new DateTime(2016, 03, 22)

            };

            ForetagsAnnons.Add(foretagsannons5);

            ForetagsAnnons.ForEach(c => context.ForetagsAnnonses.AddOrUpdate(c));

            context.SaveChanges();

            anvandare2.ForetagsAnnonser.Add(foretagsannons2);
            anvandare2.ForetagsAnnonser.Add(foretagsannons4);
            anvandare3.ForetagsAnnonser.Add(foretagsannons3);
            anvandare3.ForetagsAnnonser.Add(foretagsannons4);
            anvandare4.ForetagsAnnonser.Add(foretagsannons2);
            anvandare4.ForetagsAnnonser.Add(foretagsannons5);
            anvandare5.ForetagsAnnonser.Add(foretagsannons2);
            anvandare6.ForetagsAnnonser.Add(foretagsannons4);
            anvandare7.ForetagsAnnonser.Add(foretagsannons2);
            anvandare8.ForetagsAnnonser.Add(foretagsannons5);
            anvandare9.ForetagsAnnonser.Add(foretagsannons3);
            anvandare10.ForetagsAnnonser.Add(foretagsannons4);

            personannons1.Tags.Add(tag1);
            personannons1.Tags.Add(tag2);
            personannons2.Tags.Add(tag4);
            personannons2.Tags.Add(tag3);
            personannons3.Tags.Add(tag2);
            personannons3.Tags.Add(tag1);
            personannons4.Tags.Add(tag2);
            personannons4.Tags.Add(tag4);
            personannons5.Tags.Add(tag4);
            personannons5.Tags.Add(tag3);

            foretagsannons1.Tags.Add(tag1);
            foretagsannons1.Tags.Add(tag2);
            foretagsannons2.Tags.Add(tag4);
            foretagsannons2.Tags.Add(tag3);
            foretagsannons3.Tags.Add(tag2);
            foretagsannons3.Tags.Add(tag1);
            foretagsannons4.Tags.Add(tag2);
            foretagsannons4.Tags.Add(tag4);
            foretagsannons5.Tags.Add(tag4);
            foretagsannons5.Tags.Add(tag3);

            context.SaveChanges();
        }
    }
}