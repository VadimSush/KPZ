namespace Application.Abstractions
{
    public interface IShipment
    {
        void Shipment(string name, int amount, string units);
    }
}
