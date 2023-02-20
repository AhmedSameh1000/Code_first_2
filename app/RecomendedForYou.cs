using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public partial class RecomendedForYou
{
    [Key]
    public int CatId { get; set; }

    public string? CatName { get; set; }

    public int? ProCount { get; set; }

    public string? CatPicture { get; set; }

    public Customer? Customer { get; set; }
    [ForeignKey("Customer")]
    public int? CustomerId { get; set; }
}
