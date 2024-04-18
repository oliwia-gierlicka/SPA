namespace WebApplication1;

public class NotificationService
{
    private IEmailSender sender;

    public NotificationService(IEmailSender sender)
    {
        this.sender = sender;
    }

    public void SendNotification(string to, string message)
    {
        sender.Send(to, "mau", message);
    }
}