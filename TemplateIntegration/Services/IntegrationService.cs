using System.Collections.Generic;
using TemplateIntegration.ExternalApi.Models;

namespace TemplateIntegration.ExternalApi.Services
{
    public class IntegrationService : IIntegrationService
    {
        public List<ServiceDependency> GetDependencies()
        {
            var dependencies = new List<ServiceDependency>
            {
                new ServiceDependency
                {
                    Type = DependencyTypes.Web,
                    Name = "your web service",
                    Url = "https:\\address"
                },
                new ServiceDependency
                {
                    Type = DependencyTypes.Desktop,
                    Name = "your desktop product",
                    Version = "Version"
                }
            };

            return dependencies;
        }

        public string GetVersion()
        {
            return "your product version";
        }
    }
}
