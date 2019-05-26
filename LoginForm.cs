/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 23/05/2019
 * Time: 11:22 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Proyecto
{

	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class Login : Form
	{
		Usuario usuario;
		public Login()
		{
			usuario = new Usuario();
			Conexion.crearConexionLocal();
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void TextUserEnter(object sender, EventArgs e)
		{
			if(textUser.Text.Equals("Username")){
				textUser.Clear();
				textUser.ForeColor = Color.DarkSlateBlue;
			}
		}
		void TextUserLeave(object sender, EventArgs e)
		{
			if(textUser.Text.Equals("")){
				textUser.Text = "Username";
				textUser.ForeColor = Color.DimGray;
			}
		}
		void TextPasswordEnter(object sender, EventArgs e)
		{
			if(textPassword.Text.Equals("Password")){
				textPassword.Clear();
				textPassword.ForeColor = Color.DarkSlateBlue;
			}
		}
		void TextPasswordLeave(object sender, EventArgs e)
		{
			if(textPassword.Text.Equals("")){
				textPassword.Text = "Password";
				textPassword.ForeColor = Color.DimGray;
			}
		}

		private void BtnLogin_Click(object sender, EventArgs e)
		{
			DataTable selectedUser= usuario.GetUsuario(textUser.Text, textPassword.Text);
			if (selectedUser.Rows.Count > 0)
			{
				Console.WriteLine(usuario.GetUsuario(textUser.Text, textPassword.Text).Rows[0][0].ToString());
				textUser.Clear();
				textPassword.Clear();
				MainMenuForm menu = new MainMenuForm();
				menu.ShowDialog();

			}
			else
			{
				MessageBox.Show("No existe el usuario");

			}

			//usuario.GetUsuario(textUser.Text, textPassword.Text).Rows[0][0].ToString();
			
			//usuario.GetUsuarioById()
		}
	}
}
