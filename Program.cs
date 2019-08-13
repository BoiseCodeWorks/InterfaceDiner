using System;
using System.Collections.Generic;
using InterfaceDiner.Interfaces;
using InterfaceDiner.Models;

namespace InterfaceDiner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ICompleteOrder> Cooks = new List<ICompleteOrder>(){
                new BOH("D$", 12.25f),
                new ContractCook("John Wisk")
            };
            foreach (var cook in Cooks)
            {

            }
        }
    }
}
