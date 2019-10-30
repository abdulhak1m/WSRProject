namespace Deadline_5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.topPanel = new System.Windows.Forms.Panel();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usernameTXT = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.passwordTXT = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.showButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.linkSignUp = new System.Windows.Forms.LinkLabel();
            this.topPanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.topPanel.Controls.Add(this.closeButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(831, 190);
            this.topPanel.TabIndex = 0;
            // 
            // loginPanel
            // 
            this.loginPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginPanel.BackColor = System.Drawing.Color.White;
            this.loginPanel.Controls.Add(this.linkSignUp);
            this.loginPanel.Controls.Add(this.button1);
            this.loginPanel.Controls.Add(this.showButton);
            this.loginPanel.Controls.Add(this.panel2);
            this.loginPanel.Controls.Add(this.panel1);
            this.loginPanel.Controls.Add(this.passwordTXT);
            this.loginPanel.Controls.Add(this.usernameTXT);
            this.loginPanel.Controls.Add(this.pictureBox1);
            this.loginPanel.Location = new System.Drawing.Point(181, 48);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(469, 300);
            this.loginPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(183, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // usernameTXT
            // 
            this.usernameTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTXT.Location = new System.Drawing.Point(82, 131);
            this.usernameTXT.Name = "usernameTXT";
            this.usernameTXT.Size = new System.Drawing.Size(274, 19);
            this.usernameTXT.TabIndex = 1;
            this.usernameTXT.TextChanged += new System.EventHandler(this.UsernameTXT_TextChanged);
            this.usernameTXT.Enter += new System.EventHandler(this.UsernameTXT_Enter);
            this.usernameTXT.Leave += new System.EventHandler(this.UsernameTXT_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(82, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 5);
            this.panel1.TabIndex = 2;
            // 
            // passwordTXT
            // 
            this.passwordTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTXT.Location = new System.Drawing.Point(82, 181);
            this.passwordTXT.Name = "passwordTXT";
            this.passwordTXT.Size = new System.Drawing.Size(274, 19);
            this.passwordTXT.TabIndex = 1;
            this.passwordTXT.TextChanged += new System.EventHandler(this.PasswordTXT_TextChanged);
            this.passwordTXT.Enter += new System.EventHandler(this.PasswordTXT_Enter);
            this.passwordTXT.Leave += new System.EventHandler(this.PasswordTXT_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(82, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 5);
            this.panel2.TabIndex = 2;
            // 
            // showButton
            // 
            this.showButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showButton.FlatAppearance.BorderSize = 0;
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showButton.Image = ((System.Drawing.Image)(resources.GetObject("showButton.Image")));
            this.showButton.Location = new System.Drawing.Point(362, 182);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(25, 25);
            this.showButton.TabIndex = 3;
            this.showButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(806, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.TabIndex = 3;
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(156, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // linkSignUp
            // 
            this.linkSignUp.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkSignUp.AutoSize = true;
            this.linkSignUp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkSignUp.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkSignUp.Location = new System.Drawing.Point(128, 277);
            this.linkSignUp.Name = "linkSignUp";
            this.linkSignUp.Size = new System.Drawing.Size(212, 16);
            this.linkSignUp.TabIndex = 5;
            this.linkSignUp.TabStop = true;
            this.linkSignUp.Text = "Нет аккаунта? Нажмите сюда";
            this.linkSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkSignUp_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(831, 396);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.topPanel.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox passwordTXT;
        private System.Windows.Forms.TextBox usernameTXT;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkSignUp;
    }
}

