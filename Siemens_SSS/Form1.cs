using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace Siemens_SSS
{
    
    public partial class Form1 : Form
    {
        public bool TextWasChanged = false;

        public Form1()
        {
            InitializeComponent();
        

        }



        private void Secimbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            
        }



        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }





        private void AnasayfaInfo_TextChanged(object sender, EventArgs e)
        {
            Anasayfa.Text = "Buraya gelen yazı";
        }

        private void LMSTextBox_TextChanged(object sender, EventArgs e)
        {
            
            string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "SELECT * FROM [dbo].[LMS] where [LMS-Soru] like'" + LMSTextBox.Text + "%'";


            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            
            dgvlms.DataSource = dt;
    
            sqlconn.Close();

        }

        private void GuncelleLMS_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "SELECT * FROM LMS ";


            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
       

        





            sqlconn.Close();
        }


    }

}