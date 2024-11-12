using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D2DForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
			this.Load += Form1_Load;
        }

		private void Form1_Load(object sender, EventArgs e)
		{
			Console.WriteLine("Lero");
		}
	}
}
