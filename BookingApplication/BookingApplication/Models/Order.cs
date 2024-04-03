using System.ComponentModel.DataAnnotations;

namespace BookingApplication.Models
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public BookingApplicationUser? User { get; set; }
        public ICollection<ReservationInOrder>? ReservationInOrders { get; set; }

}
}
