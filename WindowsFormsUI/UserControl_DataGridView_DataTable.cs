using System.Data;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;

using WindowsForms.Control_Custom.Extension;

namespace WindowsFormsUI
{
    public partial class UserControl_DataGridView_DataTable : UserControl
    {
        #region 設定表格唯讀不可修改
        [Description("Set DataGridView ReadOnly"), Category("DataCustom")]
        public bool _DataGridView_ReadOnly
        {
            set
            {
                dataGridView.ReadOnly = value;
            }
            get
            {
                return dataGridView.ReadOnly;
            }
        }
        #endregion

        #region 選取模式 : 欄位,整列
        [Description("Set groupBox_SelectMode Visible"), Category("DataCustom")]
        public bool _SelectMode_Visible
        {
            set
            {
                groupBox_SelectMode.Visible = value;
            }
            get
            {
                return groupBox_SelectMode.Visible;
            }
        }

        protected enum SelectionMode { Cell, FullRow }
        SelectionMode _selectionMode = SelectionMode.Cell;
        protected SelectionMode selectionMode
        {
            set
            {
                switch (value)
                {
                    default:
                        break;
                    case SelectionMode.Cell:
                        dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
                        break;
                    case SelectionMode.FullRow:
                        dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        break;
                }
                _selectionMode = value;
            }
            get
            {
                return _selectionMode;
            }
        }
        #endregion

        #region 可選擇多列
        [Description("Set checkBox_MultiSelect Visible"), Category("DataCustom")]
        public bool _CheckBox_MultiSelect_Visible
        {
            set
            {
                checkBox_MultiSelect.Visible = value;
            }
            get
            {
                return checkBox_MultiSelect.Visible;
            }
        }

        protected bool dataGridViewMultiSelect
        {
            set
            {
                dataGridView.MultiSelect = value;
            }
            get
            {
                return dataGridView.MultiSelect;
            }
        }
        private void checkBox_MultiSelect_CheckedChanged(object sender, System.EventArgs e)
        {
            dataGridViewMultiSelect = checkBox_MultiSelect.Checked;
        }
        #endregion

        #region 新增一筆資料
        [Description("Set button_Add Visible"), Category("DataCustom")]
        public bool _button_Add_Visible
        {
            set
            {
                button_Add.Visible = value;
            }
            get
            {
                return button_Add.Visible;
            }
        }
        #endregion

        #region 刪除選定資料
        [Description("Set button_Del Visible"), Category("DataCustom")]
        public bool _button_Del_Visible
        {
            set
            {
                button_Del.Visible = value;
            }
            get
            {
                return button_Del.Visible;
            }
        }
        #endregion

        #region 編輯選定資料
        [Description("Set button_Edit Visible"), Category("DataCustom")]
        public bool _button_Edit_Visible
        {
            set
            {
                button_Edit.Visible = value;
            }
            get
            {
                return button_Edit.Visible;
            }
        }
        #endregion

        public DataGridView dataGridView
        {
            get
            {
                return userControl_DataGridView.dataGridView;
            }
        }
        public DataTable dataGridViewDataSource
        {
            set
            {
                dataGridView.DataSource = value;
            }
            get
            {
                return (DataTable)dataGridView.DataSource;
            }
        }
        List<int> GetDelSelectedRowsIndexList()
        {
            return userControl_DataGridView.GetDelSelectedRowsIndexList();
        }
        protected List<DataRow> GetSelectedRows()
        {
            return userControl_DataGridView.GetSelectedRows();
        }

        virtual protected void AddRow(DataRow row)
        {
            dataGridViewDataSource.Rows.Add(row);
        }
        virtual protected void AddNewRow()
        {
            AddRow(dataGridViewDataSource.NewRow());
        }
        virtual protected void DelSelectedRows()
        {
            List<int> indexList = GetDelSelectedRowsIndexList();

            //倒序做刪除才不會有因Index順序改變而發生錯誤的問題
            for (int i = dataGridViewDataSource.Rows.Count - 1; i >= 0; i--)
            {
                if (indexList.Contains(i))
                {
                    dataGridViewDataSource.Rows.RemoveAt(i);
                }
            }
        }
        virtual protected void EditSelectedRows()
        {

        }

        public UserControl_DataGridView_DataTable()
        {
            InitializeComponent();
            dataGridViewDataSource = new DataTable();

            //預設選取模式:欄位
            radioButton_Cell.Checked = true;

            //初始多行選取
            checkBox_MultiSelect_CheckedChanged(checkBox_MultiSelect, new System.EventArgs());

            //預設關閉編輯按鈕,因編輯功能未實作
            _button_Edit_Visible = false;
        }

        private void radioButton_Cell_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioButton_Cell.Checked)
            {
                selectionMode = SelectionMode.Cell;
            }
        }

        private void radioButton_FullRow_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioButton_FullRow.Checked)
            {
                selectionMode = SelectionMode.FullRow;
            }
        }

        private void button_Add_Click(object sender, System.EventArgs e)
        {
            this.DisableControlOnBusy_delegate_VoidNoArg(AddNewRow);
        }

        private void button_Del_Click(object sender, System.EventArgs e)
        {
            this.DisableControlOnBusy_delegate_VoidNoArg(DelSelectedRows);
        }

        private void button_Edit_Click(object sender, System.EventArgs e)
        {
            this.DisableControlOnBusy_delegate_VoidNoArg(EditSelectedRows);
        }
    }
}