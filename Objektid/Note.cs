using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektid
{
    class Note
    {
        public string Author { get; set; }
        public string NoteText { get; set; }
        public DateTime ModificationDate { get; set; }

        public Note()
        {
            ModificationDate = DateTime.Now;
        }
    }
}
