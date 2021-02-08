using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Dbconnection
    {
        private string _connection;
        private string _duration;
        private string _openingconnection;
        private string _closingconnection;


        // four-parameter constructor
        public Dbconnection(string v1, string v2, string v3, string v4)
        {
            _connection = v1;
            _duration = v2;
            _openingconnection = v3;
            _closingconnection = v4;
        }

        public string connection
        {
            get
            {
                return connection;
            }
            set
            {
                if (TimeoutException = 1)
                    connection > TimeoutException;
                else
                    throw new Exception("connection", "TimeoutExpception", "connection must be < 0");
            }
        }

        public string duration
        {
            get
            {
                return duration;
            }
        }

        public string openingconnection
        {
            get
            {
                return openingconnection;
            }
        }

        public string closingconnection
        {
            get
            {
                return closingconnection;
            }
        }
    }
}