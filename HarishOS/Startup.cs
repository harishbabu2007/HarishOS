// Made By harish
// Startup Screen


using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HarishOS
{
    class Startup
    {
        // Startup Screen Content
        public void startup()
        {
            Console.Clear();
            string logo = @"




                 _    _            _     _        ____   _____ 
                | |  | |          (_)   | |      / __ \ / ____|
                | |__| | __ _ _ __ _ ___| |__   | |  | | (___  
                |  __  |/ _` | '__| / __| '_ \  | |  | |\___ \ 
                | |  | | (_| | |  | \__ \ | | | | |__| |____) |
                |_|  |_|\__,_|_|  |_|___/_| |_|  \____/|_____/

                                VERSION 1.1
                                 BY HARISH





";
            Console.WriteLine(logo);

            // Startup Music
            // Only Works on VMWare Player
            Console.Beep();
            Console.Beep();

            wait();
            Console.Beep();
            wait();

            Console.Beep();
            Console.Beep();
            wait();
            wait();
            wait();
            wait();
            wait();
            wait();
            wait();
            wait();
            wait();
            wait();
            wait();
            wait();
        }

        // Wait Function
        void wait()
        {
            for (int i=0; i<10000000; i++)
            {

            }
        }

    }
}
