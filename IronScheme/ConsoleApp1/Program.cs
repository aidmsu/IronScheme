using System;
using System.Reflection.Emit;
using IronScheme.Hosting;

namespace ConsoleApp1
{
    class Program
    {
        static int Main(string[] args)
        {
			
			return IronSchemeConsoleHost.Execute(args);
		}
    }
}
