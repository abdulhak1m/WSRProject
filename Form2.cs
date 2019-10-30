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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            SwitchLocationForm();
            closeButton.Click += (s, e) => { Close(); };
            PasswordBox(passwordTXT, showPassword);
            PasswordBox(confirmPasswordTXT, showConfirmpassword);
            confirmPasswordTXT.TextChanged += (s, e) => { CheckPassword(); };
        }
        private void CheckPassword()
        {
            if(passwordTXT.Text != confirmPasswordTXT.Text)
            {
                lblError.Text = "Внимание, пароли не совпадают!";
                doneButton.Enabled = false;
            }
            else
            {
                lblError.Text = "";
                doneButton.Enabled = true;
            }
        }
        private void SwitchLocationForm()
        {
            int move = 0, x = 0, y = 0;
            topPanel.MouseDown += (s, e) => { move = 1; x = e.X; y = e.Y; };
            topPanel.MouseMove += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y); };
            topPanel.MouseUp += (s, e) => { move = 0; };
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите покинуть окно регистрации?", "Уведомление системы!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                ActiveForm.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
                Close();
            }
        }

        private void PasswordBox(TextBox textBox, Button button)
        {
            textBox.TextChanged += (s, e) => { textBox.UseSystemPasswordChar = true; };
            button.MouseDown += (s, e) => { textBox.UseSystemPasswordChar = false; };
            button.MouseUp += (s, e) => { textBox.UseSystemPasswordChar = true; };
        }
    }
}
