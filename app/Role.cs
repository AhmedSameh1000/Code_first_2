using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public partial class Role
{
    [Key]
    public int RoleId { get; set; }

    public string? RoleName { get; set; }

    public string? RoleDescription { get; set; }

    public  ICollection<User> Users { get; } = new List<User>();
}
