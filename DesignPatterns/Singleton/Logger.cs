namespace DesignPatterns.Singleton
{
    public class Logger
    {
        private static Logger _logger;

        private Logger()
        {
            
        }

        public string Message { get; set; }

        public static Logger GetInstance()
        {
            if (_logger == null)
            {
                _logger = new Logger();
            }

            return _logger;
        }
    }
}
