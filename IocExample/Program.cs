using IocCommon;
using System;

namespace IocExample
{
    class Program
    {
        private static IMessageSender messageSender;

        static void Main(string[] args)
        {
            messageSender = ApplicationBuilder.ApplicationBuilder.Instance.GetMessageSenderService();
            messageSender.SendMessage("Send some message");
            Console.ReadKey();
        }
    }
}
