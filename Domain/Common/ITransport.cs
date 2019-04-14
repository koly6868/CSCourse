namespace Domain.Common
{
    public interface ITransport
    {
        int ID { get; }
        int MaxWeight { get; }
        int Price { get; }
        int TimeOfDelivery { get; }
        string TypeOfTransport { get; }
    }
}