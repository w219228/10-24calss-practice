using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問候
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			greetingLabel.Text = string.Empty;
		}

		private void greetButton_Click(object sender, EventArgs e)
		{
			//得到輸入姓名
			string name = NameTextbox.Text;

			string message = $"Hi,{name}";

			greetingLabel.Text = message;
		}
	}
}
