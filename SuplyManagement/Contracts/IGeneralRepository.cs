namespace SuplyManagement.Contracts
{
    public interface IGeneralRepository<TEntity>
    {
        TEntity? Create(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity? GetByGuid(string guid);
    }
}
