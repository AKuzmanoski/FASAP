using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace SmetkaZaNaracka
{
    public partial class FasapPocetenEkran : Form
    {
        public FasapPocetenEkran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchFilter sf = new SearchFilter();
            sf.ShowDialog();
        }

        private void FasapPocetenEkran_Load(object sender, EventArgs e)
        {/*
              string oradb = "Data Source=(DESCRIPTION="
             + "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1620))"
             + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));"
             + "User Id=DBA_20132014L_GRP_020;Password=7734924;";


	    // XXX = Workspace (od rabotni prostori)
	    // YYY = Password (od rabotni prostori)

            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = oradb;

            conn.Open();
	    



	    // OD TUKA E QUERY

            string sql = "select * from RESTORAN"; // C#
            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader(); // C#
            dr = cmd.ExecuteReader();
            dr.Read();

           // lbRestorani.Items.Add( dr["IME_RESTORAN"].ToString());
            //label3.Text = dr["GRAD"].ToString();

            Console.ReadLine();
            // C# retrieve by column name
            conn.Close(); */
        }
        }
    }

