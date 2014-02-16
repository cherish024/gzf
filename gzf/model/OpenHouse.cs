using System;
using System.Collections.Generic;
using System.Text;

namespace gzf.model
{
    public class OpenHouse
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private int _building_id;

        public int Building_id
        {
            get { return _building_id; }
            set { _building_id = value; }
        }
        private int _house_id;

        public int House_id
        {
            get { return _house_id; }
            set { _house_id = value; }
        }
        private int _main_guest_id;

        public int Main_guest_id
        {
            get { return _main_guest_id; }
            set { _main_guest_id = value; }
        }
        private DateTime _start_time;

        public DateTime Start_time
        {
            get { return _start_time; }
            set { _start_time = value; }
        }
        private DateTime _end_time;

        public DateTime End_time
        {
            get { return _end_time; }
            set { _end_time = value; }
        }
        private int _guest_num;

        public int Guest_num
        {
            get { return _guest_num; }
            set { _guest_num = value; }
        }
        private int _price;

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
        private int _deposit;

        public int Deposit
        {
            get { return _deposit; }
            set { _deposit = value; }
        }
        private int _user_id;

        public int User_id
        {
            get { return _user_id; }
            set { _user_id = value; }
        }
        private string _guest_array;

        public string Guest_array
        {
            get { return _guest_array; }
            set { _guest_array = value; }
        }
        private DateTime _addtime;

        public DateTime Addtime
        {
            get { return _addtime; }
            set { _addtime = value; }
        }
        private int _is_jiezhang;

        public int Is_jiezhang
        {
            get { return _is_jiezhang; }
            set { _is_jiezhang = value; }
        }

        private int _is_team;

        public int Is_team
        {
            get { return _is_team; }
            set { _is_team = value; }
        }

        private string _house_sn;

        public string House_sn
        {
            get { return _house_sn; }
            set { _house_sn = value; }
        }

        private int _kind;

        public int Kind
        {
            get { return _kind; }
            set { _kind = value; }
        }
    }
}
