namespace UnitConvertorWebApp.Services
{
    public interface IFavoritesService
    {
        Task<List<string>> GetFavoritesAsync();
        Task AddFavoriteAsync(string quantity);
        Task RemoveFavoriteAsync(string quantity);
        Task<bool> IsFavoriteAsync(string quantity);
    }
}
