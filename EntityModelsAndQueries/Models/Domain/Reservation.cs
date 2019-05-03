﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityModelsAndQueries.Models.Domain
{
    public class Reservation
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public virtual Room Room { get; set; }
        public virtual Customer Customer { get; set; }
        public Decimal TotalAmount { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public virtual List<Room> Rooms { get; set; }
        public virtual List<Customer> Customers { get; set; }

    }
}