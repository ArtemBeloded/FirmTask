using System;

namespace FirmTask
{
    public static class Printer
    {
        public static void OutputText(string text) 
        {
            Console.WriteLine(text);
        }

        public static string InputText() 
        {
            return Console.ReadLine();
        }
    }
}
