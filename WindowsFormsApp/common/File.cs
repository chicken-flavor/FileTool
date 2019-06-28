using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    class Files
    {
        public static string GetFileSizeFormat(long b)
        {
            if (b <= 0)
                return 0 + "b";
            if (b < 1024)
                return b + "b";
            if (b < 1024 * 1024)
                return b / 1024 + "k";
            if (b < 1024 * 1024 * 1024)
                return b / 1024 / 1024 + "m";
            return b / 1024 / 1024 / 1024 + "g";
        }
    }
}
