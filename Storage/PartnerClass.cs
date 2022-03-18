using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    #region Enum
    enum TypeOfPartner
    {   
        [Description("Magánszemély")]
        privatePerson,
        [Description("Cég")]
        company
    }
    #endregion
    class PartnerClass
    {
        #region DataMembers
        int? id;
        TypeOfPartner type;
        string name;
        string taxNumber;
        string billingCountry;
        string billingPostcode;
        string billingCity;
        string billingAddress;
        string deliveryCountry;
        string deliveryPostcode;
        string deliveryCity;
        string deliveryAddress;
        string web;
        string bankAccount;
        string comment;
        #endregion
        #region Konstruktorok        
        public PartnerClass(TypeOfPartner type, string name, string taxNumber, string billingCountry, string billingPostcode, string billingCity, string billingAddress, string deliveryCountry, string deliveryPostcode, string deliveryCity, string deliveryAddress, string web, string bankAccount, string comment)
        {
            Type = type;
            Name = name;
            TaxNumber = taxNumber;
            BillingCountry = billingCountry;
            BillingPostcode = billingPostcode;
            BillingCity = billingCity;
            BillingAddress = billingAddress;
            DeliveryCountry = deliveryCountry;
            DeliveryPostcode = deliveryPostcode;
            DeiveryCity = deliveryCity;
            DeliveryAddress = deliveryAddress;
            Web = web;
            BankAccount = bankAccount;
            Comment = comment;
        }
        public PartnerClass(int? id, TypeOfPartner type, string name, string taxNumber, string billingCountry, string billingPostcode, string billingCity, string billingAddress, string deliveryCountry, string deliveryPostcode, string deliveryCity, string deliveryAddress, string web, string bankAccount, string comment)
        {
            Id = id;
            Type = type;
            Name = name;
            TaxNumber = taxNumber;
            BillingCountry = billingCountry;
            BillingPostcode = billingPostcode;
            BillingCity = billingCity;
            BillingAddress = billingAddress;
            DeliveryCountry = deliveryCountry;
            DeliveryPostcode = deliveryPostcode;
            DeiveryCity = deliveryCity;
            DeliveryAddress = deliveryAddress;
            Web = web;
            BankAccount = bankAccount;
            Comment = comment;
        }
        //For company data
        public PartnerClass(string name, string taxNumber, string billingCountry, string billingPostcode, string billingCity, string billingAddress, string web, string bankAccount, string comment)
        {
            Name = name;
            TaxNumber = taxNumber;
            BillingCountry = billingCountry;
            BillingPostcode = billingPostcode;
            BillingCity = billingCity;
            BillingAddress = billingAddress;
            Web = web;
            BankAccount = bankAccount;
            Comment = comment;
        }
        public PartnerClass(int? id, string name, string taxNumber, string billingCountry, string billingPostcode, string billingCity, string billingAddress, string web, string bankAccount, string comment)
        {
            Id = id;
            Name = name;
            TaxNumber = taxNumber;
            BillingCountry = billingCountry;
            BillingPostcode = billingPostcode;
            BillingCity = billingCity;
            BillingAddress = billingAddress;
            Web = web;
            BankAccount = bankAccount;
            Comment = comment;
        }
        #endregion
        #region Property
        public int? Id
        {
            get => id;
            set
            {
                if (id == null)
                {
                    id = value;
                }
                else
                {
                    throw new InvalidOperationException("Az azonosító beállítható, de nem módosítható!");
                }
            }
        }
        public string Name 
        { 
            get => name;
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("A név mező kitöltése kötelező!");
                }
            }
        }
        public string TaxNumber { get => taxNumber; set => taxNumber = value; }
        public string BillingCountry 
        { 
            get => billingCountry;
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    billingCountry = value;
                }
                else
                {
                    throw new ArgumentException("Az ország mező kitöltése kötelező!");
                }
            }
        }
        public string BillingPostcode 
        { 
            get => billingPostcode;
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    billingPostcode = value;
                }
                else
                {
                    throw new ArgumentException("Az irányítószám mező kitöltése kötelező!");
                }
            }
        }
        public string BillingCity 
        { 
            get => billingCity;
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    billingCity = value;
                }
                else
                {
                    throw new ArgumentException("A város mező kitöltése kötelező!");
                }
            }
        }
        public string BillingAddress 
        { 
            get => billingAddress;
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    billingAddress = value;
                }
                else
                {
                    throw new ArgumentException("A cím mező kitöltése kötelező!");
                }
            } 
        }
        public string DeliveryCountry 
        { 
            get => deliveryCountry;
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    deliveryCountry = value;
                }
                else
                {
                    throw new ArgumentException("Az ország mező kitöltése kötelező!");
                }
            }
        }
        public string DeliveryPostcode 
        { 
            get => deliveryPostcode;
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    deliveryPostcode = value;
                }
                else
                {
                    throw new ArgumentException("Az irányítószám mező kitöltése kötelező!");
                }
            }
        }
        public string DeiveryCity 
        { 
            get => deliveryCity;
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    deliveryCity = value;
                }
                else
                {
                    throw new ArgumentException("A város mező kitöltése kötelező!");
                }
            }
        }
        public string DeliveryAddress 
        { 
            get => deliveryAddress;
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    deliveryAddress = value;
                }
                else
                {
                    throw new ArgumentException("A cím mező kitöltése kötelező!");
                }
            } 
        }
        public string Web { get => web; set => web = value; }
        public string BankAccount { get => bankAccount; set => bankAccount = value; }
        public string Comment { get => comment; set => comment = value; }
        internal TypeOfPartner Type { get => type; set => type = value; }
        #endregion
        #region String Override
        public override string ToString()
        {
            return string.Format ($"{deliveryCountry}\n" + 
                                  $"{deliveryPostcode} {deliveryCity}\n" + 
                                  $"{deliveryAddress} ");
        }
        #endregion
    }
}
