using System;
using System.Runtime.Remoting.Contexts;
using System.Threading;

namespace ThreadsTut
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // ExtractExecutingThread();
            // ExtractAppDomainHostingThread();
            ExtractCurrentThreadContext();
        }

        /// <summary>
        /// Получение потока, выполняющего данный метод
        /// </summary>
        public static void ExtractExecutingThread()
        {
            Thread currThread = Thread.CurrentThread;
            
            Console.WriteLine(" - ExtractExecutingThread - ");
            Console.WriteLine(currThread.Name);
            Console.WriteLine(currThread.Priority);
        }

        /// <summary>
        /// Получить AppDomain, в котором работает текущий поток
        /// </summary>
        public static void ExtractAppDomainHostingThread()
        {
            AppDomain appDomain = Thread.GetDomain();
            Console.WriteLine(appDomain.FriendlyName);
        }

        /// <summary>
        /// Получить контекст, в котором работает текущий поток
        /// </summary>
        public static void ExtractCurrentThreadContext()
        {
            Context context = Thread.CurrentContext;
            Console.WriteLine(context.ContextID);
        }
    }
}