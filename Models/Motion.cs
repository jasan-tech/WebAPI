using System.Runtime.Serialization;


namespace WebApi.Models
{
    [DataContract]
    public class Motion
    {
        
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string text { get; set; }
        public Motion(string id, string text)
        {
            this.id = id;
            this.text = text;
        }

        public Motion()
        {
        }
    }
}
