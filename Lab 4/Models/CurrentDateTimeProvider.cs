namespace Lab_4.Models
{
    public class CurrentDateTimeProvider : IDateTimeProvider
    {
        public DateTime DateTimeMethod()
        {
            return DateTime.Now;
        }
    }
}
