using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class fileio
    {
        private int id;
        private string name;
        private int age;
        private string city;
        
        public void setid(int id)
        {
            this.id = id;
        }
        public int getid() 
        { 
            return id; 
        }
        public string getName() 
        { 
            return name; 
        }
        public int getAge() 
        { 
            return age; 
        }
        public string getCity() 
        { 
            return city; 
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setage(int age)
        {
            this.age = age;
        }
        public void setcity(string city)
        {
            this.city = city;
        }
        public fileio(int id,string name,int age, string city)
        {
            this.id=id;
            this.name = name;
            this.age = age;
            this.city = city;
        }
    }
    class fileoperations
    {
        public void writefile(string filename, List<fileio> filepo)
        {
            StreamWriter sw = new StreamWriter(filename);
            foreach(fileio file in filepo)
            {
                string filecontent = Convert.ToString(file.getid())+","+file.getName()+","+Convert.ToString(file.getAge())+","+file.getCity();
                sw.WriteLine(filecontent);
            }
            sw.Close();
        }
        public fileio readfile(string filename)
        {
            StreamReader sw = new StreamReader(filename);
            string str = sw.ReadLine();
            string[] lines = str.Split(',');
            int id = Convert.ToInt32(lines[0]);
            string name = lines[1];
            int age = Convert.ToInt32(lines[2]);
            string city = lines[3];
            sw.Close ();
            fileio file0 = new fileio(id, name, age, city);
            return file0;
        }
        public void writefile1(string filename, fileio file)
        {
            StreamWriter sw = new StreamWriter(filename);
                string filecontent = Convert.ToString(file.getid()) + "," + file.getName() + "," + Convert.ToString(file.getAge()) + "," + file.getCity();
                sw.WriteLine(filecontent);
            sw.Close();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = "Sample.txt";
            /*List<fileio> files = new List<fileio>();
            fileio file0 = new fileio(1, "Dhanush",28,"Chennai");
            fileio file1 = new fileio(2, "Sunil", 23, "Bangalore");
            fileio file2 = new fileio(3, "Arun", 25, "Pune");
            fileio file3 = new fileio(4, "Kumar", 24, "Pune");
            fileio file4 = new fileio(4, "Kumar", 24, "Pune");
            files.Add(file0);
            files.Add(file1);
            files.Add(file2);
            files.Add(file3);*/
            fileoperations fileop = new fileoperations();
            /*fileop.writefile(filename,files);
            fileop.writefile1(filename,file4);*/
            fileio file0 = fileop.readfile(filename);
            Console.WriteLine($"{file0.getid()}\n{file0.getName()}\n{file0.getAge()}\n{file0.getCity()}");
        }
    }
}
            
