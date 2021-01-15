namespace WindowsFormsUI
{
    partial class FormBase_ChangePassword
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
            this.textBox_pwd = new System.Windows.Forms.TextBox();
            this.label_pwd = new System.Windows.Forms.Label();
            this.textBox_newPwd = new System.Windows.Forms.TextBox();
            this.label_newPwd = new System.Windows.Forms.Label();
            this.textBox_newPwdAgain = new System.Windows.Forms.TextBox();
            this.label_newPwdAgain = new System.Windows.Forms.Label();
            this.button_Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_pwd
            // 
            this.textBox_pwd.Location = new System.Drawing.Point(104, 7);
            this.textBox_pwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_pwd.MaxLength = 18;
            this.textBox_pwd.Name = "textBox_pwd";
            this.textBox_pwd.Size = new System.Drawing.Size(114, 22);
            this.textBox_pwd.TabIndex = 4;
            this.textBox_pwd.UseSystemPasswordChar = true;
            this.textBox_pwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_pwd_KeyPress);
            // 
            // label_pwd
            // 
            this.label_pwd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_pwd.Location = new System.Drawing.Point(9, 7);
            this.label_pwd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_pwd.Name = "label_pwd";
            this.label_pwd.Size = new System.Drawing.Size(90, 20);
            this.label_pwd.TabIndex = 3;
            this.label_pwd.Text = "輸入舊密碼";
            this.label_pwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_newPwd
            // 
            this.textBox_newPwd.Location = new System.Drawing.Point(104, 32);
            this.textBox_newPwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_newPwd.MaxLength = 18;
            this.textBox_newPwd.Name = "textBox_newPwd";
            this.textBox_newPwd.Size = new System.Drawing.Size(114, 22);
            this.textBox_newPwd.TabIndex = 6;
            this.textBox_newPwd.UseSystemPasswordChar = true;
            this.textBox_newPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_newPwd_KeyPress);
            // 
            // label_newPwd
            // 
            this.label_newPwd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_newPwd.Location = new System.Drawing.Point(9, 32);
            this.label_newPwd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_newPwd.Name = "label_newPwd";
            this.label_newPwd.Size = new System.Drawing.Size(90, 20);
            this.label_newPwd.TabIndex = 5;
            this.label_newPwd.Text = "輸入新密碼";
            this.label_newPwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_newPwdAgain
            // 
            this.textBox_newPwdAgain.Location = new System.Drawing.Point(104, 57);
            this.textBox_newPwdAgain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_newPwdAgain.MaxLength = 18;
            this.textBox_newPwdAgain.Name = "textBox_newPwdAgain";
            this.textBox_newPwdAgain.Size = new System.Drawing.Size(114, 22);
            this.textBox_newPwdAgain.TabIndex = 8;
            this.textBox_newPwdAgain.UseSystemPasswordChar = true;
            this.textBox_newPwdAgain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_newPwdAgain_KeyPress);
            // 
            // label_newPwdAgain
            // 
            this.label_newPwdAgain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_newPwdAgain.Location = new System.Drawing.Point(9, 57);
            this.label_newPwdAgain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_newPwdAgain.Name = "label_newPwdAgain";
            this.label_newPwdAgain.Size = new System.Drawing.Size(90, 20);
            this.label_newPwdAgain.TabIndex = 7;
            this.label_newPwdAgain.Text = "再次輸入新密碼";
            this.label_newPwdAgain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(104, 82);
            this.button_Send.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(114, 24);
            this.button_Send.TabIndex = 9;
            this.button_Send.Text = "送出";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // FormBase_ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 115);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.textBox_newPwdAgain);
            this.Controls.Add(this.label_newPwdAgain);
            this.Controls.Add(this.textBox_newPwd);
            this.Controls.Add(this.label_newPwd);
            this.Controls.Add(this.textBox_pwd);
            this.Controls.Add(this.label_pwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBase_ChangePassword";
            this.Text = "修改密碼";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_pwd;
        private System.Windows.Forms.Label label_pwd;
        private System.Windows.Forms.TextBox textBox_newPwd;
        private System.Windows.Forms.Label label_newPwd;
        private System.Windows.Forms.TextBox textBox_newPwdAgain;
        private System.Windows.Forms.Label label_newPwdAgain;
        private System.Windows.Forms.Button button_Send;
    }
}