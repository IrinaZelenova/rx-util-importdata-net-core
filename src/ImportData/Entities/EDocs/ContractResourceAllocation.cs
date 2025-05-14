using ImportData.Entities.EDocs;
using ImportData.IntegrationServicesClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportData
{
    public class ContractResourceAllocation:Contract
    {        
        public override int PropertiesCount { get { return 22; } }
        protected override Type EntityType { get { return typeof(IContractResourceAllocations); } }
        

    }
}
