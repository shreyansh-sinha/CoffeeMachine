// See https://aka.ms/new-console-template for more information
using CoffeeMachine.Classes;
using CoffeeMachine.Decorators;

Console.WriteLine("Hello, World!");

var obj = new MochaDecorator(new HouseBlend());
Console.WriteLine(obj.Cost());