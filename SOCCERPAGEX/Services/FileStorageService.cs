using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SOCCERPAGEX.Services
{


    //Usaremos almacenamiento local con operaciones asíncronas para manejar los datos.


    public class FileStorageService<T>
    {
        private readonly string _filePath;

        public FileStorageService(string fileName)
        {
            _filePath = Path.Combine(FileSystem.AppDataDirectory, fileName);
        }

        public async Task<List<T>> LoadAsync()
        {
            if (!File.Exists(_filePath)) return new List<T>();
            var json = await File.ReadAllTextAsync(_filePath);
            return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
        }

        public async Task SaveAsync(List<T> data)
        {
            var json = JsonSerializer.Serialize(data);
            await File.WriteAllTextAsync(_filePath, json);
        }
    }
}
