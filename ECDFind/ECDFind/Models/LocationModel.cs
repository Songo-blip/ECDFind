using System;
using System.Collections.Generic;
using System.Text;

namespace FindECD.Models
{
    public class LocationModel
    {
        public int Id { get; set; }
        public string ECDName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public double Longitute { get; set; }
        public double Latiute { get; set; }
    }
}