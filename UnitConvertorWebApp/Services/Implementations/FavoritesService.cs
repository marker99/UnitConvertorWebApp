using Blazored.LocalStorage;
using System.Text.Json;

namespace UnitConvertorWebApp.Services.Implementations
{
    public class FavoritesService : IFavoritesService
    {
        private const string StorageKey = "favorites";
        private readonly ILocalStorageService _localStorage;

        public FavoritesService(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        public async Task<List<string>> GetFavoritesAsync()
        {
            try
            {
                var favoritesJson = await _localStorage.GetItemAsync<string>(StorageKey);
                return string.IsNullOrEmpty(favoritesJson)
                    ? new List<string>() // Ensure we return a new empty list if nothing is found
                    : JsonSerializer.Deserialize<List<string>>(favoritesJson);
            }
            catch (JsonException ex)
            {
                // Handle deserialization errors if needed
                Console.WriteLine($"Error deserializing favorites: {ex.Message}");
                return new List<string>(); // Return empty list in case of error
            }
        }

        public async Task AddFavoriteAsync(string quantity)
        {
            var favorites = await GetFavoritesAsync();
            if (!favorites.Any(f => f.Equals(quantity, StringComparison.OrdinalIgnoreCase)))
            {
                favorites.Add(quantity);
                await SaveFavoritesAsync(favorites);
            }
        }

        public async Task RemoveFavoriteAsync(string quantity)
        {
            var favorites = await GetFavoritesAsync();
            var favoriteToRemove = favorites.FirstOrDefault(f => f.Equals(quantity, StringComparison.OrdinalIgnoreCase));
            if (favoriteToRemove != null)
            {
                favorites.Remove(favoriteToRemove);
                await SaveFavoritesAsync(favorites);
            }
        }

        public async Task<bool> IsFavoriteAsync(string quantity)
        {
            var favorites = await GetFavoritesAsync();
            return favorites.Any(f => f.Equals(quantity, StringComparison.OrdinalIgnoreCase));
        }

        private async Task SaveFavoritesAsync(List<string> favorites)
        {
            var favoritesJson = JsonSerializer.Serialize(favorites);
            await _localStorage.SetItemAsync(StorageKey, favoritesJson);
        }
    }
}
