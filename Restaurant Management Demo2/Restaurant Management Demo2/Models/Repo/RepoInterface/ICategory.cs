namespace Restaurant_Management_Demo2.Models.Repo.RepoInterface
{
    public interface ICategory
    {
        public List<Category> GetAll();
        public Category GetById(int id);
        public void GetAdd(Category category);
        
    }
}
