using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    class Contact
    {
        #region DataMembers
        int? id;
        int? partnerId;
        string name;
        string phoneNumber;
        string email;
        string title;
        #endregion
        #region Konstruktor
        public Contact(int? id, int? partnerId, string name, string phoneNumber, string email, string title)
        {
            Id = id;
            PartnerId = partnerId;
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
            Title = title;
        }
        public Contact(int? partnerId, string name, string phoneNumber, string email, string title)
        {
            PartnerId = partnerId;
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
            Title = title;
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
        public int? PartnerId
        {
            get => partnerId;
            set
            {
                if (partnerId == null)
                {
                    partnerId = value;
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
                    throw new ArgumentException("Az név mező kitöltése kötelező!");
                }
            }           
        }
        public string PhoneNumber 
        { 
            get => phoneNumber;
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    phoneNumber = value;
                }
                else
                {
                    throw new ArgumentException("A telefonszám mező kitöltése kötelező!");
                }
            }
        }
        public string Email 
        { 
            get => email;
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    email = value;
                }
                else
                {
                    throw new ArgumentException("Az e-mail mező kitöltése kötelező!");
                }
            }
        }
        public string Title { get => title; set => title = value; }
        #endregion
    }
}
