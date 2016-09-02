using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSafety
{
    class CounterUnsafe: Counter
    {
        public override int Read(int threadNum)
        {
            try
            {
            Console.WriteLine(
                "CounterUnsafe:Read:Start Resource reading (Thread={0})count:{1}", threadNum, count);
            Thread.Sleep(250);
            Console.WriteLine(
                "CounterUnsafe: Read: Stop Resource reading (Thread={0}) count:{1}", threadNum, count);
                return count;                    
            }
            finally { }
        }

        public override void Increment(int threadNum)
        {
            try
            {
                Console.WriteLine("CounterUnsafe:Increment: Start Resource writing (Thread={0} count: {1}",threadNum,count);

                int tempCount = count;
                Thread.Sleep(1000);
                tempCount++;
                count = tempCount;
                Console.WriteLine("CounterUnsafe: Increment: Stop Resource writing (Thread={0} count: {1}",threadNum,count);
            }
            finally { }
        }
    }
}
