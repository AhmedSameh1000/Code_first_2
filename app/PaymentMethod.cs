using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public partial class PaymentMethod
{
    [Key]
    public int MethodId { get; set; }

    public string? MethodName { get; set; }

    public  List<CardVisa> CardVisas  = new List<CardVisa>();

}
