using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelOnTheGo.Models.Classes
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        public DateTime ReservationDate { get; set; }
        public int UserID { get; set; }
        public int TravelID { get; set; }
    }
}