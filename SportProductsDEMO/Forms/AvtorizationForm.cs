using SportProductsDEMO.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportProductsDEMO.Forms
{
	public partial class AvtorizationForm : Form
	{
		private DataBaseManager dbManager = new DataBaseManager();

		public AvtorizationForm()
		{
			InitializeComponent();
		}

		private void ClickProductsGosti_Click(object sender, EventArgs e)
		{
			Form form = new ProductsForm();
			form.Show();
			this.Hide();
		}

		private void CheckTxtBox()
		{
			bool bothTextboxesEmpty = string.IsNullOrEmpty(txtBoxLogin.Text) && string.IsNullOrEmpty(txtBoxPass.Text);

			btnEditAvtor.Enabled = !bothTextboxesEmpty;
		}

		private void txtBoxPass_TextChanged(object sender, EventArgs e)
		{
			CheckTxtBox();
		}

		private void txtBoxLogin_TextChanged(object sender, EventArgs e)
		{
			CheckTxtBox();
		}

		private void btnEditAvtor_Click_1(object sender, EventArgs e)
		{
			if (dbManager.AuthenticateUser(txtBoxLogin.Text, txtBoxPass.Text))
			{
				MessageBox.Show("Добро пожаловать!");
				Form form = new ProductsForm();
				form.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Неверный логин или пароль!");
			}
		}
	}
}
