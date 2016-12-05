using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MyShowsParser;

namespace MyShowsWcfService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "MyShowsService" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы MyShowsService.svc или MyShowsService.svc.cs в обозревателе решений и начните отладку.
    public class MyShowsService : IMyShowsService
    {
        public ShowInfo GetShowById(string id)
        {
            return Parse.GetShowById(id);
        }

        public ShowInfo GetShowByWord(string word)
        {
            return Parse.GetShowByWord(word);
        }

        public List<ShowModel> GetShowsByCountry(string country)
        {
            return Parse.GetShowsByCountry(country);
        }
    }
}
