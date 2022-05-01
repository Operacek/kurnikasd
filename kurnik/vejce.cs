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


    public partial class vejce : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Path.GetDirectoryName(Application.ExecutablePath) + "\\db.mdf;Integrated Security=True");        //Promenne
        string idFull { get; set; }
        string id { get; set; }
        string den { get; set; }
        DateTime datum { get; set; }
        int hneda { get; set; }
        int zelena { get; set; }
        int bila { get; set; }
        int kremova { get; set; }
        int ksCelkem { get; set; }
        int prodano { get; set; }
        double cena { get; set; }
        int darovano { get; set; }
        public int sumHneda = 0;
        public int sumZelena = 0;
        public int sumBila = 0;
        public int sumKremova = 0;
        public int sumProdano = 0;
        public int sumDarovano = 0;
        public int sumCelkem = 0;

        public vejce()
        {
            InitializeComponent();
            reloadSql();
        }

        // reloadSql (Celkove nacteni do grid_Vejce\\
        public void reloadSql()
        {
            connection.Close();
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            cmd.CommandText = "select * from [vejce] order by datum";
            dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            grid_Vejce.DataSource = dta;
            grid_Vejce.Columns["id"].Visible = false;
            connection.Close();
        }
        // -- reloadSql (Celkove nacteni do grid_Vejce -- \\


        // ++ add ++ \\

        // add picture main \\
        private void pBoxAddMain_Click(object sender, EventArgs e)
        {
            panelAdd.Show();
            pInventar.Hide();
            pnlEdit.Hide();
            pFilter.Hide();
            txtBBila.Text = "0";
            txtBHneda.Text = "0";
            txtBKremova.Text = "0";
            txtBZelena.Text = "0";

        }
        // --add picture main -- \\


        public SqlCommand cmd;
        public DataTable dta;
        SqlDataAdapter dataadp;
        //  add picture inside
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DateTime datum = dateAdd.Value;
            prodano = 0;
            darovano = 0;
            cena = 0;
            int intparse;
            if (int.TryParse(txtBZelena.Text, out intparse) && int.TryParse(txtBHneda.Text, out intparse) && int.TryParse(txtBBila.Text, out intparse) && int.TryParse(txtBKremova.Text, out intparse))
            {
                hneda = Int32.Parse(txtBHneda.Text);
                bila = Int32.Parse(txtBBila.Text);
                zelena = Int32.Parse(txtBZelena.Text);
                kremova = Int32.Parse(txtBKremova.Text);
                ksCelkem = hneda + bila + zelena + kremova;



                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = "insert into [vejce] (Den,Datum,Hneda,Zelena,Bila,Kremova,CelkemVajec,Prodano,Cena,Darovano) values ('" + datum.DayOfWeek + "','" + datum.Date + "','" + hneda + "','" + zelena + "','" + bila + "','" + kremova + "','" + ksCelkem + "','" + prodano + "','" + cena + "','" + darovano + "' )";
                cmd.ExecuteNonQuery();

                reloadSql();
                connection.Close();
            }
            else
            {
                MessageBox.Show("Jeden ze zadávaných údajů je špatně zadaný, nebo prázdný!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }


        }
        // --add picture inside-- \\



        // add window txt changed \\
        private void txtBHneda_TextChanged(object sender, EventArgs e)
        {
            int intparse = 0;
            if (txtBBila.Text != null && txtBHneda.Text != null && txtBKremova.Text != null && txtBZelena != null)
            {
                if (int.TryParse(txtBZelena.Text, out intparse) && int.TryParse(txtBHneda.Text, out intparse) && int.TryParse(txtBBila.Text, out intparse) && int.TryParse(txtBKremova.Text, out intparse))
                {
                    hneda = Int32.Parse(txtBHneda.Text);
                    bila = Int32.Parse(txtBBila.Text);
                    zelena = Int32.Parse(txtBZelena.Text);
                    kremova = Int32.Parse(txtBKremova.Text);
                    ksCelkem = hneda + bila + zelena + kremova;
                    txtBSoucet.Text = ksCelkem.ToString();
                    lblAddError.Visible = false;
                }
                else { lblAddError.Visible = true; }
            }
        }

        private void txtBZelena_TextChanged(object sender, EventArgs e)
        {
            int intparse = 0;
            if (txtBBila.Text != null && txtBHneda.Text != null && txtBKremova.Text != null && txtBZelena != null)
            {
                if (int.TryParse(txtBZelena.Text, out intparse) && int.TryParse(txtBHneda.Text, out intparse) && int.TryParse(txtBBila.Text, out intparse) && int.TryParse(txtBKremova.Text, out intparse))
                {
                    hneda = Int32.Parse(txtBHneda.Text);
                    bila = Int32.Parse(txtBBila.Text);
                    zelena = Int32.Parse(txtBZelena.Text);
                    kremova = Int32.Parse(txtBKremova.Text);
                    ksCelkem = hneda + bila + zelena + kremova;
                    txtBSoucet.Text = ksCelkem.ToString();
                    lblAddError.Visible = false;
                }
                else { lblAddError.Visible = true; }

            }
        }

        private void txtBBila_TextChanged(object sender, EventArgs e)
        {
            int intparse = 0;
            if (txtBBila.Text != null && txtBHneda.Text != null && txtBKremova.Text != null && txtBZelena != null)
            {
                if (int.TryParse(txtBZelena.Text, out intparse) && int.TryParse(txtBHneda.Text, out intparse) && int.TryParse(txtBBila.Text, out intparse) && int.TryParse(txtBKremova.Text, out intparse))
                {
                    hneda = Int32.Parse(txtBHneda.Text);
                    bila = Int32.Parse(txtBBila.Text);
                    zelena = Int32.Parse(txtBZelena.Text);
                    kremova = Int32.Parse(txtBKremova.Text);
                    ksCelkem = hneda + bila + zelena + kremova;
                    //grid_Vejce.Rows.Add(datum.DayOfWeek, datum.Date, hneda, zelena, bila, kremova, hneda + bila + zelena + kremova);
                    txtBSoucet.Text = ksCelkem.ToString();
                    lblAddError.Visible = false;
                }
                else { lblAddError.Visible = true; }
            }
        }

        private void txtBKremova_TextChanged(object sender, EventArgs e)
        {
            int intparse = 0;
            if (txtBBila.Text != null && txtBHneda.Text != null && txtBKremova.Text != null && txtBZelena != null)
            {
                if (int.TryParse(txtBZelena.Text, out intparse) && int.TryParse(txtBHneda.Text, out intparse) && int.TryParse(txtBBila.Text, out intparse) && int.TryParse(txtBKremova.Text, out intparse))
                {
                    hneda = Int32.Parse(txtBHneda.Text);
                    bila = Int32.Parse(txtBBila.Text);
                    zelena = Int32.Parse(txtBZelena.Text);
                    kremova = Int32.Parse(txtBKremova.Text);
                    ksCelkem = hneda + bila + zelena + kremova;
                    //grid_Vejce.Rows.Add(datum.DayOfWeek, datum.Date, hneda, zelena, bila, kremova, hneda + bila + zelena + kremova);
                    txtBSoucet.Text = ksCelkem.ToString();
                    lblAddError.Visible = false;
                }
                else { lblAddError.Visible = true; }
            }
        }
        // -- add window txt changed -- \\


        // == add == \\








        // ++ edit ++ \\

        // edit picture main \\
        private void pBoxEdit_Click(object sender, EventArgs e)
        {

            panelAdd.Visible = false;
            pInventar.Visible = false;

            pFilter.Hide();

            if (grid_Vejce.SelectedRows.Count == 1)
            {
                pnlEdit.Visible = true;
                txtB_EditDen.Text = " ";
                txtB_EditHneda.Text = " ";
                txtB_EditZelena.Text = " ";
                txtB_EditBila.Text = " ";
                txtB_EditKremova.Text = " ";
                txtB_EditCelkemVajec.Text = " ";
                txtB_EditProdano.Text = " ";
                txtB_EditCena.Text = " ";
                txtBDarovano.Text = " ";


                txtB_EditDen.Text = den;
                txtB_EditHneda.Text = hneda.ToString();
                txtB_EditZelena.Text = zelena.ToString();
                txtB_EditBila.Text = bila.ToString();
                txtB_EditKremova.Text = kremova.ToString();
                txtB_EditCelkemVajec.Text = ksCelkem.ToString();
                txtB_EditProdano.Text = prodano.ToString();
                txtB_EditCena.Text = cena.ToString();
                txtB_EditDarovano.Text = darovano.ToString();
            }
            else
            {
                MessageBox.Show("Označ řádek pro edit!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // -- edit picture main -- \\

        
        // edit window txt changed \\
        private void txtB_EditCelkemVajec_TextChanged(object sender, EventArgs e)
        {
            int intparse = 0;
            if (txtBBila.Text != null && txtBHneda.Text != null && txtBKremova.Text != null && txtBZelena != null)
            {
                if (int.TryParse(txtBZelena.Text, out intparse) && int.TryParse(txtBHneda.Text, out intparse) && int.TryParse(txtBBila.Text, out intparse) && int.TryParse(txtBKremova.Text, out intparse))
                {
                    hneda = Int32.Parse(txtBHneda.Text);
                    bila = Int32.Parse(txtBBila.Text);
                    zelena = Int32.Parse(txtBZelena.Text);
                    kremova = Int32.Parse(txtBKremova.Text);
                    ksCelkem = hneda + bila + zelena + kremova;
                    //grid_Vejce.Rows.Add(datum.DayOfWeek, datum.Date, hneda, zelena, bila, kremova, hneda + bila + zelena + kremova);
                    txtBSoucet.Text = ksCelkem.ToString();
                    lblAddError.Visible = false;
                }
                else { lblAddError.Visible = true; }
            }
        }

        private void txtB_EditHneda_TextChanged(object sender, EventArgs e)
        {
            int intparse = 0;
            if (txtB_EditHneda.Text != null && txtB_EditBila.Text != null && txtB_EditZelena.Text != null && txtB_EditKremova != null)
            {
                if (int.TryParse(txtB_EditHneda.Text, out intparse) && int.TryParse(txtB_EditBila.Text, out intparse) && int.TryParse(txtB_EditZelena.Text, out intparse) && int.TryParse(txtB_EditKremova.Text, out intparse))
                {
                    hneda = Int32.Parse(txtB_EditHneda.Text);
                    bila = Int32.Parse(txtB_EditBila.Text);
                    zelena = Int32.Parse(txtB_EditZelena.Text);
                    kremova = Int32.Parse(txtB_EditKremova.Text);
                    ksCelkem = hneda + bila + zelena + kremova;
                    txtB_EditCelkemVajec.Text = ksCelkem.ToString();
                    lblEditError.Visible = false;
                }
                else { lblEditError.Visible = true; }
            }
        }

        private void txtB_EditZelena_TextChanged(object sender, EventArgs e)
        {
            int intparse = 0;
            if (txtB_EditHneda.Text != null && txtB_EditBila.Text != null && txtB_EditZelena.Text != null && txtB_EditKremova != null)
            {
                if (int.TryParse(txtB_EditHneda.Text, out intparse) && int.TryParse(txtB_EditBila.Text, out intparse) && int.TryParse(txtB_EditZelena.Text, out intparse) && int.TryParse(txtB_EditKremova.Text, out intparse))
                {
                    hneda = Int32.Parse(txtB_EditHneda.Text);
                    bila = Int32.Parse(txtB_EditBila.Text);
                    zelena = Int32.Parse(txtB_EditZelena.Text);
                    kremova = Int32.Parse(txtB_EditKremova.Text);
                    ksCelkem = hneda + bila + zelena + kremova;
                    txtB_EditCelkemVajec.Text = ksCelkem.ToString();
                    lblEditError.Visible = false;
                }
                else { lblEditError.Visible = true; }
            }
        }

        private void txtB_EditKremova_TextChanged(object sender, EventArgs e)
        {
            int intparse = 0;
            if (txtB_EditHneda.Text != null && txtB_EditBila.Text != null && txtB_EditZelena.Text != null && txtB_EditKremova != null)
            {
                if (int.TryParse(txtB_EditHneda.Text, out intparse) && int.TryParse(txtB_EditBila.Text, out intparse) && int.TryParse(txtB_EditZelena.Text, out intparse) && int.TryParse(txtB_EditKremova.Text, out intparse))
                {
                    hneda = Int32.Parse(txtB_EditHneda.Text);
                    bila = Int32.Parse(txtB_EditBila.Text);
                    zelena = Int32.Parse(txtB_EditZelena.Text);
                    kremova = Int32.Parse(txtB_EditKremova.Text);
                    ksCelkem = hneda + bila + zelena + kremova;
                    txtB_EditCelkemVajec.Text = ksCelkem.ToString();
                    lblEditError.Visible = false;
                }
                else { lblEditError.Visible = true; }
            }
        }

        private void txtB_EditBila_TextChanged(object sender, EventArgs e)
        {
            int intparse = 0;
            if (txtB_EditHneda.Text != null && txtB_EditBila.Text != null && txtB_EditZelena.Text != null && txtB_EditKremova != null)
            {
                if (int.TryParse(txtB_EditHneda.Text, out intparse) && int.TryParse(txtB_EditBila.Text, out intparse) && int.TryParse(txtB_EditZelena.Text, out intparse) && int.TryParse(txtB_EditKremova.Text, out intparse))
                {
                    hneda = Int32.Parse(txtB_EditHneda.Text);
                    bila = Int32.Parse(txtB_EditBila.Text);
                    zelena = Int32.Parse(txtB_EditZelena.Text);
                    kremova = Int32.Parse(txtB_EditKremova.Text);
                    ksCelkem = hneda + bila + zelena + kremova;
                    txtB_EditCelkemVajec.Text = ksCelkem.ToString();
                    lblEditError.Visible = false;
                }
                else { lblEditError.Visible = true; }
            }
        }

        private void txtB_EditDen_TextChanged(object sender, EventArgs e)
        {

            if (txtB_EditDen == null)
            {
                lblEditError.Visible = true;
            }
            else { lblEditError.Visible = false; }
        }

        private void txtB_EditProdano_TextChanged(object sender, EventArgs e)
        {
            int intparse = 0;
            if (txtB_EditHneda.Text != null && txtB_EditBila.Text != null && txtB_EditZelena.Text != null && txtB_EditKremova != null)
            {
                if (int.TryParse(txtB_EditHneda.Text, out intparse) && int.TryParse(txtB_EditBila.Text, out intparse) && int.TryParse(txtB_EditZelena.Text, out intparse) && int.TryParse(txtB_EditKremova.Text, out intparse))
                {
                    lblEditError.Visible = false;
                }
                else { lblEditError.Visible = true; }
            }
        }

        private void txtB_EditCena_TextChanged(object sender, EventArgs e)
        {
            int intparse = 0;
            if (txtB_EditHneda.Text != null && txtB_EditBila.Text != null && txtB_EditZelena.Text != null && txtB_EditKremova != null)
            {
                if (int.TryParse(txtB_EditHneda.Text, out intparse) && int.TryParse(txtB_EditBila.Text, out intparse) && int.TryParse(txtB_EditZelena.Text, out intparse) && int.TryParse(txtB_EditKremova.Text, out intparse))
                {
                    lblEditError.Visible = false;
                }
                else { lblEditError.Visible = true; }
            }
        }

        private void txtB_EditDarovano_TextChanged(object sender, EventArgs e)
        {
            int intparse = 0;
            if (txtB_EditHneda.Text != null && txtB_EditBila.Text != null && txtB_EditZelena.Text != null && txtB_EditKremova != null)
            {
                if (int.TryParse(txtB_EditHneda.Text, out intparse) && int.TryParse(txtB_EditBila.Text, out intparse) && int.TryParse(txtB_EditZelena.Text, out intparse) && int.TryParse(txtB_EditKremova.Text, out intparse))
                {
                    lblEditError.Visible = false;
                }
                else { lblEditError.Visible = true; }
            }
        }

        // -- edit window txt changed-- \\


        // edit date changed \\
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            datum = dateEdit.Value;
            txtB_EditDen.Text = Convert.ToString(datum.DayOfWeek);
        }

        // -- edit date changed \\

        // picture box edit confirm \\ 
        private void pBoxEditConfirm_Click(object sender, EventArgs e)
        {

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);

            //cmd.CommandText = "select * from [Table]";
            den = Convert.ToString(datum.DayOfWeek);
            prodano = Int32.Parse(txtB_EditProdano.Text);
            cena = Double.Parse(txtB_EditCena.Text);
            darovano = Int32.Parse(txtB_EditDarovano.Text);
            cmd.CommandText = "Update [vejce] set Den='" + den + "',Datum='" + datum + "',hneda='" + hneda + "',zelena = '" + zelena + "',bila = '" + bila + "',kremova = '" + kremova + "',CelkemVajec = '" + ksCelkem + "',Prodano = '" + prodano + "',Cena = '" + cena + "',Darovano = '" + darovano + "' where id = '" + id + "'";
            cmd.ExecuteNonQuery();
            reloadSql();
            connection.Close();
        }
        // --picture box edit confirm --\\ 
        // == edit == \\


        // ++ delete row ++ \\
        private void pBoxRemove_Click(object sender, EventArgs e)
        {
            if (grid_Vejce.SelectedRows.Count == 1)
            {
                DialogResult dr = MessageBox.Show("Opravdu chces odstranit řádek?", "Odstranění", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                switch (dr)
                {
                    case DialogResult.Yes:
                        connection.Open();
                        SqlCommand cmd = connection.CreateCommand();
                        cmd.CommandType = CommandType.Text;

                        cmd.CommandText = "DELETE FROM [vejce] WHERE id='" + id + "'";
                        cmd.ExecuteNonQuery();
                        reloadSql();
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            else { MessageBox.Show("Označ řádek pro odstranění!", "Chyba", MessageBoxButtons.OK); }
        }

        // == delete row == \\



        //  ++ filter ++ \\

        // filter picture main \\
        private void pBoxFilter_Click(object sender, EventArgs e)
        {

            pFilter.Show();
            panelAdd.Hide();
            pnlEdit.Hide();
            pInventar.Hide();
            filterReset();
        }

        // -- filter picture main -- \\



        // filter reset button \\
        private void btnFilterRestart_Click(object sender, EventArgs e)
        {
            reloadSql();
            filterReset();
        }

        // -- filter reset button -- \\



        // filter confirm button \\
        private void pBoxFilterConfirm_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = new DateTime();
            DateTime dateTo = new DateTime();
            //from to
            dateFrom = dateFilterFrom.Value.AddDays(-1);
            dateTo = dateFilterTo.Value;

            if (dateFrom <= dateTo)
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd);

                //cmd.CommandText = "select * from [Table]";            
                cmd.CommandText = "select * from [vejce] where Datum BETWEEN '" + dateFrom + "' and '" + dateTo + "' ORDER BY Datum";
                dataadp = new SqlDataAdapter(cmd);
                dataadp.Fill(dta);
                grid_Vejce.DataSource = dta;

                connection.Close();
                sumHneda = 0;
                sumZelena = 0;
                sumBila = 0;
                sumKremova = 0;
                sumProdano = 0;
                sumDarovano = 0;
                sumCelkem = 0;
                filterReset();
            }
            else
            {
                MessageBox.Show("Špatně zadaný datum!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        // -- filter confirm button -- \\


        // == filter == \\



        // ++ inventar ++ \\

        // inventar main \\
        private void btn_Click(object sender, EventArgs e)
        {
            panelAdd.Hide();
            pInventar.Show();
            pFilter.Hide();
            pnlEdit.Hide();
            //hide inside panel
            lblInvKusy.Hide();
            lblInvCena.Hide();
            lblInvDatum.Hide();
            txtBInvCena.Hide();
            txtBInvKusy.Hide();
            dateInv.Hide();
            btnInventarConfirm.Hide();
            reloadSql();
            invTxtBoxReload();
            // -- hide inside panel---

            // -- zapis celkem --
        }

        // -- inventar main -- \\


        // inventar button prodano \\
        private void btnInvProdej_Click(object sender, EventArgs e)
        {
            lblInvKusy.Show();
            lblInvCena.Show();
            lblInvDatum.Show();
            txtBInvCena.Show();
            txtBInvKusy.Show();
            dateInv.Show();
            btnInventarConfirm.Show();
            txtBInvCena.Text = "0";
            txtBInvKusy.Text = "0";
            btnInventarConfirm.Text = "Prodej";
        }

        // -- inventar button prodano -- \\


        // inventar button daruj \\
        private void btnInvDarovano_Click(object sender, EventArgs e)
        {
            lblInvKusy.Show();
            lblInvCena.Hide();
            lblInvDatum.Show();
            txtBInvCena.Hide();
            txtBInvKusy.Show();
            dateInv.Show();
            btnInventarConfirm.Show();
            txtBInvCena.Text = "0";
            txtBInvKusy.Text = "0";
            btnInventarConfirm.Text = "Daruj!";
        }
        // -- inventar button daruj -- \\


        //  inventar button confirm \\
        private void btnInventarConfirm_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);


            //cmd.CommandText = "";
            //dataadp = new SqlDataAdapter(cmd);
            //dataadp.Fill(dta);
            int kusy;
            int cena;
            if (lblInvCena.Visible == false)
            {
                int tryparse;
                if (int.TryParse(txtBInvKusy.Text, out tryparse) && lblInvCena.Text != null)
                {
                    kusy = Int32.Parse(txtBInvKusy.Text);
                    datum = dateInv.Value.Date;
                    cmd.CommandText = "update [vejce] set Darovano='" + kusy + "' where id = (select max(id) from [vejce] where datum =(select max(datum) from [vejce] where datum = '" + datum + "')) ";
                    cmd.ExecuteNonQuery();
                    reloadSql();
                }
                else
                {
                    MessageBox.Show("Špatně zadané kusy!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            else if (lblInvCena.Visible == true)
            {
                int tryparse;
                if (int.TryParse(txtBInvKusy.Text, out tryparse) && txtBInvKusy.Text != null && int.TryParse(txtBInvCena.Text, out tryparse) && txtBInvCena.Text != null)
                {
                    kusy = Int32.Parse(txtBInvKusy.Text);
                    datum = dateInv.Value.Date;
                    cena = Int32.Parse(txtBInvCena.Text);
                    //cmd.CommandText = "select * from [Table] order by datum";
                    //cmd.CommandText = "Update [Table] set Den='" + Den + "',Datum='" + Datum + "',hneda='" + hneda + "',zelena = '" + zelena + "',bila = '" + bila + "',kremova = '" + kremova + "',CelkemVajec = '" + ksCelkem + "',Prodano = '" + Prodano + "',Cena = '" + Cena + "',Darovano = '" + Darovano + "' where id = '" + id + "'";
                    //cmd.CommandText = "select top(1) id from [Table]";
                    //
                    cmd.CommandText = "select max(id) from [vejce] where datum =(select max(datum) from [vejce] where datum = '" + datum + "')";
                    dta = new DataTable();
                    dataadp.Fill(dta);
                    id = dta.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update [vejce] set Prodano='" + kusy + "', Cena='" + cena + "' where id = (select max(id) from [vejce] where datum =(select max(datum) from [vejce] where datum = '" + datum + "')) ";
                    cmd.ExecuteNonQuery();
                    reloadSql();
                }
                else
                {
                    MessageBox.Show("Špatně zadané hodnoty!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {

            }
            invTxtBoxReload();
            connection.Close();
        }

        // -- inventar button confirm -- \\


        // == inventar == \\ 


        // ++ methods ++ \\




        // invTxtBoxReload (Celkove nacteni txt Boxu v inventari) \\
        private void invTxtBoxReload()
        {
            int celkemVajec = 0;
            darovano = 0;
            prodano = 0;

            // soucet vsech hodnot v sloupci
            for (int i = 0; i < grid_Vejce.Rows.Count; i++)
            {
                string gridvalue = grid_Vejce.Rows[i].Cells["celkemVajec"].Value.ToString();
                celkemVajec = celkemVajec + Int32.Parse(gridvalue);
            }
            for (int i = 0; i < grid_Vejce.Rows.Count; i++)
            {
                string gridvalue = grid_Vejce.Rows[i].Cells["Darovano"].Value.ToString();
                darovano = darovano + Int32.Parse(gridvalue);
            }
            for (int i = 0; i < grid_Vejce.Rows.Count; i++)
            {
                string gridvalue = grid_Vejce.Rows[i].Cells["celkemVajec"].Value.ToString();
                prodano = prodano + Int32.Parse(gridvalue);
            }
            txtBSkladem.Text = celkemVajec.ToString();
            txtBProdano.Text = prodano.ToString();
            txtBDarovano.Text = darovano.ToString();
        }

        // -- invTxtBoxReload (Celkove nacteni txt Boxu v inventari) -- \\


        // kliknuti na radek v tabulce \\
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grid_Vejce.Refresh();
            id = grid_Vejce.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
            den = grid_Vejce.Rows[e.RowIndex].Cells["Den"].FormattedValue.ToString();
            datum = Convert.ToDateTime(grid_Vejce.Rows[e.RowIndex].Cells["Datum"].FormattedValue.ToString());
            hneda = Int32.Parse(grid_Vejce.Rows[e.RowIndex].Cells["hneda"].FormattedValue.ToString());
            zelena = Int32.Parse(grid_Vejce.Rows[e.RowIndex].Cells["zelena"].FormattedValue.ToString());
            bila = Int32.Parse(grid_Vejce.Rows[e.RowIndex].Cells["bila"].FormattedValue.ToString());
            kremova = Int32.Parse(grid_Vejce.Rows[e.RowIndex].Cells["kremova"].FormattedValue.ToString());
            ksCelkem = Int32.Parse(grid_Vejce.Rows[e.RowIndex].Cells["CelkemVajec"].FormattedValue.ToString());
            prodano = Int32.Parse(grid_Vejce.Rows[e.RowIndex].Cells["Prodano"].FormattedValue.ToString());
            cena = Double.Parse(grid_Vejce.Rows[e.RowIndex].Cells["Cena"].FormattedValue.ToString());
            darovano = Int32.Parse(grid_Vejce.Rows[e.RowIndex].Cells["Darovano"].FormattedValue.ToString());
        }
        // -- kliknuti na radek v tabulce -- \\


        // reload button \\
        private void btnReloadSql_Click(object sender, EventArgs e)
        {
            reloadSql();
        }
        // -- reload button -- \\



        // filter reload handler
        private void filterReset()
        {
            for (int i = 0; i < grid_Vejce.Rows.Count; i++)
            {
                sumHneda += Convert.ToInt32(grid_Vejce.Rows[i].Cells["hneda"].Value);
                sumZelena += Convert.ToInt32(grid_Vejce.Rows[i].Cells["zelena"].Value);
                sumBila += Convert.ToInt32(grid_Vejce.Rows[i].Cells["bila"].Value);
                sumKremova += Convert.ToInt32(grid_Vejce.Rows[i].Cells["kremova"].Value);
                sumProdano += Convert.ToInt32(grid_Vejce.Rows[i].Cells["Prodano"].Value);
                sumDarovano += Convert.ToInt32(grid_Vejce.Rows[i].Cells["Darovano"].Value);
            }
            sumCelkem = sumHneda + sumZelena + sumBila + sumKremova;
            txtBFilterHneda.Text = sumHneda.ToString();
            txtBFilterZelena.Text = sumZelena.ToString();
            txtBFilterBila.Text = sumBila.ToString();
            txtBFilterKremova.Text = sumKremova.ToString();
            txtBFilterProdano.Text = sumProdano.ToString();
            txtBFilterDarovano.Text = sumDarovano.ToString();
            txtBFilterCelkem.Text = sumCelkem.ToString();
        }
        // -- filter reload handler --


        // == methods == \\

























        private void grid_Vejce_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void grid_Vejce_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }




        // -- inventar --
    }
}
        
 

