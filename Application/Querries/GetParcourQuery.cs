using MediatR;

namespace testswagger.Application.Querries
{
    public record GetParcourQuery(int parcourId) : IRequest<ParcoursRespons>;

   

    public record ParcoursRespons(
        int id,
        string ParcoursName,
        string ParcoursDescription,
        DateTime Datecretaion);
}


