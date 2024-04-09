using System;
using System.ServiceModel;
using WCFch_1;

namespace WCFch_1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(Service1)))
            {
                host.Open();
                Console.WriteLine("Сервис запущен.");
                Console.WriteLine("Нажмите Enter для остановки сервиса...");
                Console.ReadLine();

                host.Close();
            }
        }
    }
}

