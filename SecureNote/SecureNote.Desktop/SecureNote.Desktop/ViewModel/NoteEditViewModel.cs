using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SecureNote.DAL;
using SecureNote.Desktop.Utils;
using SecureNote.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SecureNote.Desktop.ViewModel
{
    public class NoteEditViewModel : ViewModelBase
    {
        #region Fields

        private Note _note = new Note();
        private NoteTypeToString _noteTypeToString = new NoteTypeToString();
        private DatabaseUnitOfWork _database;

        #endregion

        #region Ctor

        public NoteEditViewModel(DatabaseUnitOfWork database)
        {
            _database = database;
        }

        #endregion

        #region Properties

        public string Title
        {
            get
            {
                return _note.Title;
            }
            set
            {
                if( value != _note.Title )
                {
                    _note.Title = value;
                    base.RaisePropertyChanged(() => Title);
                }
            }
        }

        public string Text
        {
            get
            {
                return _note.Text;
            }
            set
            {
                if( value != _note.Text )
                {
                    _note.Text = value;
                    RaisePropertyChanged(() => Text);
                }
            }
        }

        public List<string> NoteTypes
        {
            get
            {
                return _noteTypeToString.Values.ToList();
            }
        }

        #endregion

        #region Commands

        ICommand _addNoteCommand;

        public ICommand AddNoteCommand
        {
            get
            {
                return _addNoteCommand ??
                    (
                        _addNoteCommand = new RelayCommand(
                            () => 
                            {
                                _database.Notes.Add(_note);
                                _note = new Note();                                
                            },
                            null
                        )
                    );
            }

        }

        #endregion

    }
}
