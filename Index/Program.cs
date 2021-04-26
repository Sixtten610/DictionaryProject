using System.Collections.Generic;
using System;

namespace Index
{
    class Program
    {
        static void Main(string[] args)
        {
            // kooling välkomstmeddelande:
            System.Console.WriteLine("HEY! Write something and index it!");
            
            // program:
            while (true)
            {
                // instruktioner
                System.Console.WriteLine("Write; 'input' to add | 'read' to search | 'view' to view list");
                // hämtar in svar och fortsätter med rätt klassmetod, om inte, skriv felmeddelande
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
                else
                {
                    System.Console.WriteLine("'" + text + "' does not exist as command");
                }
                
                // vänta på användaren innan skärmen rensas
                System.Console.WriteLine("\npress 'enter' to proceed");
                Console.ReadLine();
                Console.Clear();
            }

            // skapar en ny instans av klassen "Library"
            void NewIndex()
            {
                Library library = new Library();
            }
            // skriver metatext som finns under nyckeln(index) användaren angivit
            void ReadIndex()
            {
                System.Console.WriteLine("Write index of information:");

                string index = Console.ReadLine();
                System.Console.WriteLine("this was found under " + index + ":");
                // skriv metatext för index:
                System.Console.WriteLine(Library.List[index]);
            }

            // metoden skriver ut en lista på objekt i dictionary-Library.List, om inte skriver ut felmeddelande
            void ReadList()
            {   
                System.Console.WriteLine("Contents:");

                // om list har 0 index:
                if (Library.List.Count == 0)
                {
                    System.Console.WriteLine(":wow, such empty:");
                }
                // annars hämta dictionary keys från Library.List.Keys in i parametern indexColl
                else
                {
                    Dictionary<string, string>.KeyCollection indexColl = Library.List.Keys;

                    // för varje meta(meta texten i varje klass Library) skriv nyckel namn
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
        // skriver ut information && instruktioner
        public Library()
        {
            System.Console.WriteLine("Index Name:");
            index = Console.ReadLine();
            System.Console.WriteLine("Metta Text:");
            meta = Console.ReadLine();

            // lägger till instans i indexList
            indexList.Add(index, meta);
        }
        // reutrnerar indexList
        static public Dictionary<string, string> List
        {
            get
            {
                return indexList;
            }
        }
    }
}
