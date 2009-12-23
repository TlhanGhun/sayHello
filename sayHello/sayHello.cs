using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

/* set project type to console application to test the options dialog */

namespace sayHello
{
    class sayHello
    {
        static void Main()
        {


            Options myPrefWnd = new Options();
                myPrefWnd.Show();
         
            Application.Run();
        }
    }
}
