using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSocialNetWorkManager.Utilities.Log
{
    public class LogJson : ILog<LogObject>, ILog<string>
    {
        public void SaveLog(LogObject action)
        {
            string logPath = Directory.GetCurrentDirectory() + @"\Log.json";
            string currentContent = string.Empty;

            List<LogObject> logObjects = new List<LogObject>();

            if (File.Exists(logPath))
            {
                var streamReader = new StreamReader(logPath);
                currentContent = streamReader.ReadToEnd();
                logObjects = JsonConvert.DeserializeObject<List<LogObject>>(currentContent);
                streamReader.Close();
            }

            var streamWriter = new StreamWriter(logPath);            

            logObjects.Add(action);

            var jsonResult = JsonConvert.SerializeObject(logObjects);

            streamWriter.WriteLine(jsonResult);
            streamWriter.Close();
        }

        public void SaveLog(string action)
        {
            string logPath = Directory.GetCurrentDirectory() + @"\Log.json";
            string currentContent = string.Empty;

            List<LogObject> logObjects = new List<LogObject>();

            if (File.Exists(logPath))
            {
                var streamReader = new StreamReader(logPath);
                currentContent = streamReader.ReadToEnd();
                logObjects = JsonConvert.DeserializeObject<List<LogObject>>(currentContent);
                streamReader.Close();
            }

            var streamWriter = new StreamWriter(logPath);

            logObjects.Add(new LogObject() { Action = action, LogDate = DateTime.Now });

            var jsonResult = JsonConvert.SerializeObject(logObjects);

            streamWriter.WriteLine(jsonResult);
            streamWriter.Close();
        }
    }
}
