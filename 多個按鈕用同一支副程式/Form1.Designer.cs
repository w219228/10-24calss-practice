namespace 多個按鈕用同一支副程式
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
			this.guess01Button = new System.Windows.Forms.Button();
			this.guess02Butto = new System.Windows.Forms.Button();
			this.guess03Button = new System.Windows.Forms.Button();
			this.answerLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// guess01Button
			// 
			this.guess01Button.Font = new System.Drawing.Font("新細明體", 20F);
			this.guess01Button.Location = new System.Drawing.Point(95, 65);
			this.guess01Button.Name = "guess01Button";
			this.guess01Button.Size = new System.Drawing.Size(103, 89);
			this.guess01Button.TabIndex = 0;
			this.guess01Button.Tag = "1";
			this.guess01Button.Text = "1";
			this.guess01Button.UseVisualStyleBackColor = true;
			this.guess01Button.Click += new System.EventHandler(this.guessButton_Click);
			// 
			// guess02Butto
			// 
			this.guess02Butto.Font = new System.Drawing.Font("新細明體", 20F);
			this.guess02Butto.Location = new System.Drawing.Point(238, 65);
			this.guess02Butto.Name = "guess02Butto";
			this.guess02Butto.Size = new System.Drawing.Size(103, 89);
			this.guess02Butto.TabIndex = 1;
			this.guess02Butto.Tag = "2";
			this.guess02Butto.Text = "2";
			this.guess02Butto.UseVisualStyleBackColor = true;
			this.guess02Butto.Click += new System.EventHandler(this.guessButton_Click);
			// 
			// guess03Button
			// 
			this.guess03Button.Font = new System.Drawing.Font("新細明體", 20F);
			this.guess03Button.Location = new System.Drawing.Point(381, 65);
			this.guess03Button.Name = "guess03Button";
			this.guess03Button.Size = new System.Drawing.Size(103, 89);
			this.guess03Button.TabIndex = 2;
			this.guess03Button.Tag = "3";
			this.guess03Button.Text = "3";
			this.guess03Button.UseVisualStyleBackColor = true;
			this.guess03Button.Click += new System.EventHandler(this.guessButton_Click);
			// 
			// answerLabel
			// 
			this.answerLabel.AutoSize = true;
			this.answerLabel.Location = new System.Drawing.Point(398, 179);
			this.answerLabel.Name = "answerLabel";
			this.answerLabel.Size = new System.Drawing.Size(63, 12);
			this.answerLabel.TabIndex = 3;
			this.answerLabel.Text = "answerLabel";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(581, 248);
			this.Controls.Add(this.answerLabel);
			this.Controls.Add(this.guess03Button);
			this.Controls.Add(this.guess02Butto);
			this.Controls.Add(this.guess01Button);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button guess01Button;
		private System.Windows.Forms.Button guess02Butto;
		private System.Windows.Forms.Button guess03Button;
		private System.Windows.Forms.Label answerLabel;
	}
}

