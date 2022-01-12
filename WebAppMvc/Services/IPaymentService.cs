using System.Collections.Generic;
using WebAppMvc.Models.Payment;

namespace WebAppMvc.Services
{
    public interface IPaymentService
    {
        public List<InstallmentModel> CheckInstallments(string binNumber, decimal price);
        public PaymentResponseModel Pay(PaymentModel model);
    }
}
