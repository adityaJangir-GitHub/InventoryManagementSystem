namespace InventoryManagementSystem
{
    public class SupplierOperations
    {
        public static void PerformSupplierOperation(int value)
        {
            ChoiceDisplay.DisplayOperationChoices(value);
            int inputValue;
            var performOperation = int.TryParse(Console.ReadLine(), out inputValue);

            SupplierInfoManager manager = new SupplierInfoManager();

            switch ((OperationList)inputValue)
            {
                case OperationList.add:
                    {
                        manager.AddInfo();
                        break;
                    }
                case OperationList.remove:
                    {
                        manager.RemoveInfo();
                        break;
                    }
                case OperationList.Edit:
                    {
                        manager.EditInfo();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
    }
}
