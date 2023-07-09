using MassTransit;
using SharedMessages.Schedule;

namespace EmailService.Consumers.Schedule
{
    public class ScheduleConsumer : IConsumer<ScheduleCreated>
    {
        private readonly ILogger<ScheduleCreated> _logger;

        // Other classes like any kind of DTO object could be used instead of ScheduleCreated object
        public ScheduleConsumer(ILogger<ScheduleCreated> logger)
        {
            _logger = logger;
        }
        public async Task Consume(ConsumeContext<ScheduleCreated> context)
        {
            var message = context.Message.Title + context.Message.ScheduleDate;
            _logger.LogInformation(message);

        }
    }
}
