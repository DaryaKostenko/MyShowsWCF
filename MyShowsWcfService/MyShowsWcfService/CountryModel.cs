﻿
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace MyShowsParser
{
    public class CountryModel
    {
        [Key]
        public string Name { get; set; }
        public virtual List<ShowModel> Shows { get; set; }
    }
}
