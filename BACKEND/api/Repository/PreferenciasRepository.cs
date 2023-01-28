using Microsoft.EntityFrameworkCore;

public interface IPreferenciasRepository{
    public void save(Preferencias preferencia);
    public void update(Preferencias preferencia);
    
}
public class PreferenciasRepository : IPreferenciasRepository{
    private readonly ApplicationDbContext _context;
    public PreferenciasRepository(ApplicationDbContext context){
        _context = context;
    }
    public void save(Preferencias preferencia){
        _context.Preferencias.Add(preferencia);
        _context.SaveChanges();
    }
    public void update(Preferencias preferencia){
        preferencia.Id = 1;
        _context.Entry(preferencia).State = EntityState.Modified;
        _context.SaveChanges();
    }
}