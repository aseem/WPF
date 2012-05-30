using System.Windows.Controls;
using ContactManager.Presenters;

namespace ContactManager.UserControls
{
    /// <summary>
    /// Interaction logic for SearchBar.xaml
    /// </summary>
    public partial class SearchBar : UserControl
    {
        public SearchBar()
        {
            InitializeComponent();
        }

        public ApplicationPresenter Presenter
        {
            get { return DataContext as ApplicationPresenter; }
        }
        private void SearchText_Changed(object sender, TextChangedEventArgs e)
        {
            Presenter.Search(searchText.Text);
        }
    }
}
