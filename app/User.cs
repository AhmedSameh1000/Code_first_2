using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public partial class User
{
    [Key]
    public int UserId { get; set; }

    public string? UserFullName { get; set; }

    public string? UserUserName { get; set; }

    public string? UserPassword { get; set; }

    public string? UserMail { get; set; }

    public bool? UserIsBlocked { get; set; }

    [ForeignKey("UserRole")]
    public int? UserRoleId { get; set; }

    public Role? UserRole { get; set; }
}
