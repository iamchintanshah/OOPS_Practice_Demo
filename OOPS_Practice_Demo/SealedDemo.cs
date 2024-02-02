using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Practice_Demo
{
    public sealed class Singleton // Sealed class can't be inheirted.
    {
        private static readonly Singleton instance = new Singleton();
        private Singleton() // Can't create instance of Singleton class due to protection level with Private Keyword
        {
        }

        public static Singleton Instance
        {
            get { return instance;  }
        }

        public void SomeMethod()
        {

        }
    }
}
