using Newtonsoft.Json;
using WinFormsApp4.Models;
namespace WinFormsApp4.Services
{
    public static class DatabaseService
    {
        private static readonly string DataFilePath = "data.json";
        public static AppDataBase Load()
        {

            if (!File.Exists(DataFilePath))
            {
                return new AppDataBase();

            }
            string json = File.ReadAllText(DataFilePath);
            AppDataBase? db = JsonConvert.DeserializeObject<AppDataBase>(json);
            return db ?? new AppDataBase();
        }
        public static void Save(AppDataBase dataBase)
        {
            string json = JsonConvert.SerializeObject(dataBase, Formatting.Indented);
            File.WriteAllText(DataFilePath, json);

        }
    };
    
   
}
