using MassTransit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ScheduleService.API.DTO.ScheduleDTOs;
using SharedMessages.Schedule;

namespace ScheduleService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        private readonly IPublishEndpoint _publishEndpoint;
        private readonly ILogger<CreateScheduleDTO> _logger;

        public ScheduleController(IPublishEndpoint publishEndpoint, ILogger<CreateScheduleDTO> logger)
        {
            _publishEndpoint = publishEndpoint;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateScheduleDTO createScheduleDTO)
        {
            _logger.Log(LogLevel.Information, $"Schedule has been created at{createScheduleDTO.ScheduleDate}");
            await _publishEndpoint.Publish<ScheduleCreated>(new
            {
                createScheduleDTO.Id,
                createScheduleDTO.Title,
                createScheduleDTO.ScheduleDate,
                createScheduleDTO.IsActive,
                createScheduleDTO.ScheduleCreated
            });
            return Ok($"The message has been sent to the consumer - Title: ${createScheduleDTO.Title}");
        }
    }
}
