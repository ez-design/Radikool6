﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Radikool6.Entities
{
    [Table("stations")]
    public class Station
    {
        [Key]
        public string Id { get; set; }

        public string RegionId { get; set; } = "";
        
        public string RegionName { get; set; } = "";
        
        public string Area { get; set; } = "";

        public string Type { get; set; } = "";

        public string Code { get; set; } = "";

        public string Name { get; set; } = "";
        
        public int Sequence { get; set; }
        
        public string MediaUrl { get; set; } = "";
        
        public string TimetableUrl { get; set; } = "";

        public List<Program> Programs { get; set; } = new List<Program>();

    }
}
