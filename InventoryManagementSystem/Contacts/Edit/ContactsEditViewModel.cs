using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using InventoryManagementSystem.Common.Core;
using InventoryManagementSystem.DAL;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Contacts.Edit
{
    public class ContactsEditViewModel : ObservableObject, IPageViewModel
    {
        #region Fields

        //private int _productId;
        private Contact _currentContact;
        private ICommand _getModelCommand;
        private ICommand _saveContactCommand;

        #endregion

        public ContactsEditViewModel() : this(new Contact()) {  }
        public ContactsEditViewModel(Contact currentContact)
        {
            _currentContact = currentContact;
        }

        #region Properties/Commands

        public string Name
        {
            get { return "Contacts Edit"; }
        }


        //expose property to allow parent control to to set id - otherwise its a new one.



        public Contact CurrentContact
        {
            get { return _currentContact; }
            set
            {
                if (value != _currentContact)
                {
                    _currentContact = value;
                    OnPropertyChanged("CurrentContact");
                }
            }
        }

        //public ICommand GetProductCommand
        //{
        //    get
        //    {
        //        if (_getProductCommand == null)
        //        {
        //            _getProductCommand = new RelayCommand(
        //                param => GetProduct(),
        //                param => ProductId > 0
        //            );
        //        }
        //        return _getProductCommand;
        //    }
        //}

        public ICommand SaveContactCommand
        {
            get
            {
                if (_saveContactCommand == null)
                {
                    _saveContactCommand = new RelayCommand(
                        param => SaveContact()//,
                        //param => (CurrentContact != null)
                    );
                }
                return _saveContactCommand;
            }
        }

        #endregion

        #region Methods

        private void SaveContact()
        {
            var data = new ContactsData();

            if (CurrentContact.ContactID > 0)
                data.EditContact(CurrentContact);
            else
                data.CreateContact(CurrentContact);
        }

        #endregion
    }



}
