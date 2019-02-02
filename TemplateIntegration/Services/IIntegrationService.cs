using System.Collections.Generic;
using TemplateIntegration.ExternalApi.Models;

namespace TemplateIntegration.ExternalApi.Services
{
    public interface IIntegrationService
    {
        List<ServiceDependency> GetDependencies();
        string GetVersion();
    }
}
