using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using System.Web.Http;
using System.Diagnostics;
using System.Net;
using System.Net.Http;

namespace WebApi.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("/api/[controller]")]
    public class VoterController : ControllerBase
    {
        public static readonly VoterRepo voter_repo = new VoterRepo();
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public IEnumerable<Voter> GetAllVoters()
        {
            Debug.WriteLine("");
            return voter_repo.GetAll();
        }
        // GET: api/Voter/5
        [Microsoft.AspNetCore.Mvc.HttpGet("{id}")]
        public Voter GetVoter(string id)
        {
            Voter v = voter_repo.Get(id);
            return v;
        }
        // POST: api/Voter
        [Microsoft.AspNetCore.Mvc.HttpPost]
    public bool PostVoter([System.Web.Http.FromBody] Voter vtr)
        {
            HttpRequestMessage request = new HttpRequestMessage();
            request.SetConfiguration(new HttpConfiguration());
            var response = request.CreateResponse<Voter>(HttpStatusCode.OK, vtr);
            if(response.StatusCode.ToString().Equals("OK"))
            {
                Debug.WriteLine(response.StatusCode);
                voter_repo.Add(vtr);
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
            voter_repo.RemoveAll();
        }
        [Microsoft.AspNetCore.Mvc.HttpDelete("{id}")]
        public void DeleteVoter(string id)
        {
            Voter v = voter_repo.Get(id);
            voter_repo.Remove(v);
        }
        // PUT: api/Voter/5
        [Microsoft.AspNetCore.Mvc.HttpPut]
        public bool PutVoter([System.Web.Http.FromBody] Voter vtr)
        {
            HttpRequestMessage request = new HttpRequestMessage();
            request.SetConfiguration(new HttpConfiguration());
            var response = request.CreateResponse<Voter>(HttpStatusCode.Created, vtr);
            if(response.StatusCode.Equals("Ok"))
            {
                Debug.WriteLine(response.StatusCode);
                voter_repo.Update(vtr);
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
