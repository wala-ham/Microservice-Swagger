using MediatR;
using testswagger.Application.Parcours.Update;
using testswagger.Data;
using testswagger.Data.Repositories.Parcours;

namespace testswagger.Application.Handlers
{
    public sealed class UpdateParcourCommanHandler : IRequestHandler<UpdateParcoursCommand>
    {
        private readonly IParcoursRepository _parcoursRepository;
        private readonly IUnitOfwork _unitOfwork;
        public UpdateParcourCommanHandler(IParcoursRepository parcoursRepository, IUnitOfwork unitOfWork)
        {
            _parcoursRepository = parcoursRepository;
            _unitOfwork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateParcoursCommand request, CancellationToken cancellationToken)
        {
            var parcours = await _parcoursRepository.GetById(request.parcourId);
            if (parcours is null)
            {
                throw new ParcourstNotFoundException(request.parcourId);
            }

            parcours.ParcoursName = request.ParcoursName;
            parcours.ParcoursDescription = request.ParcoursDescription;
            parcours.DateCreation = request.DateCreation;

            _parcoursRepository.Update(parcours);
            await _unitOfwork.SaveAsync();
            return Unit.Value;




        }


    }
}



