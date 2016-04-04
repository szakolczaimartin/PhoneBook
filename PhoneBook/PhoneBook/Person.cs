using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{

    struct Person
    {
        string name;
        string address;
        int age;
        string mobile;
        string type;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public string Mobile
        {
            get
            {
                return mobile;
            }

            set
            {
                mobile = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public Person(string name, string address, int age, string mobile, string type)
        {
            this.name = name;
            this.address = address;
            this.age = age;
            this.mobile = mobile;
            this.type = type;

        }


        public override string ToString()
        {
            return base.ToString() + String.Format("Name: {0}  Address: {1}  Age: {2}  Mobile: {3}  Type: {4}", Name,Address,Age,Mobile,Type);
                
        }


    }
}
