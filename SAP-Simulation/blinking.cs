using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAP_Simulation
{
    class blinking
       : Label
    {
        Timer timer;

        public blinking()
        {

            timer = new Timer();

            this.firstColor = Color.Blue;
            this.secondColor = Color.Red;
            this.Interval = 2000;
            this.ElabelBlinking = false;
            this.timer.Tick += new System.EventHandler(timer_tick);
        }

        void timer_tick(object sender, System.EventArgs e)
        {
            //   throw new System.NotImplementedException();

            if (this.BackColor == this.firstColor)
                this.BackColor = this.secondColor;
            else
                this.BackColor = this.firstColor;

        }



        [Category("Blinking Settings")]
        public Color firstColor { get; set; }

        [Category("Blinking Settings")]
        public Color secondColor { get; set; }

        [Category("Blinking Settings")]
        public int Interval
        {

            get {return this.timer.Interval ;}
            set {this.timer.Interval = value; }
        }

        [Category("Blinking Settings")]
        public bool ElabelBlinking
        {

            get { return this.timer.Enabled; }
            set { this.timer.Enabled = value; }
        }


    }
}
