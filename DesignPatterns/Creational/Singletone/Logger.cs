using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    public class Logger
    {
        private static Logger? _instance;

        protected Logger()
        {
           
        }

        //We have an static Instance property that accesses our private _instance property , and all objects from this class
        //use the same instance and there is no need to create a new instance for each object.

        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }
                return _instance;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine($"[{DateTime.Now}] Logging : {message}");
        }
    }
}
