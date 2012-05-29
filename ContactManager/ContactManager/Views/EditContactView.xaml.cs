using System.Windows;
using System.Windows.Controls;
using ContactManager.Presenters;
using Microsoft.Win32;
namespace ContactManager.Views
{
    public partial class EditContactView : UserControl
    {
        public EditContactView()
        {
            InitializeComponent();
        }

        public EditContactPresenter Presenter
        {
            get { return DataContext as EditContactPresenter; }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Presenter.Save();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Presenter.Delete();
        }
        
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Presenter.Close();
        }
        
        private void SelectImage_Click(object sender, RoutedEventArgs e)
        {
            Presenter.SelectImage();
        }
        
        public string AskUserForImagePath()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            return dlg.FileName;
        }
    }
}