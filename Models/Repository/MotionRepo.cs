using System;
using System.Collections.Generic;
namespace WebApi.Models
{
    public class MotionRepo 
    {
        public readonly List<Motion> motions = new List<Motion>();
        public MotionRepo()
        {
            motions.Add(new Motion("v1","Hello"));
            motions.Add(new Motion("v2","Hai"));
            motions.Add(new Motion("v3","Bye"));

        }
        public Motion Get(string id)
        {
            return motions.Find(m => m.m_id == id);
        }
        public IEnumerable<Motion> GetAll()
        {
            return motions;
        }
        public bool Add(Motion v)
        {
            motions.Add(v);
            return true;
        }
        public bool Remove(Motion mtn)
        {

            int index = motions.FindIndex(m => m.m_id == mtn.m_id);
            if(index == -1)
            {
                return false;
            }
            motions.RemoveAt(index);
            return true;
        }
        public void RemoveAll()
        {
            motions.RemoveRange(0, motions.Count);
            
        } 
        public bool Update(Motion mtn)
        {
            int index = motions.FindIndex(m => m.m_id == mtn.m_id);
            if (index == -1)
            {
                return false;
            }
            motions.RemoveAt(index);
            motions.Add(mtn);
            return true;
        }
    }
}
