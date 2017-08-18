using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.DAL
{
    public class ContactsData : DbContext
    {
        private ApplicationContext db = new ApplicationContext();

        public IEnumerable<Contact> GetAllContacts()
        {
            return db.Contact.ToList();
        }

        public void CreateContact(Contact contact)
        {
            db.Contact.Add(contact);
            db.SaveChanges();
        }

        public void EditContact(Contact contact)
        {
            var contactToUpdate = db.Contact.Find(contact.ContactID);

            contactToUpdate = contact;
            db.SaveChanges();
        }

        public void DeleteContact(int contactId)
        {
            Contact contact = db.Contact.Find(contactId);
            db.Contact.Remove(contact);
            db.SaveChanges();
        }
    }
}