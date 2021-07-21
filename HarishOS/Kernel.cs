// Made By Harish
// Harish OS kernel

using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.System.FileSystem;
using System.IO;

namespace HarishOS
{
    public class Kernel : Sys.Kernel
    {
        Commands cmd = new Commands();
        Startup startup = new Startup();

        // input taking function
        void input_take()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            cmd.print(cmd.get_prompt());
            cmd.print("@");
            Console.ForegroundColor = ConsoleColor.Magenta;
            cmd.print(cmd.get_cwd());
            Console.ForegroundColor = ConsoleColor.Cyan;
            cmd.print("~");
            Console.ForegroundColor = ConsoleColor.White;
            cmd.print("$ ");
        }

        // Main Event Loop
        protected override void BeforeRun()
        {
            startup.startup();
            cmd.init_fs();
            cmd.clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            cmd.println("HarishOS [Version 1.1.0]");
            cmd.println("(c) Hairsh Digtal. All rights reserved.");
            cmd.Return();
        }

        // function to process command for Commands.cs
        protected override void Run()
        {
            input_take();
            var input = Console.ReadLine();

            cmd.ProcessCommand(input);
        }
    }
}
