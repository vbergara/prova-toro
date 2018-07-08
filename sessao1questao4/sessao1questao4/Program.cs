using System;
using System.Threading;

namespace sessao1questao4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Tester tester = new Tester();

            Thread[] threads = new Thread[200];
            for (int i = 0; i < 200; i++)
            {
                Thread t;
                
                // Adicionando e removendo elementos intermitentemente
                if (i < 100)
                    t = new Thread(new ThreadStart(tester.TestAdd));
                else
                    t = new Thread(new ThreadStart(tester.TestRemove));
                threads[i] = t;
            }

            Console.WriteLine("Rodando threads...");
            for (int i = 0; i < 200; i++)
            {
                threads[i].Start();
            }

            //Esperando as thread completarem
            foreach (var t in threads)
                t.Join();

            var result = tester.list.SortByKey();
            Console.WriteLine("Count: " + result.Count);
            foreach (var x in result)
            {
                Console.WriteLine(x.Key + " - " + x.Value);
            }
            Console.ReadLine();
        }
    }

    public class Tester
    {
        public ToroDictionary list;
        public Random rnd = new Random();

        public Tester()
        {
            list = new ToroDictionary();
        }

        public void TestAdd()
        {
            for (int i = 0; i < 20; i++)
            {
                list.Add(rnd.Next(1, 1000), rnd.Next(1, 1000).ToString());
            }
        }

        public void TestRemove()
        {
            for (int i = 0; i < 20; i++)
            {
                list.Remove(rnd.Next(1, 1000));
            }
        }
    }


}
