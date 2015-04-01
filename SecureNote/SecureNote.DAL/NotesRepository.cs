using SecureNote.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.DAL
{
    public class NotesRepository
    {
        public void Add(Note note)
        {
            _notes.Add(note);
        }

        public List<Note> GetAll()
        {
            return _notes;
        }

        private static List<Note> _notes = new List<Note>();
    }
}
