using System;
using System.ComponentModel.DataAnnotations.Schema;
using testgit2019.Areas.Identity.Data;

namespace testgit2019.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int NumberOfGuest { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ReservationAt { get; set; }
        public int Status { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        [ForeignKey("Table")]
        public int TableId { get; set; }
        public Table Table { get; set; }
    }
}
