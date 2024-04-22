using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230105
{
    public partial class Form1 : Form
    {
        int imageIdx=0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            imageIdx++;
            if (imageIdx >= imageList1.Images.Count) imageIdx = 0;
            pictureBox1.Image=imageList1.Images[imageIdx];
            pictureBox1.Left -= 5;
            if(pictureBox1.Left < 0) pictureBox1.Left = this.Width;

        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = 100 - hScrollBar1.Value;
        }
    }
}
