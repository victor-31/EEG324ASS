using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Sqlconnection
    {
        private string _openingSqlconnection;
        private string _closingSqlconnection;

        //two parameter constructor
        public Sqlconnection(string t1, string t2)
        {
            _openingSqlconnection = t1;
            _closingSqlconnection = t2;
        }

        public string openingSqlconnection
        {
            get
            {
                return openingSqlconnection;
            }
        }

        public string closingSqlconnection
        {
            get
            {
                return closingSqlconnection;
            }
        }
    }
}
