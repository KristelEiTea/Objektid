using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektid
{
    class Program
    {
        static void Main(string[] args)
        {
            Note note1 = new Note();
            Console.WriteLine("Kes sa oled?");
            note1.Author = Console.ReadLine();
            Console.WriteLine("Mis on sinu märge?");
            note1.NoteText = Console.ReadLine();
            note1.ModificationDate = DateTime.Now;

            Note note2 = new Note();
            Console.WriteLine("Kes SA oled?");
            note2.Author = Console.ReadLine();
            Console.WriteLine("Mis on SINU märge?");
            note2.NoteText = Console.ReadLine();
            note2.ModificationDate = DateTime.Now;

            WorkNote note3 = new WorkNote();
            Console.WriteLine("Kes SA töö oled?");
            note3.Author = Console.ReadLine();
            Console.WriteLine("Mis on SINU töö märge?");
            note3.NoteText = Console.ReadLine();
            note3.ModificationDate = DateTime.Now;

            List<Note> NoteList = new List<Note>();
            NoteList.Add(note1);
            NoteList.Add(note2);
            NoteList.Add(note3);

            //var test = NoteList[0];

            foreach(Note element in NoteList)
            {
                Console.WriteLine("Author: " + element.Author);
                Console.WriteLine("Note text: " + element.NoteText);
                Console.WriteLine("Modification date is: " + element.ModificationDate);
            }

            //Console.WriteLine("Author: " + test.Author);
            //Console.WriteLine("Note text: " + test.NoteText);
            //Console.WriteLine("Modification date is: " + test.ModificationDate);

            Console.ReadKey();
        }
    }
}
