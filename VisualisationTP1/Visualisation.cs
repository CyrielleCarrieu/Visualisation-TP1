using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsControlLibrary1;

namespace VisualisationTP1
{
    public partial class Form1 : Form
    {


        private UserControl1 myUserControl1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myUserControl1 = new UserControl1();
            myUserControl1.Location = new Point(10, 10);
            myUserControl1.Size = new Size(200, 20);
            this.Controls.Add(myUserControl1);
        }
    }
}
