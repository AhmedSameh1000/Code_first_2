using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public partial class CardVisa
{
    [Key]
    public string CardNumber { get; set; } = null!;
    [ForeignKey("CardTypeNavigation")]
    public int? CardType { get; set; }

    public string? Month { get; set; }

    public string? Year { get; set; }

    public string? NameInCard { get; set; }

    public string? UserName { get; set; }

    public string? MasterBalance { get; set; }

    [ForeignKey("customer")]
    public int Customer_id { get; set; }

    public Customer? customer { get; set; }

    public PaymentMethod? CardTypeNavigation { get; set; }
}
