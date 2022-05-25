using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    public class Food
    {
        public int Energy { get; set; }
         
        public virtual (int, int) toEat()
        {
            return (Energy, 0);
        }

        public static bool operator ==(Food f, Food m)
        {
            return f.GetType() == m.GetType();
        }

        public static bool operator !=(Food f, Food m)
        {
            return f.GetType() != m.GetType();
        }
    }

    public class Milk : Food 
    {
        public override (int, int) toEat() 
        {
            var a = base.toEat();
            a.Item2 = 10;
            return a;
        }
    }
    public class Fish : Food 
    {
        public override (int, int) toEat()
        {
            var a = base.toEat();
            a.Item2 = 15;
            return a; 
        }
    }
    public class Orange : Food
    {
        public override (int, int) toEat()
        {
            var a = base.toEat();
            a.Item2 = -5;
            return a; 
        }

    }

}
