using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        private Tamagotchi Tom;
        private DateTime started;
        
        public Form1()
        {
            InitializeComponent();
            Tom = new Tamagotchi("Tom", 70, 85, 5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //Tom.Satiety += 100;
            label1.Text = Tom.Name + " " + Tom.Satiety + " " + Tom.Mood;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Milk m = new Milk();
            m.Energy = 2;
            Tom.eat(m);
            button1_Click(sender, e);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Orange o = new Orange();
            o.Energy = 1;
            Tom.eat(o);
            button1_Click(sender, e);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DrowingGame dg = new DrowingGame(this);
            dg.Show();
            started = new DateTime();
            started = DateTime.Now;
            this.Hide();
        }

        public DateTime GameTimeClosed { get; set; } 
    }
}
