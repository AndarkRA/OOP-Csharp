using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks_OOP
{
    public interface ICoder
    {
        string Encode(string baseString);

        string Decode(string baseString);
    }
}
