using System;

namespace DesignPatterns
{
    public class Singleton
    {
        private static readonly object lockPad = new object();

        Random random = new Random();
        private Singleton()
        {
            this.RandomValue = random.Next(1000);
        }
        public float RandomValue { get; set; }
        private static Singleton _instance;
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                lock (lockPad)
                {
                    _instance = new Singleton();
                }
            }

            return _instance;
        }

        public string GetName() => $"This is singleton class wwith random value is {this.RandomValue}";
    }
}