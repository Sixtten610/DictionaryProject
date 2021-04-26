using System.Collections.Generic;
using System;

namespace Index
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("HEY! Write something and index it!");
            
            while (true)
            {
                System.Console.WriteLine("Write; 'input' to add | 'read' to search | 'view' to view list");
                string text = Console.ReadLine();
                if (text == "input")
                {
                    NewIndex();
                }
                else if (text == "read")
                {
                    ReadIndex();
                }
                else if (text == "view")
                {
                    ReadList();
                }
                
                System.Console.WriteLine("\npress 'enter' to proceed");
                Console.ReadLine();
                Console.Clear();
            }

            void NewIndex()
            {
                Library library = new Library();
            }
            void ReadIndex()
            {
                System.Console.WriteLine("Write index of information:");

                string index = Console.ReadLine();
                System.Console.WriteLine("this was found under " + index + ":");
                System.Console.WriteLine(Library.List[index]);
            }
            void ReadList()
            {   
                System.Console.WriteLine("Contents:");

                if (Library.List.Count == 0)
                {
                    System.Console.WriteLine(":wow, such empty:");
                }
                else
                {
                    Dictionary<string, string>.KeyCollection indexColl = Library.List.Keys;

                    foreach(string meta in indexColl)
                    {
                        Console.WriteLine(meta);  
                    }
                }
            }
        }
    }

    class Library
    {
        static Dictionary<string, string> indexList = new Dictionary<string, string>();

        string index;
        string meta;
        public Library()
        {
            System.Console.WriteLine("Index Name:");
            index = Console.ReadLine();
            System.Console.WriteLine("Metta Text:");
            meta = Console.ReadLine();

            indexList.Add(index, meta);
        }
        static public Dictionary<string, string> List
        {
            get
            {
                return indexList;
            }
        }
    }
}
