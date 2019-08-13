using InterfaceDiner.Interfaces;

namespace InterfaceDiner.Models
{
    class ContractCook : ICompleteOrder
    {
        public string Name { get; set; }
        public void CompleteOrder(int orderId)
        {
            System.Console.WriteLine("BANG BANG YOUR DINNER IS SERVED");
        }
        public ContractCook(string n)
        {
            Name = n;
        }
    }
}