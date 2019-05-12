using IocCommon;
using System;

namespace IocExample
{
    public class MessageSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine(string.Format("MessageSender was called!"));
        }
    }
}
