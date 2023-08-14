
using MediatR;

namespace testswagger.Application.Commands
{
    public record CreateParcoursCommand(
        string ParcoursName,
        string ParcoursDescription,
        DateTime DateCreation
) : IRequest;

}


