using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterClass
{
    class Section6_OOP
    {
        public static void Section6Main()
        {
            Box box = new Box(4, 5, -3);
            //box.SetLength(4);
            //box.Width = 5;
            //box.Height = -3;
            box.DisplayInfo();

            //Human mikel = new Human("Mikel", "Mikelson", "blue", 21);
            //mikel.IntroduceMyself();
        }

    }
}
