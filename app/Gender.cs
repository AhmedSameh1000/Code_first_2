using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public partial class Gender
{
    [Key]
    public int GenderId { get; set; }

    public string? GenderName { get; set; }

    public List<Customer> Customers = new List<Customer>();
}
