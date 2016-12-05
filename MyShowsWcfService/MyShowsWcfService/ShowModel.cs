﻿using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace MyShowsParser
{
    
    public class ShowModel
    {
        [Key]
        public string Name { get; set; }
        public string OriginalName { get; set; }
        public CountryModel Country { get; set; }
        public string Genres { get; set; }
        public string MyShowsRating { get; set; }
    }
}
