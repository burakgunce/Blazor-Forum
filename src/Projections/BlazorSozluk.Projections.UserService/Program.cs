using BlazorSozluk.Projections.UserService.Services;

namespace BlazorSozluk.Projections.UserService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IHost host = Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddHostedService<Worker>();
                    services.AddTransient<BlazorSozluk.Projections.UserService.Services.UserService>();
                    services.AddTransient<EmailService>();
                })
                .Build();

            host.Run();
        }
    }
}