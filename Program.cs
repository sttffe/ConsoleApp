using Microsoft.Extensions.Hosting ;

using Wolverine ;



namespace ConsoleApp1;

internal class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        IHostBuilder builder
            = new HostBuilder ( ) ;
        
        builder.UseWolverine ( ) ;
        
        var app = builder.Build ( ) ;
        app.Start ( ) ;
        
    var    bus = app.MessageBus ( ) ;


    await bus.InvokeAsync (
        new GetMessage ( Message : "Hello" )
    ) ;


    }
}
