using Castle.Windsor;
using IocCommon;
using System.Configuration;

namespace ApplicationBuilder
{
    public class ApplicationBuilder
    {
        private static ApplicationBuilder applicationBuilder;

        private WindsorContainer container;

        private ApplicationBuilder(string configPath)
        {
            container = new WindsorContainer(configPath);
        }

        public static ApplicationBuilder Instance
        {
            get
            {
                if (applicationBuilder == null)
                {
                    string configPath = ConfigurationManager.AppSettings["castleConfigPath"].ToString();
                    applicationBuilder = new ApplicationBuilder(configPath);
                }

                return applicationBuilder;
            }
        }

        public IMessageSender GetMessageSenderService()
        {
            return container.Resolve<IMessageSender>("messageSenderService");
        }
    }
}
