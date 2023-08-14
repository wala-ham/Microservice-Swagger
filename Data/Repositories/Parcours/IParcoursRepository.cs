using testswagger.Domain.Models;

namespace testswagger.Data.Repositories.Parcours
{
    public interface IParcoursRepository
    {
        Task<Parcour?> GetById(int id);
        IQueryable<Parcour> GetAll();
        Task Add(Parcour parcours);
        Task Update(Parcour parcours);
        void Delete(Parcour parcours);
    }
}
