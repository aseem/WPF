using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace ContactManager.Model
{
    public class ContactRepository
    {
        private List<Contact> _contactStore;
        private readonly string _stateFile;
        
        public ContactRepository()
        {
            _stateFile = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "ContactManager.state"
                );
        
            Deserialize();
        }

        public void Save(Contact contact)
        {
            if (contact.Id == Guid.Empty)
                contact.Id = Guid.NewGuid();
            if (!_contactStore.Contains(contact))
                _contactStore.Add(contact);
            Serialize();
        }

        public void Delete(Contact contact)
        {
            _contactStore.Remove(contact);
            Serialize();
        }

        public List<Contact> FindByLookup(string lookupName)
        {
            IEnumerable<Contact> found =
            from c in _contactStore
            where c.LookupName.StartsWith( lookupName,
                                           StringComparison.OrdinalIgnoreCase
                                            )
            select c;
            return found.ToList();
        }

        public List<Contact> FindAll()
        {
            return new List<Contact>(_contactStore);
        }

        private void Serialize()
        {
            using (FileStream stream =File.Open(_stateFile, FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, _contactStore);
            }
        }

        private void Deserialize()
        {
            if (File.Exists(_stateFile))
            {
                using (FileStream stream =
                File.Open(_stateFile, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    _contactStore =
                    (List<Contact>)formatter.Deserialize(stream);
                }
            }
            else _contactStore = new List<Contact>();
        }
    }
}
