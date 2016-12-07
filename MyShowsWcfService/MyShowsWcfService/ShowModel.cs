using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace MyShowsParser
{
    [DataContract]
    public class ShowModel
    {
        [DataMember]
        [Key]
        public string Name { get; set; }
        [DataMember]
        public string OriginalName { get; set; }
        [DataMember]
        public CountryModel Country { get; set; }
        [DataMember]
        public string Genres { get; set; }
        [DataMember]
        public string MyShowsRating { get; set; }
    }
}
