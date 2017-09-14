using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp17
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            var baglantiCumlesi = "Data Source=CAVIDAN-PC\\SQLEXPRESS;Initial Catalog=CodeAcademy;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection bagla = new SqlConnection(baglantiCumlesi);
            bagla.Open();

            var sqlEmr = "select * from Sobeler";
            SqlCommand kamanda = new SqlCommand(sqlEmr, bagla);
            kamanda.ExecuteNonQuery();

            var adapter = new SqlDataAdapter(kamanda);
            var ds = new DataSet();
            adapter.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(ds.Tables[0].Rows[i]["Name"]);
            }


            var sqlEmrD = "select * from Hekimler";
            SqlCommand kamandaD = new SqlCommand(sqlEmrD, bagla);
            kamandaD.ExecuteNonQuery();

            var adapterD = new SqlDataAdapter(kamandaD);
            var dsD = new DataSet();
            adapterD.Fill(dsD);

            for (int i = 0; i < dsD.Tables[0].Rows.Count; i++)
            {
                comboBox5.Items.Add(dsD.Tables[0].Rows[i]["Name"].ToString() + " " + dsD.Tables[0].Rows[i]["SurName"].ToString());
            }

            var sqlEmrF = "select * from Tarix";
            SqlCommand kamandaF = new SqlCommand(sqlEmrF, bagla);
            kamandaD.ExecuteNonQuery();

            var adapterF = new SqlDataAdapter(kamandaF);
            var dsF = new DataSet();
            adapterF.Fill(dsF);

            for (int i = 0; i < dsF.Tables[0].Rows.Count; i++)
            {
                comboBox4.Items.Add(dsF.Tables[0].Rows[i]["Tarix"].ToString());
            }

            var sqlEmrG = "select * from Novbe";
            SqlCommand kamandaG = new SqlCommand(sqlEmrG, bagla);
            kamandaG.ExecuteNonQuery();

            var adapterG = new SqlDataAdapter(kamandaG);
            var dsG = new DataSet();
            adapterG.Fill(dsG);

            for (int i = 0; i < dsG.Tables[0].Rows.Count; i++)
            {
                comboBox2.Items.Add(dsG.Tables[0].Rows[i]["Name"].ToString() + " " + dsG.Tables[0].Rows[i]["Start_Time"].ToString() + " " + dsG.Tables[0].Rows[i]["End_Time"].ToString());
            }

        }

    }
}
