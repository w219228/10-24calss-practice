using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 顯示列數
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			stasrLabel.Text=string.Empty;
		}

		private void generateButton_Click(object sender, EventArgs e)
		{
			int? rows = GetRows();

			if(rows.HasValue==false)
			{
				MessageBox.Show("請列出列數");
				return;
			}
			if(rows.Value<0)
			{
				MessageBox.Show("列數必須大於零");
				return ;
			}
			string stars = GenerateStars(rows.Value);

			resultTextbox.Text = stars;
			stasrLabel.Text = stars;
		}

		private string GenerateStars(int rows)
		{
			string result = string.Empty;
			for(int i = 1; i <=rows; i++)
			{
				result+=new string('*',i)+"\r\n";
			}
			return result;
		}

		private int? GetRows()
		{
			string input = rowsTextBox.Text;
			bool isInt = int.TryParse(input, out int rows);
			if(isInt)
			{
				return rows;
			}
			else
			{
				return null;
			}
		}
	}
}
