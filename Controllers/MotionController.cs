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
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    public class MotionController : ApiController
    {
        public static readonly MotionRepo motion_repo = new MotionRepo();
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public IEnumerable<Motion> GetAllMotions()
        {
            return motion_repo.GetAll();
        }
        // GET: api/Motion/5
        [Microsoft.AspNetCore.Mvc.HttpGet("{id}")]
        public Motion GetMotion(string id)
        {
            Motion m = motion_repo.Get(id);
            return m;
        }
        // POST: api/Motion
        [Microsoft.AspNetCore.Mvc.HttpPost]
        public bool PostMotion([System.Web.Http.FromBody] Motion mtn)
        {
            HttpRequestMessage request = new HttpRequestMessage();
            request.SetConfiguration(new HttpConfiguration());
            var response = request.CreateResponse<Motion>(HttpStatusCode.OK, mtn);
            if(response.StatusCode.ToString().Equals("OK"))
            {
                Debug.WriteLine(response.StatusCode);
                motion_repo.Add(mtn);
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
        public void DeleteAllMotion()
        {
            motion_repo.RemoveAll();
        }
        [Microsoft.AspNetCore.Mvc.HttpDelete("{id}")]
        public void DeleteMotion(string id)
        {
            Motion m = motion_repo.Get(id);
            motion_repo.Remove(m);
        }
        // PUT: api/Voter/5
        [Microsoft.AspNetCore.Mvc.HttpPut]
        public bool PutMotion([System.Web.Http.FromBody] Motion mtn)
        {
            HttpRequestMessage request = new HttpRequestMessage();
            request.SetConfiguration(new HttpConfiguration());
            var response = request.CreateResponse<Motion>(HttpStatusCode.OK, mtn);
            if(response.StatusCode.ToString().Equals("OK"))
            {
                Debug.WriteLine("if : "+response.StatusCode);
                motion_repo.Update(mtn);
                return true;
            }
            else
            {
                Debug.WriteLine("Else:"+response.StatusCode);
                return false;
            }
        }
    }
}