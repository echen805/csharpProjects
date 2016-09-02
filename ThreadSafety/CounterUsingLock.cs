using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSafety
{
    class CounterUsingLock : Counter
    {
        public override void Increment(int threadNum)
        {
            lock (this)
            {
                Console.WriteLine("CounterUsingLock, Increment: Start Resource writing (Thread={0}) count: {1}",threadNum,count);
                int tempCount = count;
                Thread.Sleep(1000);
                tempCount++;
                count = tempCount;
                Console.WriteLine("CounterUsingLock, Increment: Stop Resource writing (Thread={0}) count: {1}",threadNum,count);
            }
        }

        public override int Read(int threadNum)
        {
            lock (this)
            {
                Console.WriteLine("CounterUsingLock, Read: Start Resource raeding (Thread={0}) count: {1}", threadNum, count);
                Thread.Sleep(250);
                Console.WriteLine("CounterUsingLock, Read: Stop Resource reading (Thread={0}) count:{1}", threadNum, count);
                return count;
            }
        }
    }
}
