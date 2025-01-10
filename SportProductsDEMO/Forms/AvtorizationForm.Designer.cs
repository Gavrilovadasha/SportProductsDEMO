namespace SportProductsDEMO.Forms
{
	partial class AvtorizationForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvtorizationForm));
			this.label1 = new System.Windows.Forms.Label();
			this.lblLogin = new System.Windows.Forms.Label();
			this.lblPass = new System.Windows.Forms.Label();
			this.txtBoxLogin = new System.Windows.Forms.TextBox();
			this.txtBoxPass = new System.Windows.Forms.TextBox();
			this.errorInputLogin = new System.Windows.Forms.Label();
			this.errorInputPass = new System.Windows.Forms.Label();
			this.ClickProductsGosti = new System.Windows.Forms.Label();
			this.btnEditAvtor = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(178, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(135, 28);
			this.label1.TabIndex = 1;
			this.label1.Text = "Авторизация";
			// 
			// lblLogin
			// 
			this.lblLogin.AutoSize = true;
			this.lblLogin.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblLogin.Location = new System.Drawing.Point(62, 137);
			this.lblLogin.Name = "lblLogin";
			this.lblLogin.Size = new System.Drawing.Size(67, 24);
			this.lblLogin.TabIndex = 2;
			this.lblLogin.Text = "Логин:";
			// 
			// lblPass
			// 
			this.lblPass.AutoSize = true;
			this.lblPass.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblPass.Location = new System.Drawing.Point(62, 207);
			this.lblPass.Name = "lblPass";
			this.lblPass.Size = new System.Drawing.Size(77, 24);
			this.lblPass.TabIndex = 3;
			this.lblPass.Text = "Пароль:";
			// 
			// txtBoxLogin
			// 
			this.txtBoxLogin.Location = new System.Drawing.Point(167, 140);
			this.txtBoxLogin.Name = "txtBoxLogin";
			this.txtBoxLogin.Size = new System.Drawing.Size(216, 22);
			this.txtBoxLogin.TabIndex = 7;
			// 
			// txtBoxPass
			// 
			this.txtBoxPass.Location = new System.Drawing.Point(167, 210);
			this.txtBoxPass.Name = "txtBoxPass";
			this.txtBoxPass.Size = new System.Drawing.Size(216, 22);
			this.txtBoxPass.TabIndex = 8;
			this.txtBoxPass.TextChanged += new System.EventHandler(this.txtBoxPass_TextChanged);
			// 
			// errorInputLogin
			// 
			this.errorInputLogin.AutoSize = true;
			this.errorInputLogin.BackColor = System.Drawing.Color.Transparent;
			this.errorInputLogin.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.errorInputLogin.ForeColor = System.Drawing.Color.Red;
			this.errorInputLogin.Location = new System.Drawing.Point(224, 165);
			this.errorInputLogin.Name = "errorInputLogin";
			this.errorInputLogin.Size = new System.Drawing.Size(100, 18);
			this.errorInputLogin.TabIndex = 9;
			this.errorInputLogin.Text = "Введите логин";
			this.errorInputLogin.Visible = false;
			// 
			// errorInputPass
			// 
			this.errorInputPass.AutoSize = true;
			this.errorInputPass.BackColor = System.Drawing.Color.Transparent;
			this.errorInputPass.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.errorInputPass.ForeColor = System.Drawing.Color.Red;
			this.errorInputPass.Location = new System.Drawing.Point(217, 235);
			this.errorInputPass.Name = "errorInputPass";
			this.errorInputPass.Size = new System.Drawing.Size(107, 18);
			this.errorInputPass.TabIndex = 10;
			this.errorInputPass.Text = "Введите пароль";
			this.errorInputPass.Visible = false;
			// 
			// ClickProductsGosti
			// 
			this.ClickProductsGosti.AutoSize = true;
			this.ClickProductsGosti.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ClickProductsGosti.Location = new System.Drawing.Point(116, 348);
			this.ClickProductsGosti.Name = "ClickProductsGosti";
			this.ClickProductsGosti.Size = new System.Drawing.Size(277, 24);
			this.ClickProductsGosti.TabIndex = 11;
			this.ClickProductsGosti.Text = "Перейти к товарам в роли гостя";
			this.ClickProductsGosti.Click += new System.EventHandler(this.ClickProductsGosti_Click);
			// 
			// btnEditAvtor
			// 
			this.btnEditAvtor.BackColor = System.Drawing.Color.ForestGreen;
			this.btnEditAvtor.Enabled = false;
			this.btnEditAvtor.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnEditAvtor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnEditAvtor.Location = new System.Drawing.Point(183, 284);
			this.btnEditAvtor.Name = "btnEditAvtor";
			this.btnEditAvtor.Size = new System.Drawing.Size(134, 50);
			this.btnEditAvtor.TabIndex = 12;
			this.btnEditAvtor.Text = "Войти";
			this.btnEditAvtor.UseVisualStyleBackColor = false;
			this.btnEditAvtor.Click += new System.EventHandler(this.btnEditAvtor_Click_1);
			// 
			// AvtorizationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(482, 453);
			this.Controls.Add(this.btnEditAvtor);
			this.Controls.Add(this.ClickProductsGosti);
			this.Controls.Add(this.errorInputPass);
			this.Controls.Add(this.errorInputLogin);
			this.Controls.Add(this.txtBoxPass);
			this.Controls.Add(this.txtBoxLogin);
			this.Controls.Add(this.lblPass);
			this.Controls.Add(this.lblLogin);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AvtorizationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Авторизация";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblLogin;
		private System.Windows.Forms.Label lblPass;
		private System.Windows.Forms.TextBox txtBoxLogin;
		private System.Windows.Forms.TextBox txtBoxPass;
		private System.Windows.Forms.Label errorInputLogin;
		private System.Windows.Forms.Label errorInputPass;
		private System.Windows.Forms.Label ClickProductsGosti;
		private System.Windows.Forms.Button btnEditAvtor;
	}
}