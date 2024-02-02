using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Practice_Demo
{
    interface IDemo1
    {
        public int CreateTask(int a, int b);
    }

    interface IDemo2
    {
        public void DoWork();
    }

    class TestInterface : IDemo1, IDemo2
    {
        public int CreateTask(int a, int b)
        {
            return a + b;
        }
        public void DoWork()
        {
        }
    }
}
