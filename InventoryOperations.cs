namespace InventoryManagementSystem
{
    public class InventoryOperations
    {
        public static void PerformInventoryOperation(int value)
        {
            ChoiceDisplay.DisplayOperationChoices(value);
            int inputValue;
            var performOperation = int.TryParse(Console.ReadLine(), out inputValue);

            InventoryInfoManager manager = new InventoryInfoManager();

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
