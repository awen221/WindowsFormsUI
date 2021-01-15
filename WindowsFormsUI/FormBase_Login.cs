using System;
using System.Resources;
using System.Windows.Forms;

using WindowsForms;

namespace WindowsFormsUI
{
    /// <summary>
    /// 登入視窗基本類別
    /// </summary>
    public partial class FormBase_Login : Form
    {
        /// <summary>
        /// 密碼遮罩字元
        /// </summary>
        const char PasswordChar = '*';

        /// <summary>
        /// 資源儲存,主要為訊息儲存
        /// </summary>
        ResourceManager res = WindowsFormFunc.GetFormResourceManager<FormBase_Login>();
        /// <summary>
        /// 訊息:帳號不可為空!
        /// </summary>
        protected string Message_AccountIsNull { get { return res.GetString("_AccountIsNull"); } }

        #region 傳遞資料給外部
        public string user { protected set; get; }
        public string pwd { protected set; get; }
        public string name { protected set; get; }
        public string account_group { protected set; get; }
        #endregion

        #region virtual
        /// <summary>帳號輸入規範</summary>
        /// <param name="e"></param>
        virtual protected bool _KeyPressLimitInputCustom_Account(KeyPressEventArgs e) { return false; }
        /// <summary>密碼輸入規範</summary>
        /// <param name="e"></param>
        virtual protected bool _KeyPressLimitInputCustom_Password(KeyPressEventArgs e) { return false; }

        /// <summary>登入作業</summary>
        /// <param name="_user">帳號</param>
        /// <param name="_pwd">密碼</param>
        /// <returns>bool</returns>
        virtual protected bool _LoginProcess(string _user, string _pwd) { return false; }
        #endregion

        /// <summary>設定密碼遮罩字元</summary>
        /// <param name="bShowPassword">是否顯示密碼</param>
        /// <param name="tbPassword">textbox</param>
        void ShowPasswordSet(bool bShowPassword, ref TextBox tbPassword)
        {
            const char PasswordCharRemove = '\0';

            if (bShowPassword)
            {
                tbPassword.PasswordChar = PasswordCharRemove;
            }
            else
            {
                tbPassword.PasswordChar = PasswordChar;
            }
        }

        protected void LoginBySoftControl(string _user, string _pwd)
        {
            textBox_account.Text = _user;
            textBox_password.Text = _pwd;
            button_login_Click(this, new EventArgs());
        }

        public FormBase_Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //初始密碼遮罩字元
            ShowPasswordSet(checkBox_ShowPassword.Checked, ref textBox_password);
        }

        private void Form_Login_Shown(object sender, EventArgs e)
        {
            //有紀錄帳號時,Focus移到password
            if (textBox_account.Text != string.Empty)
            {
                textBox_password.Focus();
            }
        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void checkBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            //切換密碼是否遮罩
            ShowPasswordSet(checkBox_ShowPassword.Checked, ref textBox_password);
        }

        private void textBox_account_KeyPress(object sender, KeyPressEventArgs e)
        {
            //輸入帳號後跳到密碼框
            if (_KeyPressLimitInputCustom_Account(e)) textBox_password.Focus();
        }

        private void textBox_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            //輸入密碼後執行登入按鈕
            if (_KeyPressLimitInputCustom_Account(e)) button_login_Click(textBox_account, e);
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;

                user = textBox_account.Text;
                pwd = textBox_password.Text;
                #region 檢查帳號不為空
                if (user == string.Empty)
                {
                    string message = Message_AccountIsNull;

                    MessageBox.Show(message);
                    textBox_account.Focus();
                    return;
                }
                #endregion

                if (!_LoginProcess(user, pwd)) { return; }

                this.DialogResult = DialogResult.OK;
            }
            finally
            {
                this.Enabled = true;
            }
        }
    }

    /// <summary>
    /// 登入程序
    /// 處理基本程序,錯誤時循環登入視窗
    /// </summary>
    public class LoginProcess
    {
        static public string user;
        static public string pwd;
        static public string name;
        static public string account_group;

        /// <summary>
        /// 登入成功時執行
        /// 可做初次登入變更密碼作業等功能,平時不覆寫
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        virtual protected bool ProcessLoginOK(string user, ref string pwd) { return true; }

        /// <summary>
        /// 登入作業
        /// ,重複嘗試
        /// ,登入成功處理
        /// </summary>
        /// <typeparam name="T_Form">登入視窗類別</typeparam>
        /// <returns>登入是否成功</returns>
        public bool Run<T_Form>() where T_Form : FormBase_Login, new()
        {
            while (true)
            {
                T_Form login = new T_Form();
                DialogResult dr = login.ShowDialog();

                if (dr == DialogResult.Retry)
                {
                    continue;
                }

                if (dr == DialogResult.OK)
                {
                    user = login.user;
                    pwd = login.pwd;
                    name = login.name;
                    account_group = login.account_group;

                    if (!ProcessLoginOK(user,ref pwd))
                    {
                        return false;
                    }

                    break;
                }

                return false;
            }
            return true;
        }
    }
}
