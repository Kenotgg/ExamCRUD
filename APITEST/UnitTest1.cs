using ExamCRUD;
using ExamCRUD.Models.Data;
using ExamCRUD.Services;


namespace APITEST
{
    public class Tests
    {
        [TestFixture]
        public class DishServiceTests
        {
            private DishService _dishService;
            private AppDataContext _appDataContext;

            [SetUp]
            public void Setup()
            {
                _appDataContext = new AppDataContext();
                _dishService = new DishService(_appDataContext);
            }

            [Category("Create")]
            [Test]
            public void Create_Dish_Correct_Input() 
            {
                string name = "bread";
                string description = "nice";
                int calories = 120;
                _dishService.Create(name, description, calories);
                var newDish = _appDataContext.dishes.FirstOrDefault();
                Assert.AreEqual(newDish.Name, name);
                Assert.AreEqual(newDish.Description, description);
                Assert.AreEqual(newDish.KCAL, calories);

            }

            [Test]
            public void Test1()
            {
                Assert.Pass();
            }
        }
        
    }
}