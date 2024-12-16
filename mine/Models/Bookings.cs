namespace mine.Models
{
    public class Bookings
    {
        public int booking_Id { get; set; }
        public int user_id { get; set; }
        public int property_id {  get; set; }
        public DateTime schedule_date {  get; set; }
        public string booking_status { get; set; }
    }
}
