using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SecureNote.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SecureNote.Desktop.ViewModel
{
    public class AddDocumentViewModel : ViewModelBase
    {
        #region Fields

        private readonly IFileBrowserDialog _fileBrowserDialog;

        #endregion

        #region Ctor

        public AddDocumentViewModel(IFileBrowserDialog fileBrowserDialog)
        {
            _fileBrowserDialog = fileBrowserDialog;
        }

        #endregion

        #region Commands

        private ICommand _browseFileCommand;
        public ICommand BrowseFileCommand
        {
            get
            {
                return _browseFileCommand ??
                    (
                        new RelayCommand( 
                            () =>
                            {
                                string path = _fileBrowserDialog.Open();
                                if( path != String.Empty )
                                {

                                }
                            }
                        )
                    );
            }
        }

        #endregion
    }
}
