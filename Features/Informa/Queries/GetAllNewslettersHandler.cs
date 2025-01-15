using MediatR;
using MediatrTest.Domain;
using MediatrTest.Features.Informa.Repositories;

namespace MediatrTest.Features.Informa.Queries
{
    public record GetAllNewslettersQuery() : IRequest<IEnumerable<Newsletter>>;
    public class GetAllNewslettersHandler(IInformaRepo informaRepo) : IRequestHandler<GetAllNewslettersQuery, IEnumerable<Newsletter>>
    {
        private readonly IInformaRepo _informaRepo = informaRepo;

        public async Task<IEnumerable<Newsletter>> Handle(GetAllNewslettersQuery request, CancellationToken cancellationToken) => await _informaRepo.GetAll();
    }
}
