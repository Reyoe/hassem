/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 23/05/2019
 * Time: 11:22 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Proyecto
{
	partial class Login
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.TextBox textUser;
		private System.Windows.Forms.TextBox textPassword;
		private System.Windows.Forms.PictureBox logo;
		private System.Windows.Forms.PictureBox logoPassword;
		private System.Windows.Forms.PictureBox logoUser;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnLogin = new System.Windows.Forms.Button();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.logoPassword = new System.Windows.Forms.PictureBox();
            this.logoUser = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(96, 267);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(132, 39);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // textUser
            // 
            this.textUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUser.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.textUser.Location = new System.Drawing.Point(65, 185);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(196, 26);
            this.textUser.TabIndex = 1;
            this.textUser.Text = "Username";
            this.textUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textUser.Enter += new System.EventHandler(this.TextUserEnter);
            this.textUser.Leave += new System.EventHandler(this.TextUserLeave);
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.textPassword.Location = new System.Drawing.Point(65, 217);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(196, 26);
            this.textPassword.TabIndex = 2;
            this.textPassword.Text = "Password";
            this.textPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textPassword.Enter += new System.EventHandler(this.TextPasswordEnter);
            this.textPassword.Leave += new System.EventHandler(this.TextPasswordLeave);
            // 
            // logoPassword
            // 
            this.logoPassword.Image = ((System.Drawing.Image)(resources.GetObject("logoPassword.Image")));
            this.logoPassword.Location = new System.Drawing.Point(30, 222);
            this.logoPassword.Name = "logoPassword";
            this.logoPassword.Size = new System.Drawing.Size(29, 21);
            this.logoPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPassword.TabIndex = 4;
            this.logoPassword.TabStop = false;
            // 
            // logoUser
            // 
            this.logoUser.Image = ((System.Drawing.Image)(resources.GetObject("logoUser.Image")));
            this.logoUser.Location = new System.Drawing.Point(30, 185);
            this.logoUser.Name = "logoUser";
            this.logoUser.Size = new System.Drawing.Size(29, 32);
            this.logoUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoUser.TabIndex = 5;
            this.logoUser.TabStop = false;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(96, 39);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(132, 107);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(314, 364);
            this.Controls.Add(this.logoPassword);
            this.Controls.Add(this.logoUser);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.logoPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
    }
}
