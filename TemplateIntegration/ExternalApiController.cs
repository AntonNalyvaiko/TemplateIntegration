using System;
using Microsoft.AspNetCore.Mvc;
using TemplateIntegration.ExternalApi.Services;

namespace TemplateIntegration.ExternalApi
{
    [Route("externalapi")]
    [ApiController]
    public class IntegrationApiController : ControllerBase
    {
        private readonly IIntegrationService _integrationCheckService;

        public IntegrationApiController(IIntegrationService integrationCheckService)
        {
            _integrationCheckService = integrationCheckService;
        }

        [HttpGet("checkconnection")]
        public IActionResult CheckConnection()
        {
            return Ok(DateTime.UtcNow);
        }

        [HttpGet("dependencies")]
        public IActionResult GetDependencies()
        {
            return Ok(_integrationCheckService.GetDependencies());
        }

        [HttpGet("version")]
        public IActionResult GetVersion()
        {
            return Ok(_integrationCheckService.GetVersion());
        }
    }
}
