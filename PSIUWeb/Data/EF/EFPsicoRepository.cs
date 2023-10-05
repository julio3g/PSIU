using PSIUWeb.Data.Interface;
using PSIUWeb.Models;

namespace PSIUWeb.Data.EF
{
    public class EFPsicoRepository : IPsicoRepository
    {
        private AppDbContext context;

        public EFPsicoRepository(AppDbContext ctx)
        {
            context = ctx;
        }

        public Psico? Create(Psico p)
        {
            try
            {
                context.Psicos?.Add(p);
                context.SaveChanges();
            }
            catch
            {
                return null;
            }

            return p;
        }

        public Psico? Delete(int id)
        {
            Psico? p = GetPsicoById(id);
            
            if (p == null)            
                return null;

            context.Psicos?.Remove(p);
            context.SaveChanges();

            return p;
        }

        public Psico? GetPsicoById(int id)
        {
            Psico? p = 
                context
                    .Psicos?
                    .Where(p => p.Id == id)
                    .FirstOrDefault();

            return p;
        }

        public IQueryable<Psico>? GetPsicos()
        {
            return context.Psicos;
        }

        public Psico? Update(Psico p)
        {
            try
            {
                context.Psicos?.Update(p);
                context.SaveChanges();
            }
            catch
            {
                return null;
            }

            return p;
        }
    }
}
