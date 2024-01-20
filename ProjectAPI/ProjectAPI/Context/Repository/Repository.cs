using Microsoft.EntityFrameworkCore;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly DbContext _context;
    private DbSet<T> entities;

    public Repository(DbContext context)
    {
        _context = context;
        entities = context.Set<T>();
    }

    public IEnumerable<T> GetAll()
    {
        return entities.AsEnumerable();
    }

    public T Get(int id)
    {
        return entities.Find(id);
    }

    public void Add(T entity)
    {
        entities.Add(entity);
        _context.SaveChanges();
    }

    public void Update(T entity)
    {
       var x= entities.Update(entity);
        _context.SaveChanges();
    }

    public void Delete(T entity)
    {
        entities.Remove(entity);
        _context.SaveChanges();
    }
}
