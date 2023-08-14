using testswagger.Data.Repositories.Parcours;
using testswagger.Domain.Models;

namespace testswagger.Data
{
    public class UnitOfWork : IUnitOfwork
    {
        private readonly ApplicationDbContext _context;
        private readonly IParcoursRepository _parcoursRepository;

        public UnitOfWork(ApplicationDbContext context, IParcoursRepository parcoursRepository)
        {
            _context = context;
            _parcoursRepository = parcoursRepository;

        }


        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }

}
