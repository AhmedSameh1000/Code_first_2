using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public partial class Customer
{
    [Key]
    public int CustId { get; set; }

    public string? CustName { get; set; }

    public string? CustMail { get; set; }

    public string? CustUserName { get; set; }

    public string? CustPassword { get; set; }
    [ForeignKey("CustGender")]
    public int? CustGenderId { get; set; }
    [ForeignKey("CustGov")]
    public int? CustGovId { get; set; }

    public string? CustCity { get; set; }

    public string? CustFullAddress { get; set; }

    public string? CustTel1 { get; set; }

    public string? CustTel2 { get; set; }

    [ForeignKey("CustMasterCard")]
    public string? CustMasterCardId { get; set; }

    public DateTime? CustRegDate { get; set; }

    public string? CustIsBlocked { get; set; }


    public  Gender? CustGender { get; set; }

    public  Governorate? CustGov { get; set; }

    public  MasterCard? CustMasterCard { get; set; }

    public List<Wishlist> Wishlists = new List<Wishlist>();

    public  List<CardVisa> CardVisa = new List<CardVisa>();
}
