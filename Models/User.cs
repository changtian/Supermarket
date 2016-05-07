using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class User
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string pwd;

        public string Pwd
        {
            get { return pwd; }
            set { pwd = value; }
        }

        private int rId;
        public int RId
        {
            get { return rId; }
            set { rId = value; }
        }


    }
}