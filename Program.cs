using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("Sample.Txt",FileMode.Create,FileAccess.ReadWrite);
            for(int i = 0; i < 20; i++)
            {
                f.WriteByte((Byte)i);
            }
            f.Position = 0;
            for(int i = 0;i < 20; i++)
            {
                Console.WriteLine(f.ReadByte());
            }
            f.Close();
            Console.ReadKey();
        }
    }
}
            
