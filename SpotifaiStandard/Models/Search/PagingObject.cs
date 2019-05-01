using System;
using System.Collections.Generic;
using System.Text;

namespace SpotifaiStandard.Models.Search
{
    public class PagingObject<T>
    {
        public T[] Items { get; set; }
        public int Limit { get; set; }
        public string Next { get; set; }
        public int Offset { get; set; }
        public string Previous { get; set; }
        public int Total { get; set; }
    }
}
