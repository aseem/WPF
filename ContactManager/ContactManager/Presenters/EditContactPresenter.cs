using ContactManager.Model;
using ContactManager.Views;

namespace ContactManager.Presenters
{
    public class EditContactPresenter : PresenterBase<EditContactView>
    {
        private readonly ApplicationPresenter _applicationPresenter;
        private readonly Contact _contact;

        public EditContactPresenter(ApplicationPresenter applicationPresenter, EditContactView view, Contact contact)
            : base(view, "Contact.LookupName")
        {
            _applicationPresenter = applicationPresenter;
            _contact = contact;
        }

        public Contact Contact
        {
            get { return _contact; }
        }

        public void SelectImage()
        {
            string imagePath = View.AskUserForImagePath();

            if (!string.IsNullOrEmpty(imagePath))
                Contact.ImagePath = imagePath;
        }

        public void Save()
        {
            _applicationPresenter.SaveContact(Contact);
        }

        public void Delete()
        {
            _applicationPresenter.CloseTab(this);
            _applicationPresenter.DeleteContact(Contact);
        }

        public void Close()
        {
            _applicationPresenter.CloseTab(this);
        }

        public override bool Equals(object obj)
        {
            EditContactPresenter presenter = obj as EditContactPresenter;
            return presenter != null && presenter.Contact.Equals(Contact);
        }
    }
}