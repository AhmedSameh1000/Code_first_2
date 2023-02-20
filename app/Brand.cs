using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public partial class Brand
{
    [Key]
    public int BrandId { get; set; }

    public string? BrandName { get; set; }
}
