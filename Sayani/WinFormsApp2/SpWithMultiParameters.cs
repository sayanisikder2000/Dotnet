using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class SpWithMultiParameters : Form
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-5E9DNII\\SAYANIDATABASE;Database=EmployeeTb;User Id=sa;Password=user123;");
        SqlCommand cmd;
        SqlParameter p1;

        public SpWithMultiParameters()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //cmd = new SqlCommand("SPEmp_Insert", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //p1 = new SqlParameter("@PEmpId", SqlDbType.Int);

            cmd = new SqlCommand("SPEmp_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            p1 = new SqlParameter("@PEmpId", SqlDbType.Int);
            p1.Value = Convert.ToInt32(txtEmpId.Text);
            cmd.Parameters.Add(p1);


            p1 = new SqlParameter("@PEmpName", SqlDbType.VarChar);
            p1.Value = txtEmpName.Text;
            cmd.Parameters.Add(p1);


            p1 = new SqlParameter("@PEmpDesg", SqlDbType.VarChar);
            p1.Value = txtEmpDesig.Text;
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter ("@PEmpDOJ", SqlDbType.DateTime);
            p1.Value = Convert.ToDateTime(txtEmpDoj.Text);
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@PEmpSal", SqlDbType.Int);
            p1.Value = Convert.ToInt32(txtEmpSal.Text);
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@PEmpDept", SqlDbType.Int);
            p1.Value = Convert.ToInt32(txtEmpDeptNo.Text);
            cmd.Parameters.Add(p1);


            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(i + "record(s)Inserted");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand( "SPEmp_Deletee", con); 
            cmd.CommandType = CommandType.StoredProcedure; 
            p1.Value = Convert.ToInt32(txtEmpId.Text); 
            cmd.Parameters.Add(p1);
            p1 = new SqlParameter("@PEmpId", SqlDbType.Int);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(i + "record(S)deleted");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
        }
    }
}
