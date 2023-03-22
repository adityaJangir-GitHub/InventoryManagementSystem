using InventoryManagementSystem.UserInterface;

namespace InventoryManagementSystem
{
    public interface IProductSupplier
    {
        void AddInfo(Details details);
        void RemoveInfo();
        void EditInfo();

    }
}
