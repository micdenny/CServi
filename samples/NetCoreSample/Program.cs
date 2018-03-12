using CServi.Hosting;

namespace NetCoreSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildConsoleHost(args).Run();
        }

        public static IConsoleHost BuildConsoleHost(string[] args) =>
            new ConsoleHostBuilder()
                .Build();
    }
}
