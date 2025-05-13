using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportData.IntegrationServicesClient.Models
{
    [EntityName("Ресурсный договор")]
    internal class IContractResources:IContacts
    {
        [PropertyOptions("Дата центр", RequiredType.NotRequired, PropertyType.Simple)]
        public string DataCenter { get; set; }

    }
}
