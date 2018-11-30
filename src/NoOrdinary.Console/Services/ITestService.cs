namespace NoOrdinary.Console.Services
{
    using Microsoft.Extensions.Options;
    using NoOrdinary.Console.Models;
    using Serilog;

    public interface ITestService
    {
        void Run();
    }

    public class TestService : ITestService
    {
        private readonly AppSettings config;

        public TestService(
            ILogger logger,
            IOptions<AppSettings> config)
        {
            Log.Logger = logger;
            this.config = config.Value;
        }

        /// <inheritdoc/>
        public void Run()
        {
            Log.Warning($"Wow! We are now in the test service of: {this.config.ConsoleTitle}");
        }
    }
}
