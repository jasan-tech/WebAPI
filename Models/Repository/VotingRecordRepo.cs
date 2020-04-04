using System;
using System.Collections.Generic;
using WebAPI.Models;

namespace WebApi.Models
{
    public class VoterRecordRepo {
        public readonly List<VotingRecord> votingRecordList = new List<VotingRecord>();
        public VoterRecordRepo()
        {
            votingRecordList.Add(new VotingRecord("v1", "m1", "s1"));
            votingRecordList.Add(new VotingRecord("v2", "m2", "s2"));
            votingRecordList.Add(new VotingRecord("v3", "m3", "s3"));
        }
        public VotingRecord Get(string id)
        {
          VotingRecord vr = votingRecordList.Find(v => v.vid == id);
            return vr;
        }
        public IEnumerable<VotingRecord> GetAll()
        {
            return votingRecordList;
        }
        public bool Add(VotingRecord vr)
        {
            
            votingRecordList.Add(vr);
            return true;
        }
        public void RemoveAll()
        { 
            votingRecordList.RemoveRange(0, votingRecordList.Count);
        }
        public bool Update(Voter vtr)
        {
            return false;
        }
     }
}