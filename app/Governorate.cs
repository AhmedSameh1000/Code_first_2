using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public partial class Governorate
{
    [Key]
    public int GovId { get; set; }

    public string? GovName { get; set; }

    public  List<Customer> Customers = new List<Customer>();
}
