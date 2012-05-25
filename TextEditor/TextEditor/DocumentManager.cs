using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using Microsoft.Win32;

namespace TextEditor
{
    public class DocumentManager
    {
        private string _currentFile;
        private RichTextBox _textBox;
        public DocumentManager(RichTextBox textBox)
        {
            _textBox = textBox;
        }

        public bool OpenDocument()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == true)
            {
                _currentFile = dlg.FileName;
                using (Stream stream = dlg.OpenFile())
                {
                    TextRange range = new TextRange(
                    _textBox.Document.ContentStart,
                    _textBox.Document.ContentEnd
                    );
                    range.Load(stream, DataFormats.Rtf);
                }
                return true;
            }
            return false;
           }

        public bool SaveDocument()
        {
            if (string.IsNullOrEmpty(_currentFile)) 
                return SaveDocumentAs();
            else
            {
                using (Stream stream =
                    new FileStream(_currentFile, FileMode.Create))
                {
                    TextRange range = new TextRange(
                    _textBox.Document.ContentStart,
                    _textBox.Document.ContentEnd
                    );
                    range.Save(stream, DataFormats.Rtf);
                }
                return true;
            }
        }

        public bool SaveDocumentAs()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == true)
            {
                _currentFile = dlg.FileName;
                return SaveDocument();
            }
            return false;
        }
    }
}