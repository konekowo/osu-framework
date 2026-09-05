using System;
using System.Runtime.InteropServices.JavaScript;
using System.Threading.Tasks;
using osu.Framework.Browser;

namespace SampleGame.Browser;

internal partial class Program
{
    [JSExport]
    [STAThread]
    private static Task Main(string[] args)
    {
        try
        {
            Console.WriteLine("Hello World!");

            BrowserGameHost host = new BrowserGameHost(@"sample-game");
            host.Run(new SampleGameGame());
        }
        catch(Exception e)
        {
            Console.Error.WriteLine(e.ToString());
        }

        return Task.CompletedTask;
    }
}
