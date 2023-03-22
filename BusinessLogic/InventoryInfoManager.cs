using InventoryManagementSystem.UserInterface;
using System;
using System.Text;

namespace InventoryManagementSystem
{
    public class InventoryInfoManager : IProductSupplier
    {
        public void AddInfo(Details details)
        {
            string fileName = @"C:\Users\AdityaJangir\Desktop\Inventory.csv";
            string separator = ",";
            StringBuilder output = new StringBuilder();
            if (File.ReadAllLines(fileName).Length == 0)
            {
                foreach (string headingItem in Enum.GetValues(typeof(ProductHeader)))
                    output.Append(headingItem.ToString());  
            }
            else
            {
                foreach (var productData in details.GetType().GetProperties())
                    output.Append(productData.ToString());
            }
            output.Append(string.Join(separator, output));
            File.AppendAllText(fileName, output.ToString());
            output.Clear();
        }
        public void RemoveInfo() 
        {

        }
        public void EditInfo() 
        {

        }

    }
}
