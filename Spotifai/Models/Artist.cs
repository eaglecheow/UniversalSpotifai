using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifai.Models
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
