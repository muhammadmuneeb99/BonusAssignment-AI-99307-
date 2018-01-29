using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI___Bonus_Assignment_std_Id_59423_
{
    public partial class Form1 : Form
    {
        int count = 0, x = 10;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox11.Location = new Point(pictureBox11.Location.X - x, pictureBox11.Location.Y);
            pictureBox12.Location = new Point(pictureBox12.Location.X - x, pictureBox12.Location.Y);
            pictureBox13.Location = new Point(pictureBox13.Location.X - x, pictureBox13.Location.Y);
            pictureBox14.Location = new Point(pictureBox14.Location.X - x, pictureBox14.Location.Y);
            pictureBox3.Location = new Point(pictureBox3.Location.X - x, pictureBox3.Location.Y);
            pictureBox4.Location = new Point(pictureBox4.Location.X - x, pictureBox4.Location.Y);
            Invalidate();
            if (pictureBox11.Location.X < 0)
            {
                pictureBox11.Location = new Point(841-x, pictureBox11.Location.Y);
            }
            if (pictureBox14.Location.X < 0)
            {
                pictureBox14.Location = new Point(841 - x, pictureBox14.Location.Y);
            }
            if (pictureBox12.Location.X < 0)
            {
                pictureBox12.Location = new Point(841 - x, pictureBox12.Location.Y);
            }
            if (pictureBox3.Location.X < 0)
            {
                pictureBox3.Location = new Point(841 - x, pictureBox3.Location.Y);
            }
            if (pictureBox4.Location.X < 0)
            {
                pictureBox4.Location = new Point(841 - x, pictureBox4.Location.Y);
            }
            if (pictureBox13.Location.X < 0)
            {
                pictureBox13.Location = new Point(841 - x, pictureBox13.Location.Y);
            }
            moveUp();
            moveDown();

        }
        public void moveUp()
        {
            if (DBox.Bounds.IntersectsWith(pictureBox13.Bounds))
            {
                DBox.Location = new Point(DBox.Location.X, DBox.Location.Y - 35 + 5 + 5);
            }
            if (DBox.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                DBox.Location = new Point(DBox.Location.X, DBox.Location.Y - 35 + 5 +5);
            }
            if (DBox.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                DBox.Location = new Point(DBox.Location.X, DBox.Location.Y - 35 + 5 + 5);
            }
        }

      

        public void moveDown()
        {
            if (DBox.Bounds.IntersectsWith(pictureBox11.Bounds))
            {
                DBox.Location = new Point(DBox.Location.X, 253 + 10 + 10);
            }
            if (DBox.Bounds.IntersectsWith(pictureBox12.Bounds))
            {
                DBox.Location = new Point(DBox.Location.X, 253 + 10 + 10);
            }
            if (DBox.Bounds.IntersectsWith(pictureBox14.Bounds))
            {
                DBox.Location = new Point(DBox.Location.X, 253 + 10 + 10);
            }
        }
        
    }
}
