// Made By Hairsh
// Main Command Script for HarishOS

using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.System.FileSystem;
using System.IO;


namespace HarishOS
{
    class Commands
    {
        CosmosVFS vfs;
        private string cwd = @"0:\";
        private string prompt = "HarishOS";

        FileSystem fsp;
        Maths math;
        DiskCommands dc;

        // Returns Prompt String for kernel
        public string get_prompt()
        {
            return this.prompt;
        }

        // Returns the Current Working Directory for kernel
        public string get_cwd()
        {
            return this.cwd;
        }

        // Intializes Classes, FileSystem and Constants
        public void init_fs()
        {
            
            this.math = new Maths();
            this.vfs = new CosmosVFS();
            this.fsp = new FileSystem();
            this.dc = new DiskCommands();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(this.vfs);
            // vfs.Format(@"0", "FAT32", true);
        }

        // Print line Command
        public void println(string value)
        {
            Console.WriteLine(value);
        }

        // Print Command
        public void print(string value)
        {
            Console.Write(value);
        }

        // Clear function to clear display
        public void clear()
        {
            Console.Clear();
        }

        // Return empty Line
        public void Return()
        {
            println("");
        }
        

        // Main Command Parsing Fucntion
        public void ProcessCommand(string input)
        {
            char[] spliters = { ' ' };

            string[] inp_sp = input.Split(spliters);

            switch (inp_sp[0])
            {
                case "shutdown":
                    Sys.Power.Shutdown();
                    break;

                case "reboot":
                    println("Rebooting System...");
                    Sys.Power.Reboot();
                    break;

                case "clear":
                    clear();
                    break;

                case "echo":
                    try
                    {
                        for (int i=1; i<inp_sp.Length; i++)
                        {
                            print(inp_sp[i] + " ");
                        }
                    } catch { }
                    break;

                case "add":
                    math.Add();
                    break;

                case "sub":
                    math.Sub();
                    break;

                case "mul":
                    math.Mul();
                    break;

                case "div":
                    math.Div();
                    break;

                case "ls":
                    fsp.LS(this.cwd);
                    break;

                case "disk":
                    try
                    {
                        println("Command : "+ inp_sp[1]);
                        dc.ParseCommands(inp_sp, this.vfs);
                        if (inp_sp[1] == "format")
                        {
                            cwd = @"0:\";
                        }
                    } catch
                    {
                        println("please include an arrgument with disk");
                    }
                    
                    break;

                case "prompt":
                    string rv_prompt = "";                   
                    try
                    {
                        for (int i = 1; i < inp_sp.Length; i++)
                        {
                            rv_prompt += inp_sp[i];
                        }
                        this.prompt = rv_prompt;
                    }
                    catch { }
                    break;

                case "rmdir":
                    fsp.RmDir(inp_sp, cwd);
                    break;

                case "mkdir":
                    fsp.MkDir(inp_sp, cwd);
                    break;

                case "miv":
                    MIV.StartMIV(this.cwd);
                    break;

                case "cat":
                    fsp.CAT(inp_sp, cwd);
                    break;

                case "rmfile":
                    fsp.RmFile(inp_sp, cwd);
                    break;

                case "cd":
                    try
                    {
                        if (Directory.Exists(cwd + inp_sp[1]) && inp_sp[1] != "//" && inp_sp[1] != @"\\" && inp_sp[1] != @"\" && inp_sp[1] != @"/")
                        {

                            cwd += @"" + inp_sp[1] + @"\";
                        } else if (Directory.Exists(inp_sp[1]))
                        {
                            if (inp_sp[1][inp_sp[1].Length - 1] == '\\')
                            {
                                cwd = inp_sp[1];
                            } else
                            {
                                cwd = inp_sp[1] + @"\";
                            }
                        }
                        else if (inp_sp[1] == ".." && inp_sp[1] != "//" && inp_sp[1] != @"\\" && inp_sp[1] != @"\" && inp_sp[1] != @"/")
                        {
                            if (cwd != @"0:\")
                            {
                                char[] spliters_cd = { '\\' };
                                string[] dirs;
                                dirs = cwd.Split(spliters_cd);
                                this.cwd = fsp.CdDotDot(dirs);                                
                            }
                        } else
                        {
                            println("Please enter a valid dir name with the arguments");
                            Console.Beep();
                        }
                    } catch
                    {
                        println("Please use a dir name like: cd <dir_name>");
                        Console.Beep();
                    }
                    break;

                case "game":
                    SnakeGame sn = new SnakeGame();
                    sn.RunGame();
                    break;

                case "":
                    break;

                default:
                    println("Command is not recognized :(");
                    break;
            }

            Return();
        }
    }
}
