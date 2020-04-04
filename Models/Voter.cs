using System.Runtime.Serialization;

namespace WebApi.Models
{
    [DataContract]
    public class Voter 
    {
        
        [DataMember]
        public string v_id { get; set; }

        public Voter(string id)
        {
           v_id = id;
        }

        public Voter()
        {
        }
    }
}
