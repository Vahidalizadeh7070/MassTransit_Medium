using MassTransit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ScheduleService.API.DTO.ScheduleDTOs;

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
        public async Task<IActionResult> Post()
        {
            return Ok();
        }
    }
}
