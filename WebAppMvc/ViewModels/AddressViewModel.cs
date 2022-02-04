using System;
using WebAppMvc.Models.Entities;

namespace WebAppMvc.ViewModels
{
    public class AddressViewModel
    {
        public Guid Id { get; set; }
        public string Line { get; set; }
        public string PostCode { get; set; }
        public AddressType AddressType { get; set; }
        public int StateId { get; set; }
        public string UserId { get; set; }
    }
}
