using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
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
using WPFNotepad.Models;


namespace WPFNotepad.ViewModels
{
    public class EditViewModel
    {
        public ICommand FormatCommand { get; }
        //public ICommand UndoCommand { get; }
        public ICommand WrapCommand { get; }
        public FormatModel Format { get; set; }
        public DocumentModel Document { get; set; }
        public EditViewModel(DocumentModel document)
        {
            Document = document;
            Format = new FormatModel();
            FormatCommand = new RelayCommand(OpenStyleDialog);
            WrapCommand = new RelayCommand(ToggleWrap);
            //UndoCommand = new RelayCommand(UndoChanged);
        }
        private void OpenStyleDialog()
        {
            var fontDialog = new FontDialog();
            fontDialog.DataContext = Format;
            fontDialog.ShowDialog();
        }

        private void ToggleWrap()
        {
            if (Format.Wrap == System.Windows.TextWrapping.Wrap)
                Format.Wrap = System.Windows.TextWrapping.NoWrap;
            else
                Format.Wrap = System.Windows.TextWrapping.Wrap;
        }
       
    }
}
