﻿namespace hello_world
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.btnClick = new System.Windows.Forms.Button();
			this.greetButton = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnClick
			// 
			this.btnClick.Location = new System.Drawing.Point(33, 102);
			this.btnClick.Name = "btnClick";
			this.btnClick.Size = new System.Drawing.Size(46, 28);
			this.btnClick.TabIndex = 3;
			this.btnClick.Text = "button1";
			this.btnClick.UseVisualStyleBackColor = true;
			this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
			// 
			// greetButton
			// 
			this.greetButton.Location = new System.Drawing.Point(84, 102);
			this.greetButton.Name = "greetButton";
			this.greetButton.Size = new System.Drawing.Size(53, 28);
			this.greetButton.TabIndex = 4;
			this.greetButton.Text = "say hi";
			this.greetButton.UseVisualStyleBackColor = true;
			this.greetButton.Click += new System.EventHandler(this.greetButton_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(142, 102);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(46, 28);
			this.button1.TabIndex = 5;
			this.button1.Text = "button2";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(33, 23);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(154, 22);
			this.textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(33, 64);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(68, 22);
			this.textBox2.TabIndex = 1;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(120, 64);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(68, 22);
			this.textBox3.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.greetButton);
			this.Controls.Add(this.btnClick);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnClick;
		private System.Windows.Forms.Button greetButton;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
	}
}

