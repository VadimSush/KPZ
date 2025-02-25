using Application.Abstractions;

namespace Application.Implemintations
{
    public class Reporting : IIncome, IShipment, IReport
    {
        private readonly IWarehouse _warehouse;
        public Reporting(IWarehouse warehouse)
        {
            _warehouse = warehouse;
        }

        public void Report()
        {
            Console.WriteLine("Звіт по інвентаризації:");
            
            foreach (Product product in _warehouse.GetProducts())
            {
                Console.WriteLine($"{product.Name}: ціна: {product.Price.Print()}, кількість: {product.Amount} {product.Units}, дата останнього завозу: {product.LastDelivery.ToShortDateString()}");
            }

            Console.WriteLine("------------------------------");
        }

        public void Shipment(string name, int amount, string units)
        {
            Console.WriteLine("Реєстрація відвантаження товара");
            Console.WriteLine($"Відвантажено {name} у кількості {amount} {units}. Дата {DateTime.Now.ToShortDateString()}");
        }

        public void Income(string name, int amount, string units)
        {
            Console.WriteLine("Реєстрація надходження товара");
            Console.WriteLine($"Надійшли {name} у кількості {amount} {units}. Дата {DateTime.Now.ToShortDateString()}");
        }
    }
}
