﻿using System;
using System.Collections.Generic;

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
    }
}