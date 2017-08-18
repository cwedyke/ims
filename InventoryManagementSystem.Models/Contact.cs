using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Common.Core;

namespace InventoryManagementSystem.Models
{
    public class Contact : ObservableObject
    {
        #region Fields
        private int _contactId;
        private string _title;
        private string _firstName;
        private string _lastName;
        private string _companyName;
        private string _contactDisplayName;
        private string _email;
        private string _workPhone;
        private string _mobilePhone;
        private string _website;
        private ContactType _contactType;
        private string _billingName;
        private string _billingStreet1;
        private string _billingStreet2;
        private string _billingCity;
        private string _billingState;
        private string _billingZipCode;
        private string _billingCountry;
        private string _billingFax;
        private string _billingPhone;
        private string _shippingName;
        private string _shippingStreet1;
        private string _shippingStreet2;
        private string _shippingCity;
        private string _shippingState;
        private string _shippingZipCode;
        private string _shippingCountry;
        private string _shippingFax;
        private string _shippingPhone;
        private CurrencyType _currencyTypeId;
        private PaymentTermsType _paymentTermsTypeId;
        private string _facebook;
        private string _twitter;
        private string _notes;
        #endregion // Fields

        #region Properties
        public int ContactID
        {
            get
            {
                return _contactId;
            }

            set
            {
                if (value != _contactId)
                {
                    _contactId = value;
                    OnPropertyChanged("ContactID");
                }
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                if (value != _title)
                {
                    _title = value;
                    OnPropertyChanged("Title");
                }
            }
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                if (value != _firstName)
                {
                    _firstName = value;
                    OnPropertyChanged("FirstName");
                }
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                if (value != _lastName)
                {
                    _lastName = value;
                    OnPropertyChanged("LastName");
                }
            }
        }

        public string CompanyName
        {
            get
            {
                return _companyName;
            }

            set
            {
                if (value != _companyName)
                {
                    _companyName = value;
                    OnPropertyChanged("CompanyName");
                }
            }
        }

        public string ContactDisplayName
        {
            get
            {
                return _contactDisplayName;
            }

            set
            {
                if (value != _contactDisplayName)
                {
                    _contactDisplayName = value;
                    OnPropertyChanged("ContactDisplayName");
                }
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                if (value != _email)
                {
                    _email = value;
                    OnPropertyChanged("Email");
                }
            }
        }

        public string WorkPhone
        {
            get
            {
                return _workPhone;
            }

            set
            {
                if (value != _workPhone)
                {
                    _workPhone = value;
                    OnPropertyChanged("WorkPhone");
                }
            }
        }

        public string MobilePhone
        {
            get
            {
                return _mobilePhone;
            }

            set
            {
                if (value != _mobilePhone)
                {
                    _mobilePhone = value;
                    OnPropertyChanged("MobilePhone");
                }
            }
        }

        public string Website
        {
            get
            {
                return _website;
            }

            set
            {
                if (value != _website)
                {
                    _website = value;
                    OnPropertyChanged("Website");
                }
            }
        }

        public ContactType ContactTypeID
        {
            get
            {
                return _contactType;
            }

            set
            {
                if (value != _contactType)
                {
                    _contactType = value;
                    OnPropertyChanged("ContactType");
                }
            }
        }

        public string BillingName
        {
            get
            {
                return _billingName;
            }

            set
            {
                if (value != _billingName)
                {
                    _billingName = value;
                    OnPropertyChanged("BillingName");
                }
            }
        }

        public string BillingStreet1
        {
            get
            {
                return _billingStreet1;
            }

            set
            {
                if (value != _billingStreet1)
                {
                    _billingStreet1 = value;
                    OnPropertyChanged("BillingStreet1");
                }
            }
        }

        public string BillingStreet2
        {
            get
            {
                return _billingStreet2;
            }

            set
            {
                if (value != _billingStreet2)
                {
                    _billingStreet2 = value;
                    OnPropertyChanged("BillingStreet2");
                }
            }
        }

        public string BillingCity
        {
            get
            {
                return _billingCity;
            }

            set
            {
                if (value != _billingCity)
                {
                    _billingCity = value;
                    OnPropertyChanged("BillingCity");
                }
            }
        }

        public string BillingState
        {
            get
            {
                return _billingState;
            }

            set
            {
                if (value != _billingState)
                {
                    _billingState = value;
                    OnPropertyChanged("BillingState");
                }
            }
        }

        public string BillingZipCode
        {
            get
            {
                return _billingZipCode;
            }

            set
            {
                if (value != _billingZipCode)
                {
                    _billingZipCode = value;
                    OnPropertyChanged("BillingZipCode");
                }
            }
        }

        public string BillingCountry
        {
            get
            {
                return _billingCountry;
            }

            set
            {
                if (value != _billingCountry)
                {
                    _billingCountry = value;
                    OnPropertyChanged("BillingCountry");
                }
            }
        }

        public string BillingFax
        {
            get
            {
                return _billingFax;
            }

            set
            {
                if (value != _billingFax)
                {
                    _billingFax = value;
                    OnPropertyChanged("BillingFax");
                }
            }
        }

        public string BillingPhone
        {
            get
            {
                return _billingPhone;
            }

            set
            {
                if (value != _billingPhone)
                {
                    _billingPhone = value;
                    OnPropertyChanged("BillingPhone");
                }
            }
        }

        public string ShippingName
        {
            get
            {
                return _shippingName;
            }

            set
            {
                if (value != _shippingName)
                {
                    _shippingName = value;
                    OnPropertyChanged("ShippingName");
                }
            }
        }

        public string ShippingStreet1
        {
            get
            {
                return _shippingStreet1;
            }

            set
            {
                if (value != _shippingStreet1)
                {
                    _shippingStreet1 = value;
                    OnPropertyChanged("ShippingStreet1");
                }
            }
        }

        public string ShippingStreet2
        {
            get
            {
                return _shippingStreet2;
            }

            set
            {
                if (value != _shippingStreet2)
                {
                    _shippingStreet2 = value;
                    OnPropertyChanged("ShippingStreet2");
                }
            }
        }

        public string ShippingCity
        {
            get
            {
                return _shippingCity;
            }

            set
            {
                if (value != _shippingCity)
                {
                    _shippingCity = value;
                    OnPropertyChanged("ShippingCity");
                }
            }
        }

        public string ShippingState
        {
            get
            {
                return _shippingState;
            }

            set
            {
                if (value != _shippingState)
                {
                    _shippingState = value;
                    OnPropertyChanged("ShippingState");
                }
            }
        }

        public string ShippingZipCode
        {
            get
            {
                return _shippingZipCode;
            }

            set
            {
                if (value != _shippingZipCode)
                {
                    _shippingZipCode = value;
                    OnPropertyChanged("ShippingZipCode");
                }
            }
        }

        public string ShippingCountry
        {
            get
            {
                return _shippingCountry;
            }

            set
            {
                if (value != _shippingCountry)
                {
                    _shippingCountry = value;
                    OnPropertyChanged("ShippingCountry");
                }
            }
        }

        public string ShippingFax
        {
            get
            {
                return _shippingFax;
            }

            set
            {
                if (value != _shippingFax)
                {
                    _shippingFax = value;
                    OnPropertyChanged("ShippingFax");
                }
            }
        }

        public string ShippingPhone
        {
            get
            {
                return _shippingPhone;
            }

            set
            {
                if (value != _shippingPhone)
                {
                    _shippingPhone = value;
                    OnPropertyChanged("ShippingPhone");
                }
            }
        }

        public CurrencyType CurrencyTypeID
        {
            get
            {
                return _currencyTypeId;
            }

            set
            {
                if (value != _currencyTypeId)
                {
                    _currencyTypeId = value;
                    OnPropertyChanged("CurrencyTypeID");
                }
            }
        }

        public PaymentTermsType PaymentTermsTypeID
        {
            get
            {
                return _paymentTermsTypeId;
            }

            set
            {
                if (value != _paymentTermsTypeId)
                {
                    _paymentTermsTypeId = value;
                    OnPropertyChanged("PaymentTermsTypeID");
                }
            }
        }

        public string Facebook
        {
            get
            {
                return _facebook;
            }

            set
            {
                if (value != _facebook)
                {
                    _facebook = value;
                    OnPropertyChanged("Facebook");
                }
            }
        }

        public string Twitter
        {
            get
            {
                return _twitter;
            }

            set
            {
                if (value != _twitter)
                {
                    _twitter = value;
                    OnPropertyChanged("Twitter");
                }
            }
        }

        public string Notes
        {
            get
            {
                return _notes;
            }

            set
            {
                if (value != _notes)
                {
                    _notes = value;
                    OnPropertyChanged("Notes");
                }
            }
        }

        #endregion // Properties
    }
}
