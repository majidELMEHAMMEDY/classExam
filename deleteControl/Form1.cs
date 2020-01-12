using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace deleteControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dat = new DataClasses1DataContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            Rempli();  dataGridView1.AllowUserToAddRows = false;
        }
        private void Rempli()
        {
          
            var t = from emp in dat.users
                    select emp;
            dataGridView1.DataSource = t;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.ColumnIndex;
            if (i == 1)
            {


                string Dtgv = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                MessageBox.Show(Dtgv);
                var a = dat.users.SingleOrDefault(delegate (user x)
                {
                    return x.empno.Equals(int.Parse(Dtgv));
                });
                dat.users.DeleteOnSubmit(a);
                dat.SubmitChanges();
                Rempli();

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = true;
                }
            }
            else
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value))
                {
                    var deleted = dat.users.SingleOrDefault(delegate (user u)
                    {
                        return u.empno.Equals(int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()));
                    });
                   
                    dat.users.DeleteOnSubmit(deleted);
                    dat.SubmitChanges();
                }
            }
            Rempli();

        }
    }
}
