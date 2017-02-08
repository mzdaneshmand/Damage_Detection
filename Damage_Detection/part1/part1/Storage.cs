using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part1
{
    public class Storage
    {
        private string location;
        private string type = "jpg";
        private string car = "car";

        private string[,] img = new string[6,9] {
            {"1_1","1_2", "1_3", "1_4", "1_5", "1_6", "1_7", "1_8", "1_9"},
            {"2_1","2_2", "2_3", "2_4", "2_5", "2_6", "2_7", "2_8", "2_9"},
            {"3_1","3_2", "3_3", "3_4", "3_5", "3_6", "3_7", "3_8", "3_9"},
            {"4_1","4_2", "4_3", "4_4", "4_5", "4_6", "4_7", "4_8", "4_9"},
            {"5_1","5_2", "5_3", "5_4", "5_5", "5_6", "5_7", "5_8", "5_9"},
            {"6_1","6_2", "6_3", "6_4", "6_5", "6_6", "6_7", "6_8", "6_9"}
        };

        public Storage(string location)
        {
            this.location = location;
        }

        public Storage(string location, string type)
        {
            this.location = location;
            this.type = type;
        }

        public string getLocation(int x, int y)
        {
            return location + img[x-1, y-1] + "." + type;
        }

        public string carFront()
        {
            return location + car + "." + type;
        }

        public string carFront(string type)
        {
            return location + car + "." + type;
        }

        public static bool isExist(string path)
        {
            if (File.Exists(path))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
