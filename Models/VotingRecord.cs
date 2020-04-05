using System.Runtime.Serialization;

namespace WebAPI.Models
{
    [DataContract]
    public class VotingRecord
    {
        [DataMember]
        public string v_id { get; set; }
        [DataMember]
        public string m_id { get; set; }
        [DataMember]
        public string rd_id { get; set; }
        [DataMember]
        public bool vote_cast { get; set; }
        [DataMember]
        public bool voted_yes { get; set; }
        public VotingRecord()
        { 
        }
        public VotingRecord(string rdid)
        {
            this.rd_id = rdid;
        }
        public VotingRecord(string vid, string mid, string rdid,bool cast,bool yesno)
        {
            this.v_id = vid;
            this.m_id = mid;
            this.rd_id = rdid;
            this.vote_cast = cast;
            this.voted_yes = yesno;
        }
        public VotingRecord(string vid, string rdid, bool yesno)
        {
            this.v_id = vid;
            this.rd_id = rdid;
            this.voted_yes = yesno;
        }
    }
}
