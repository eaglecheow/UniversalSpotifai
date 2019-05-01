using System;
using System.Collections.Generic;
using System.Text;

namespace SpotifaiStandard.Models
{
    public class Track
    {
        public Album Album { get; set; }
        public Artist[] Artists { get; set; }
        public string[] AvailableMarkets { get; set; }
        public int DiscNumber { get; set; }
        public int DurationMs { get; set; }
        public bool Explicit { get; set; }
        public string Id { get; set; }
        public bool IsPlayable { get; set; }
        public string Name { get; set; }
        public string PreviewUrl { get; set; }
        public int TrackNumber { get; set; }
        public string Uri { get; set; }
    }
}
