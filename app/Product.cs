using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public partial class Product
{
    [Key]
    public int ProId { get; set; }

    public string? ProName { get; set; }

    public int? ProUnitPrice { get; set; }

    public double? ProDiscountPercent { get; set; }

    public string? ProDiscription { get; set; }

    public bool? ProIsValid { get; set; }

    public int? ProQuantityPerUnit { get; set; }

    public bool? ProIsFeatured { get; set; }

    public string? ProPicture { get; set; }

    public DateTime? ProInsertingDate { get; set;}

    [ForeignKey("ProCat")]
    public int? ProCatId { get; set; }

    [ForeignKey("brand")]
    public int? BrandId { get; set; }

    public Brand? brand { get; set; }
    public Category? ProCat { get; set; }

    public List<Wishlist> Wishlists = new List<Wishlist>();
}

