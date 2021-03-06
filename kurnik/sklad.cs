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

            cbox_edit_kategorie.Items.Add("krmeni");
            cbox_edit_kategorie.Items.Add("vybaveni");
            cbox_edit_kategorie.Items.Add("doplnky");


            reloadSql();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Path.GetDirectoryName(Application.ExecutablePath) + "\\db.mdf;Integrated Security=True");
        // ++ promenne ++ \\
        DateTime date = new DateTime();
        string datum;
        string kategorie;
        string polozka;
        string hmotnost;
        double cenaZaKus { get; set; }
        double kusy { get; set; }
        double cenaCelkem { get; set; }
        string id;
        public SqlCommand cmd;
        public DataTable dta;
        SqlDataAdapter dataadp;
        int intparse;

        // reloadSql

        public void reloadSql()
        {
            connection.Close();
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            cmd.CommandText = "select * from [sklad] order by datum";
            dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            grid_Sklad.DataSource = dta;
            grid_Sklad.Columns["id"].Visible = false;
            grid_Sklad.Columns["datum"].Visible = false;
            grid_Sklad.Columns["kusy"].Visible = false;
            grid_Sklad.Columns["cenazakus"].Visible = false;
            connection.Close();
        }





        // datagrid click event
        int index;       
        private void grid_Sklad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grid_Sklad.Refresh();
             
            
            date = Convert.ToDateTime(grid_Sklad.Rows[e.RowIndex].Cells["datum"].FormattedValue.ToString());
            kategorie = grid_Sklad.Rows[e.RowIndex].Cells["kategorasdie"].FormattedValue.ToString();
            polozka = grid_Sklad.Rows[e.RowIndex].Cells["polozka"].FormattedValue.ToString();
            hmotnost = grid_Sklad.Rows[e.RowIndex].Cells["hmotnost"].FormattedValue.ToString();
            cenaZaKus = Double.Parse(grid_Sklad.Rows[e.RowIndex].Cells["cenazakus"].FormattedValue.ToString());
            kusy = Double.Parse(grid_Sklad.Rows[e.RowIndex].Cells["kusy"].FormattedValue.ToString());
            cenaCelkem = Double.Parse(grid_Sklad.Rows[e.RowIndex].Cells["cenacelkem"].FormattedValue.ToString());
            id = grid_Sklad.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
            if (grid_Sklad.Visible)
            {
                
                date_sklad_edit.Value = date;                
                txtb_sklad_edit_polozka.Text = polozka;
                txtb_sklad_edit_hmotnost.Text = hmotnost;
                txtb_sklad_edit_cenaZaKus.Text = cenaZaKus.ToString();                
            }
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
            if (txtBox_pridatPolozku_hmotnost == null)
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

        }

        private void txtBox_pridatPolozku_kusy_TextChanged(object sender, EventArgs e)
        {

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

        // -- txt Changed -- \\


        // confirm \\
        private void btn_pridatPolozku_Confirm_Click(object sender, EventArgs e)
        {
            //kategorie
            date = date_pridatPolozku.Value;
            Double tryparse;
            if (cBox_pridatPolozku_kategorie.Text != null && txtBox_pridatPolozku_polozka.Text != null && txtBox_pridatPolozku_hmotnost.Text != null && txtBox_pridatPolozku_cenaZaKus.Text != null && cenaCelkem != null)
            {
                kategorie = cBox_pridatPolozku_kategorie.SelectedItem.ToString();
                polozka = txtBox_pridatPolozku_polozka.Text;
                hmotnost = txtBox_pridatPolozku_hmotnost.Text;
                cenaZaKus = double.Parse(txtBox_pridatPolozku_cenaZaKus.Text);

                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = "insert into [sklad] (datum,kategorie,polozka,hmotnost,cenazakus,kusy,cenacelkem) values('" + date.Date + "','" + kategorie + "','" + polozka + "','" + hmotnost + "','0','0','0')";
                cmd.ExecuteNonQuery();
                reloadSql();
                connection.Close();
            }
            else
            {
                MessageBox.Show("Jeden ze zadávaných údajů je špatně zadaný, nebo prázdný!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }



        }
        // -- confirm -- \\

        // pridat polozku main show button \\
        private void pridatPolozku_Click(object sender, EventArgs e)
        {
            pnl_sklad_pridatPolozku.Show();
            pnl_sklad_edit.Hide();
        }
        // -- pridat polozku main show button -- \\

        // == pridat polozku == \\



        // ++ edit ++ \\

        // txt changed \\
        private void txtb_sklad_edit_polozka_TextChanged(object sender, EventArgs e)
        {
            if (txtb_sklad_edit_polozka == null)
            {
                lbl_sklad_edit_error.Show();
            }
            else
            {
                lbl_sklad_edit_error.Hide();
            }
        }

        private void txtb_sklad_edit_hmotnost_TextChanged(object sender, EventArgs e)
        {
            if (txtb_sklad_edit_hmotnost == null)
            {
                lbl_sklad_edit_error.Show();
            }
            else
            {
                lbl_sklad_edit_error.Hide();
            }
        }

        private void txtb_sklad_edit_cenaZaKus_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtb_sklad_edit_kusy_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtb_sklad_edit_cenaCelkem_TextChanged(object sender, EventArgs e)
        {
            if (txtb_sklad_edit_polozka == null)
            {
                lbl_sklad_edit_error.Show();
            }
            else
            {
                lbl_sklad_edit_error.Hide();
            }
        }

        private void prehledPolozek_Click(object sender, EventArgs e)
        {
            reloadSql();
            pnl_sklad_edit.Hide();
            pnl_sklad_pridatPolozku.Hide();
            pnl_sklad_home.Show();
        }

        private void pnl_sklad_edit_confirm_Click(object sender, EventArgs e)
        {

            date = date_sklad_edit.Value;

            double doubleparse;
            if (cbox_edit_kategorie.Text != null && txtb_sklad_edit_polozka.Text != null && txtb_sklad_edit_hmotnost.Text != null && Double.TryParse(txtb_sklad_edit_cenaZaKus.Text, out doubleparse))
            {
                kategorie = cbox_edit_kategorie.SelectedItem.ToString();
                polozka = txtb_sklad_edit_polozka.Text;
                hmotnost = txtb_sklad_edit_hmotnost.Text;
                cenaZaKus = Double.Parse(txtb_sklad_edit_cenaZaKus.Text);
                connection.Close();
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = "update [sklad] set datum = '" + date.Date + "', kategorie = '" + kategorie + "', polozka = '"+polozka+"',hmotnost = '" + hmotnost + "', cenazakus = '" + cenaZaKus.ToString() + "' where id = '" + id + "'";
                cmd.ExecuteNonQuery();
                reloadSql();
                connection.Close();
            }
            else
            {
               
                MessageBox.Show("Špatně zadané hodnoty!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void krmeni_Click(object sender, EventArgs e)
        {
            connection.Close();
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            cmd.CommandText = "select * from [sklad] where kategorie = 'krmeni'  order by datum ";
            dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            grid_Sklad.DataSource = dta;
            grid_Sklad.Columns["id"].Visible = false;
            connection.Close();
            pnl_sklad_edit.Show();
            pnl_sklad_pridatPolozku.Show();
        }

        private void vybaveni_Click(object sender, EventArgs e)
        {
            connection.Close();
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            cmd.CommandText = "select * from [sklad] where kategorie = 'vybaveni'  order by datum ";
            dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            grid_Sklad.DataSource = dta;
            grid_Sklad.Columns["id"].Visible = false;
            connection.Close();
            pnl_sklad_edit.Show();
            pnl_sklad_pridatPolozku.Show();

        }

        private void doplnky_Click(object sender, EventArgs e)
        {
            connection.Close();
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            cmd.CommandText = "select * from [sklad] where kategorie = 'doplnky'  order by datum ";
            dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            grid_Sklad.DataSource = dta;
            grid_Sklad.Columns["id"].Visible = false;
            connection.Close();
            pnl_sklad_edit.Show();
            pnl_sklad_pridatPolozku.Show();
        }

        private void btn_sklad_prehledPolozek_pridat_Click(object sender, EventArgs e)
        {
            pnl_sklad_edit.Hide();
            pnl_sklad_pridatPolozku.Show();
            pnl_sklad_home.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnl_sklad_edit.Show();
            pnl_sklad_pridatPolozku.Hide();
            pnl_sklad_home.Hide();

        }
        private void btn_sklad_prehledPolozek_remove_Click(object sender, EventArgs e)
        {
            pnl_sklad_edit.Hide();
            pnl_sklad_pridatPolozku.Hide();
            if (grid_Sklad.SelectedRows.Count == 1)
            {
                DialogResult dr = MessageBox.Show("Opravdu chces odstranit řádek?", "Odstranění", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                switch (dr)
                {
                    case DialogResult.Yes:
                        connection.Open();
                        SqlCommand cmd = connection.CreateCommand();
                        cmd.CommandType = CommandType.Text;

                        cmd.CommandText = "DELETE FROM [sklad] WHERE id='" + id + "'";
                        cmd.ExecuteNonQuery();
                        reloadSql();
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            else { MessageBox.Show("Označ řádek pro odstranění!", "Chyba", MessageBoxButtons.OK); }
        }

        private void btn_sklad_edit_home_Click(object sender, EventArgs e)
        {
            pnl_sklad_edit.Hide();
            pnl_sklad_pridatPolozku.Hide();
            pnl_sklad_home.Show();
        }

        private void btn_sklad_add_home_Click(object sender, EventArgs e)
        {
            pnl_sklad_edit.Hide();
            pnl_sklad_pridatPolozku.Hide();
            pnl_sklad_home.Show();
        }


        // -- txt changed \\



        // == edit == \\


    }
}