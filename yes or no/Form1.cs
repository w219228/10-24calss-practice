using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yes_or_no
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("hi");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("您確定要刪除這筆紀錄嗎", "刪除紀錄");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			DialogResult result= MessageBox.Show("您確定要刪除這筆紀錄嗎", 
							"刪除紀錄",
							MessageBoxButtons.RetryCancel,
							MessageBoxIcon.Stop);
			if(result==DialogResult.Retry)
			{
				MessageBox.Show("你選了yes");
			}
			else
			{
				MessageBox.Show("你選了no");
			}


		}

		private void textBox10_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
