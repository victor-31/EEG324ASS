using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Oracleconnection
    {
        private string _openingOracleconnection;
        private string _closingOracleconnection;



        //two parameter constructor
        public Oracleconnection(string b1, string b2)
        {
            _openingOracleconnection = b1;
            _closingOracleconnection = b2;
        }

        public string openingOracleconnection
        {
            get
            {
                return openingOracleconnection;
            }
        }

        public string closingOracleconnection
        {
            get
            {
                return closingOracleconnection;
            }
        }
    }
}
