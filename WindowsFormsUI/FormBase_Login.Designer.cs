namespace WindowsFormsUI
{
    partial class FormBase_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase_Login));
            this.label_acc = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_pwd = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.button_quit = new System.Windows.Forms.Button();
            this.checkBox_ShowPassword = new System.Windows.Forms.CheckBox();
            this.textBox_account = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_acc
            // 
            resources.ApplyResources(this.label_acc, "label_acc");
            this.label_acc.Name = "label_acc";
            // 
            // textBox_password
            // 
            resources.ApplyResources(this.textBox_password, "textBox_password");
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_password_KeyPress);
            // 
            // label_pwd
            // 
            resources.ApplyResources(this.label_pwd, "label_pwd");
            this.label_pwd.Name = "label_pwd";
            // 
            // button_login
            // 
            resources.ApplyResources(this.button_login, "button_login");
            this.button_login.Name = "button_login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_quit
            // 
            resources.ApplyResources(this.button_quit, "button_quit");
            this.button_quit.Name = "button_quit";
            this.button_quit.UseVisualStyleBackColor = true;
            this.button_quit.Click += new System.EventHandler(this.button_quit_Click);
            // 
            // checkBox_ShowPassword
            // 
            resources.ApplyResources(this.checkBox_ShowPassword, "checkBox_ShowPassword");
            this.checkBox_ShowPassword.Name = "checkBox_ShowPassword";
            this.checkBox_ShowPassword.UseVisualStyleBackColor = true;
            this.checkBox_ShowPassword.CheckedChanged += new System.EventHandler(this.checkBox_ShowPassword_CheckedChanged);
            // 
            // textBox_account
            // 
            this.textBox_account.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.textBox_account, "textBox_account");
            this.textBox_account.Name = "textBox_account";
            this.textBox_account.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_account_KeyPress);
            // 
            // FormBase_Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox_ShowPassword);
            this.Controls.Add(this.button_quit);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_pwd);
            this.Controls.Add(this.textBox_account);
            this.Controls.Add(this.label_acc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBase_Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Login_Load);
            this.Shown += new System.EventHandler(this.Form_Login_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.TextBox textBox_account;
        protected System.Windows.Forms.TextBox textBox_password;
        protected System.Windows.Forms.Label label_acc;
        protected System.Windows.Forms.Label label_pwd;
        protected System.Windows.Forms.Button button_login;
        protected System.Windows.Forms.Button button_quit;
        protected System.Windows.Forms.CheckBox checkBox_ShowPassword;
    }
}