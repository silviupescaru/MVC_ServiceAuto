namespace MVC_ServiceAuto.View
{
    partial class VLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VLogin));
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            comboBoxChangeLanguage = new ComboBox();
            labelChangeLanguage = new Label();
            SuspendLayout();
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUsername.Location = new Point(647, 372);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(199, 22);
            textBoxUsername.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(647, 407);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(199, 22);
            textBoxPassword.TabIndex = 1;
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLogin.Location = new Point(633, 474);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(123, 23);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = true;
            // 
            // comboBoxChangeLanguage
            // 
            comboBoxChangeLanguage.Font = new Font("Montserrat", 9F);
            comboBoxChangeLanguage.FormattingEnabled = true;
            comboBoxChangeLanguage.Items.AddRange(new object[] { "", "English", "Russian", "French" });
            comboBoxChangeLanguage.Location = new Point(965, 223);
            comboBoxChangeLanguage.Name = "comboBoxChangeLanguage";
            comboBoxChangeLanguage.Size = new Size(150, 24);
            comboBoxChangeLanguage.TabIndex = 3;
            // 
            // labelChangeLanguage
            // 
            labelChangeLanguage.AutoSize = true;
            labelChangeLanguage.BackColor = Color.Transparent;
            labelChangeLanguage.Font = new Font("Montserrat SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelChangeLanguage.ForeColor = Color.White;
            labelChangeLanguage.Location = new Point(810, 221);
            labelChangeLanguage.Name = "labelChangeLanguage";
            labelChangeLanguage.Size = new Size(149, 21);
            labelChangeLanguage.TabIndex = 4;
            labelChangeLanguage.Text = "Change Language";
            // 
            // VLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.loginNebun;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1388, 777);
            Controls.Add(labelChangeLanguage);
            Controls.Add(comboBoxChangeLanguage);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginGUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonLogin;
        private ComboBox comboBoxChangeLanguage;
        private Label labelChangeLanguage;
    }
}