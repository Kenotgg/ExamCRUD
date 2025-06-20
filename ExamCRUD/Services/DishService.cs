using ExamCRUD.Models;
using ExamCRUD.Models.Data;
using ExamCRUD.Services.Interfaces;
namespace ExamCRUD.Services
{
    public class DishService : IDishService
    {
        private readonly AppDataContext _appDataContext;
        public DishService(AppDataContext appDataContext)
        {
            _appDataContext = appDataContext;
        }

        public async Task<List<DishModel>> GetAll() 
        {
            var result = _appDataContext.dishes.ToList();
            return result;
        }

        public async Task<DishModel> Create(string name, string description, int KCAL)
        {
            DishModel dishToAdd = new DishModel { ID = _appDataContext.currentDishId++, Name= name, Description = description, KCAL = KCAL};
            _appDataContext.dishes.Add(dishToAdd);
            return dishToAdd;
        }
    }
}
