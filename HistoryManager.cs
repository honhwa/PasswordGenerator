using System.IO;
using System.Text.Json;

namespace PasswordGenerator
{
    public class PasswordRecord
    {
        public DateTime Timestamp { get; set; }
        public string Password { get; set; } = string.Empty;
        public int Length { get; set; }
        public string Rules { get; set; } = string.Empty;
    }

    public class HistoryManager
    {
        private readonly string _filePath;
        private List<PasswordRecord> _records = new();

        public HistoryManager()
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var appFolder = Path.Combine(appDataPath, "PasswordGenerator");
            
            if (!Directory.Exists(appFolder))
                Directory.CreateDirectory(appFolder);

            _filePath = Path.Combine(appFolder, "history.json");
            Load();
        }

        public void Add(PasswordRecord record)
        {
            _records.Insert(0, record); // Add to beginning (newest first)
            Save();
        }

        public void Remove(PasswordRecord record)
        {
            _records.Remove(record);
            Save();
        }

        public void Clear()
        {
            _records.Clear();
            Save();
        }

        public List<PasswordRecord> GetAll()
        {
            return new List<PasswordRecord>(_records);
        }

        private void Load()
        {
            try
            {
                if (File.Exists(_filePath))
                {
                    var json = File.ReadAllText(_filePath);
                    _records = JsonSerializer.Deserialize<List<PasswordRecord>>(json) ?? new List<PasswordRecord>();
                }
            }
            catch
            {
                _records = new List<PasswordRecord>();
            }
        }

        private void Save()
        {
            try
            {
                var json = JsonSerializer.Serialize(_records, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(_filePath, json);
            }
            catch
            {
                // Silent fail - don't crash the app
            }
        }
    }
}
