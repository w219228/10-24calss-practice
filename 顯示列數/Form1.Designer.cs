namespace 顯示列數
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
			this.rowlabel = new System.Windows.Forms.Label();
			this.generateButton = new System.Windows.Forms.Button();
			this.rowsTextBox = new System.Windows.Forms.TextBox();
			this.resultTextbox = new System.Windows.Forms.TextBox();
			this.stasrLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// rowlabel
			// 
			this.rowlabel.AutoSize = true;
			this.rowlabel.Location = new System.Drawing.Point(211, 92);
			this.rowlabel.Name = "rowlabel";
			this.rowlabel.Size = new System.Drawing.Size(33, 12);
			this.rowlabel.TabIndex = 0;
			this.rowlabel.Text = "label1";
			// 
			// generateButton
			// 
			this.generateButton.Location = new System.Drawing.Point(356, 92);
			this.generateButton.Name = "generateButton";
			this.generateButton.Size = new System.Drawing.Size(75, 23);
			this.generateButton.TabIndex = 1;
			this.generateButton.Text = "顯示";
			this.generateButton.UseVisualStyleBackColor = true;
			this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
			// 
			// rowsTextBox
			// 
			this.rowsTextBox.Location = new System.Drawing.Point(250, 92);
			this.rowsTextBox.Name = "rowsTextBox";
			this.rowsTextBox.Size = new System.Drawing.Size(100, 22);
			this.rowsTextBox.TabIndex = 2;
			// 
			// resultTextbox
			// 
			this.resultTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.resultTextbox.Location = new System.Drawing.Point(213, 140);
			this.resultTextbox.Multiline = true;
			this.resultTextbox.Name = "resultTextbox";
			this.resultTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.resultTextbox.Size = new System.Drawing.Size(204, 148);
			this.resultTextbox.TabIndex = 3;
			this.resultTextbox.WordWrap = false;
			// 
			// stasrLabel
			// 
			this.stasrLabel.Location = new System.Drawing.Point(213, 310);
			this.stasrLabel.Name = "stasrLabel";
			this.stasrLabel.Size = new System.Drawing.Size(247, 100);
			this.stasrLabel.TabIndex = 4;
			this.stasrLabel.Text = "starsLabel";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(768, 408);
			this.Controls.Add(this.stasrLabel);
			this.Controls.Add(this.resultTextbox);
			this.Controls.Add(this.rowsTextBox);
			this.Controls.Add(this.generateButton);
			this.Controls.Add(this.rowlabel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label rowlabel;
		private System.Windows.Forms.Button generateButton;
		private System.Windows.Forms.TextBox rowsTextBox;
		private System.Windows.Forms.TextBox resultTextbox;
		private System.Windows.Forms.Label stasrLabel;
	}
}

