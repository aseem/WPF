using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ContactManager.Presenters;
using ContactManager.Model;
using ContactManager.Views;

namespace ContactManager.Presenters
{
    public class ContactListPresenter : PresenterBase<ContactListView>
    {
        private readonly ApplicationPresenter _applicationPresenter;

        public ContactListPresenter(ApplicationPresenter applicacationPresenter, ContactListView view)
            : base(view, "TabHeader")
        {
            _applicationPresenter = applicacationPresenter;
        }

        public string TabHeader
        {
            get { return "All Contacts"; }
        }
        
        public void Close()
        {
            _applicationPresenter.CloseTab(this);
        }
        
        public override bool Equals(object obj)
        {
            return obj != null && GetType() == obj.GetType();
        }
    }
}
