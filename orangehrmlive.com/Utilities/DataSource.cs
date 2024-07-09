using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orangehrmlive.com.Utilities
{
    public class DataSource
    {
        public static object[] ValidLoginData()
        {
            object[] dataSet1 = new object[3];
            dataSet1[0] = "admin";
            dataSet1[1] = "pass";
            dataSet1[2] = "OpenEMR";

            object[] dataSet2 = new object[3];
            dataSet2[0] = "physician";
            dataSet2[1] = "physician";
            dataSet2[2] = "OpenEMR";

            object[] allData = new object[2];
            allData[0] = dataSet1;
            allData[1] = dataSet2;

            return allData;
        }
        public static object[] InvalidLoginData()
        {
            object[] dataSet1 = new object[3];
            dataSet1[0] = "john";
            dataSet1[1] = "admin123";
            dataSet1[2] = "Invalid credentials";

            object[] dataSet2 = new object[3];
            dataSet2[0] = "Peter";
            dataSet2[1] = "admin123";
            dataSet2[2] = "Invalid credentials";

            object[] allData = new object[3];
            allData[0] = dataSet1;
            allData[1] = dataSet2;
            

            return allData;
        }
    }
}

