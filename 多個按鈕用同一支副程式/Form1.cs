using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 多個按鈕用同一支副程式
{
	public partial class Form1 : Form
	{
		private int answer=0;
		public Form1()
		{
			InitializeComponent();
			answer = new Random().Next(1, 4);
			answerLabel.Text = answer.ToString();
			answerLabel.Visible = false;
		}

		private void guessButton_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			int tag = Convert.ToInt32(btn.Tag);

			//MessageBox.Show(tag.ToString());

			if(tag == answer)
			{
				MessageBox.Show("您答對了");
			}
			else
			{
				MessageBox.Show("您答錯了");
			}
		}
	}
}
