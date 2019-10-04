using System;
using System.Collections.Generic;
using System.Text;

namespace ISAM5430.Class05
{
    public class Account
    {
        private string _name;
        public readonly bool Is_Active; // field
        public bool IsActive
        {
            get; private set;
        }
        // Java, C#, C++
        public Account(string name)
        {
            // D'Morgan's Law
            // A || B == !(!A && !B)
            // A && B == !(!A || !B)
//            if (name != null && name != "")
//            if (!(name == null || name == ""))
//            if (!string.IsNullOrEmpty(name))
                Name = name;
            Is_Active = true;
            IsActive = true;
        }

        public Account(string name, bool isActive)
        {
            Name = name;
            IsActive = Is_Active = isActive;
        }

        public override string ToString()
        {
            // object 
            // default implementation of object's ToString() method.
            // return GetType().FullName; // prints out the fully-qualified type name
//            return base.ToString();
            if (IsActive)
            {
                return $"Active Account {Name}";
            }
            else
            {
                return $"Inactive Account {Name}";
            }
        }


        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (value != null && value != "")
                {
                    _name = value;
                }
            }
        }

        /*
        public string get_Name()
        {
            return _name;
        }

        public void set_Name(string value)
        {
            _name = value;
        } */
    }
}
