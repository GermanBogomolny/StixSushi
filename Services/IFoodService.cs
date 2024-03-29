using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Stix.Models;
using Stix.ViewModels;

namespace Stix.Services;

public interface IFoodService
{
    void Create(Food food, FoodCreateViewModel viewModel);
    List<Food> GetAll(string filter);
    void Update(Food obj);
    void Delete(int id);
    Food? GetById(int? id);
    bool FoodExists(int id);

}
