namespace Facade
{
    public interface IEmailService
    {
        void SendEmail(string email);
        
    }
    public class EmailService : IEmailService
    {
        public void SendEmail(string email)
        {
            Console.WriteLine($"Sent email to {email}.");
        }
    }
}
