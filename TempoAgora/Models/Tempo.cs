﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempoAgora.Models
{
    public class Tempo
    {
        public double? lon { get; set; }
        public double? lat { get; set; }
        public int? visibility { get; set; }
        public double? temp_min { get; set; }
        public double? temp_max { get; set; }
        public string? sunrise { get; set; }
        public string? sunset { get; set; }
        public string? main { get; set; }
        public string? description { get; set; }
        public double? speed { get; set; }

    }
}
