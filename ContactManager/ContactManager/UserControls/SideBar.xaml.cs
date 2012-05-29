using System.Windows;
using System.Windows.Controls;
using ContactManager.Presenters;

namespace ContactManager.UserControls
{
    public partial class SideBar : UserControl
    {
        public SideBar()
        {
            InitializeComponent();
        }

        public ApplicationPresenter Presenter
        {
            get { return DataContext as ApplicationPresenter; }
        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            Presenter.NewContact();
        }

        private void ViewAll_Click(object sender, RoutedEventArgs e)
        {
            Presenter.DisplayAllContacts();
        }
    }
}