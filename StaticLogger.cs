private static class StaticLogger
{
    private static readonly object lockObj = new object();
    public static void Log(string message)
    {
        
    }

    //Static object ve class'lar heap'in managed (high frequency) kısmında tutulur.
    //Static bir singleton class'ın release edilmesi için uygulamanın unload olması veya terminate edilmesi gerekir.
    //Singleton class'larda ise garbage collection kullanılabildiğinden memory management açısından daha verimlidir.
}