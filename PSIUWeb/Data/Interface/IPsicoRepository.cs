using PSIUWeb.Models;

namespace PSIUWeb.Data.Interface
{
    public interface IPsicoRepository
    {        
        public Psico? GetPsicoById(int id);

        public IQueryable<Psico>? GetPsicos();

        public Psico? Update(Psico p);

        public Psico? Delete(int id);

        public Psico? Create(Psico p);
    }
}
