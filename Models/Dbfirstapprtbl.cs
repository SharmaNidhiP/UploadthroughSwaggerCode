﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApiCRUDSwagger.Models;

public partial class Dbfirstapprtbl
{
    [Key]
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public string? Gender { get; set; }

    public int? Standard { get; set; }
}
