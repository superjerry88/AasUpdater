using System;
using System.IO;

namespace AasUpdater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.WriteLine(Logic.CheckPathExist());
            
            Console.Read();
        }
    }

    public class Logic
    {
        public static bool CheckPathExist()
        {
           return Directory.Exists(Config.GatewayPath);
        }
    }

    public class Config
    {
        public const string GatewayPath = @"C:\AAS";
        public const string ControlPanelPath = @"C:\ControlPanel";
    }
}
