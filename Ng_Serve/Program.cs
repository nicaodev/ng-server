using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ng_Serve
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] cmdAberto = Process.GetProcessesByName("cmd");
            Boolean controle = false;

            foreach (var item in cmdAberto)
            {
                controle = item.MainWindowTitle == "ng" ? true : controle;
            }
            if (!controle)
                System.Diagnostics.Process.Start(@"cmd.exe", @"/k cd D:\Users\est11396\Documents\TFS\New\SisRe\SisReWeb & ng serve");
        }
    }
}