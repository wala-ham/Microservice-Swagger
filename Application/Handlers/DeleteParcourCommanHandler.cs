using MediatR;
using testswagger.Application.Parcours.Delete;
using testswagger.Data;
using testswagger.Data.Repositories.Parcours;

namespace testswagger.Application.Handlers
{
    public sealed class DeleteParcourCommanHandler : IRequestHandler<DeleteParcourCommand>
    {
        private readonly IParcoursRepository _parcoursRepository;
        private readonly IUnitOfwork _unitOfwork;

        public DeleteParcourCommanHandler(IParcoursRepository parcoursRepository, IUnitOfwork unitOfwork)
        {
            _parcoursRepository = parcoursRepository;
            _unitOfwork = unitOfwork;
        }

        public async Task<Unit> Handle(DeleteParcourCommand request, CancellationToken cancellationToken)
        {
            var parcours = await _parcoursRepository.GetById(request.parcoursId);
            if (parcours is null)
            {
                throw new ParcourstNotFoundException(request.parcoursId);
            }
            _parcoursRepository.Delete(parcours);
            await _unitOfwork.SaveAsync();
            return Unit.Value;
        }

        
    }
}
