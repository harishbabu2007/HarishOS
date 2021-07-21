// Made By Harish
// Disk Commands


using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.System.FileSystem;
using System.IO;

namespace HarishOS
{
    class DiskCommands
    {
        // Parses Commands
        public void ParseCommands(string[] str_arr, CosmosVFS vfs)
        {
            try
            {
                var drive = new DriveInfo("0");
                switch (str_arr[1])
                {
                    case "size":
                        Console.WriteLine("Drive Size : " + drive.TotalSize);
                        break;
                    case "space":
                        Console.Write("Free Space : " + drive.TotalFreeSpace);
                        break;
                    case "format":
                        Console.Clear();
                        Console.WriteLine("FORMATING DISK");
                        vfs.Format(@"0", "FAT32", true);
                        Console.WriteLine("Disk Formated succesfully");
                        break;
                    case "-h":
                        Console.WriteLine("Disk subcommands");
                        Console.WriteLine("size --- gives the size of the disk");
                        Console.WriteLine("space -- give the free space available on the disk ");
                        Console.WriteLine("format - formats the disk");
                        Console.WriteLine("-h ----- to get subcommands of disk available");

                        break;
                    default:
                        Console.WriteLine("Disk Commands");
                        Console.WriteLine("Use <disk -h> for more info");
                        break;
                }
            } catch
            {
                Console.WriteLine("Disk Commands");
                Console.WriteLine("Use <disk -h> for more info");
            }
            
        }
        
    }
}
