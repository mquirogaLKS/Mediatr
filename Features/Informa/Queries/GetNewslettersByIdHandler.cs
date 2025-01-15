using MediatR;
using MediatrTest.Domain;
using MediatrTest.Features.Informa.Repositories;

namespace MediatrTest.Features.Informa.Queries
{
    public record GetNewslettersById(int id) : IRequest<Newsletter?>
    {
        public int Id { get; set; } = id;
    }
    public class GetNewslettersByIdHandler(IInformaRepo informaRepo) : IRequestHandler<GetNewslettersById, Newsletter?>
    {
        private readonly IInformaRepo _informaRepo = informaRepo;
        public async Task<Newsletter?> Handle(GetNewslettersById request, CancellationToken cancellationToken) => await _informaRepo.GetById(request.Id);
    }
}
