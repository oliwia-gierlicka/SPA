namespace WebApplication1;

public interface IEmailSender
{
    public void Send(string to, string subject, string message);
}