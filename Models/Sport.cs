﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace WEB.Models
{
    public class Sport
    {
        public int ID { get; set; }

        public string NumeSport { get; set; }

        public int? InstructorID { get; set; }
        public Instructor? Instructor { get; set; }


        [Column(TypeName = "decimal(6, 2)")]
        public decimal Pret { get; set; }
        public string Locatie { get; set; }

        public ICollection<CategorieSport>? CategoriiSport { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Durata { get; set; }
    }
}