﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;

namespace MiApp.Products
{
    public class Product : FullAuditedEntity
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
