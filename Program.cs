// See https://aka.ms/new-console-template for more information
using InventoryManagementSystem;

ChoiceDisplay.DisplayManagingChoices();
Console.Write("Enter your choice: ");

var InputResponce = int.TryParse(Console.ReadLine(), out var InputValue);


if (InputResponce)
{
    OperationSeletor.PerformAction(InputValue);
}






