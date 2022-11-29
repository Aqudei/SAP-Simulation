using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Reflection;



namespace SAP_Simulation
{
    public partial class Main_Form2 : Form
    {
        public Main_Form2()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Connection has been broken in the middle";
            string title = "Error";
            MessageBox.Show(message, title);
        }

        private void button1_Click(object sender, EventArgs e)
        {










        }

        private void Main_Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeshow.Text = DateTime.Now.ToLongTimeString();
            Datenow.Text = DateTime.Now.ToLongDateString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ////textBox1.Text = String.Empty();
            //textBox1.Clear();
            //textBox2.Clear();
            //textBox3.Clear();
            //textBox4.Clear();
            //textBox5.Clear();
            //textBox6.Clear();
            //textBox7.Clear();
            //textBox8.Clear();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsDigit(e.KeyChar))
            {
                if ((sender as TextBox).Text.Count(Char.IsDigit) >= 6)
                    e.Handled = true;
            }

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsDigit(e.KeyChar))
            {
                if ((sender as TextBox).Text.Count(Char.IsDigit) >= 6)
                    e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
         (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (char.IsDigit(e.KeyChar))
            {
                if ((sender as TextBox).Text.Count(Char.IsDigit) >= 12)
                //              && 
                //     (e.KeyChar = '.') > =3)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (char.IsDigit(e.KeyChar))
            {
                if ((sender as TextBox).Text.Count(Char.IsDigit) >= 12)
                    e.Handled = true;
            }

        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.oracle.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.sap.com/index.htm");
        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button7_Click(object sender, EventArgs e)
        {
            var configPane = new ConfigurationPane();
            configPane.Width = panelContainer.Width;
            configPane.Height = panelContainer.Height;
            RemoveChildren(panelContainer);
            panelContainer.Controls.Add(configPane);
        }


        private void RemoveChildren(Panel container)
        {
            for (int i = container.Controls.Count-1; i >= 0; i--)
            {
                container.Controls.Remove(container.Controls[i]);
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            var syncPane = new SyncPane();
            syncPane.Width = panelContainer.Width;
            syncPane.Height = panelContainer.Height;
            RemoveChildren(panelContainer);
            panelContainer.Controls.Add(syncPane);
        }
    }
}