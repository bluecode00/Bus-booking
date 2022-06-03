using Bus_Ticket_Booking.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Ticket_Booking.Data.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new BookingContext();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Cities.Count() == 0)
                {
                    context.Cities.AddRange(Cities);
                }
                if (context.Buses.Count() == 0)
                {
                    context.Buses.AddRange(Buses);
                }
                if (context.Routes.Count() == 0)
                {
                    context.Routes.AddRange(Routes);
                }
                if (context.Tickets.Count() == 0)
                {
                    context.Tickets.AddRange(Tickets);
                }
                context.SaveChanges();
            }
        }

        private static City[] Cities =
        {
            new City() { CityName = "İstanbul" },
            new City() { CityName = "Kocaeli" },
            new City() { CityName = "Sakarya" },
            new City() { CityName = "Düzce" },
            new City() { CityName = "Zonguldak" },
            new City() { CityName = "Samsun" },
            new City() { CityName = "Ordu" },
            new City() { CityName = "Trabzon" },
            new City() { CityName = "Giresun" },
            new City() { CityName = "Artvin" }
        };

        private static Bus[] Buses =
        {
            new Bus() { BusSeatCapacity = 30 }
        };

        private static Route[] Routes =
        {
            new Route() {RouteId=1, StartLocation = "İstanbul", FirstStation = "Sakarya", SecondStation = "Düzce", ThirdStation = "Trabzon", EndLocation = "Artvin", Date = "2022-05-12", Time = "19.00", Price = 110 },
            new Route() {RouteId=2, StartLocation = "Giresun", FirstStation = "Trabzon", SecondStation = "Ordu", ThirdStation = "Zonguldak", EndLocation = "Kocaeli", Date = "2022-05-12", Time = "19.00", Price = 180 }
        };

        private static Ticket[] Tickets =
        {
            new Ticket() { CostumerName = "Abdullah", CosturmerSurname = "Seisoglu", PhoneNumber = "+905554442211", TravelFrom = "İstanbul", TravelTo = "Düzce", SeatNumber = 11, Price=100, PeronNumber= 5554752, RouteId = 1}
        };
    }
}
