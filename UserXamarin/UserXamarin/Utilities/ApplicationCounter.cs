using Xamarin.Essentials;

namespace UserXamarin.Utilities
{
	public class ApplicationCounter
	{

        private ApplicationCounter() { }

        static readonly string key = "applicationCounter";

        private static ApplicationCounter instance = null;
        public static ApplicationCounter Instance {
            get {
                if (instance == null) {
                    instance = new ApplicationCounter();
                }
                return instance;
            }
        }

        public int Count {
            get => Preferences.Get(ApplicationCounter.key, 0);
        }


        public void clear() {
            Preferences.Set(ApplicationCounter.key, 0);
        }

        public void increment() {
            Preferences.Set(ApplicationCounter.key, Count+1);
        }
    }
}

