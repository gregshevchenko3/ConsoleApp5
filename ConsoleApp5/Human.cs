using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
        public enum Gender
        {
            UNDEFINE,
            FEMALE,
            MALE
        }

        [Serializable]
        public abstract class Human
        {
            private string _name;
            private string _surname;
            private DateTime _birthDate;
            private Gender _gender;

            public string getName()
            {
                return this._name;
            }

            public string Name
            {
                get
                {
                    return _name;
                }
                set
                {
                    if (value.Length >= 3)
                    {
                        _name = value;
                    }
                    else
                    {
                        throw new ArgumentException("указанное имя не корректно");
                    }
                }
            }
            public string Surname
            {
                get
                {
                    return _surname;
                }
                set
                {
                    if (value.Length >= 3)
                    {
                        _surname = value;
                    }
                    else
                    {
                        throw new ArgumentException("указанное фамилия не корректна");
                    }
                }
            }
            public Gender Gender
            {
                get
                {
                    return _gender;
                }
                set
                {
                    if (Enum.IsDefined(typeof(Gender), value))
                    {
                        _gender = value;
                    }
                }
            }
            public DateTime BirthDate
            {
                get
                {
                    return _birthDate;
                }
                set
                {
                    if (value > DateTime.Now)
                    {
                        throw new ArgumentException("Человек из будущего");
                    }
                    else
                    {
                        _birthDate = value;
                    }
                }
            }
            public Human()
            {
                Name = "Human-name";
                Surname = "Human-surname";
                BirthDate = DateTime.Now;
                Gender = Gender.UNDEFINE;
            }
            public Human(string name, string surname, DateTime birthDate, Gender gender)
            {
                Name = name;
                Surname = surname;
                BirthDate = birthDate;
                this.Gender = gender;
            }
            public override string ToString()
            {
                return  $"\n\tName: {Name};" +
                        $"\n\tSurname: {Surname};" +
                        $"\n\tBirth Date: {BirthDate.ToShortDateString()};" +
                        $"\n\tGender: {Gender}";
            }
        }
    }