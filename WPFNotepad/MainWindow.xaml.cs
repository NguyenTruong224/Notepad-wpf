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
        void HandleRequestNavigate(string URL)
        {
            Process.Start(new ProcessStartInfo(URL));
        }
        void sourceCodeHL_RequestNavigate(object sender, RoutedEventArgs e)
        {
            string navigateUri = sourceCodeLink.NavigateUri.ToString();
            HandleRequestNavigate(navigateUri);
            e.Handled = true;
        }
        private void OnMouseEnter(object sender, EventArgs e)
        {
            sourceCodeLink.TextDecorations = TextDecorations.Underline;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            sourceCodeLink.TextDecorations = null;
        }

        private void ViewHelp_Click(object sender, RoutedEventArgs e)
        {
            string helpUrl = "https://www.bing.com/search?q=nh%e1%ba%adn+tr%e1%bb%a3+gi%c3%bap+v%e1%bb%81+notepad+trong+windows+10&filters=guid:%224466414-vi-dia%22%20lang:%22vi%22&form=T00032&ocid=HelpPane-BingIA";
            HandleRequestNavigate(helpUrl);
            e.Handled = true;
        }

        private void SendFeedback_Click(object sender, RoutedEventArgs e)
        {
            string feedBackUrl = "https://mail.google.com";
            HandleRequestNavigate(feedBackUrl);
            e.Handled = true;
        }
    }
}
