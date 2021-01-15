using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsUI
{
    public partial class UserControl_DataGridView : UserControl
    {
        /// <summary>
        /// DataGridView
        /// </summary>
        public DataGridView dataGridView
        {
            get
            {
                return dataGridView_Data;
            }
        }
        /// <summary>
        /// DataGridView.DataSource
        /// </summary>
        public DataTable dataGridViewDataSource
        {
            set
            {
                dataGridView_Data.DataSource = value;
            }
            get
            {
                return (DataTable)dataGridView_Data.DataSource;
            }
        }

        /// <summary>
        /// DataGridView.ReadOnly
        /// </summary>
        public bool dataGridViewReadOnly
        {
            set
            {
                dataGridView_Data.ReadOnly = value;
            }
            get
            {
                return dataGridView_Data.ReadOnly;
            }
        }


        /// <summary>
        ///DataGridView排序後順序會與DataSource不同
        ///先轉成DataRowView取得Row屬性即為DataSource該DataRow
        ///再以IndexOf取得該項在DataSource中的Index
        /// </summary>
        /// <param name="dataGridViewRow"></param>
        /// <returns></returns>
        public int GetDataSourceRowIndexFromDataGridViewRow(DataGridViewRow dataGridViewRow)
        {
            DataRowView rowView = (DataRowView)dataGridViewRow.DataBoundItem;
            DataRow dataRow = rowView.Row;

            return dataGridViewDataSource.Rows.IndexOf(dataRow);
        }

        public List<int> GetDelSelectedRowsIndexList()
        {
            List<int> indexList = new List<int>();

            switch (dataGridView.SelectionMode)
            {
                default:
                case DataGridViewSelectionMode.CellSelect:
                    DataGridViewSelectedCellCollection cells = dataGridView.SelectedCells;
                    foreach (DataGridViewCell cell in cells)
                    {
                        int index = GetDataSourceRowIndexFromDataGridViewRow(cell.OwningRow);
                        
                        if (!indexList.Contains(index))
                        {
                            indexList.Add(index);
                        }
                    }
                    break;

                case DataGridViewSelectionMode.FullRowSelect:
                    DataGridViewSelectedRowCollection rows = dataGridView.SelectedRows;
                    foreach (DataGridViewRow row in rows)
                    {
                        int index = GetDataSourceRowIndexFromDataGridViewRow(row);

                        indexList.Add(index);
                    }
                    break;
            }

            return indexList;
        }
        public List<DataRow> GetSelectedRows()
        {
            List<DataRow> listRow = new List<DataRow>();

            List<int> indexList = GetDelSelectedRowsIndexList();
            foreach (int index in indexList)
            {
                listRow.Add(dataGridViewDataSource.Rows[index]);
            }

            return listRow;
        }

        public UserControl_DataGridView()
        {
            InitializeComponent();
        }
    }
}
