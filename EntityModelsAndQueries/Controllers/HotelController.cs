using EntityModelsAndQueries.Models;
using System.Linq;
using System.Web.Mvc;

namespace EntityModelsAndQueries.Controllers
{
    public class HotelController : BaseController
    {
        // GET: Room
        public ActionResult Rooms()
        {
            System.Collections.Generic.List<RoomViewModel> rooms = DbContext.Reservations
                .Where(p => p.CheckOutDate < new System.DateTime(2019, 05, 09) && p.CheckInDate > new System.DateTime(2019, 05, 14))
                .Select(p => new RoomViewModel()
                {
                    RoomNumber = p.Room.Number,
                    RoomType = p.Room.Type.Name,
                    Price = p.Room.DailyRate
                }).ToList();
            return View();
        }
        public ActionResult Reservations()
        {
            System.Collections.Generic.List<ReservationViewModel> reservations = DbContext.Reservations.Select(p => new ReservationViewModel
            {
                customerFirstName = p.Customer.FirstName,
                customerLastName = p.Customer.LastName,
                customerPhoneNumber = p.Customer.PhoneNumber,
                ReservationCode = p.Code,
                RoomNumber = p.Room.Number,
                RoomType = p.Room.Type.Name,
                TotalPrice = p.TotalAmount,
                RentPeriod = (p.CheckOutDate - p.CheckInDate).ToString()
            }).ToList();

            return View();
        }
        public ActionResult Money()
        {
            System.Collections.Generic.List<MoneyViewModel> money = DbContext.Reservations.Select(p => new MoneyViewModel()
            {
                RoomNumber = p.Room.Number,
                RoomType = p.Room.Type.Name,
                Money = p.Room.DailyRate * (decimal)(p.CheckOutDate - p.CheckInDate).TotalDays
            }).ToList();
            return View();
        }
    }
}