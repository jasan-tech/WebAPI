using System;
using System.Collections.Generic;


namespace WebApi.Models
{
    public class VoterRepo {
        public readonly List<Voter> voters = new List<Voter>();
        public VoterRepo()
        {
            voters.Add(new Voter("v1"));
            voters.Add(new Voter("v2"));
            voters.Add(new Voter("v3"));
        }
        public Voter Get(string id)
        {
            return voters.Find(v => v.v_id == id);
        }
        public IEnumerable<Voter> GetAll()
        {
            return voters;
        }
        public bool Add(Voter v)
        {
            voters.Add(v);
            return true;
        }
        public bool Remove(Voter vtr)
        {
            int index = voters.FindIndex(v => v.v_id == vtr.v_id);
            if(index == -1)
            {
                return false;
            }
            voters.RemoveAt(index);
            return true;
        }
        public void RemoveAll()
        { 
            voters.RemoveRange(0, voters.Count);
        } 
        public bool Update(Voter vtr)
        {
           int index = voters.FindIndex(v => v.v_id == vtr.v_id);
            if (index == -1)
            {
                return false;
            }
            voters.RemoveAt(index);
            voters.Add(vtr);
            return true;
        }
     }
}