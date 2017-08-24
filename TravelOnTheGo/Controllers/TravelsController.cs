using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TravelOnTheGo.Models.ADO;

namespace TravelOnTheGo.Controllers
{
    public class TravelsController : BaseController
    {
        public HttpResponseMessage Get()
        {
            return ToJson(DB.Travel.AsEnumerable());
        }

        public HttpResponseMessage Get(int id)
        {
            return ToJson(DB.Travel.Find(id));
        }

        public HttpResponseMessage Post([FromBody]Travel value)
        {
            DB.Travel.Add(value);
            return ToJson(DB.SaveChanges());
        }

        public HttpResponseMessage Put(int id, [FromBody]Travel value)
        {
            DB.Entry(value).State = EntityState.Modified;
            return ToJson(DB.SaveChanges());
        }
        public HttpResponseMessage Delete(int id)
        {
            DB.Travel.Remove(DB.Travel.FirstOrDefault(x => x.Id == id));
            return ToJson(DB.SaveChanges());
        }
    }
}
