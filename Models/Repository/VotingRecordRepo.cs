using System;
using System.Collections.Generic;
using System.Diagnostics;
using WebAPI.Models;

namespace WebApi.Models
{
    public class VoterRecordRepo {
        public readonly List<VotingRecord> votingRecordList = new List<VotingRecord>();
        public readonly List<VotingRecord> vrList = new List<VotingRecord>();
        public VoterRecordRepo()
        {
            votingRecordList.Add(new VotingRecord("v1", "m1", "rd1",true, false));
            votingRecordList.Add(new VotingRecord("v2", "m1", "rd2",false,  true));
            votingRecordList.Add(new VotingRecord("v3", "m1", "rd3",true,false));
        }
        public VotingRecord Get(string id)
        {
             VotingRecord vr = votingRecordList.Find(v => v.v_id == id);
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
            int index = votingRecordList.FindIndex(rd => rd.rd_id == record.rd_id);
            if(index == -1)
            {
                return false;
            }
            foreach(VotingRecord r in votingRecordList)
            {
                if(r.rd_id == record.rd_id)
                {
                    r.voted_yes = record.voted_yes;
                    return true;
                }
            }
            //votingRecordList.Add(new VotingRecord(record.rd_id,record.m_id,record.v_id,true,true));
            return false;
        }
     }
}