using System.Threading.Tasks;
using WebAppMvc.Core.ComplexTypes;

namespace WebAppMvc.Business.Services.Email
{
    public interface IEmailSender
    {
        Task SendAsync(EmailMessage message);
    }
}
