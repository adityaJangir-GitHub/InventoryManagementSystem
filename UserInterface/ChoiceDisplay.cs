namespace InventoryManagementSystem
{
    public class ChoiceDisplay
    {
        public static void DisplayManagingChoices()
        {
            Console.WriteLine("Choose from the following:");
            Console.WriteLine("Manage inventory by pressing 1");
            Console.WriteLine("Manage supplier by pressing 2");
            Console.WriteLine("Place order by pressing 3");
            Console.WriteLine("Show inventory report by pressing 4");
        }
        public static void DisplayOperationChoices(int value) 
        {
            Console.WriteLine("For adding item to {0} press 1",(ManagingOption)value);
            Console.WriteLine("For removing item from {0} press 2", (ManagingOption)value);
            Console.WriteLine("For editing into {0} press 3", (ManagingOption)value);
        }
    }
}
