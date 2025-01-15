using MediatR;
using MediatrTest.Domain;
using MediatrTest.Features.Informa.Repositories;

namespace MediatrTest.Features.Informa.Notifications
{
    public record NewsletterProcessed(Newsletter Item) : INotification;

    public class NewsletterProcessedEventHandler(ILogger<NewsletterProcessedEventHandler> logger, IInformaRepo informaRepo) : INotificationHandler<NewsletterProcessed>
    {
        private readonly IInformaRepo _informaRepo = informaRepo;
        public async Task Handle(NewsletterProcessed notification, CancellationToken cancellationToken)
        {
            await _informaRepo.Add(notification.Item);
            logger.LogInformation($"El boletín {notification.Item.Name}({notification.Item.Id}) se ha guardado en la BBDD");
        }
    }
}
