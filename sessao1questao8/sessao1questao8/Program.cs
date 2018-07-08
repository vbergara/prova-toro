using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sessao1questao8
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, Person>();
            dic.Add("A", new Person { Name = "Ana", BirthDate = new DateTime(2000, 1, 1) });
            dic.Add("B", new Person { Name = "Jorge", BirthDate = new DateTime(2003, 1, 1) });
            dic.Add("C", new Person { Name = "Carlos", BirthDate = new DateTime(2003, 1, 1) });
            dic.Add("D", new Person { Name = "Roberta", BirthDate = new DateTime(2003, 1, 1) });
            dic.Add("E", new Person { Name = "Sandra", BirthDate = new DateTime(2004, 1, 1) });
            Console.WriteLine("--- Ordem original");
            foreach (var p in dic)
                Console.WriteLine(p.ToString());
            Console.WriteLine();

            var people = from d in dic
                         orderby d.Value.BirthDate descending, d.Value.Name ascending
                         select d.Value;
            Console.WriteLine("--- Ordem final");
            foreach (var p in people)
                Console.WriteLine(p.ToString());
            Console.ReadKey();
        }
    }

    class Person
    {
        public DateTime BirthDate { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return BirthDate.ToShortDateString() + " - " + Name;
        }
    }
}
