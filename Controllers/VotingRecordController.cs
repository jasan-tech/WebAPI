using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using System.Web.Http;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using WebAPI.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("/api/[controller]")]
    public class VotingRecordController : ControllerBase
    {
        public static readonly VoterRecordRepo vr_repo = new VoterRecordRepo();
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public IEnumerable<VotingRecord> GetAllVoters()
        {
            return vr_repo.GetAll();
        }
        // GET: api/Voter/5
        [Microsoft.AspNetCore.Mvc.HttpGet("{id}")]
        public VotingRecord GetVoter(string id)
        {
            return vr_repo.Get(id);
        }
        // POST: api/Voter
        [Microsoft.AspNetCore.Mvc.HttpPost]
    public bool PostVoter([System.Web.Http.FromBody] VotingRecord record)
        {
            HttpRequestMessage request = new HttpRequestMessage();
            request.SetConfiguration(new HttpConfiguration());
            var response = request.CreateResponse<VotingRecord>(HttpStatusCode.OK, record);
            if(response.StatusCode.ToString().Equals("OK"))
            {
                Debug.WriteLine("okokokokok ::: "+response.StatusCode);
                vr_repo.Add(record);
                return true;
            }
            else
            {
                Debug.WriteLine(response.StatusCode);
                return false;
            }
        } 
        [Microsoft.AspNetCore.Mvc.HttpDelete]
        // DELETE: api/Voter/5
        public void DeleteAllVoter()
        {
            vr_repo.RemoveAll();
        }
        [Microsoft.AspNetCore.Mvc.HttpDelete("{id}")]
        // PUT: api/Voter/5
        [Microsoft.AspNetCore.Mvc.HttpPut]
        public bool PutVoter([System.Web.Http.FromBody] VotingRecord record)
        {
            HttpRequestMessage request = new HttpRequestMessage();
            request.SetConfiguration(new HttpConfiguration());
            var response = request.CreateResponse<VotingRecord>(HttpStatusCode.OK, record);
            if(response.StatusCode.ToString().Equals("OK"))
            {
                Debug.WriteLine(response.StatusCode);
                vr_repo.Update(record);
                return true;
            }
            else
            {
                Debug.WriteLine(response.StatusCode);
                return false;
            }
        }
    }
}
