using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class Eqp
    {
        public string name { get; set; }
        public float td;
        public float cost;

        public virtual void total_dist(float d)
        {
            td = this.td + d;
        }

 
    }


    public class Mobile : Eqp
    {
        public override void total_dist(float d)
        {
            base.total_dist(d);

        }
        public void total_cost(float now)
        {
            cost = td * now;
            Console.WriteLine(cost);
            Console.ReadKey();
        }

    }

    //class Immobile : Equipment
    //    {
    //        public override void total_dist(int n)
    //        {
    //            cost = wt * dist_moved;
    //            Console.WriteLine(cost);
    //        }
    //    }
    class Equipment
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the type of equipment: Press M for mobile and I for immobile");
            string type_of_eqp = Console.ReadLine();
            if (type_of_eqp.Equals('m') || type_of_eqp.Equals('M'))
            {
                Eqp eq = new Mobile();
                Console.WriteLine("Enter the name of equipment");
                eq.name = Console.ReadLine();
                Console.WriteLine("Enter the number of wheels");
                string wh = Console.ReadLine();
                float w = float.Parse(wh);
                eq.total_cost(w);

            }



        }
    }
}
