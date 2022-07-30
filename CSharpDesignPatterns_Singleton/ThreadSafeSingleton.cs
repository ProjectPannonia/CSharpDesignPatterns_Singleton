namespace CSharpDesignPatterns_Singleton
{
    // Thread safe singleton without using locks and no lazy instantiation
    public sealed class ThreadSafeSingleton
    {

        private static readonly ThreadSafeSingleton instance = new ThreadSafeSingleton();
        static ThreadSafeSingleton() { }

        private ThreadSafeSingleton() { }

        public static ThreadSafeSingleton Instance
        {
            get
            {
                return instance;
            }
        }

    }
}
