The following programming principles are used in this lab:
* DRY - I moved the repeating code into separate methods([click](./Application/Application/Abstractions/Money.cs#L82-L91))
* Composition Over Inheritance - In several places I used composition([click](./Application/Application/Implemintations/Reporting.cs#L7), [click](./Application/Application/Implemintations/Product.cs#L23))
* Program to Interfaces not Implementations - I used abstractions and created fields with the type of these abstractions([click](./Application/Application/Implemintations/Reporting.cs#L7))
* Fail Fast - I created methods so that when passing incorrect parameters - they throw errors and the program stops working([click](./Application/Application/Abstractions/Money.cs#L55), [click](./Application/Application/Abstractions/Money.cs#L62))
* Single-responsibility Principle - I created all classes so that each had only one responsibility.(Example: [click](./Application/Application/Implemintations/Product.cs))
* Interface Segregation Principle - I split the interface into several smaller interfaces.([first](./Application/Application/Abstractions/IIncome.cs), [second](./Application/Application/Abstractions/IShipment.cs), [third](./Application/Application/Abstractions/IReport.cs))
* Liskov Substitution Principle - Child entities only complement, not change, the behavior of the parent entity([click](./Application/Application/Implemintations/Euro.cs), [click](./Application/Application/Implemintations/Dollar.cs)
