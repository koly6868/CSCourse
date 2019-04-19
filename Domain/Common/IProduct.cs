namespace Domain.Common
{
    public interface IProduct
    {
        int ID { get; }
        string TypeOfProduct { get; }
        int Price { get; }
    }
}