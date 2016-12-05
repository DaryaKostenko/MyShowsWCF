using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MyShowsParser;

namespace MyShowsWcfService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IMyShowsService" в коде и файле конфигурации.
    [ServiceContract]
    public interface IMyShowsService
    {
        [OperationContract]
        List<ShowModel> GetShowsByCountry(string country);

        [OperationContract]
        ShowInfo GetShowById(string id);

        [OperationContract]
        ShowInfo GetShowByWord(string word);

    }
}
