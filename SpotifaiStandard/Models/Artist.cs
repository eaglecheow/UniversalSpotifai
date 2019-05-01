using System;
using System.Collections.Generic;
using System.Text;

namespace SpotifaiStandard.Models
{
    public class Artist
    {
        public string Id { get; set; }
        public CoverImage[] Images { get; set; }
        public string Name { get; set; }
        public int Popularity { get; set; }
        public string Uri { get; set; }
    }
}
