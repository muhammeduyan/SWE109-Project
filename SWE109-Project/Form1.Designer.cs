namespace SWE109_Project
{
	partial class Form1
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnRandom = new System.Windows.Forms.Button();
			this.btnDraw = new System.Windows.Forms.Button();
			this.btnRotate = new System.Windows.Forms.Button();
			this.txtCenterX = new System.Windows.Forms.TextBox();
			this.txtLength = new System.Windows.Forms.TextBox();
			this.txtEdges = new System.Windows.Forms.TextBox();
			this.txtRotation = new System.Windows.Forms.TextBox();
			this.txtCenterY = new System.Windows.Forms.TextBox();
			this.lstVertices = new System.Windows.Forms.ListBox();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(67, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Center Points";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(67, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Length";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(67, 158);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(107, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Number Of Edge";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(67, 204);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(95, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Rotation Angel";
			// 
			// btnRandom
			// 
			this.btnRandom.Location = new System.Drawing.Point(367, 343);
			this.btnRandom.Name = "btnRandom";
			this.btnRandom.Size = new System.Drawing.Size(129, 23);
			this.btnRandom.TabIndex = 4;
			this.btnRandom.Text = "Set Random Value";
			this.btnRandom.UseVisualStyleBackColor = true;
			this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click_1);
			// 
			// btnDraw
			// 
			this.btnDraw.Location = new System.Drawing.Point(367, 408);
			this.btnDraw.Name = "btnDraw";
			this.btnDraw.Size = new System.Drawing.Size(129, 23);
			this.btnDraw.TabIndex = 5;
			this.btnDraw.Text = "Draw";
			this.btnDraw.UseVisualStyleBackColor = true;
			this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click_1);
			// 
			// btnRotate
			// 
			this.btnRotate.Location = new System.Drawing.Point(367, 470);
			this.btnRotate.Name = "btnRotate";
			this.btnRotate.Size = new System.Drawing.Size(129, 23);
			this.btnRotate.TabIndex = 6;
			this.btnRotate.Text = "Rotate";
			this.btnRotate.UseVisualStyleBackColor = true;
			this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click_1);
			// 
			// txtCenterX
			// 
			this.txtCenterX.Location = new System.Drawing.Point(207, 58);
			this.txtCenterX.Name = "txtCenterX";
			this.txtCenterX.Size = new System.Drawing.Size(100, 22);
			this.txtCenterX.TabIndex = 7;
			// 
			// txtLength
			// 
			this.txtLength.Location = new System.Drawing.Point(207, 109);
			this.txtLength.Name = "txtLength";
			this.txtLength.Size = new System.Drawing.Size(100, 22);
			this.txtLength.TabIndex = 8;
			// 
			// txtEdges
			// 
			this.txtEdges.Location = new System.Drawing.Point(207, 158);
			this.txtEdges.Name = "txtEdges";
			this.txtEdges.Size = new System.Drawing.Size(100, 22);
			this.txtEdges.TabIndex = 9;
			// 
			// txtRotation
			// 
			this.txtRotation.Location = new System.Drawing.Point(207, 204);
			this.txtRotation.Name = "txtRotation";
			this.txtRotation.Size = new System.Drawing.Size(100, 22);
			this.txtRotation.TabIndex = 10;
			// 
			// txtCenterY
			// 
			this.txtCenterY.Location = new System.Drawing.Point(341, 58);
			this.txtCenterY.Name = "txtCenterY";
			this.txtCenterY.Size = new System.Drawing.Size(100, 22);
			this.txtCenterY.TabIndex = 11;
			// 
			// lstVertices
			// 
			this.lstVertices.FormattingEnabled = true;
			this.lstVertices.ItemHeight = 16;
			this.lstVertices.Location = new System.Drawing.Point(70, 265);
			this.lstVertices.Name = "lstVertices";
			this.lstVertices.Size = new System.Drawing.Size(253, 228);
			this.lstVertices.TabIndex = 12;
			// 
			// pictureBox
			// 
			this.pictureBox.Location = new System.Drawing.Point(548, 58);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(421, 435);
			this.pictureBox.TabIndex = 13;
			this.pictureBox.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1002, 546);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.lstVertices);
			this.Controls.Add(this.txtCenterY);
			this.Controls.Add(this.txtRotation);
			this.Controls.Add(this.txtEdges);
			this.Controls.Add(this.txtLength);
			this.Controls.Add(this.txtCenterX);
			this.Controls.Add(this.btnRotate);
			this.Controls.Add(this.btnDraw);
			this.Controls.Add(this.btnRandom);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnRandom;
		private System.Windows.Forms.Button btnDraw;
		private System.Windows.Forms.Button btnRotate;
		private System.Windows.Forms.TextBox txtCenterX;
		private System.Windows.Forms.TextBox txtLength;
		private System.Windows.Forms.TextBox txtEdges;
		private System.Windows.Forms.TextBox txtRotation;
		private System.Windows.Forms.TextBox txtCenterY;
		private System.Windows.Forms.ListBox lstVertices;
		private System.Windows.Forms.PictureBox pictureBox;
	}
}

