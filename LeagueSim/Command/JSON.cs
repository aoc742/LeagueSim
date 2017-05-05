using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;
using LeagueSim.Model;

namespace LeagueSim.Command
{
    public class JSON
    {

        public void JSONSerialize(ChampionComparison obj)
        {
            MemoryStream stream = new MemoryStream();
            DataContractJsonSerializer jsonSer = new DataContractJsonSerializer(typeof(ChampionComparison));
            jsonSer.WriteObject(stream, obj);
            stream.Position = 0;
            StreamReader sr = new StreamReader(stream);
            string x = sr.ReadToEnd();
        }

        public string JSONDeserialize(string JSONData)
        {
            DataContractJsonSerializer jsonSer = new DataContractJsonSerializer(typeof(ChampionComparison));
            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(JSONData));
            ChampionComparison obj = (ChampionComparison)jsonSer.ReadObject(stream);
            return string.Format("First = {0}, Second = {1}, Wins: {2}, Losses: {3}, AllyWins: {4}, AllyLosses: {5}", obj.FirstChampion, obj.SecondChampion, obj.Wins, obj.Losses, obj.AllyWins, obj.AllyLosses);
        }

        public void WriteToJsonFile<T>(string filePath, T objectToWrite, bool append = false) where T: new()
        {
            TextWriter writer = null;
            try
            {
                var contentsToWriteToFile = JsonConvert.SerializeObject(objectToWrite);
                writer = new StreamWriter(filePath, append);
                writer.Write(contentsToWriteToFile);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }

        public T ReadFromJsonFile<T>(string filePath) where T : new()
        {
            TextReader reader = null;
            try
            {
                reader = new StreamReader(filePath);
                var fileContents = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(fileContents);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        public JSON()
        {

        }
    }
}
