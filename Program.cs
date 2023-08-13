// See https://aka.ms/new-console-template for more information
using CoffeeMachine.Classes;
using CoffeeMachine.Decorators;

Console.WriteLine("Hello, World!");

var coffee = new HouseBlend();
coffee.setSize(Beverage.Size.TALL);

var description = coffee.getDescription();
Console.WriteLine(description);

var obj = new SoyaDecorator(new HouseBlend());
Console.WriteLine(obj.Cost());
Console.WriteLine(obj.getSize());