using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class RoleGrant
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int rId;

        public int RId
        {
            get { return rId; }
            set { rId = value; }
        }

        private int gId;

        public int GId
        {
            get { return gId; }
            set { gId = value; }
        }
    }
}
