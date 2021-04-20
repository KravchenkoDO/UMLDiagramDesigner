using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML_Diagram_Designer
{
    public partial class EditClassTextForm : Form
    {
        List<string> listClassText;
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
            DataTable dt = new DataTable();
            dt.Columns.Add("Elements", typeof(string));

            foreach (var element in listClassText)
            {
                dt.Rows.Add(element); 
            }
            dataGridView1.DataSource = dt;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
