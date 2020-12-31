using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Printer
{
    public interface IPrinter
    {
        void Print(string season);

    }

    public class ConsolePrinter : IPrinter
    {
        

        public void Print(string season)
        {
            Console.WriteLine(season);
        }
    }

    public class FilePrinter : IPrinter
    {
        public string fileName;

        public FilePrinter(string fileName)
        {
            this.fileName = fileName;
        }

        public void Print(string season)
        {
            using (System.IO.StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(season);
            }
        }
    }
}
