using SecureNote.Model;
using SecureNote.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.Service.Implementations
{
    public class NotesProviderStub : INotesProvider
    {
        public IEnumerable<Note> GetNotes()
        {
            List<Note> _notes = new List<Note>();
            _notes.Add(new Note { Title = "Hello world", Text = "Sample note added just for fun!" });
            _notes.Add(new Note { Title = "Note 1", Text = "Text 1: Sample note added just for fun!" });
            _notes.Add(new Note { Title = "Note 2", Text = "Text 2: Sample note added just for fun!" });
            _notes.Add(new Note { Title = "Note 3", Text = "Text 3: Sample note added just for fun!" });
            _notes.Add(new Note { Title = "Note 4", Text = "Text 4: Sample note added just for fun!" });
            _notes.Add(new Note { Title = "Note 5", Text = "Text 5: Sample note added just for fun!" });
            _notes.Add(new Note { Title = "Note 5", Text = "Text 6: Sample note added just for fun!" });

            return _notes;
        }
    }
}
