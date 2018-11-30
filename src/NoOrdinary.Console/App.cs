namespace NoOrdinary.Console
{
    using Microsoft.Extensions.Options;
    using NoOrdinary.Console.Models;
    using NoOrdinary.Console.Services;
    using Serilog;

    public class App
    {
        private readonly ITestService testService;
        private readonly AppSettings config;

        public App(
            ITestService testService,
            IOptions<AppSettings> config,
            ILogger logger)
        {
            this.testService = testService;
            this.config = config.Value;
            Log.Logger = logger;
        }

        public void Run()
        {
            Log.Information($"This is a console application for {this.config.ConsoleTitle}");
            this.testService.Run();
        }
    }
}
