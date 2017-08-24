using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelOnTheGo.Models.Classes
{
    public class Travel
    {
        [Key]
        public int Id { get; set; }
        public User Driver { get; set; }
        public List<Reservation> Passengers { get; set; }
        public int PlacesLeft { get; set; }
        public string Destination { get; set; }
        public string Origin { get; set; }
        public DateTime Departure { get; set; }
    }
}