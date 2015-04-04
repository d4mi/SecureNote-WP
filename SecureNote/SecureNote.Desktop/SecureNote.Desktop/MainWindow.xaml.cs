using System.Windows;
using SecureNote.Desktop.ViewModel;
using SecureNote.Desktop.Utils;
using SecureNote.DAL;

namespace SecureNote.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            DatabaseAccessor db = new DatabaseAccessor();

            Closing += (s, e) => ViewModelLocator.Cleanup();
        }
    }
}