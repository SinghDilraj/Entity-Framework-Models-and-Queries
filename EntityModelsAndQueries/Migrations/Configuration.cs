namespace EntityModelsAndQueries.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityModelsAndQueries.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EntityModelsAndQueries.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            if (!context.Types.Any())
            {
                context.Types.AddOrUpdate(type => type.Name,
                    new Models.Domain.RoomType() { Name = "Single", Description = "A room assigned to one person. May have one or more beds." },
                    new Models.Domain.RoomType() { Name = "Double", Description = "A room assigned to two people. May have one or more beds." },
                    new Models.Domain.RoomType() { Name = "Queen", Description = "A room with a queen-sized bed. May be occupied by one or more people." },
                    new Models.Domain.RoomType() { Name = "King", Description = "A room with a king-sized bed. May be occupied by one or more people." },
                    new Models.Domain.RoomType() { Name = "Master Suite", Description = "A parlour or living room connected to one or more bedrooms." }
                    );
            }

            if (!context.Rooms.Any())
            {
                context.Rooms.AddOrUpdate(room => room.Number,
                    new Models.Domain.Room() { Number = "1A", DailyRate = 50m, Type = context.Types.FirstOrDefault(type => type.Name == "Single") },
                    new Models.Domain.Room() { Number = "1B", DailyRate = 50m, Type = context.Types.FirstOrDefault(type => type.Name == "Single") },
                    new Models.Domain.Room() { Number = "2A", DailyRate = 90m, Type = context.Types.FirstOrDefault(type => type.Name == "Double") },
                    new Models.Domain.Room() { Number = "2B", DailyRate = 90m, Type = context.Types.FirstOrDefault(type => type.Name == "Double") },
                    new Models.Domain.Room() { Number = "3A", DailyRate = 130m, Type = context.Types.FirstOrDefault(type => type.Name == "Queen") },
                    new Models.Domain.Room() { Number = "3B", DailyRate = 130m, Type = context.Types.FirstOrDefault(type => type.Name == "Queen") },
                    new Models.Domain.Room() { Number = "3C", DailyRate = 130m, Type = context.Types.FirstOrDefault(type => type.Name == "Queen") },
                    new Models.Domain.Room() { Number = "4A", DailyRate = 200m, Type = context.Types.FirstOrDefault(type => type.Name == "King") },
                    new Models.Domain.Room() { Number = "4B", DailyRate = 200m, Type = context.Types.FirstOrDefault(type => type.Name == "King") },
                    new Models.Domain.Room() { Number = "5A", DailyRate = 250m, Type = context.Types.FirstOrDefault(type => type.Name == "Master Suite") }
                    );
            }

            if (!context.Customers.Any())
            {
                context.Customers.AddOrUpdate(customer => customer.FirstName,
                    new Models.Domain.Customer() { FirstName = "Alan", LastName = "Foster", Email = "alanfoster@assignment2.com", PhoneNumber = "(204) – 111-1111" },
                    new Models.Domain.Customer() { FirstName = "Harley", LastName = "Moore", Email = "harleymoore@assignment2.com", PhoneNumber = "(204) – 222-2222" },
                    new Models.Domain.Customer() { FirstName = "Kara", LastName = "Rogers", Email = "kararogers@assignment2.com", PhoneNumber = "(204) – 333-3333" },
                    new Models.Domain.Customer() { FirstName = "Lara", LastName = "Mason", Email = "laramason@assignment2.com", PhoneNumber = "(204) – 444-4444" },
                    new Models.Domain.Customer() { FirstName = "Amber", LastName = "Hunt", Email = "amberhunt@assignment2.com", PhoneNumber = "(204) – 555-5555" }
                    );
            }

            if (!context.Reservations.Any())
            {
                context.Reservations.AddOrUpdate(res => res.Code,
                    new Models.Domain.Reservation()
                    {
                        Code = "PMJYW5WH2",
                        CheckInDate = new System.DateTime(2019, 04, 08),
                        CheckOutDate = new System.DateTime(2019,
                        04, 15),
                        TotalAmount = 250m,
                        Room = context.Rooms.FirstOrDefault(room => room.Number == "1A"),
                        Customer = context.Customers.FirstOrDefault(cust => cust.FirstName == "Alan" && cust.LastName == "Foster")
                    }, new Models.Domain.Reservation()
                    {
                        Code = "ICKU0JMMN",
                        CheckInDate = new System.DateTime(2019, 04, 22),
                        CheckOutDate = new System.DateTime(2019,
                        04, 24),
                        TotalAmount = 150m,
                        Room = context.Rooms.FirstOrDefault(room => room.Number == "1A"),
                        Customer = context.Customers.FirstOrDefault(cust => cust.FirstName == "Alan" && cust.LastName == "Foster")
                    }, new Models.Domain.Reservation()
                    {
                        Code = "Y1SNW2YQ3",
                        CheckInDate = new System.DateTime(2019, 04, 15),
                        CheckOutDate = new System.DateTime(2019,
                        04, 19),
                        TotalAmount = 250m,
                        Room = context.Rooms.FirstOrDefault(room => room.Number == "1B"),
                        Customer = context.Customers.FirstOrDefault(cust => cust.FirstName == "Harley" && cust.LastName == "Moore")
                    }, new Models.Domain.Reservation()
                    {
                        Code = "EW4X1NWEU",
                        CheckInDate = new System.DateTime(2019, 05, 01),
                        CheckOutDate = new System.DateTime(2019,
                        05, 10),
                        TotalAmount = 1300m,
                        Room = context.Rooms.FirstOrDefault(room => room.Number == "3A"),
                        Customer = context.Customers.FirstOrDefault(cust => cust.FirstName == "Kara" && cust.LastName == "Rogers")
                    }, new Models.Domain.Reservation()
                    {
                        Code = "7XLLBVZYB",
                        CheckInDate = new System.DateTime(2019, 05, 06),
                        CheckOutDate = new System.DateTime(2019,
                        05, 10),
                        TotalAmount = 1000m,
                        Room = context.Rooms.FirstOrDefault(room => room.Number == "4B"),
                        Customer = context.Customers.FirstOrDefault(cust => cust.FirstName == "Amber" && cust.LastName == "Hunter")
                    }, new Models.Domain.Reservation()
                    {
                        Code = "WD4EFAINV",
                        CheckInDate = new System.DateTime(2019, 05, 13),
                        CheckOutDate = new System.DateTime(2019,
                        05, 17),
                        TotalAmount = 1000m,
                        Room = context.Rooms.FirstOrDefault(room => room.Number == "4B"),
                        Customer = context.Customers.FirstOrDefault(cust => cust.FirstName == "Lara" && cust.LastName == "Mason")
                    }, new Models.Domain.Reservation()
                    {
                        Code = "Y4Y97Q4WG",
                        CheckInDate = new System.DateTime(2019, 05, 13),
                        CheckOutDate = new System.DateTime(2019,
                        05, 15),
                        TotalAmount = 150m,
                        Room = context.Rooms.FirstOrDefault(room => room.Number == "1A"),
                        Customer = context.Customers.FirstOrDefault(cust => cust.FirstName == "Alan" && cust.LastName == "Foster")
                    }
                    );
            }
        }
    }
}
