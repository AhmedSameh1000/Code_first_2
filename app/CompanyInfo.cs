﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public partial class CompanyInfo
{
    [Key]
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public string? Phone1 { get; set; }

    public string? Phone2 { get; set; }
}
