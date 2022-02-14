using System.Collections.Generic;
using WebAppMvc.Core.Payment;

namespace WebAppMvc.Business.Services.Payment
{
    public interface IPaymentService
    {
        public InstallmentModel CheckInstallments(string binNumber, decimal price);
        public PaymentResponseModel Pay(PaymentModel model);
    }
}
