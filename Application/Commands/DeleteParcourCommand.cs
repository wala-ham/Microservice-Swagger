using MediatR;
using testswagger.Controllers;

namespace testswagger.Application.Parcours.Delete
{
    public record DeleteParcourCommand(int parcoursId):IRequest;
    
}
