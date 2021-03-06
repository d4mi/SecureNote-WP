﻿using System.Windows;
using SecureNote.Desktop.ViewModel;
using SecureNote.Desktop.Utils;
using SecureNote.DAL;
using MahApps.Metro.Controls;

namespace SecureNote.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            Closing += (s, e) => ViewModelLocator.Cleanup();
        }
    }
}