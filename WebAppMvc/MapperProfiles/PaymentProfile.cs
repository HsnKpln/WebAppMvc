﻿using AutoMapper;
using Iyzipay.Model;
using WebAppMvc.Models;
using WebAppMvc.Models.Payment;

namespace WebAppMvc.MapperProfiles
{
    public class PaymentProfile: Profile
    {
        public PaymentProfile()
        {
            CreateMap<CardModel, Card>().ReverseMap();
            CreateMap<BasketModel, BasketItem>().ReverseMap();
            CreateMap<AddressModel, Address>().ReverseMap();
            CreateMap<CustomerModel, Buyer>().ReverseMap();
            CreateMap<InstallmentModel, InstallmentDetail>().ReverseMap();
            CreateMap<InstallmentPriceModel, InstallmentPrice>().ReverseMap();

        }
    }
}
