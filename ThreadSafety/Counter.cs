using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSafety
{
    abstract class Counter
    {
        protected int count = 0;

        public abstract int Read(int threadNum);
        public abstract void Increment(int threadNum);
    }
}
