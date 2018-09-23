using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Methods
    {
        public static string Return(string path, char toRemoveAfter)
        {
            var pathArr = path.ToCharArray();
            var index = new int();
            for (var i = pathArr.Length - 1; i > 0; i--)
            {
                if (pathArr[i] == toRemoveAfter)
                {
                    index = i;
                    i = 0;
                }
            }
            path = path.Remove(index);
            if (path.Length <= 2)
                path = path + toRemoveAfter;
            return path;
        }
    }
}
