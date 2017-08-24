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
    public class ReservationsController : BaseController
    {
        public HttpResponseMessage Get()
        {
            return ToJson(DB.Reservation.AsEnumerable());
        }

        public HttpResponseMessage Get(int id)
        {
            return ToJson(DB.Reservation.Find(id));
        }

        public HttpResponseMessage Post([FromBody]Reservation value)
        {
            DB.Reservation.Add(value);
            return ToJson(DB.SaveChanges());
        }

        public HttpResponseMessage Put(int id, [FromBody]Reservation value)
        {
            DB.Entry(value).State = EntityState.Modified;
            return ToJson(DB.SaveChanges());
        }
        public HttpResponseMessage Delete(int id)
        {
            DB.Reservation.Remove(DB.Reservation.FirstOrDefault(x => x.Id == id));
            return ToJson(DB.SaveChanges());
        }
    }
}
