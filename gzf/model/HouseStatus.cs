using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace gzf.model
{
    public class HouseStatus
    {
        private int _statusid;
        private string _statustxt;
        private Hashtable _ht = new Hashtable();
        
        public HouseStatus(int status)
        {
            _ht.Add(0, "占用房");
            _ht.Add(1, "空闲房");
            _ht.Add(2, "清洁房");
            _ht.Add(3, "厨房");
            _ht.Add(4, "维修房");
            //_ht.Add(5, "办公房");
            //_ht.Add(6, "门面房");
            //_ht.Add(7, "值班室");
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
