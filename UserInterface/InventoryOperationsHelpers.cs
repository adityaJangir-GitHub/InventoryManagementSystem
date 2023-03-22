using InventoryManagementSystem.UserInterface;

public static class InventoryOperationsHelpers
{

    public static Details DisplayInfoField()
    {
        Details details = new Details();
        Console.Write("BatchNo");
        details.batchNum = Console.ReadLine();

        Console.Write("Product Name");
        details.productName = Console.ReadLine();

        Console.Write("Quantity");
        details.quantity = int.Parse(Console.ReadLine());

        Console.Write("Rate");
        details.rate = double.Parse(Console.ReadLine());

        Console.Write("Manufacturing Date");
        details.mfgDate = DateTime.ParseExact(Console.ReadLine(), "M/dd/yyyy", null);

        Console.Write("Expire Date");
        details.expDate = DateTime.ParseExact(Console.ReadLine(), "M/dd/yyyy", null);

        return details;

    }
}