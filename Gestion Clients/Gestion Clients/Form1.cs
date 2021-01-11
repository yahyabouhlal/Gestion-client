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

namespace Gestion_Clients
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-UAFP1DM; initial catalog=Gestion; integrated security=true;");
        DataSet DS = new DataSet();
        SqlDataAdapter DA;


       

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow Ligne = DS.Tables["client"].NewRow();
            Ligne[0] = int.Parse(Identity.Text);
            Ligne[1] = nom.Text;
            Ligne[2] = Prenom.Text;
            Ligne[3] = Adresse.Text;
            Ligne[4] = Ville.Text;
            DS.Tables["client"].Rows.Add(Ligne);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DA = new SqlDataAdapter("Select * from Client", cnx);
            DA.Fill(DS, "client");
            dataGridView1.DataSource = DS.Tables["client"];
        }

        private void nom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int p = -1;
            for (int i = 0; i < DS.Tables["client"].Rows.Count; i++)
            {
                if (Identity.Text == DS.Tables["client"].Rows[i][0].ToString())
                {
                    p = i;
                }
            }
            if (p == -1) { MessageBox.Show("Client introuvale"); }
            else
            {
                DS.Tables["client"].Rows.RemoveAt(p);
                MessageBox.Show("client suprimer");
            }
            
        }

        private void Modify_Click(object sender, EventArgs e)
        {
            int p = -1;
            for (int i = 0; i < DS.Tables["client"].Rows.Count; i++)
            {
                if (Identity.Text == DS.Tables["client"].Rows[i][0].ToString())
                {
                    p = i;
                }
            }
            if (p == -1) { MessageBox.Show("Client introuvale"); }
            else
            {
                DS.Tables["client"].Rows[p][0] = int.Parse(Identity.Text);
                DS.Tables["client"].Rows[p][1] = nom.Text;
                DS.Tables["client"].Rows[p][2] = Prenom.Text;
                DS.Tables["client"].Rows[p][3] = Adresse.Text;
                DS.Tables["client"].Rows[p][4] = Ville.Text;
                MessageBox.Show("client suprimer");
            }

        }
    }
}
