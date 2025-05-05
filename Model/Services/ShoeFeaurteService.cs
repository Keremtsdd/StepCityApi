using System.Text.Json;

namespace ShoeFeature.Services
{
    public static class ShoeFeaurteService
    {
        private static readonly string filePath = "data/products.json"; // JSON dosyan buradaysa

        public static List<ShoeFeature> GetAll()
        {
            if (!File.Exists(filePath))
                return new List<ShoeFeature>();

            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<ShoeFeature>>(json) ?? new List<ShoeFeature>();
        }

        public static void SaveAll(List<ShoeFeature> list)
        {
            var json = JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static void Add(ShoeFeature item)
        {
            var list = GetAll();
            item.Id = list.Count > 0 ? list.Max(p => p.Id) + 1 : 1;
            list.Add(item);
            SaveAll(list);
        }

        public static void Delete(int id)
        {
            var list = GetAll();
            var itemToRemove = list.FirstOrDefault(p => p.Id == id);
            if (itemToRemove != null)
            {
                list.Remove(itemToRemove);
                SaveAll(list);
            }
        }

        public static ShoeFeature? GetById(int id)
        {
            return GetAll().FirstOrDefault(p => p.Id == id);
        }

        public static void Update(ShoeFeature updatedItem)
        {
            var list = GetAll();
            var index = list.FindIndex(p => p.Id == updatedItem.Id);
            if (index != -1)
            {
                list[index] = updatedItem;
                SaveAll(list);
            }
        }
    }
}
