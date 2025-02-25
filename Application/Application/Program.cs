using Application.Abstractions;
using Application.Implemintations;

List<Product> products = [
    new Product("Яблуко", new Dollar(10, 30), "шт.", 200, DateTime.Now), 
    new Product("Банан", new Dollar(20, 20), "кг", 30, DateTime.Now),
    new Product("Стіл", new Euro(100, 0), "шт.", 10, DateTime.Now)];
IWarehouse warehouse = new Warehouse(products);
Reporting reporting = new Reporting(warehouse);

Console.WriteLine("Виведемо початкову інформацію про товари");
reporting.Report();
Console.WriteLine("Змінемо товари і знову виведемо інформацію про товари");
warehouse.AddProduct(new Product("Вишня", new Dollar(15, 55), "кг", 500, DateTime.Now));
warehouse.GetProducts()[0].IncreasePrice(1, 80);
reporting.Report();
