﻿using System.Collections.Generic;

namespace EntityModelsAndQueries.Models.Domain
{
    public class RoomType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<Room> Rooms { get; set; }
    }
}