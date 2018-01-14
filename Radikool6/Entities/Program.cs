﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Radikool6.Entities
{
    [Table("programs")]
    public class Program
    {
        [Key]
        [Column("id")]
        public string Id { get; set; }

        [ForeignKey("Station")]
        [Column("station_id")]
        public string StationId { get; set; }

        [Column("start")]
        public DateTime Start { get; set; }

        [Column("end")]
        public DateTime End { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("cast")]
        public string Cast { get; set; }

        [Column("description")]
        public string Description { get; set; }

        public Station Station { get; set; }
    }
}
