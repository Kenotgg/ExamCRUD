namespace ExamCRUD.Models.Data
{
    public class AppDataContext
    {
        public List<DishModel> dishes { get; set; } = new List<DishModel>();

        public int currentDishId { get; set; } = 0;
    }
}
