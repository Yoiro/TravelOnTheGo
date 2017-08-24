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
    public class UsersController : BaseController
    {
        public HttpResponseMessage Get()
        {
            return ToJson(DB.User.AsEnumerable());
        }

        public HttpResponseMessage Get(int id)
        {
            return ToJson(DB.User.Find(id));
        }

        public HttpResponseMessage Post([FromBody]User value)
        {
            DB.User.Add(value);
            return ToJson(DB.SaveChanges());
        }

        public HttpResponseMessage Put(int id, [FromBody]User value)
        {
            DB.Entry(value).State = EntityState.Modified;
            return ToJson(DB.SaveChanges());
        }
        public HttpResponseMessage Delete(int id)
        {
            DB.User.Remove(DB.User.FirstOrDefault(x => x.Id == id));
            return ToJson(DB.SaveChanges());
        }
    }
}
