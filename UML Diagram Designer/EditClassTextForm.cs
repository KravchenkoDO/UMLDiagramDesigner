using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace UML_Diagram_Designer
{
    public partial class EditClassTextForm : Form
    {
        List<string> listClassText;
        DataTable dataTable;

        public EditClassTextForm()
        {
            InitializeComponent();
        }

        public EditClassTextForm(List<string> _currentClassTextList)
        {
            InitializeComponent();
            listClassText = _currentClassTextList;
        }

        private void EditClassTextForm_Load(object sender, EventArgs e)
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("Elements", typeof(string));

            foreach (var element in listClassText)
            {
                dataTable.Rows.Add(element);
            }
            dataGridView1.DataSource = dataTable;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Canvas canvas = Canvas.GetCanvas();

            listClassText.Clear();
            int col = 0;
            for (int rows = 0; rows < dataGridView1.Rows.Count - 1; rows++)
            {
                listClassText.Add(dataGridView1.Rows[rows].Cells[col].Value.ToString());
            }

            canvas._graphics.Clear(Color.White);
            canvas.RedrawElementsFromElementsList();

            this.Close();
        }
    }
}
