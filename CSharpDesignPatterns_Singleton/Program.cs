using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns_Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreadSafeSingleton tss = ThreadSafeSingleton.Instance;
            ThreadSafeSingleton tss2 = ThreadSafeSingleton.Instance;
        }
    }
}
