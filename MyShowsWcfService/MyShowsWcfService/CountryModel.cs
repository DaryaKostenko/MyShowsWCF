
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;


namespace MyShowsParser
{
    [DataContract]
    public class CountryModel
    {
        [DataMember]
        [Key]
        public string Name { get; set; }
        [DataMember]
        public virtual List<ShowModel> Shows { get; set; }
    }
}
