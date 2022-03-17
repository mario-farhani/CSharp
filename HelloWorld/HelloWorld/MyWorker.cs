using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HelloWorld
{
    class MyWorker
    {
        private Thread myThread;
        private bool _threadRun = false;
        private Queue<string> _myQueue;

        public MyWorker()
        {
            _myQueue = new Queue<string>();
            myThread = new Thread(ThreadCode);
        }

        public void Start()
        {
            _threadRun = true;
            myThread.Start();
        }
        public void Stop()
        {
            _threadRun= false;
        }
        public void Send(string s)
        {
            _myQueue.Enqueue(s); //load the strinf to the queue
        }
        private void ThreadCode()
        {
            Console.WriteLine("MyWorker Thread started");

            while (_threadRun)
            {
                if (_myQueue.Count > 0) //detect if something waiting in the queue
                {
                    var Message = _myQueue.Dequeue(); //get the message out of the queue
                    Console.WriteLine($"MyWorker Message = {Message} ");
                }
            }

            Console.WriteLine("MyWorker is finished");
        }
    }
}
