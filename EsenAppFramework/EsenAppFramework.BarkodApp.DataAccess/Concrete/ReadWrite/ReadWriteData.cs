using EsenAppFramework.BarkodApp.Entities.Concrete;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace EsenAppFramework.BarkodApp.DataAccess.Concrete.ReadWrite
{
    public class ReadWriteData
    {
        public static string Path = "C:\\TestFile\\";
        public static void WriteList<T>(List<T> Data ,string dosyaAdi) where T : class 
        {
            var stringdata = JsonConvert.SerializeObject(Data);
            StreamWriter sw = File.AppendText(Path + dosyaAdi + ".txt");
            sw.WriteLine(stringdata);
            sw.Flush();
            sw.Close();

        }
        public static void WriteDataTest<T>(T Data,string dosyaAdi) where T:class
        {
            var stringdata = JsonConvert.SerializeObject(Data);
            StreamWriter sw = File.AppendText(Path + dosyaAdi + ".txt");
            sw.WriteLine(stringdata);
            sw.Flush();
            sw.Close();
        }
        public static void DeleteData<T>(string dosyaAdi, List<T> model) where T : class
        {
            List<string> tempModel = new List<string>();
            model.ForEach(x => tempModel.Add(JsonConvert.SerializeObject(x)));
            File.WriteAllLines(Path + dosyaAdi + ".txt", tempModel);
        }
       
        public static T ReadData<T>(string dosyaAdi)where T: new()
        {
            var oldLines = File.ReadAllLines(Path + dosyaAdi + ".txt");
            var DataString = "[";
            oldLines.ToList().ForEach(x => DataString += x + ",");
            DataString = DataString.Substring(0, DataString.Length - 1);
            DataString += "]";
            if (oldLines.Length == 0)
                return new T();
            return JsonConvert.DeserializeObject<T>(DataString); 
        }
    }
}
