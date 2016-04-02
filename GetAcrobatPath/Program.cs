using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortableDevices
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var adobe = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Microsoft").OpenSubKey("Windows").OpenSubKey("CurrentVersion").OpenSubKey("App Paths").OpenSubKey("AcroRd32.exe");
            var path = adobe.GetValue("");

            Console.WriteLine(path);
        }
    }
}
