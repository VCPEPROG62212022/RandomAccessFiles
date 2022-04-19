using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomAccessFile
{
    class student
    {
        private string stnumber;
        private string stname;
        private double test;
        private double assignment;
        private int recordsize;
        public int size
        {
            get { return calsize(); }
        }

        private int calsize()
        {
            recordsize = 50; // max record size
            return recordsize;
        }
        public string Stnumber
        {
            get { return stnumber; }
            set { stnumber = value; }
        }
        
        public string Stname
        {
            get { return stname; }
            set { stname = value; }
        }
        
        public double Test
        {
            get { return test; }
            set { test = value; }
        }
        
        public double Assignment
        {
            get { return assignment; }
            set { assignment = value; }
        }

        
    }
}
