using System.Runtime.Serialization;

namespace WebAPI.Models
{
    [DataContract]
    public class VotingRecord
    {
        [DataMember]
        public string rd_id { get; set; }
        public string v_id { get; set; }
        public string m_id { get; set; }
        public bool vote_cast { get; set; }
        public bool voted_yes { get; set; }

        public VotingRecord(string vid, string mid, string rdid,bool cast,bool yesno)
        {
            this.m_id = mid;
            this.v_id = vid;
            this.rd_id = rdid;
            this.vote_cast = cast;
            this.voted_yes = yesno;
        }
        public VotingRecord(string rdid)
        {
            this.rd_id = rdid;
        }
    }
}
