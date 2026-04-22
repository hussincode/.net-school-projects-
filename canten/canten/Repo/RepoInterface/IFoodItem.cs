using canten.Models;

namespace canten.Repo.RepoInterface
{
    public interface IFoodItem
    {
        public List<FoodItem> GetAllFoodItems();
        public FoodItem GetById(int id);
        public FoodItem CreateStaff(FoodItem staff);
        public FoodItem UpdateStaff(FoodItem staff);
        public void DeleteStaff(int id);

    }
}
