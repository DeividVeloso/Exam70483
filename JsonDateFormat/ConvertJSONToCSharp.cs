using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace JsonDateFormat
{
    public static class ConvertJSONToCSharp
    {
        public static void DataJsonToCSharp()
        {

            string json = JsonConvert.SerializeObject(new ConvertedDate() { Date = DateTime.Now });

            //const string json = "{\"Date\" : \"\\/Date(765763211111)\\/\"}";

            var result = JsonConvert.DeserializeObject<ConvertedDate>(json, new IsoDateTimeConverter { DateTimeFormat = "dd/mm/yyyy:hh:mm:ss" });

            Console.WriteLine(result.Date);
            Console.ReadKey();
        }


        //private const string _StrDateFormat = "yyyy-MM-dd HH:mm:ss";

        //public static string GetJSON(object value)
        //{

        //    return JsonConvert.SerializeObject(value, new JsonSerializerSettings
        //    {
        //        DateFormatString = _StrDateFormat
        //    });
        //}

        // var newResult = JsonConvert.SerializeObject(new DateTime(2016, 6, 9, 0, 0, 0, DateTimeKind.Utc), new JsonSerializerSettings());//Newtonsoft.Json.JsonConvert.SerializeObject(DateTime.Now);    

        //\/Date(1465344000000-0300)\/

        //var json = JsonConvert.SerializeObject(new ConvertedDate() { Date = new DateTime(2016, 6, 9, 0, 0, 0, DateTimeKind.Utc) }, new JsonSerializerSettings());

        class ConvertedDate
        {
            public DateTime Date { get; set; }
        }


        //public class LogEntry
        //{
        //    public string Details { get; set; }
        //    public DateTime LogDate { get; set; }
        //}

        ////[Test]
        //public static void WriteJsonDates()
        //{
        //    LogEntry entry = new LogEntry
        //    {
        //        LogDate = new DateTime(2009, 2, 15, 0, 0, 0, DateTimeKind.Utc),
        //        Details = "Application started."
        //    };

        //    string defaultJson = JsonConvert.SerializeObject(entry);
        //    // {"Details":"Application started.","LogDate":"\/Date(1234656000000)\/"}

        //    string javascriptJson = JsonConvert.SerializeObject(entry, new JavaScriptDateTimeConverter());
        //    // {"Details":"Application started.","LogDate":new Date(1234656000000)}

        //    string isoJson = JsonConvert.SerializeObject(entry, new IsoDateTimeConverter());
        //    // {"Details":"Application started.","LogDate":"2009-02-15T00:00:00Z"}
        //}

    }


}
