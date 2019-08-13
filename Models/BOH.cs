using InterfaceDiner.Interfaces;

namespace InterfaceDiner.Models
{
    class BOH : HourlyEmployee, ICompleteOrder
    {
        public void CompleteOrder(int orderId)
        {
            System.Console.WriteLine("COOKEDY COOK COOK COOK");
        }

        public BOH(string name, float rate) : base(name, rate)
        {
        }
    }
}