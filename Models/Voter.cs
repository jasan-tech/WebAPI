using System.Runtime.Serialization;

namespace WebApi.Models
{
    [DataContract]
    public class Voter 
    {
        
        [DataMember]
        public string id { get; set; }

        public Voter(string v)
        {
            this.id = v;
        }

        public Voter()
        {
        }
    }
}
