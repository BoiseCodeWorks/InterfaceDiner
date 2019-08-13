using InterfaceDiner.Interfaces;

namespace InterfaceDiner.Models
{
    class Manager : SalaryEmployee, IEnterOrder, ICompleteOrder
    {
        public float MaxDiscount { get; set; }

        public void Hire(Employee newEmployee)
        {
            //code Ommitted
        }
        public void Fire(Employee termEmployee)
        {
            //code Ommitted
        }

        public void EnterOrder()
        {
            //Code Ommited;
        }

        public void CompleteOrder(int orderId)
        {
            //Code Ommitted
        }

        public Manager(string name, float rate) : base(name, rate)
        {
        }
    }
}