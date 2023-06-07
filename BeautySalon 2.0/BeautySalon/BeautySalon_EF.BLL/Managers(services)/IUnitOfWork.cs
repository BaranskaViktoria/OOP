namespace BeautySalon_EF.BLL.Managers
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync();
    }
}