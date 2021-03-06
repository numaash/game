using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    public class Tamagotchi
    {
        private int sleep;
        private string name;
        private int satiety;
        private int mood;
        private int numberLife;
        private const int maxnumberLife = 9;
        private char? gender;

        public Tamagotchi(string name, int satiety, int sleep, int mood)
        {
            this.name = name;
            this.satiety = satiety;
            this.mood = mood;
            this.sleep = sleep;
            this.numberLife = maxnumberLife;
        }

        public void eat(Food f)
        {
            var a = f.toEat();
            Mood += a.Item2;
            Satiety += a.Item1; 
        }

        public void eat(Food f1, Food f2)
        {
            if ((f1 is Orange && f2 is Milk) || (f1 is Milk && f2 is Orange))
            {
                var a = f1.toEat();
                var b = f2.toEat();
                Satiety += a.Item1 + b.Item1;
                Mood += (a.Item2 + b.Item2) * 2;                
            }

            if ((f1 is Fish && f2 is Milk) || (f1 is Milk && f2 is Fish))
            {
                var a = f1.toEat();
                var b = f2.toEat();
                Satiety += a.Item1 + b.Item1;
                Mood -= (a.Item2 + b.Item2) * 2;
            }

            if ((f1 is Orange && f2 is Fish) || (f1 is Fish && f2 is Orange))
            {
                var a = f1.toEat();
                var b = f2.toEat();
                Satiety += a.Item1 + b.Item1;
                Mood += a.Item2 + b.Item2;
            }

            if (f1 == f2)
            {
                var a = f1.toEat();               
                Satiety += a.Item1 * 2;
                Mood += a.Item2 * 2;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public char? Gender {
            get 
            {
                return gender;
            }
            set
            {
                if (value is char && (value == 'M' || value == 'F'))
                    gender = value;
            }
        }
        public int Satiety
        {
            get
            {
                return satiety;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    satiety = value;
                }
                else if (value > 100)
                {
                    satiety = 100;
                }
                else
                {
                    satiety = 0;
                }
            }
        }
        public int Sleep
        {
            get
            {
                return sleep;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    sleep = value;
                }
                else if (value > 100)
                {
                    sleep = 100;
                }
                else
                {
                    sleep = 0;
                }
            }
        }
        public int NumberLife
        {
            get
            {
                return numberLife;
            }
            set
            {
                if (value >= 0 && value <= maxnumberLife)
                {
                    numberLife = value;
                }
                else if (value > maxnumberLife)
                {
                    numberLife = maxnumberLife;
                }
                else
                {
                    numberLife = 0;
                }
            }
        }
        public int Mood
        {
            get
            {
                return mood;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    mood = value;
                }
                else if (value > 100)
                {
                    mood = 100;
                }
                else
                {
                    mood = 0;
                }
            }
        }
    }


}
