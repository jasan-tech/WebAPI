using System.Runtime.Serialization;

namespace WebAPI.Models
{
    [DataContract]
    public class VotingRecord
    {
        [DataMember]
        public string vid { get; set; }
        public string mid { get; set; }
        public string sid { get; set; }
        public VotingRecord(string vid, string mid, string sid)
        {
            this.mid = mid;
            this.vid = vid;
            this.sid = sid;
        }
        public VotingRecord()
        {

        }
    }
}
