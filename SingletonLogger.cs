public sealed class SingletonLogger
{
    private static SingletonLogger _instance;
    private static object lockObj = new object();

    private SingletonLogger() { }


    public static SingletonLogger Instance
    {
        get
        {
            lock (lockObj)
                if (_instance is null)
                    _instance = new SingletonLogger();

            return _instance;
        }
    }

    public void Log(string message)
    {
        
    }

    //Static Singleton class hiçbir şekilde extendable değildir.
    //Fakat bu class'tan sealed keyword'ünü kaldırıp , constructor'ı protected yaparak child class oluşturup bu class'tan kalıtım alınmasını sağğlayabiliriz.
}