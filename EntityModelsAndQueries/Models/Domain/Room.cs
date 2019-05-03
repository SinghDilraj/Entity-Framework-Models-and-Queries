namespace EntityModelsAndQueries.Models.Domain
{
    public class Room
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; }
        public decimal DailyRate { get; set; }
        public int TypeId { get; set; }
        public virtual Type Type { get; set; }
    }
}