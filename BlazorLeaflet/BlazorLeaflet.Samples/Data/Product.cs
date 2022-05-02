﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorLeaflet.Samples.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Workers { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
