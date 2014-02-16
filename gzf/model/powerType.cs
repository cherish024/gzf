using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace gzf.model
{
    public class powerType
    {
        private int _statusid;
        private string _statustxt;
        private Hashtable _ht = new Hashtable();

        public powerType(int status)
        {
            _ht.Add(0, "冷水费");
            _ht.Add(1, "电费");
            _ht.Add(2, "电视费");
            _ht.Add(3, "煤气费");
            _ht.Add(4, "热水费");
            _ht.Add(5, "门禁卡");
            _ht.Add(6, "钥匙");
            _ht.Add(7, "其他");
            _statusid = status;

            foreach (DictionaryEntry de in _ht)
            {
                if (Convert.ToInt32(de.Key) == status)
                {
                    _statustxt = de.Value.ToString();
                }
            }
        }

        public int Statusid
        {
            get { return _statusid; }
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
