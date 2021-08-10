using System;
namespace SolidPrinciples.DIP
{
    public class DipExample
    {
        interface ILogger
        {
            void Log(string data);
        }

        class Logger
        {
            private ILogger _logger { get; set; }

            public Logger(ILogger logger)
            {
                this._logger = logger;
            }

            public void Log(string data)
            {
                this._logger.Log(data);
            }

        }
    }
}
