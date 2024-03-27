using BlazorSozluk.Common.Events.User;
using BlazorSozluk.Common.Infrastructure;
using BlazorSozluk.Common;

namespace BlazorSozluk.Projections.UserService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly UserService.Services.UserService _userService;
        private readonly UserService.Services.EmailService _emailService;

        public Worker(ILogger<Worker> logger, UserService.Services.UserService userService, Services.EmailService emailService)
        {
            _logger = logger;
            _userService = userService;
            _emailService = emailService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            QueueFactory.CreateBasicConsumer()
            .EnsureExchange(SozlukConstants.UserExchangeName)
            .EnsureQueue(SozlukConstants.UserEmailChangedQueueName, SozlukConstants.UserExchangeName)
            .Receive<UserEmailChangedEvent>(user =>
            {
                // DB Insert 

                var confirmationId = _userService.CreateEmailConfirmation(user).GetAwaiter().GetResult();

                // Generate Link

                var link = _emailService.GenerateConfirmationLink(confirmationId);

                // Send Email

                _emailService.SendEmail(user.NewEmailAddress, link).GetAwaiter().GetResult();
            })
            .StartConsuming(SozlukConstants.UserEmailChangedQueueName);
        }
    }
}