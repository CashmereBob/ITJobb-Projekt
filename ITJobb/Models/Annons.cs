using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITJobb.Models
{
    public abstract class Annons
    {

        public Annons()
        {
            this.Tags = new HashSet<Tag>();
        }

        public int AnnonsId { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Publicerings Datum")]

        public DateTime PubliceringsDatum { get; set; }

        public int? YrkestitelRefId { get; set; }
        [ForeignKey("YrkestitelRefId")]
        public YrkesTitel Yrkestitel { get; set; }

        public int? OrtRefId { get; set; }
        [ForeignKey("OrtRefId")]
        public Ort Ort { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }



    }
}