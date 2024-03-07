using System;
using System.Diagnostics;
using System.Linq;

namespace PowerShellWrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the path to the actual PowerShell executable
            string pwshPath = @"C:\Program Files\PowerShell\7\pwsh.exe";

            // Prepend -NoProfile to bypass loading profile scripts and then join the arguments into a single string, properly quoted
            string arguments = "-NoProfile " + string.Join(" ", args.Select(arg => $"\"{arg}\""));

            // Set up the process start info
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = pwshPath,
                Arguments = arguments,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true,
            };

            // Inherit the PATH environment variable
            string pathVar = Environment.GetEnvironmentVariable("PATH");
            startInfo.EnvironmentVariables["PATH"] = pathVar;

            // Start the process
            using (Process process = Process.Start(startInfo))
            {
                // Redirect standard output and standard error
                process.OutputDataReceived += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                    {
                        Console.WriteLine(e.Data);
                    }
                };
                process.ErrorDataReceived += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                    {
                        Console.Error.WriteLine(e.Data);
                    }
                };

                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                // Wait for the process to exit
                process.WaitForExit();
            }
        }
    }
}
