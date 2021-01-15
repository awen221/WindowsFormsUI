using System;
using System.Resources;
using System.Windows.Forms;

using WindowsForms;
using WindowsForms.TextBox_Custom;

namespace WindowsFormsUI
{
    public partial class FormBase_ChangePassword : Form
    {
        /// <summary>
        /// 帳號
        /// </summary>
        public string User;
        /// <summary>
        /// 密碼
        /// </summary>
        public string Pwd;

        /// <summary>
        /// 資源儲存,主要為訊息儲存
        /// </summary>
        ResourceManager res = WindowsFormFunc.GetFormResourceManager<FormBase_ChangePassword>();
        /// <summary>
        /// 訊息:舊密碼錯誤
        /// </summary>
        protected string Message_OldPwdError { get { return res.GetString("OldPwdError"); } }
        /// <summary>
        /// 訊息:密碼不得小於{0}個字元
        /// </summary>
        protected string Message_LengthMinLimitWarn { get { return res.GetString("LengthMinLimitWarn"); } }
        /// <summary>
        /// 訊息:新密碼確認錯誤
        /// </summary>
        protected string Message_NewPwdCheckError { get { return res.GetString("NewPwdCheckError"); } }
        /// <summary>
        /// 訊息:密碼不可與帳號相同
        /// </summary>
        protected string Message_SamePwdUserWarn { get { return res.GetString("SamePwdUserWarn"); } }
        /// <summary>
        /// 訊息:修改成功
        /// </summary>
        protected string Message_Success { get { return res.GetString("Success"); } }
        /// <summary>
        /// 訊息:修改失敗
        /// </summary>
        protected string Message_Fail { get { return res.GetString("Fail"); } }


        /// <summary>
        /// 自訂KeyPress輸入限制
        /// </summary>
        /// <param name="e"></param>
        virtual protected void KeyPressLimitInputCustom(KeyPressEventArgs e)
        {
            //允許功能鍵,禁止所有符號,允許大小寫英數字
            TextBox_Custom.KeyPressLimitInput(e, true, false, true, true, true);

            //允許'-'符號
            if (e.KeyChar == '-')
            {
                e.Handled = false;
                return;
            }
        }

        /// <summary>
        /// 密碼最少字元數限制
        /// </summary>
        virtual protected uint LengthMinLimit { get { return 6; } }

        /// <summary>
        /// 密碼變更後更新動作
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        virtual protected bool ChangePassword(string user,string pwd)
        {
            return false;
        }

        /// <summary>
        /// 提供一個無參數的建構式 繼承類別才能開啟設計界面
        /// </summary>
        public FormBase_ChangePassword()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 建構時帳密以參數帶入
        /// </summary>
        /// <param name="user">帳號</param>
        /// <param name="pwd">密碼</param>
        public FormBase_ChangePassword(string user, ref string pwd)
        {
            InitializeComponent();
            User = user;
            Pwd = pwd;
        }

        private void textBox_pwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressLimitInputCustom(e);
        }

        private void textBox_newPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressLimitInputCustom(e);
        }

        private void textBox_newPwdAgain_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressLimitInputCustom(e);
        }

        private void button_Send_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (textBox_pwd.Text != Pwd)
                {
                    MessageBox.Show(Message_OldPwdError);
                    return;
                }

                if (textBox_newPwd.Text.Length < LengthMinLimit)
                {
                    MessageBox.Show(string.Format(Message_LengthMinLimitWarn, LengthMinLimit));
                    return;
                }

                if (textBox_newPwd.Text != textBox_newPwdAgain.Text)
                {
                    MessageBox.Show(Message_NewPwdCheckError);
                    return;
                }

                if (textBox_newPwd.Text == User)
                {
                    MessageBox.Show(Message_SamePwdUserWarn);
                    return;
                }

                if (ChangePassword(User, textBox_newPwd.Text))
                {
                    MessageBox.Show(Message_Success);
                    Pwd = textBox_newPwd.Text;
                    this.DialogResult = DialogResult.OK;

                    ///這裡要return
                    ///不然最下面的this.DialogResult = DialogResult.Cancel;依然會執行
                    return;
                }
                else
                {
                    MessageBox.Show(Message_Fail);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
