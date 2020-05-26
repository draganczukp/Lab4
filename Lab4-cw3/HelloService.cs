using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_cw3
{
    class HelloService : ServiceBase
    {
        public HelloService()
        {
            ServiceName = "HelloService";
        }

        protected override void OnStart(string[] args)
        {

        }

        protected override void OnStop()
        {
        }
    }
}
