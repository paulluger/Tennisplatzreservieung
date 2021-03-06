﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tennisplatzreservierung
{
    class User
    {
        private string firstName;
        private string lastName;
        private string email;
        private string password;
        private string salt;
        private int rank;
        private string gender;
        private string skillLevel;
        private int userID;
        private int age;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ApplicationException("Vorname ist leer!");
                else
                    firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ApplicationException("Nachname ist leer!");
                else
                    lastName = value;
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ApplicationException("E-Mail ist leer!");
                }

                if (value.Contains("@"))
                {
                    string[] splitEmail = value.Split('@');
                    if (splitEmail[2].Contains("."))
                        email = value;
                }
                else
                {
                    throw new ApplicationException("E-Mail ist nicht gültig!");
                }
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ApplicationException("Passwort ist leer!");
                }
                else
                {
                    password = CreatePasswordHash(value,Salt);
                }

            }
        }
<<<<<<< HEAD

        public string Salt { get { return salt; } set { } }

        private static string CreateSalt(int size)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[size];
            rng.GetBytes(buff);

            return Convert.ToBase64String(buff);

        }
=======
>>>>>>> 9c13fdfe199d75c67a5e67ea23bf6f3141829f77
        public int Rank
        {
            get { return rank; }
            set
            {
                if (value < 0 || value > 2)
                    throw new ApplicationException("Mögliche Ränge sind 0...nicht verifiziert 1...Mitglied 2...Admin!");
                else
                    rank = value;
            }
        }

        public string Gender { get { return gender; } set { } }
        public string SkillLevel { get { return skillLevel; } set { } }
        public int Age { get { return age; } set { } }
        public int UserID { get { return userID; } set { } }
        public string Salt
        {
            get { return salt; }
            set
            {
                //salt = CreateSalt(16);
            }
        }

        private static string CreatePasswordHash(string pwd, string salt)
        {
            throw new NotImplementedException();
        }

        private static string CreateSalt(int size)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[size];
            rng.GetBytes(buff);

            return Convert.ToBase64String(buff);
        }

        public User() { }
        public User(string _firstname, string _lastname, string _email, string _password, int _age, int _rank, string _gender, string _skillevel, string _salt)
        {
            FirstName = _firstname;
            LastName = _lastname;
            Email = _email;
            Password = _password;
            Age = _age;
            Rank = _rank;
            Gender = _gender;
            SkillLevel = _skillevel;
            Salt = _salt;
        }
    }
}

