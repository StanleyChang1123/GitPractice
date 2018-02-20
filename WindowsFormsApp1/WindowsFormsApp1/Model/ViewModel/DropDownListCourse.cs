using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class DropDownListCourse
    {
        private string dataName;
        private string dataValue;

        public DropDownListCourse()
        {
        }

        public string DataName
        {
            get { return dataName; }
            set { dataName = value; }
        }

        public string DataValue
        {
            get { return dataValue; }
            set { dataValue = value; }
        }

        public override string ToString()
        {
            return dataName;
        }
    }
}
