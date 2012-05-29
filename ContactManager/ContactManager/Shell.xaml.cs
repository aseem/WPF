using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using ContactManager.Model;
using ContactManager.Presenters;

namespace ContactManager
{
    public partial class Shell : Window
    {
        public Shell()
        {
            InitializeComponent();
            DataContext = new ApplicationPresenter(this, new ContactRepository());
        }

        public void AddTab<T>(PresenterBase<T> presenter)
        {
            TabItem newTab = null;

            for (int i = 0; i < tabs.Items.Count; i++)
            {
                TabItem existingTab = (TabItem)tabs.Items[i];

                if (existingTab.DataContext.Equals(presenter))
                {
                    tabs.Items.Remove(existingTab);
                    newTab = existingTab;
                    break;
                }
            }

            if (newTab == null)
            {
                newTab = new TabItem();

                Binding headerBinding = new Binding(presenter.TabHeaderPath);
                BindingOperations.SetBinding(
                    newTab,
                    TabItem.HeaderProperty,
                    headerBinding
                    );

                newTab.DataContext = presenter;
                newTab.Content = presenter.View;
            }

            tabs.Items.Insert(0, newTab);
            newTab.Focus();
        }

        public void RemoveTab<T>(PresenterBase<T> presenter)
        {
            for (int i = 0; i < tabs.Items.Count; i++)
            {
                TabItem item = (TabItem)tabs.Items[i];

                if (item.DataContext.Equals(presenter))
                {
                    tabs.Items.Remove(item);
                    break;
                }
            }
        }
    }
}