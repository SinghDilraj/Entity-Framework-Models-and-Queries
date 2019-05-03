using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityModelsAndQueries.Models
{
    public class ReservationViewModel
    {
        public string ReservationCode { get; set; }
        public string RoomNumber { get; set; }
        public string RoomType { get; set; }
        public string RentPeriod { get; set; }
        public decimal TotalPrice { get; set; }
        public string customerFirstName { get; set; }
        public string customerLastName { get; set; }
        public string customerPhoneNumber { get; set; }
    }
}