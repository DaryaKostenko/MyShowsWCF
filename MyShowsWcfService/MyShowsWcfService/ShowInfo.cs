using System.Runtime.Serialization;

namespace MyShowsParser
{
    [DataContract]
    public class ShowInfo
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string Image { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string OriginalName { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string Genres { get; set; }
        [DataMember]
        public string MyShowsRating { get; set; }
    }
}
