namespace InventoryManagementSystem
{
    public class OperationSeletor
    {
        public static void PerformAction(int value)
        {
            switch ((ManagingOption)value)
            {
                case ManagingOption.inventory:
                    {
                        InventoryOperations.PerformInventoryOperation(value);
                        
                        break;
                    }
                case ManagingOption.supplier:
                    {
                        SupplierOperations.PerformSupplierOperation(value);
                        break;
                    }

                case ManagingOption.placeOrder:
                    {
                        PlaceOrderOperations.PerformPlaceOrderOperation();
                        break;
                    }
                case ManagingOption.inventoryReport:
                    {
                        InventoryReportOperations.PerformInventoryReportOperation();
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
