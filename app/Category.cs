using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public partial class Category
{
    [Key]
    public int CatId { get; set; }

    public string? CatName { get; set; }

    public string? CatDescription { get; set; }

    public string? CatPicture { get; set; }

    public  List<Product> Products  = new List<Product>();
    public List<Brand> Brands = new List<Brand>();
}
