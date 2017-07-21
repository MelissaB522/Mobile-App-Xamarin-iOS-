using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace iOSDataStorage
{
    class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Contact(string name, string phone)
        {
            Name = name;
            PhoneNumber = phone;
        }

        public override string ToString()
        {
            return Name + " " + PhoneNumber;
        }
    }
}