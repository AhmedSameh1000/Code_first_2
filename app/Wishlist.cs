using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public partial class Wishlist
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int WishlistId { get; set; }

    [ForeignKey("Customer")]
    public int? CustomerId { get; set; }

    [ForeignKey("product")]
    public int? ProductId { get; set; }

    public Customer? Customer { get; set; }
    public Product? product { get; set; }
}
