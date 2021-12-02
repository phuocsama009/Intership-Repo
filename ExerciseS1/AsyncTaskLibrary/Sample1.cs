using System;
using System.Threading.Tasks;

namespace AsyncTaskLibrary
{
    public class Sample1
    {
        public async void Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(" Method 1");
                    Task.Delay(100).Wait();
                }
            });
        }

        public void Method2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" Method 2");
                Task.Delay(100).Wait();
            }
        }
    }
}
