using ExamCRUD.Models;

namespace ExamCRUD.Services.Interfaces
{
    public interface IDishService
    {
        public Task<List<DishModel>> GetAll();
        public Task<DishModel> Create(string name, string description, int KCAL);
    }
}
