using MediatR;

namespace testswagger.Application.Parcours.Update
{
    public record UpdateParcoursCommand(
        int parcourId,
        string ParcoursName,
        string ParcoursDescription,
        DateTime DateCreation
) : IRequest;


    public record UpdateParcoursRequest(
       string ParcoursName,
       string ParcoursDescription,
       DateTime DateCreation
);
}


