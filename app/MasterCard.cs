using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public partial class MasterCard
{
    [Key]
    public string MasterCardId { get; set; } = null!;

    public DateTime? MasterExpDate { get; set; }

    public decimal? MasterBalance { get; set; }

    public  List<Customer> Customers = new List<Customer>();
}
