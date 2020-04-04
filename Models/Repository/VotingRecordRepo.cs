using System;
using System.Collections.Generic;
using WebAPI.Models;

namespace WebApi.Models
{
    public class VoterRecordRepo {
        public readonly List<VotingRecord> votingRecordList = new List<VotingRecord>();
        public VoterRecordRepo()
        {
            votingRecordList.Add(new VotingRecord("v1", "m1", "rd1",true, false));
            votingRecordList.Add(new VotingRecord("v2", "m2", "rd2",false,  true));
            votingRecordList.Add(new VotingRecord("v3", "m3", "rd3",true,false));
            votingRecordList.Add(new VotingRecord("rd4"));
        }
        public VotingRecord Get(string id)
        {
          VotingRecord vr = votingRecordList.Find(v => v.rd_id == id);
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
        public bool Update(VotingRecord record)
        {
            return false;
        }
     }
}