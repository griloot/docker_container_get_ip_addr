using System;
using System.Diagnostics;

namespace script
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessStartInfo process = new ProcessStartInfo();
            process.Arguments = "docker ps";
            process.FileName = "powershell.exe";
            process.UseShellExecute = false;

            Process.Start(process);
            Thread.Sleep(5000);

            Console.Write("\r\nContainer name/id: ");
            string inputContainer = Console.ReadLine();

            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.Arguments = "docker inspect -f '{{range.NetworkSettings.Networks}}{{.IPAddress}}{{end}}' " + inputContainer;
            processStartInfo.FileName = "powershell.exe";
            processStartInfo.UseShellExecute = false;

            Console.Write("Container: " + " | " + inputContainer + " | " + " ip = ");
            Process.Start(processStartInfo);
            

            
        }
    }
}