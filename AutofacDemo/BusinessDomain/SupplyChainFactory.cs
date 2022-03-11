using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessDomain
{
    public class SupplyChainFactory : ISupplyChainFactory 
    {
        private readonly ISupplyChain[] _workflows;
        public SupplyChainFactory(ISupplyChain[] workflows)
        {
            _workflows = workflows;
        }

        public void GetMessage(string message)
        {
            Console.WriteLine("Inside Getmessage of SupplyChainFactory");

            foreach (var item in _workflows)
            {
                Console.WriteLine(item.GetType().Name);
            }
        }
    }
}
