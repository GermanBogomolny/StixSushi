using Stix.Models;
using Stix.Utils;
namespace Stix.ViewModels;


public class RestaurantViewModel
{
    public List<Restaurant> Restaurants { get; set; } = new List<Restaurant>();
    public string NameFilter { get; set; }
    public List<Food> AvailableFoods { get; set; }

}