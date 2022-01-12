using System.Threading.Tasks;
using WebAppMvc.Models;

namespace WebAppMvc.Services
{
    public interface IEmailSender
    {
        Task SendAsync(EmailMessage message);
    }
}
