namespace 問候
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
			this.label1 = new System.Windows.Forms.Label();
			this.greetingLabel = new System.Windows.Forms.Label();
			this.NameTextbox = new System.Windows.Forms.TextBox();
			this.greetButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(30, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "姓名";
			// 
			// greetingLabel
			// 
			this.greetingLabel.AutoSize = true;
			this.greetingLabel.Font = new System.Drawing.Font("微軟正黑體", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.greetingLabel.Location = new System.Drawing.Point(68, 63);
			this.greetingLabel.Name = "greetingLabel";
			this.greetingLabel.Size = new System.Drawing.Size(128, 47);
			this.greetingLabel.TabIndex = 1;
			this.greetingLabel.Text = "label2";
			// 
			// NameTextbox
			// 
			this.NameTextbox.Location = new System.Drawing.Point(82, 26);
			this.NameTextbox.Name = "NameTextbox";
			this.NameTextbox.Size = new System.Drawing.Size(100, 22);
			this.NameTextbox.TabIndex = 2;
			this.NameTextbox.TextChanged += new System.EventHandler(this.greetButton_Click);
			// 
			// greetButton
			// 
			this.greetButton.Location = new System.Drawing.Point(95, 130);
			this.greetButton.Name = "greetButton";
			this.greetButton.Size = new System.Drawing.Size(75, 23);
			this.greetButton.TabIndex = 3;
			this.greetButton.Text = "greet";
			this.greetButton.UseVisualStyleBackColor = true;
			this.greetButton.Click += new System.EventHandler(this.greetButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(233, 165);
			this.Controls.Add(this.greetButton);
			this.Controls.Add(this.NameTextbox);
			this.Controls.Add(this.greetingLabel);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "問候";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label greetingLabel;
		private System.Windows.Forms.TextBox NameTextbox;
		private System.Windows.Forms.Button greetButton;
	}
}

