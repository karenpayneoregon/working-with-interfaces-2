using Lesson02.Interfaces;
using Lesson02.Models;

namespace Lesson02.Classes
{
    class Helpers
    {
        public static (int identifier, Human human) Item(object sender) 
            => (((IBase)sender).Id, (Human)sender);


    }
}
