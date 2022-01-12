﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAppMvc.Models.Identity;
using static System.Net.Mime.MediaTypeNames;

namespace WebAppMvc.Models.Entities
{
    public class Subscription :BaseEntity
    {

        public Guid SubscriptionTypeId { get; set; }
        public decimal Amount { get; set; }
        public decimal PaidAmount { get; set; }
        public DateTime EndDate { get; set; }
        [StringLength(450)]
        public string UserId { get; set; }
        [NotMapped]
        public bool IsActive => EndDate > DateTime.Now;
        [ForeignKey(nameof(SubscriptionTypeId))]
        public virtual SubscriptionType SubscriptionType { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser User { get; set; }

    }
}
