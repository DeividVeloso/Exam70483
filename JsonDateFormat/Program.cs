using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDateFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program obj = new Program();
            //obj.WriteJsonDates();

          //  var result = ConvertJSONToCSharp.GetJSON(DateTime.Now);

            ConvertJSONToCSharp.DataJsonToCSharp();
            //ConvertJSONToCSharp.DataJsonToCSharp();
            //ConvertJSONToCSharp obj = new ConvertJSONToCSharp();
            //obj.WriteJsonDates();

           // JavaScriptSerializer js = new JavaScriptSerializer();


                //var msJsonDate = '{ data: "\\/Date(1238025600000)\\/" }'; 
                //var day = Sys.Serialization.JavaScriptSerializer.deserialize(msJsonDate); 
                //alert(day.toString());
        }

         

        public class LogEntry
        {
            public string Details { get; set; }
            public DateTime LogDate { get; set; }
        }

        public void WriteJsonDates()
        {
            LogEntry entry = new LogEntry
            {
                LogDate = new DateTime(2009, 2, 15, 0, 0, 0, DateTimeKind.Utc),
                Details = "Application started."
            };

            // default as of Json.NET 4.5
            string isoJson = JsonConvert.SerializeObject(entry);
            // {"Details":"Application started.","LogDate":"2009-02-15T00:00:00Z"}

            JsonSerializerSettings microsoftDateFormatSettings = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
            };
            string microsoftJson = JsonConvert.SerializeObject(entry, microsoftDateFormatSettings);
            // {"Details":"Application started.","LogDate":"\/Date(1234656000000)\/"}

            string javascriptJson = JsonConvert.SerializeObject(entry, new JavaScriptDateTimeConverter());
            // {"Details":"Application started.","LogDate":new Date(1234656000000)}
        }
    }
}
