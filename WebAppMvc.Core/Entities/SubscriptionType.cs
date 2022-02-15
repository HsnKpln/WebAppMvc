﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WebAppMvc.Core.Entities
{
    public class SubscriptionType : BaseEntity<Guid>
    {
        [Required,StringLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Month { get; set; }
        public decimal Price { get; set; }
    }
}
