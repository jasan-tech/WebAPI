using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;



namespace WebAPI
{
    [Route("api/[controller]")]
    public class Clear : Controller
    {
        // GET: api/<controller>

        // POST api/<controller>
        [HttpPost]

        // PUT api/<controller>/5
       [HttpPut("{id}")]

        // DELETE api/<controller>/5
        [HttpDelete]
        public bool Delete()
        {
            WebApi.Controllers.VotingRecordController.vr_repo.RemoveAll();
            int count = WebApi.Controllers.VotingRecordController.vr_repo.GetAll().Count();
            if(count == 0)
            {
                return true;
            }
            else
            {
                return false;
            } 
        }
    }
}
