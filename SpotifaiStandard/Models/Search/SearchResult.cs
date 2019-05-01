using System;
using System.Collections.Generic;
using System.Text;

namespace SpotifaiStandard.Models.Search
{
    public class SearchResult
    {
        public PagingObject<Album> Album { get; set; }
        public PagingObject<Artist> Artist { get; set; }
        public PagingObject<Track> Track { get; set; }
    }
}
