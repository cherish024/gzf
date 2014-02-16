using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace gzf.model
{
    public class Guest
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _idcard;

        public string Idcard
        {
            get { return _idcard; }
            set { _idcard = value; }
        }
        private DateTime _birthday;

        public DateTime Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }
        private int _sex;

        public int Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
        private string _phone;

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        private string _remark;

        public string Remark
        {
            get { return _remark; }
            set { _remark = value; }
        }

        private string _job;

        public string Job
        {
            get { return _job; }
            set { _job = value; }
        }
        private string _company;

        public string Company
        {
            get { return _company; }
            set { _company = value; }
        }

        private Image _pic;

        public Image Pic
        {
            get { return _pic; }
            set { _pic = value; }
        }

        private string _student;

        public string Student
        {
            get { return _student; }
            set { _student = value; }
        }

    }
}
