using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Person
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        string firstname;

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        string lastname;

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        string dob;

        public string Dob
        {
            get { return dob; }
            set { dob = value; }
        }
        string position;

        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        string catagory;

        public string Catagory
        {
            get { return catagory; }
            set { catagory = value; }
        }
        string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public override string ToString()
        {
                return firstname + " " + lastname;
        }
    }
}
