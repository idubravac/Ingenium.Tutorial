using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AI.Models;

namespace AI
{
    class Program
    {
        static void Main(string[] args)
        {
            Human me = new Human(new DateTime(1982, 11, 29), null, "Ivan", "Dubravac", Helpers.Gender.Male, (decimal)180, (decimal)100, "12345678910111213", "220212345678","09912579555", "idubravac@ingeniumweb.com", Helpers.Color.Brown, Helpers.Color.Blue, "Johnny");
            Human myWife = new Human(new DateTime(1982, 01, 27), null, "Slađana", "Dubravac", Helpers.Gender.Male, (decimal)155, (decimal)50, "123123123213123", "3213123123123", "09912579555", "sladana@ingeniumweb.com");
            me.AddRelationship(myWife, false, true);

            me.Talk("I am " + me.Age + " old");
            me.Talk("My wife is " + me.Relationships[0].Person.Age + " old");

            Human child = new Human(null, null, "Ivano", "Golubović", Helpers.Gender.Male, new decimal(50), new decimal(3.6), "", "", "", "");
            Human father = new Human(new DateTime(1995, 3, 2), null, "Josip", "Golubović", Helpers.Gender.Male, new decimal(185), new decimal(87), "123456123456", "1995220212345", "+385996955395", "josip.golubovic@gmail.com");
            Human mother = new Human(new DateTime(1994, 12, 2), null, "Martina", "Golubović", Helpers.Gender.Female, new decimal(175), new decimal(75), "12223456123456", "1995212320212345", "+385996545395", "martina.golubovic@gmail.com");
            father.AddRelationship(mother, false, true);
            mother.AddRelationship(father, false, true);
            father.AddRelationship(child, false, false, true);
            mother.AddRelationship(child, false, false, true);

            child.AddRelationship(father, true);
            child.AddRelationship(mother, true);

            Console.WriteLine(father.Relationships[0].IsChild);
            Console.WriteLine(child.Relationships[0].IsChild);
            Console.WriteLine(child.Relationships[1].IsParent);
        }
    }

    /// <summary>
    /// To je obična klasa
    /// </summary>
    public class Test
    {
        public Test()
        {
        }

        public Test(int a, int b)
        {
            //this.Result = a + b;
            SetResult(a, b);
        }

        int result = 0;

        private void SetResult(int a, int b)
        {
            result = a + b;
        }

        /// <summary>
        /// Get restul
        /// </summary>
        /// <returns>int</returns>
        public int GetResult()
        {
            return result;
        }

        //public int Result { get; set; }

        public  void PrintResult()
        {
            Console.WriteLine("Rusult is following" + this.GetResult());
        }
    }
}
