﻿using System.ComponentModel.DataAnnotations;


namespace MVCAdminApplication.Models
{
    public class TicketInOrder : BaseEntity
    {
        public Guid TicketId { get; set; }
        public Ticket? Ticket { get; set; }
        public Ticket? OrderedProduct { get; set; }

        public Guid OrderId { get; set; }
        public Order? Order { get; set; }
        public int Quantity { get; set; }
    }
}
