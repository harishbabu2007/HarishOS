// Made by Harish
// fileSystem Functions

using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.System.FileSystem;
using System.IO;

namespace HarishOS
{
    class FileSystem
    {

        // ls function for listing directories/folders
        public void LS(string cwd)
        {
            string[] filePaths = Directory.GetFiles(cwd);
            var drive = new DriveInfo("0");

            for (int i = 0; i < filePaths.Length; ++i)
            {
                string path = filePaths[i];
                Console.WriteLine(System.IO.Path.GetFileName(path));
            }

            foreach (var d in System.IO.Directory.GetDirectories(cwd))
            {
                var dir = new DirectoryInfo(d);
                var dirName = dir.Name;

                Console.WriteLine(dirName + " <DIR>");
            }
            Console.WriteLine("");
        }

        // cd .. function to navigate to parent directory
        public string CdDotDot(string[] str_arr)
        {
            string rv = @"";
            int len = str_arr.Length - 3;
            for (int i = 0; i <= len; i++)
            {
                rv += str_arr[i] + @"\";
            }
            return rv;
        }

        // mkdir function - creates directory
        public void MkDir(string[] str_arr, string cwd)
        {
            try
            {
                if (!Directory.Exists(cwd + str_arr[1]))
                {
                    Directory.CreateDirectory(cwd + str_arr[1]);
                    Console.WriteLine("Created directory " + str_arr[1] + " at " + cwd);
                }
                else if (Directory.Exists(str_arr[1]))
                {
                    Directory.CreateDirectory(str_arr[1]);
                    Console.WriteLine("Created directory " + str_arr[1] + " at " + cwd);
                }
                else
                {
                    Console.WriteLine("The directory " + str_arr[1] + " exists at " + cwd);
                }
            } catch
            {
                Console.WriteLine("Please give a dir name with the command");
                Console.Beep();
            }
        }

        // rmdir function - removes directory
        public void RmDir(string[] str_arr, string cwd)
        {
            try
            {
                if (Directory.Exists(cwd + str_arr[1]))
                {
                    Directory.Delete(cwd + str_arr[1], true);
                    Console.WriteLine("Deleted Directory succesfully :)");
                }
                else
                {
                    Console.WriteLine("The Specified Directory not found :(");
                    Console.Beep();
                }
            } catch
            {
                Console.WriteLine("Please give a dir name with the command");
                Console.Beep();
            }            
        }

        // cat funtion - to show contents of a file
        public void CAT(string[] str_arr, string cwd)
        {
            try
            {
                if (File.Exists(str_arr[1]))
                {
                    string text = File.ReadAllText(str_arr[1]);
                    Console.WriteLine(text);
                } else
                {
                    Console.WriteLine("The file specified does not exists :(");
                    Console.Beep();
                }
            } catch (Exception ed)
            {
                Console.WriteLine("Please specify a file name eg- cat <file_name>");
                Console.Beep();
            }
        }

        // rmfile fucntion - remove file from hard drive
        public void RmFile(string[] str_arr, string cwd)
        {
            try
            {
                if (File.Exists(str_arr[1]))
                {
                    File.Delete(str_arr[1]);
                    Console.WriteLine("File Deleted at " + str_arr[1]);
                } else
                {
                    Console.WriteLine("File not found :(");
                    Console.Beep();
                }
            } catch
            {
                Console.WriteLine("Please specify file name eg- rmfile <file_name>");
                Console.Beep();
            }
        }       

    }
}
