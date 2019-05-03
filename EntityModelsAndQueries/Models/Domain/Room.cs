using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityModelsAndQueries.Models.Domain
{
    public class Room
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public decimal DailyRate { get; set; }
        public virtual RoomType Type { get; set; }
        public virtual List<Reservation> Reservations { get; set; }
    }
}