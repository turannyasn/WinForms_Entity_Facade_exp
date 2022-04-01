using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Connection
    {

        public static string GetConnectionString
        {
            get { return "Server=ENTRYSRV;Database=NORTHWND;User Id=report;Password=Entry2018."; }
        }
    }
}
