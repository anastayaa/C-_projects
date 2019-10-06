using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex5TP3
{
    public partial class Form1 : Form
    {
        SolidBrush myBrush;
        Graphics formGraphics;
        Rectangle rectangle;

        Color color=Color.Red;

        bool isCircle = true, isRectangle = false;
        bool increment = true;

        int x =100;
        int y = 100;
        int dx;
        int dy;

        int VITESSEICREMENT = 10;

        public Form1()
        {
            InitializeComponent();
        }

        /**
         * for the font
         * **/
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        /**
         * for the form
         * **/
        private void redToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            color = Color.Red;
            this.Refresh();
        }
        private void greenToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            color = Color.Green;
            this.Refresh();
        }
        private void yellowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            color = Color.Yellow;
            this.Refresh();
        }

        /**
         * La metod on paint
         * **/
        protected override void OnPaint(PaintEventArgs e)
        {
            dx = Form1.ActiveForm.Width / 2 - x / 2;
            dy = Form1.ActiveForm.Height / 2 - y / 2;

            if (isCircle)
            {
                myBrush = new SolidBrush(color);
                formGraphics = this.CreateGraphics();
                formGraphics.FillEllipse(myBrush, new Rectangle(dx, dy, x, y));
                myBrush.Dispose();
                formGraphics.Dispose();
            }
            else if(isRectangle){
                myBrush = new SolidBrush(color);
                formGraphics = this.CreateGraphics();
                rectangle = new Rectangle(dx, dy, x, y);
                formGraphics.FillRectangle(myBrush, rectangle);
                myBrush.Dispose();
                formGraphics.Dispose();
            }

        }

      

        private void monTimer_Tick(object sender, EventArgs e)
        {
           

            if(x >= Form1.ActiveForm.Width-100 || y>=Form1.ActiveForm.Height-100)
            {
                increment = false;
            }
            else if (x <= 100 || y<=100)
            {
                increment = true;
            }
            if (increment)
            {
                x = x + VITESSEICREMENT;
                y = y + VITESSEICREMENT;
            }
            else if(!increment)
            {
                x = x - VITESSEICREMENT;
                y = y - VITESSEICREMENT;
            }
            
            this.Refresh();
        }

        private void startStopButton_Click(object sender, EventArgs e)
        {
            if (startStopButton.Text == "Start")
            {
                monTimer.Enabled = true;
                startStopButton.Text = "Stop";
            }
            else
            {
                monTimer.Enabled = false;
                startStopButton.Text = "Start";
            }
        }

        /***
         *   Pour changer la forme
         * **/
        private void cercleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isCircle = true;
            isRectangle = false;
            this.Refresh();
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isRectangle = true;
            isCircle = false;
            this.Refresh();
            /*
            this.Invalidate();  // request a delayed Repaint by the normal MessageLoop system    
            this.Update();      // forces Repaint of invalidated area 
            this.Refresh();*/
        }

        /**
         * Pour changer le vitesse
         * **/
        private void grandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VITESSEICREMENT = 30;
        }

        private void moyenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VITESSEICREMENT = 20;
        }

        private void redToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void lenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VITESSEICREMENT = 10;
        }

    }
}
