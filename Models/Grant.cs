using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Grant
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

        private string formName;

        public string FormName
        {
            get { return formName; }
            set { formName = value; }
        }

        /// <summary>
        /// 上级权限ID
        /// </summary>
        private int pId;
        public int PId
        {
            get { return pId; }
            set { pId = value; }
        }
    }
}
