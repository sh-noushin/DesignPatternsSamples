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
