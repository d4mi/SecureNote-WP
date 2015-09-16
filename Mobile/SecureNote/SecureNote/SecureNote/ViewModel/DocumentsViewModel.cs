using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Microsoft.Practices.ServiceLocation;
using SecureNote.Model;
using SecureNote.Service;
using SecureNote.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SecureNote.ViewModel
{
    public class DocumentsViewModel : ViewModelBase
    {
        #region Fields

        private ObservableCollection<Document> _documents = 
            new ObservableCollection<Document>();

        private Document _selectedDocument =
            new Document();

        private IDocumentsProvider _documentsProvider;
        private INavigationService _navigationService;

        #endregion // Fields

        #region Properties

        public ObservableCollection<Document> All
        {
            get { return _documents; }
            set
            {
                if( value != _documents )
                {
                    _documents = value;
                    base.RaisePropertyChanged(() => All);
                }
            }
        }

        public Document SelectedDocument
        {
            get { return _selectedDocument; }
            set
            {
                if( value != _selectedDocument )
                {
                    _selectedDocument = value;

                    if (_selectedDocument != null )
                    {
                        var documentPreviewViewModel = 
                            ServiceLocator.Current.GetInstance<DocumentPreviewViewModel>();

                        documentPreviewViewModel.Document = _selectedDocument;

                        _navigationService.NavigateTo("DocumentPreview", documentPreviewViewModel);
                    }
                                        

                    base.RaisePropertyChanged(() => SelectedDocument);
                }
            }
        }

        #endregion // Properties

        #region Ctor

        public DocumentsViewModel(IDocumentsProvider documentsProvider,
                                  INavigationService navigationService)
        {
            if (documentsProvider == null)
                throw new ArgumentNullException("documentesProvider is null");
            if (navigationService == null)
                throw new ArgumentNullException("navigationService is null");

            _documentsProvider = documentsProvider;
            _navigationService = navigationService;
            _documents = new ObservableCollection<Document>(_documentsProvider.GetDocuments());

            SelectFirstDocument();
        }

        private void SelectFirstDocument()
        {
            if( _documents.Count > 0 )
            {
                SelectedDocument = _documents.First();
            }
        }

        #endregion

        #region Commands

        private Command<string> _itemClickedCommand;
        public Command<string> ItemClickedCommand
        {
            get
            {
                return _itemClickedCommand
                ?? (_itemClickedCommand = new Command<string>(
                    (name) => 
                    { 
                        ItemClicked();
                    }
                ));
            }
        }

        #endregion

        #region Methods

        private void ItemClicked()
        {
            
        }

        #endregion

    }
}
