﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Contact
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public long Phonenumber { get; set; }
        public string email { get; set; }

      public override string ToString()
        {
            return $"Name: {Firstname} {Lastname}\nAddress: {Address}\nCity: {City}\nState: {State}\nZip: {Zip}\nPhone: {Phonenumber}\nEmail: {email}\n";
        }
    }
}
