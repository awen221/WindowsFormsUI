namespace WindowsFormsUI
{
    partial class UserControl_DataGridView_DataTable
    {

        #region 元件設計工具產生的程式碼

        private void InitializeComponent()
        {
            this.radioButton_Cell = new System.Windows.Forms.RadioButton();
            this.radioButton_FullRow = new System.Windows.Forms.RadioButton();
            this.checkBox_MultiSelect = new System.Windows.Forms.CheckBox();
            this.groupBox_SelectMode = new System.Windows.Forms.GroupBox();
            this.userControl_DataGridView = new UserControl_DataGridView();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Del = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.groupBox_SelectMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton_Cell
            // 
            this.radioButton_Cell.AutoSize = true;
            this.radioButton_Cell.Location = new System.Drawing.Point(6, 21);
            this.radioButton_Cell.Name = "radioButton_Cell";
            this.radioButton_Cell.Size = new System.Drawing.Size(47, 16);
            this.radioButton_Cell.TabIndex = 8;
            this.radioButton_Cell.Text = "欄位";
            this.radioButton_Cell.UseVisualStyleBackColor = true;
            this.radioButton_Cell.CheckedChanged += new System.EventHandler(this.radioButton_Cell_CheckedChanged);
            // 
            // radioButton_FullRow
            // 
            this.radioButton_FullRow.AutoSize = true;
            this.radioButton_FullRow.Location = new System.Drawing.Point(59, 21);
            this.radioButton_FullRow.Name = "radioButton_FullRow";
            this.radioButton_FullRow.Size = new System.Drawing.Size(47, 16);
            this.radioButton_FullRow.TabIndex = 10;
            this.radioButton_FullRow.Text = "整列";
            this.radioButton_FullRow.UseVisualStyleBackColor = true;
            this.radioButton_FullRow.CheckedChanged += new System.EventHandler(this.radioButton_FullRow_CheckedChanged);
            // 
            // checkBox_MultiSelect
            // 
            this.checkBox_MultiSelect.AutoSize = true;
            this.checkBox_MultiSelect.Location = new System.Drawing.Point(124, 132);
            this.checkBox_MultiSelect.Name = "checkBox_MultiSelect";
            this.checkBox_MultiSelect.Size = new System.Drawing.Size(84, 16);
            this.checkBox_MultiSelect.TabIndex = 11;
            this.checkBox_MultiSelect.Text = "可選擇多列";
            this.checkBox_MultiSelect.UseVisualStyleBackColor = true;
            this.checkBox_MultiSelect.CheckedChanged += new System.EventHandler(this.checkBox_MultiSelect_CheckedChanged);
            // 
            // groupBox_SelectMode
            // 
            this.groupBox_SelectMode.AutoSize = true;
            this.groupBox_SelectMode.Controls.Add(this.radioButton_Cell);
            this.groupBox_SelectMode.Controls.Add(this.radioButton_FullRow);
            this.groupBox_SelectMode.Location = new System.Drawing.Point(3, 90);
            this.groupBox_SelectMode.Name = "groupBox_SelectMode";
            this.groupBox_SelectMode.Size = new System.Drawing.Size(115, 58);
            this.groupBox_SelectMode.TabIndex = 12;
            this.groupBox_SelectMode.TabStop = false;
            this.groupBox_SelectMode.Text = "資料選取模式";
            // 
            // userControl_DataGridView
            // 
            this.userControl_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControl_DataGridView.AutoScroll = true;
            this.userControl_DataGridView.AutoSize = true;
            this.userControl_DataGridView.dataGridViewDataSource = null;
            this.userControl_DataGridView.dataGridViewReadOnly = false;
            this.userControl_DataGridView.Font = new System.Drawing.Font("細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.userControl_DataGridView.Location = new System.Drawing.Point(3, 154);
            this.userControl_DataGridView.Name = "userControl_DataGridView";
            this.userControl_DataGridView.Size = new System.Drawing.Size(205, 66);
            this.userControl_DataGridView.TabIndex = 14;
            // 
            // button_Add
            // 
            this.button_Add.AutoSize = true;
            this.button_Add.Location = new System.Drawing.Point(3, 3);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(106, 23);
            this.button_Add.TabIndex = 15;
            this.button_Add.Text = "新增一筆資料";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Del
            // 
            this.button_Del.AutoSize = true;
            this.button_Del.Location = new System.Drawing.Point(3, 32);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(106, 23);
            this.button_Del.TabIndex = 16;
            this.button_Del.Text = "刪除選定資料";
            this.button_Del.UseVisualStyleBackColor = true;
            this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.AutoSize = true;
            this.button_Edit.Location = new System.Drawing.Point(3, 61);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(106, 23);
            this.button_Edit.TabIndex = 17;
            this.button_Edit.Text = "編輯選定資料";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // UserControl_DataGridView_DataTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.button_Del);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.userControl_DataGridView);
            this.Controls.Add(this.groupBox_SelectMode);
            this.Controls.Add(this.checkBox_MultiSelect);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControl_DataGridView_DataTable";
            this.Size = new System.Drawing.Size(211, 222);
            this.groupBox_SelectMode.ResumeLayout(false);
            this.groupBox_SelectMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.RadioButton radioButton_Cell;
        private System.Windows.Forms.RadioButton radioButton_FullRow;
        public System.Windows.Forms.CheckBox checkBox_MultiSelect;
        public System.Windows.Forms.GroupBox groupBox_SelectMode;
        public UserControl_DataGridView userControl_DataGridView;
        public System.Windows.Forms.Button button_Add;
        public System.Windows.Forms.Button button_Del;
        public System.Windows.Forms.Button button_Edit;
    }
}
