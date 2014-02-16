using System;
using System.Collections.Generic;
using System.Text;

namespace gzf.model
{
    public class User
    {
        private int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _username;

        public string username
        {
            get { return _username; }
            set { _username = value; }
        }
        private string _password;

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
        private int _type;

        public int type
        {
            get { return _type; }
            set { _type = value; }
        }
        private string _fullname;

        public string fullname
        {
            get { return _fullname; }
            set { _fullname = value; }
        }

    }
}
