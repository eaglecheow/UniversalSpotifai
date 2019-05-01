using System;
using System.Collections.Generic;
using System.Text;

namespace SpotifaiStandard.Models
{
    public class Album
    {
        public string AlbumType { get; set; }
        public Artist[] Artists { get; set; }
        public string[] AvailableMarkets { get; set; }
        public string[] Genres { get; set; }
        public string Id { get; set; }
        public CoverImage[] Images { get; set; }
        public string Label { get; set; }
        public string Name { get; set; }
        public int Popularity { get; set; }
        public string ReleaseDate { get; set; }
        public string ReleaseDatePresicion { get; set; }
        public Track[] Tracks { get; set; }
        public string Uri { get; set; }
    }
}
