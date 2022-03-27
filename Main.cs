using System;
using System;
using System.Data;
using System.Data.SqlClient;
namespace studentmanagementsystem
{


    public class MainClass
    {
        static void Main()
        {
            UserInterface sd = new ScreenDescription();
            do
            {
                sd.showFirstScreen();
            } while (true);
        }
    }
}
