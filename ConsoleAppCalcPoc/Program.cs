using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCalcPoc
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Process p = System.Diagnostics.Process.Start("cmd.exe", "/c calc.exe && ping -t ya.ru");
        }
    }
}
