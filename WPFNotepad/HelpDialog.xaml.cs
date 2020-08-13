using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace WPFNotepad
{
    /// <summary>
    /// Interaction logic for HelpDialog.xaml
    /// </summary>
    public partial class HelpDialog : Window
    {
        public HelpDialog()
        {
            InitializeComponent();
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
    }
}
