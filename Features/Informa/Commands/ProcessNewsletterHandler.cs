using MediatR;
using MediatrTest.Domain;
using MediatrTest.Features.Informa.Notifications;

namespace MediatrTest.Features.Informa.Commands
{
    public record ProcessNewsletter(Newsletter Newsletter) : IRequest<bool>;
    public class ProcessNewsletterHandler(ILogger<ProcessNewsletterHandler> logger, IMediator mediator) : IRequestHandler<ProcessNewsletter, bool>
    {
        private readonly IMediator _mediator = mediator;

        public async Task<bool> Handle(ProcessNewsletter request, CancellationToken cancellationToken)
        {
            logger.LogInformation($"El boletín {request.Newsletter.Name}({request.Newsletter.Id}) se ha procesado correctamente");

            await _mediator.Publish(new NewsletterProcessed(request.Newsletter), cancellationToken);
            return true;
        }
    }
}
