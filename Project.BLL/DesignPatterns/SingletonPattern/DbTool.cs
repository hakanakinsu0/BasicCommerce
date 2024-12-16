using Project.DAL.ContextClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.SingletonPattern
{
    public class DbTool
    {
        DbTool() { }

        static MyContext _dbInstace;

        public static MyContext DbInstace
        {
            get
            {
                if (_dbInstace == null) _dbInstace = new MyContext();
                return _dbInstace;
            }
        }
    }
}
