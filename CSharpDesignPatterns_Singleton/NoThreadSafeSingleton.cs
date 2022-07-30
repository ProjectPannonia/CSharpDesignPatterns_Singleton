namespace CSharpDesignPatterns_Singleton
{
    // Non thead safe singleton example
    public sealed class NoThreadSafeSingleton
    {

        private static NoThreadSafeSingleton instance = null;

        // Private constructor -> Can't instantiated directly
        private NoThreadSafeSingleton() { }

        public static NoThreadSafeSingleton Instance
        {
            get
            {
                if(instance == null)
                    instance = new NoThreadSafeSingleton();
             
                return instance;
            }


        }
        



    }
}
