using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public partial class Order
{
    [Key]
    public int OrderNo { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? ShipName { get; set; }

    public string? ShipCity { get; set; }

    public string? ShipArea { get; set; }

    public string? ShipAddress { get; set; }

    [ForeignKey("PaymentMethod")]
    public int PaymentMethodId { get; set; }
    public PaymentMethod? PaymentMethod { get; set; }

    public decimal CartTottalCost { get; set; }

    public string? MemberName { get; set; }
    [ForeignKey("customer")]
    public int customer_id { get; set; }
    public Customer? customer { get; set; } 
}
