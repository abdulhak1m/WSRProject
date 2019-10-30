using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deadline_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SwitchLocationForm();
            PasswordBox();

            closeButton.Click += (s, e) => { Close(); };
            usernameTXT.Text = "Введите логин";
            usernameTXT.ForeColor = Color.RoyalBlue;

            passwordTXT.Text = "Введите пароль";
            passwordTXT.ForeColor = Color.RoyalBlue;
        }

        private void UsernameTXT_Enter(object sender, EventArgs e)
        {
            if(usernameTXT.Text == "Введите логин")
                usernameTXT.Text = "";
        }

        private void UsernameTXT_Leave(object sender, EventArgs e)
        {
            if (usernameTXT.Text == "")
            {
                usernameTXT.Text = "Введите логин";
                usernameTXT.ForeColor = Color.RoyalBlue;
            }
        }

        private void PasswordTXT_Enter(object sender, EventArgs e)
        {
            if (passwordTXT.Text == "Введите пароль")
            {
                passwordTXT.UseSystemPasswordChar = false;
                passwordTXT.Text = "";
            }
        }

        private void PasswordTXT_Leave(object sender, EventArgs e)
        {
            if (passwordTXT.Text == "")
            {
                passwordTXT.Text = "Введите пароль";
                passwordTXT.UseSystemPasswordChar = false;
                passwordTXT.ForeColor = Color.RoyalBlue;
            }
        }

        private void SwitchLocationForm()
        {
            int move = 0, x = 0, y = 0;
            topPanel.MouseDown += (s, e) => { move = 1; x = e.X; y = e.Y; };
            topPanel.MouseMove += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y); };
            topPanel.MouseUp += (s, e) => { move = 0; };
        }

        private void PasswordBox()
        {
            passwordTXT.TextChanged += (s, e) => { passwordTXT.UseSystemPasswordChar = true; };
            showButton.MouseDown += (s, e) => { passwordTXT.UseSystemPasswordChar = false; };
            showButton.MouseUp += (s, e) => { passwordTXT.UseSystemPasswordChar = true; };
        }

        private void UsernameTXT_TextChanged(object sender, EventArgs e)
        {
            usernameTXT.ForeColor = Color.Black;
        }

        private void PasswordTXT_TextChanged(object sender, EventArgs e)
        {
            passwordTXT.ForeColor = Color.Black;
        }

        private void LinkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ActiveForm.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            Close();
        }
    }
}
