using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using InventoryManagementSystem.Common.Core;
using InventoryManagementSystem.DAL;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Contacts
{
    public class ContactsViewModel : ObservableObject, IPageViewModel
    {
        //        #region Fields

        //        private int _productId;
        //        private IPageViewModel _editContactsVM;
        private IEnumerable<Contact> _contacts;
        //        private ICommand _getProductCommand;
        //        private ICommand _saveProductCommand;

        //        #endregion

        //        #region Properties/Commands

        public string Name
        {
            get { return "Contacts"; }
        }

        public IPageViewModel EditContactsVM
        {
            get { return new Edit.ContactsEditViewModel(); }
        }

        public IEnumerable<Contact> Contacts
        {
            get
            {
                
                    var data = new ContactsData();
                    _contacts = data.GetAllContacts();
                    return _contacts;
                
            }
            private set
            {
                if (value != _contacts)
                {
                    _contacts = value;
                    OnPropertyChanged("Contacts");
                }
            }
        }

        //        public ICommand GetProductCommand
        //        {
        //            get
        //            {
        //                if (_getProductCommand == null)
        //                {
        //                    _getProductCommand = new RelayCommand(
        //                        param => GetProduct(),
        //                        param => ProductId > 0
        //                    );
        //                }
        //                return _getProductCommand;
        //            }
        //        }

        //        public ICommand SaveProductCommand
        //        {
        //            get
        //            {
        //                if (_saveProductCommand == null)
        //                {
        //                    _saveProductCommand = new RelayCommand(
        //                        param => SaveProduct(),
        //                        param => (CurrentProduct != null)
        //                    );
        //                }
        //                return _saveProductCommand;
        //            }
        //        }

        //        #endregion

        //        #region Methods

        //        private void GetProduct()
        //        {
        //            // Usually you'd get your Product from your datastore,
        //            // but for now we'll just return a new object
        //            //ContactModel p = new ContactModel();
        //            //p.ProductId = ProductId;
        //            //p.ProductName = "Test Product";
        ////p.UnitPrice = 10;
        //            CurrentProduct = p;
        //        }

        //        private void SaveProduct()
        //        {
        //            // You would implement your Product save here
        //        }

        //        #endregion
    }
}
