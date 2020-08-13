using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Media;
using System.Reflection;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualBasic;
using WPFNotepad;

namespace WPFNotepad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Undo_Click(object sender, RoutedEventArgs e)
        {
            if(text.CanUndo == true)
            {
                text.Undo();
            }    
        }

        private void Redo_Click(object sender, RoutedEventArgs e)
        {
            if (text.CanRedo == true)
            {
                text.Redo();
            }
        }

        private void Cut_Click(object sender, RoutedEventArgs e)
        {
            if (text.SelectedText != "")
                text.Cut();
        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            if (text.SelectionLength > 0)
                text.Copy();
        }

        private void Paste_Click(object sender, RoutedEventArgs e)
        {
            if(Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                if(text.SelectionLength > 0)
                {
                    text.SelectionStart = text.SelectionStart + text.SelectionLength;
                }    
            }
            text.Paste();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            text.Clear();
        }

        private void Find_Click(object sender, RoutedEventArgs e)
        {
            var openFindDialog = new FindDialog();
            openFindDialog.ShowDialog();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            text.Text = text.Text.Remove(text.SelectionStart, text.SelectionLength);
        }

        private void Selectall_Click(object sender, RoutedEventArgs e)
        {
            text.SelectAll();
        }

        
    }
}
