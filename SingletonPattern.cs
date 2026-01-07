using System;
namespace csharp{
    public sealed class SingletonPattern
    {
        private static SingletonPattern _instance;

        public static SingletonPattern Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SingletonPattern();
                return _instance;
            }
        }

        private SingletonPattern() { }

        public int CustomerId { get; set; }

        public void Show()
        {
            Console.WriteLine("customerId is: " + CustomerId);
        }
    }

	public class Test{
		public static void Main(){
			var obj = SingletonPattern.Instance;

			obj.CustomerId = 45;
			obj.Show();
			obj.CustomerId = 50;
			obj.Show();
			obj.CustomerId = 55;
			obj.Show();
			
		}
	}
}



