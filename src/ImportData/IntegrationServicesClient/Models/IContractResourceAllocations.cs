using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportData.IntegrationServicesClient.Models
{
    [EntityName("Договоры размещения ресурсов")]
    public class IContractResourceAllocations: IContracts
    {
        [PropertyOptions("Дата центр", RequiredType.NotRequired, PropertyType.Simple)]
        public string DataCenter { get; set; }


        new public static IEntity FindEntity(Dictionary<string, string> propertiesForSearch, Entity entity, bool isEntityForUpdate, List<Structures.ExceptionsStruct> exceptionList, NLog.Logger logger)
        {
            var name = propertiesForSearch.ContainsKey(Constants.KeyAttributes.CustomFieldName) ?
             propertiesForSearch[Constants.KeyAttributes.CustomFieldName] : propertiesForSearch[Constants.KeyAttributes.Name];

            return BusinessLogic.GetEntityWithFilter<IContractResourceAllocations>(x => x.Name == name, exceptionList, logger);
        }

        new public static IEntityBase CreateOrUpdate(IEntity entity, bool isNewEntity, bool isBatch, List<Structures.ExceptionsStruct> exceptionList, NLog.Logger logger)
        {
            if (isNewEntity)
                return BusinessLogic.CreateEntity((IContractResourceAllocations)entity, exceptionList, logger);
            else
                return BusinessLogic.UpdateEntity((IContractResourceAllocations)entity, exceptionList, logger);
        }
    }
}
