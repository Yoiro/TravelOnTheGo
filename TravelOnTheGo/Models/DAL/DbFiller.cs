using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelOnTheGo.Models.Classes;

namespace TravelOnTheGo.Models.DAL
{
    public class DbFiller : System.Data.Entity.DropCreateDatabaseIfModelChanges<TravelOnTheGo>
    {

        protected override void Seed(TravelOnTheGo context)
        {
            using (TravelOnTheGo ctx = new TravelOnTheGo())
            {
                User usr = new User() { Username = "simon.degreve", Password = "test" };
                User usr1 = new User() { Username = "jolan.beer", Password = "test" };
                User usr2 = new User() { Username = "J0D3T3sM0rts", Password = "test" };
                User usr3 = new User() { Username = "P.Mercier", Password = "test" };
                User usr4 = new User() { Username = "OpalermO", Password = "test" };

                Travel t1 = new Travel() { Driver = usr, Origin = "Rue Anatole France 75 7100 La Louvière", Destination = "Route de Binche 154 7000 Mons", Departure = DateTime.Parse("22/09/2017 07:30:00").ToLocalTime(), PlacesLeft = 2 };
                Travel t2 = new Travel() { Driver = usr, Origin = "Route de Binche 154 7000 Mons", Destination = "rue Anatole France 75 7100 La Louvière", Departure = DateTime.Parse("31/09/2017 13:00:00").ToLocalTime(), PlacesLeft = 3 };
                Travel t3 = new Travel() { Driver = usr1, Origin = "Rue Evrard 15 7100 La Louvière", Destination = "Rue des Célestinnes 16 4000 Liège", Departure = DateTime.Parse("25/09/2017 15:00:00").ToLocalTime(), PlacesLeft = 4 };
                Travel t4 = new Travel() { Driver = usr2, Origin = "Rue des Célestinnes 16 4000 Liège", Destination = "Rue Evrard 15 7100 La Louvière", Departure = DateTime.Parse("26/09/2017 02:00:00").ToLocalTime(), PlacesLeft = 1 };
                Travel t5 = new Travel() { Driver = usr3, Origin = "Place de la Concorde 4B 7100 La Louvière", Destination = "Place de la Station 10 5000 Namur", Departure = DateTime.Parse("25/10/2017 10:00:00").ToLocalTime(), PlacesLeft = 0 };
                Travel t6 = new Travel() { Driver = usr4, Origin = "Rue de l'Abattoir 7110 Houdeng-Goegnies ", Destination = "Rue du Géant 4 1400 Nivelles", Departure = DateTime.Parse("01/12/2017 11:30:00").ToLocalTime(), PlacesLeft = 2 };

                Reservation r1 = new Reservation() { UserID = usr.Id, TravelID = t1.Id, ReservationDate = DateTime.Parse("24/08/2017").ToLocalTime() };
                Reservation r2 = new Reservation() { UserID = usr.Id, TravelID = t2.Id, ReservationDate = DateTime.Parse("24/08/2017").ToLocalTime() };
                Reservation r3 = new Reservation() { UserID = usr.Id, TravelID = t3.Id, ReservationDate = DateTime.Parse("24/08/2017").ToLocalTime() };
                Reservation r4 = new Reservation() { UserID = usr.Id, TravelID = t4.Id, ReservationDate = DateTime.Parse("24/08/2017").ToLocalTime() };
                Reservation r5 = new Reservation() { UserID = usr.Id, TravelID = t5.Id, ReservationDate = DateTime.Parse("24/08/2017").ToLocalTime() };
                Reservation r6 = new Reservation() { UserID = usr.Id, TravelID = t6.Id, ReservationDate = DateTime.Parse("24/08/2017").ToLocalTime() };

                User[] users = { usr, usr1, usr2, usr3, usr4 };
                Travel[] travels = { t1, t2, t3, t4, t5, t6 };
                Reservation[] reservations = { r1, r2, r3, r4, r5, r6 };

                ctx.Users.AddRange(users);
                ctx.Travels.AddRange(travels);
                ctx.Reservations.AddRange(reservations);

                ctx.SaveChanges();
            }

        }
    }
}