using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d07_Adv
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoLinQ demo4 = new DemoLinQ();
            DemoLambdaCollection demo3 = new DemoLambdaCollection();
            DemoSystemDelegate demo1 = new DemoSystemDelegate();
            DemoLambda demo2 = new DemoLambda();
            demo4.Test();
            demo3.Test();
            demo1.Test();
            demo2.Test();
        }
    }
}
