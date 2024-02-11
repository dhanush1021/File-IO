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
            FileStream fs = new FileStream("Sample.Txt",FileMode.Create,FileAccess.Write);
            if (fs.CanWrite)
            {
                byte[] buffer = Encoding.Default.GetBytes("My Name Is Dhanush");
                fs.Write(buffer, 0, buffer.Length);
            }
            fs.Close();
        }
    }
}
            
