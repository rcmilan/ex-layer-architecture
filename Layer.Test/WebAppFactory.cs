using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Hosting;

namespace Layer.Test
{
    internal class WebAppFactory : WebApplicationFactory<Program>
    {

        private readonly string _environment;

        public WebAppFactory(string environment = "Development")
        {
            _environment = environment;
        }

        protected override IHost CreateHost(IHostBuilder builder)
        {
            builder.UseEnvironment(_environment);

            return base.CreateHost(builder);
        }
    }
}