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

namespace kurnik
{
    public partial class sklad : UserControl
    {
        public sklad()
        {
            InitializeComponent();

            cBox_pridatPolozku_kategorie.Items.Add("krmeni");
            cBox_pridatPolozku_kategorie.Items.Add("vybaveni");
            cBox_pridatPolozku_kategorie.Items.Add("doplnky");
            reloadSql();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Path.GetDirectoryName(Application.ExecutablePath) + "\\db.mdf;Integrated Security=True");
        // ++ promenne ++ \\
        DateTime date = new DateTime();
        string kategorie;
        string polozka;
        string hmotnost;
        double cenaZaKus { get; set; }
        double kusy { get; set; }
        double cenaCelkem { get; set; }

        public SqlCommand cmd;
        public DataTable dta;
        SqlDataAdapter dataadp;
        int intparse;

        // reloadSql

        public void reloadSql()
        {
            connection.Close();
            connection.Open();
            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            dta = new DataTable();
            cmd.CommandText = "select * from [sklad] ordered by datum";
            grid_Sklad.DataSource = dta;
            //grid_Sklad.Columns["id"].Visible = false;
            connection.Close();
        }


        // ++ pridat polozku ++ \\


        // txt Changed \\ 
        private void txtBox_pridatPolozku_polozka_TextChanged(object sender, EventArgs e)
        {
            if (txtBox_pridatPolozku_polozka == null)
            {
                lbl_pridatPolozku_error.Show();
            }
            else
            {
                lbl_pridatPolozku_error.Hide();
            }
        }

        private void txtBox_pridatPolozku_hmotnost_TextChanged(object sender, EventArgs e)
        {
            if (txtBox_pridatPolozku_polozka == null)
            {
                lbl_pridatPolozku_error.Show();
            }
            else
            {
                lbl_pridatPolozku_error.Hide();
            }
        }

        private void txtBox_pridatPolozku_cenaZaKus_TextChanged(object sender, EventArgs e)
        {

            int intparse = 0;
            if (txtBox_pridatPolozku_cenaZaKus.Text != null)
            {
                if (int.TryParse(txtBox_pridatPolozku_cenaZaKus.Text, out intparse))
                {
                    cenaZaKus = Double.Parse(txtBox_pridatPolozku_cenaZaKus.Text);
                    if (int.TryParse(txtBox_pridatPolozku_kusy.Text, out intparse))
                    {
                        kusy = Double.Parse(txtBox_pridatPolozku_kusy.Text);
                        cenaCelkem = kusy * cenaZaKus;
                        txtBox_pridatPolozku_cenaCelkem.Text = cenaCelkem.ToString();
                    }

                    lbl_pridatPolozku_error.Visible = false;
                }
                else { lbl_pridatPolozku_error.Visible = true; }
            }
        }

        private void txtBox_pridatPolozku_kusy_TextChanged(object sender, EventArgs e)
        {
            int intparse = 0;
            if (txtBox_pridatPolozku_kusy.Text != null )
            {
                if (int.TryParse(txtBox_pridatPolozku_kusy.Text, out intparse)  )
                {
                    kusy = Double.Parse(txtBox_pridatPolozku_kusy.Text);
                    if (int.TryParse(txtBox_pridatPolozku_cenaZaKus.Text, out intparse))
                    {
                        cenaZaKus = Double.Parse(txtBox_pridatPolozku_cenaZaKus.Text);
                        cenaCelkem = kusy * cenaZaKus;
                        txtBox_pridatPolozku_cenaCelkem.Text = cenaCelkem.ToString();
                    }
                        
                    lbl_pridatPolozku_error.Visible = false;
                }
                else { lbl_pridatPolozku_error.Visible = true; }
            }
        }

        private void txtBox_pridatPolozku_cenaCelkem_TextChanged(object sender, EventArgs e)
        {
            if (txtBox_pridatPolozku_polozka == null)
            {
                lbl_pridatPolozku_error.Show();
            }
            else
            {
                lbl_pridatPolozku_error.Hide();
            }
        }

        private void btn_pridatPolozku_Confirm_Click(object sender, EventArgs e)
        {
            //kategorie
            date = date_pridatPolozku.Value;
            if(cBox_pridatPolozku_kategorie.Text != null && txtBox_pridatPolozku_polozka.Text != null && txtBox_pridatPolozku_hmotnost.Text != null && txtBox_pridatPolozku_cenaZaKus.Text != null && txtBox_pridatPolozku_kusy != null && cenaCelkem != null)
            {
                kategorie = cBox_pridatPolozku_kategorie.SelectedItem.ToString();
                polozka = txtBox_pridatPolozku_polozka.Text;
                hmotnost = txtBox_pridatPolozku_hmotnost.Text;
                cenaZaKus = double.Parse(txtBox_pridatPolozku_cenaZaKus.Text);
                kusy = double.Parse(txtBox_pridatPolozku_kusy.Text);
                cenaCelkem = double.Parse(txtBox_pridatPolozku_cenaCelkem.Text);

                connection.Open();
                cmd.Connection.CreateCommand();
                cmd.CommandText = "insert into [sklad] (datum,kategorie,polozka,hmotnost,cenazakus,kusy,cenacelkem) values('"+date.Date+"','"+kategorie+"','"+polozka+"','"+hmotnost+"','"+cenaZaKus.ToString()+"','"+kusy.ToString()+"','"+cenaCelkem.ToString()+"')";
                cmd.ExecuteNonQuery();
                reloadSql();
                connection.Close();
            }
            else
            {
                MessageBox.Show("Jeden ze zadávaných údajů je špatně zadaný, nebo prázdný!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }



        }

        // -- txt Changed -- \\
    }
}
