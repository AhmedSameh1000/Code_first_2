using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public partial class OrdersDetail
{

    [Key]
    public int Id { get; set; }
    public int? CategoryNumber { get; set; }

    [ForeignKey("Product")]
    public int? ProductId { get; set; }

    public Product? Product { get; set; }
    [ForeignKey("order")]
    public int? OrderNo { get; set; }


    public Order? order { get; set; }

    public int? Quantity { get; set; }

    public double? SalePrice { get; set; }

    public double? Discount { get; set; }
}
