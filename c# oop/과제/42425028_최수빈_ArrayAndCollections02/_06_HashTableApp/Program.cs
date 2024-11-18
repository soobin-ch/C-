using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_HashTableApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Hashtable openWith = new Hashtable();
            openWith["txt"] = "notepad.exe";
            openWith["bmp"] = "paint.exe";
            openWith["dib"] = "paint.exe";

            openWith.Add("rtf", "wordpad.exe");
            openWith.Add("ppt", "powerpnt.exe");


            foreach (DictionaryEntry de in openWith)
            {
                Console.WriteLine("Key ={0}, Value = {1}", de.Key, de.Value);
                Console.WriteLine();
            }
            Console.WriteLine();

            foreach (DictionaryEntry de in openWith)
            {

                Console.WriteLine("key={0}, Value={1}", de.Key, openWith[de.Key]);
            }


        }
    }
}