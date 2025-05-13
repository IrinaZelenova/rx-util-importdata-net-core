using System;
using System.Collections.Generic;
using System.Linq;
using NLog;

namespace ImportData
{
    internal class ContractResource:Contract
    {
        //Количество колонок используемого XLSX
        public override int PropertiesCount { get { return 22; } }

        

    }
}
