using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDateFormat
{
    public static class ConvertJSONToCSharp
    {
        public static void DataJsonToCSharp()
        {

            const string json = "{\"Date\" : \"\\/Date(1465344000000-0300)\\/\"}";

            //\/Date(1465344000000-0300)\/
            
            var result = JsonConvert.DeserializeObject<ConvertedDate>(json,
            new IsoDateTimeConverter { DateTimeFormat = "dd/mm/yyyy:hh:mm:ss" });

            Console.WriteLine(result.Date);
            Console.ReadKey();
        }

        class ConvertedDate
        {
            public DateTime Date { get; set; }
        }

    }


}
