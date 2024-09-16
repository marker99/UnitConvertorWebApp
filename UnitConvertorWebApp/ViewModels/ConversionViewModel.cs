using Microsoft.AspNetCore.Components;
using System.Collections.ObjectModel;
using UnitConvertorWebApp.Services;
using UnitConvertorWebApp.Models;

namespace UnitConvertorWebApp.ViewModels
{
    public class ConversionViewModel
    {
        private readonly IConversionService _conversionService;
        private readonly IFavoritesService _favoritesService;
        //private readonly NavigationManager _navigationManager;

        public ObservableCollection<string> Quantities { get; private set; } = new();
        public ObservableCollection<string> FilteredQuantities { get; private set; } = new();
        public ObservableCollection<string> AvailableUnits { get; private set; } = new();
        public Dictionary<string, bool> FavoritesMap { get; private set; } = new();

        public string SearchText { get; set; } = string.Empty;
        public string SelectedQuantity { get; private set; }
        public string SelectedFromUnit { get; set; }
        public string SelectedToUnit { get; set; }
        public double InputValue { get; set; }
        public string ResultText { get; private set; } = string.Empty;

        public event Action StateChanged;

        public ConversionViewModel(IConversionService conversionService, IFavoritesService favoritesService)
        {
            _conversionService = conversionService;
            _favoritesService = favoritesService;
        }

        public async Task InitializeAsync()
        {
            var quantities = await _conversionService.GetAvailableQuantitiesAsync();
            Quantities = new ObservableCollection<string>(quantities);

            var favorites = await _favoritesService.GetFavoritesAsync();
            FavoritesMap = Quantities.ToDictionary(q => q, q => favorites.Contains(q, StringComparer.OrdinalIgnoreCase));

            await FilterQuantities();
            if (FilteredQuantities.Any())
            {
                await SelectQuantityAsync(FilteredQuantities.First());
            }
        }

        public async Task FilterQuantities()
        {
            var filtered = string.IsNullOrWhiteSpace(SearchText)
                ? new List<string>(Quantities)
                : Quantities.Where(q => q.Contains(SearchText, StringComparison.OrdinalIgnoreCase)).ToList();

            var orderedFiltered = FavoritesMap
                .Where(kvp => kvp.Value && filtered.Contains(kvp.Key))
                .Select(kvp => kvp.Key)
                .Concat(filtered.Where(q => !FavoritesMap.GetValueOrDefault(q)))
                .ToList();

            FilteredQuantities = new ObservableCollection<string>(orderedFiltered);

            if (!FilteredQuantities.Contains(SelectedQuantity))
            {
                await SelectQuantityAsync(FilteredQuantities.FirstOrDefault());
            }

            NotifyStateChanged();
        }

        public async Task SelectQuantityAsync(string quantity)
        {
            if (quantity == null) return;

            SelectedQuantity = quantity;
            var units = await _conversionService.GetAvailableUnitsAsync(quantity);
            AvailableUnits = new ObservableCollection<string>(units);

            SelectedFromUnit = AvailableUnits.FirstOrDefault();
            SelectedToUnit = AvailableUnits.Skip(1).FirstOrDefault();

            InputValue = 0;
            ResultText = string.Empty;

            NotifyStateChanged();
        }

        public async Task ToggleFavoriteAsync(string quantity)
        {
            FavoritesMap[quantity] = !FavoritesMap[quantity];
            if (FavoritesMap[quantity])
            {
                await _favoritesService.AddFavoriteAsync(quantity);
            }
            else
            {
                await _favoritesService.RemoveFavoriteAsync(quantity);
            }
            await FilterQuantities();
        }

        public async Task ConvertUnitsAsync()
        {
            if (!string.IsNullOrEmpty(SelectedQuantity) && !string.IsNullOrEmpty(SelectedFromUnit) && !string.IsNullOrEmpty(SelectedToUnit))
            {
                try
                {
                    var result = await _conversionService.ConvertAsync(SelectedQuantity, InputValue, SelectedFromUnit, SelectedToUnit);
                    ResultText = $"{result.NumericValue:F2} {result.Abbreviation}";
                }
                catch (Exception ex)
                {
                    ResultText = $"Error: {ex.Message}";
                }
                NotifyStateChanged();
            }
        }

        private void NotifyStateChanged() => StateChanged?.Invoke();

        public void Dispose()
        {
            // Cleanup code if needed
        }
    }
}
