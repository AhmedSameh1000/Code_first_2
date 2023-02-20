using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;



public partial class ECommerceContext : DbContext
{

    public DbSet<Brand> Brands { get; set; }

    public DbSet<CardVisa> CardVisas { get; set; }

    public DbSet<Category> Categories { get; set; }

    public DbSet<CompanyInfo> CompanyInfos { get; set; }

    public DbSet<Customer> Customers { get; set; }

    public DbSet<Gender> Genders { get; set; }

    public DbSet<Governorate> Governorates { get; set; }

    public DbSet<MasterCard> MasterCards { get; set; }

    public DbSet<Order> Orders { get; set; }

    public DbSet<OrdersDetail> OrdersDetails { get; set; }

    public DbSet<PaymentMethod> PaymentMethods { get; set; }

    public DbSet<Product> Products { get; set; }

    public DbSet<RecomendedForYou> RecomendedForYous { get; set; }

    public DbSet<Review> Reviews { get; set; }

    public DbSet<Role> Roles { get; set; }

    public DbSet<ShowRecommendedItem> ShowRecommendedItems { get; set; }

    public DbSet<User> Users { get; set; }

    public DbSet<Wishlist> Wishlists { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=site1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }
}
