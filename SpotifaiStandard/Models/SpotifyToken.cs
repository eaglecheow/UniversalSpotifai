using System;
using System.Collections.Generic;
using System.Text;

namespace SpotifaiStandard.Models
{
    public class SpotifyToken
    {
        public string AccessToken { get; set; }
        public string TokenType { get; set; }
        public int ExpiresIn { get; set; }
    }
}
