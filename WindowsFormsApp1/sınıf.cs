using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class sınıf
    {
        private static string SA;
        public static string sa
        {
            get { return SA; }
            set { SA = value; }
        }
        private static int a;
        public static int A
        {
            get { return a; }
            set { a = value; }
        }
        private static string büyükyaz;
        public static string Büyükyaz
        {
            get
            {
                return büyükyaz;
            }
            set
            {
                büyükyaz = value.Substring(0, 1).ToUpper()+value.Substring(1).ToLower();
            }
        }






        private static string f;
        public static string F
        {
            get
            {
                return f;
            }
            set
            {
                f= value;
            }
        }









    }
}
