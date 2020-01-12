using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLingToSql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox_nom.Enabled = false;
            textBox_job.Enabled = false;
            comboBox_dep.Enabled = false;
        }
        bool a=true;
        private void checkBox_nom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_nom.Checked) { textBox_nom.Enabled = true; a = !a; }
            else { textBox_nom.Enabled = false; a = !a; }
            
        }

        private void checkBox_job_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_job.Checked) { textBox_job.Enabled = true; a = !a; }
            else { textBox_job.Enabled = false; a = !a; }
        }

        private void checkBox_dep_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_dep.Checked) { comboBox_dep.Enabled = true; a = !a; }
            else { comboBox_dep.Enabled = false; a = !a; }
        }
        DataTable dt = new DataTable();
        private void Recherche_Click(object sender, EventArgs e)
        {
            bool a, b, k = false;
            a = b = k;
            DataSet ds = new DataSet();

            using (DataClasses1DataContext Dat = new DataClasses1DataContext())
            {

                var t=(object)null;
                if (checkBox_nom.Checked)
                {
                    a = true;
                     t = from emp in Dat.users
                            where emp.empname.Equals(textBox_nom.Text)
                            select emp;
                    
                }
                else
                {
                    a = false;
                }
                if (checkBox_job.Checked)
                {
                    b = true;
                    t = from emp in Dat.users
                            where emp.job.Equals(textBox_job.Text)
                            select emp;
                    
                }
                else
                {
                    b = false;
                }
                if (checkBox_dep.Checked)
                {
                    k = true;
                    t = from emp in Dat.users
                            where emp.deptno.Equals(comboBox_dep.Text)
                            select emp;
                    
                }
                else
                {
                    k = false;
                }
                if (a && b && k)
                {
                     t = from emp in Dat.users
                            where emp.empname.Equals(textBox_nom.Text)
                              && emp.job.Equals(textBox_job.Text)
                              && emp.deptno.Equals(comboBox_dep.Text)
                            select emp;
                   
                }
               else if (a & b)
                {
                     t = from emp in Dat.users
                            where emp.empname.Equals(textBox_nom.Text)
                              && emp.job.Equals(textBox_job.Text)

                            select emp;
                    
                }
                else if (b & k)
                {
                     t = from emp in Dat.users
                            where
                               emp.job.Equals(textBox_job.Text)
                              && emp.deptno.Equals(comboBox_dep.Text)
                            select emp;
                    
                }
                else if (a & k)
                {
                    t = from emp in Dat.users
                            where emp.empname.Equals(textBox_nom.Text)

                              && emp.deptno.Equals(comboBox_dep.Text)
                            select emp;
                   
                }
                dataGridView1.DataSource = t;






            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
