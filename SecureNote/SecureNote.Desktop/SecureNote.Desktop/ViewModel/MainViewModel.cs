using GalaSoft.MvvmLight;
using SecureNote.Desktop.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.Desktop.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        #region Fields

        private List<ViewEntry> _views = new List<ViewEntry>();

        private readonly AddDocumentViewModel _addDocumentViewModel;
        private readonly AddWebPageViewModel _addWebPageViewModel;
        private readonly NoteEditViewModel _noteEditViewModel;
        private readonly NotesCatalogViewModel _noteCatalogViewModel;
        private readonly CreditCardInfoViewModel _creditCardInfoViewModel;
        private readonly PagePasswordsViewModel _pagePasswordsViewModel;
        private readonly SettingsViewModel _settingsViewModel;
        private readonly LoginViewModel _loginViewModel;

        private ViewModelBase _currentViewModel;
        private ViewEntry _selectedView;

        #endregion

        #region Ctor

        public MainViewModel()
        {
            ViewModelLocator viewModelLocator = new ViewModelLocator();
            _addDocumentViewModel = viewModelLocator.AddDocumentViewModel;
            _addWebPageViewModel = viewModelLocator.AddWebPageViewModel;
            _noteEditViewModel = viewModelLocator.NoteEditViewModel;
            _noteCatalogViewModel = viewModelLocator.NotesCatalogViewModel;
            _creditCardInfoViewModel = viewModelLocator.CreditCardInfoViewModel;
            _pagePasswordsViewModel = viewModelLocator.PagePasswordsViewModel;
            _settingsViewModel = viewModelLocator.SettingsViewModel;
            _loginViewModel = viewModelLocator.LoginViewModel;

            _currentViewModel = _noteCatalogViewModel;

            RegisterViews();
        }

        private void RegisterViews()
        {
            _views.Add(new ViewEntry("Add note", "/Images/addNoteDark.png", _noteEditViewModel));
            _views.Add(new ViewEntry("Notes", "/Images/browseNotesDark.png", _noteCatalogViewModel));
            _views.Add(new ViewEntry("Add document", "/Images/addDocumentDark.png", _addDocumentViewModel));
            _views.Add(new ViewEntry("Documents", "/Images/browseFilesDark.png", _noteCatalogViewModel));
            _views.Add(new ViewEntry("Credit card", "/Images/creditcardDark.png", _creditCardInfoViewModel));
            _views.Add(new ViewEntry("Add password", "/Images/passwordDark.png", _addWebPageViewModel));
            _views.Add(new ViewEntry("Passwords", "/Images/browsePasswordsDark.png", _pagePasswordsViewModel));
            _views.Add(new ViewEntry("Calendar", "/Images/calendarDark.png", _pagePasswordsViewModel));
            _views.Add(new ViewEntry("Photos", "/Images/photosDark.png", _pagePasswordsViewModel));
            _views.Add(new ViewEntry("Login", "/Images/photosDark.png", _loginViewModel));
        }

        #endregion

        #region Properties

        public List<ViewEntry> Views
        {
            get
            {
                return _views;
            }

        }

        public ViewEntry SelectedView
        {
            get
            {
                return _selectedView;
            }

            set
            {
                if (_selectedView != value)
                {
                    _selectedView = value;
                    CurrentViewModel = _selectedView.ViewModelBase;
                    base.RaisePropertyChanged(() => SelectedView);
                }
            }
        }

        public ViewModelBase CurrentViewModel
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                if (_currentViewModel != value)
                {
                    _currentViewModel = value;
                    base.RaisePropertyChanged(() => CurrentViewModel);
                }
            }
        }

        #endregion

    }
}
