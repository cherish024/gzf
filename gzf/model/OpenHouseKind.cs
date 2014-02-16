using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace gzf.model
{
    public class OpenHouseKind
    {
        private int _kind;
        private string _statustxt;
        private Hashtable _ht = new Hashtable();

        public OpenHouseKind(int kind)
        {
            _ht.Add(0, "学生房");
            _ht.Add(1, "公租房");
            _ht.Add(2, "集体宿舍");
            _ht.Add(3, "办公用房");
            _ht.Add(4, "门面房");
            _kind = kind;

            foreach (DictionaryEntry de in _ht)
            {
                if (Convert.ToInt32(de.Key) == kind)
                {
                    _statustxt = de.Value.ToString();
                }
            }
        }

        public int Kind
        {
            get { return _kind; }
        }


        public string Statustxt
        {
            get { return _statustxt; }
        }

        public Hashtable statusTable
        {
            get { return _ht; }
        }
    }
}
