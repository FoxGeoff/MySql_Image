using Microsoft.Extensions.Logging;

namespace MySql_Image.Services
{
    public class NullMailService : IMailService
    {
        private readonly ILogger<NullMailService> _logger;

        public NullMailService(ILogger<NullMailService> logger)
        {
            _logger = logger;
        }
        public void SendMessage(string to, string subject, string body)
        {
            _logger.LogInformation($"==> To: {to} Subject: {subject} Body: {body}");
            //TODO: Replace with: Mail Chimp, Send Grid, etc.
        }
    }
}
