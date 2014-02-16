using System;
using System.Collections.Generic;
using System.Text;

namespace gzf.model
{
    public class Building
    {
        private int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _type;

        public int type
        {
            get { return _type; }
            set { _type = value; }
        }

        private int _sort;

        public int Sort
        {
            get { return _sort; }
            set { _sort = value; }
        }
    }
}
