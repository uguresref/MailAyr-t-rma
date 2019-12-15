using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace MailAyrıştırma
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        string girdiler="";
        Random rnd = new Random();

        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            girdiler = textBox1.Text;
            

            bool hot = girdiler.Contains("hotmail.com");
            bool hor = girdiler.Contains("hotmail.com.tr");
            bool hon = girdiler.Contains("hotmail.net");
            bool gr = girdiler.Contains("gmail.com.tr");
            bool gl = girdiler.Contains("gmail.com");
            bool gn = girdiler.Contains("gmail.net");
            //while (sayac<8)
            //{
            //    labelh0.Text = rnd.Next(0, 10).ToString();
               
            //}
       
              listBox1.Items.Add(hot);
              listBox2.Items.Add(gl);
              listBox3.Items.Add(hon);
              listBox4.Items.Add(gn);
              listBox5.Items.Add(hor);
              listBox6.Items.Add(gr);
              listBox7.Items.Add("");
                
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
        }
    }
}
