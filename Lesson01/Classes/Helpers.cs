using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson01.Interfaces;

namespace Lesson01.Classes
{
    class Helpers
    {
        public static (int identifier, IHuman human) Item(object sender) 
            => (((IBase)sender).Id, (IHuman)sender);
    }
}
