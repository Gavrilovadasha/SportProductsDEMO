namespace SportProductsDEMO.CustomControls
{
	partial class ProductsControll
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.labelName = new System.Windows.Forms.Label();
			this.labelDescription = new System.Windows.Forms.Label();
			this.labelProizvoditel = new System.Windows.Forms.Label();
			this.labelPrice = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox
			// 
			this.pictureBox.Location = new System.Drawing.Point(23, 23);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(185, 102);
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelName.Location = new System.Drawing.Point(236, 23);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(197, 25);
			this.labelName.TabIndex = 1;
			this.labelName.Text = "Наименование товара";
			// 
			// labelDescription
			// 
			this.labelDescription.AutoSize = true;
			this.labelDescription.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelDescription.Location = new System.Drawing.Point(238, 48);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(135, 20);
			this.labelDescription.TabIndex = 2;
			this.labelDescription.Text = "Описание товара";
			// 
			// labelProizvoditel
			// 
			this.labelProizvoditel.AutoSize = true;
			this.labelProizvoditel.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelProizvoditel.Location = new System.Drawing.Point(238, 68);
			this.labelProizvoditel.Name = "labelProizvoditel";
			this.labelProizvoditel.Size = new System.Drawing.Size(129, 20);
			this.labelProizvoditel.TabIndex = 3;
			this.labelProizvoditel.Text = "Производитель:";
			// 
			// labelPrice
			// 
			this.labelPrice.AutoSize = true;
			this.labelPrice.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelPrice.Location = new System.Drawing.Point(240, 88);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(49, 20);
			this.labelPrice.TabIndex = 4;
			this.labelPrice.Text = "Цена:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(580, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "Размер скидки";
			// 
			// ProductsControll
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.YellowGreen;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelPrice);
			this.Controls.Add(this.labelProizvoditel);
			this.Controls.Add(this.labelDescription);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.pictureBox);
			this.Margin = new System.Windows.Forms.Padding(20, 0, 20, 20);
			this.Name = "ProductsControll";
			this.Padding = new System.Windows.Forms.Padding(20);
			this.Size = new System.Drawing.Size(738, 148);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.Label labelProizvoditel;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.Label label1;
	}
}
