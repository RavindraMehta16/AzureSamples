using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessDomain
{
    public abstract class AbstractSupplyChain: ISupplyChain
    {
       public abstract void CreateSupply();
    }
}
