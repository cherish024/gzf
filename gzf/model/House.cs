using System;
using System.Collections.Generic;
using System.Text;

namespace gzf.model
{
    public class House
    {
        private int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        private int _building_id;

        public int building_id
        {
            get { return _building_id; }
            set { _building_id = value; }
        }
        private int _floor;

        public int floor
        {
            get { return _floor; }
            set { _floor = value; }
        }
        private int _status;

        public int status
        {
            get { return _status; }
            set { _status = value; }
        }
        private int _price;

        public int price
        {
            get { return _price; }
            set { _price = value; }
        }
        private string _sn;

        public string sn
        {
            get { return _sn; }
            set { _sn = value; }
        }

        private int _position;

        public int Position
        {
            get { return _position; }
            set { _position = value; }
        }

        private int _sortnum;

        public int Sortnum
        {
            get { return _sortnum; }
            set { _sortnum = value; }
        }

        private int _guestnum;

        public int Guestnum
        {
            get { return _guestnum; }
            set { _guestnum = value; }
        }

        private int _leftpos;

        public int Leftpos
        {
            get { return _leftpos; }
            set { _leftpos = value; }
        }


        //public HouseStatus houseStatus = new HouseStatus(status);
    }
}
