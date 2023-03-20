// See https://aka.ms/new-console-template for more information
using InventoryManagementSystem;

ChoiceDisplay.DisplayManagingChoices();
Console.Write("Enter your choice: ");

var InputValue = 0;
var InputResponce = int.TryParse(Console.ReadLine(), out InputValue);


if (InputResponce)
{
    OperationSeletor.PerformAction(InputValue);
}






