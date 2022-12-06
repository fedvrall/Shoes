using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes
{
    public static class Helper
    {
        public static Entities.DBModel DBContext = new Entities.DBModel();
        public static int roleID = 0;
        public static string userName = "Гость";
    }
}
