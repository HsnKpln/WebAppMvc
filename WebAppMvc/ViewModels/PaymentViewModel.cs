﻿using WebAppMvc.Models;

namespace WebAppMvc.ViewModels
{
    public class PaymentViewModel
    {
        public CardModel CardModel { get; set; }
        public AddressModel AddressModel { get; set; }
        public BasketModel Type { get; set; }
        public decimal Amount { get; set; }
        public decimal PaidAmount { get; set; }
        public int Installment { get; set; }

    }
}