using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{   
    enum TypeOfUsers
    {
        admin,
        user
    }
    class Users
    {
        int? id;
        string name;
        string username;
        string password;
        DateTime registered;
        TypeOfUsers typeOfUsers;
        string email;

        public Users(int? id, string name, TypeOfUsers typeOfUsers)
        {
            Id = id;
            Name = name;           
            TypeOfUsers = typeOfUsers;
        }
        public Users(string name, string username, string password, DateTime registered, TypeOfUsers typeOfUsers, string email)
        {
            Name = name;
            Username = username;
            Password = password;
            Registered = registered;
            TypeOfUsers = typeOfUsers;
            Email = email;
        }

        public Users(int? id, string name, string username, string password, DateTime registered, TypeOfUsers typeOfUsers, string email)
        {
            Id = id;
            Name = name;
            Username = username;
            Password = password;
            Registered = registered;
            TypeOfUsers = typeOfUsers;
            Email = email;
        }
        public Users(int? id, string name, string username, DateTime registered, TypeOfUsers typeOfUsers, string email)
        {
            Id = id;
            Name = name;
            Username = username;
            Registered = registered;
            TypeOfUsers = typeOfUsers;
            Email = email;
        }
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
        public string Username
        {
            get => username;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    username = value;
                }
                else
                {
                    throw new ArgumentException("A név mező kitöltése kötelező!");
                }
            }
        }
        public string Password
        {
            get => password;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    password = value;
                }
                else
                {
                    throw new ArgumentException("A jelszó mező kitöltése kötelező!");
                }
            }
        }
        public DateTime Registered
        {
            get => registered;
            set => registered = value;          
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
                    throw new ArgumentException("A név mező kitöltése kötelező!");
                }
            }
        }
        internal TypeOfUsers TypeOfUsers { get => typeOfUsers; set => typeOfUsers = value; }
        public override string ToString()
        {
            return string.Format($"{Name}");
        }
    }
    
}
