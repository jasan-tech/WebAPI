using System.Runtime.Serialization;

namespace WebApi.Models
{
    [DataContract]
    public class Motion
    {
        [DataMember]
        public string m_id { get; set; }
        [DataMember]
        public string m_text { get; set; }
        public Motion(string id, string text)
        {
            m_id = id;
            m_text = text;
        }
        public Motion()
        {

        }
    }
}
