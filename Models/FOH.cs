using InterfaceDiner.Interfaces;

namespace InterfaceDiner.Models
{
    //NOTE: When using both Inheritance and Interfaces, the inherited class goes first
    //NOTE: Interfaces do not provide the members, they only enforce their existance
    class FOH : HourlyEmployee, IEnterOrder
    {
        public float MaxDiscount { get; set; }

        public void EnterOrder()
        {
            //code ommited
        }












        public FOH(string name, float rate) : base(name, rate)
        {
        }
    }
}