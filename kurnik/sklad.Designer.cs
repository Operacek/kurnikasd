namespace kurnik
{
    partial class sklad
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid_Sklad = new System.Windows.Forms.DataGridView();
            this.vybaveni = new System.Windows.Forms.Button();
            this.doplnky = new System.Windows.Forms.Button();
            this.prehledPolozek = new System.Windows.Forms.Button();
            this.krmeni = new System.Windows.Forms.Button();
            this.sqlReload = new System.Windows.Forms.Button();
            this.pnl_sklad_pridatPolozku = new System.Windows.Forms.Panel();
            this.btn_sklad_add_home = new System.Windows.Forms.Button();
            this.lbl_pridatPolozku_error = new System.Windows.Forms.Label();
            this.btn_pridatPolozku_Confirm = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_pridatPolozku_cenaZaKus = new System.Windows.Forms.TextBox();
            this.txtBox_pridatPolozku_hmotnost = new System.Windows.Forms.TextBox();
            this.txtBox_pridatPolozku_polozka = new System.Windows.Forms.TextBox();
            this.cBox_pridatPolozku_kategorie = new System.Windows.Forms.ComboBox();
            this.date_pridatPolozku = new System.Windows.Forms.DateTimePicker();
            this.pnl_sklad_edit = new System.Windows.Forms.Panel();
            this.btn_sklad_edit_home = new System.Windows.Forms.Button();
            this.lbl_sklad_edit_error = new System.Windows.Forms.Label();
            this.btn_sklad_edit_confirm = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtb_sklad_edit_cenaZaKus = new System.Windows.Forms.TextBox();
            this.txtb_sklad_edit_hmotnost = new System.Windows.Forms.TextBox();
            this.txtb_sklad_edit_polozka = new System.Windows.Forms.TextBox();
            this.cbox_edit_kategorie = new System.Windows.Forms.ComboBox();
            this.date_sklad_edit = new System.Windows.Forms.DateTimePicker();
            this.pnl_sklad_home = new System.Windows.Forms.Panel();
            this.btn_sklad_prehledPolozek_pridat = new System.Windows.Forms.Button();
            this.btn_sklad_prehledPolozek_edit = new System.Windows.Forms.Button();
            this.btn_sklad_prehledPolozek_remove = new System.Windows.Forms.Button();
            this.pnl_sklad_doplnky_menu = new System.Windows.Forms.Panel();
            this.btn_sklad_doplnky_menu_add = new System.Windows.Forms.Button();
            this.btn_sklad_doplnky_menu_remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Sklad)).BeginInit();
            this.pnl_sklad_pridatPolozku.SuspendLayout();
            this.pnl_sklad_edit.SuspendLayout();
            this.pnl_sklad_home.SuspendLayout();
            this.pnl_sklad_doplnky_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_Sklad
            // 
            this.grid_Sklad.AllowUserToAddRows = false;
            this.grid_Sklad.AllowUserToDeleteRows = false;
            this.grid_Sklad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Sklad.Location = new System.Drawing.Point(110, 65);
            this.grid_Sklad.Name = "grid_Sklad";
            this.grid_Sklad.ReadOnly = true;
            this.grid_Sklad.RowTemplate.Height = 25;
            this.grid_Sklad.Size = new System.Drawing.Size(633, 330);
            this.grid_Sklad.TabIndex = 0;
            this.grid_Sklad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Sklad_CellContentClick);
            this.grid_Sklad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Sklad_CellContentClick);
            // 
            // vybaveni
            // 
            this.vybaveni.Location = new System.Drawing.Point(11, 121);
            this.vybaveni.Name = "vybaveni";
            this.vybaveni.Size = new System.Drawing.Size(93, 50);
            this.vybaveni.TabIndex = 1;
            this.vybaveni.Text = "vybaveni";
            this.vybaveni.UseVisualStyleBackColor = true;
            this.vybaveni.Click += new System.EventHandler(this.vybaveni_Click);
            // 
            // doplnky
            // 
            this.doplnky.Location = new System.Drawing.Point(11, 177);
            this.doplnky.Name = "doplnky";
            this.doplnky.Size = new System.Drawing.Size(93, 50);
            this.doplnky.TabIndex = 2;
            this.doplnky.Text = "doplnky";
            this.doplnky.UseVisualStyleBackColor = true;
            this.doplnky.Click += new System.EventHandler(this.doplnky_Click);
            // 
            // prehledPolozek
            // 
            this.prehledPolozek.Location = new System.Drawing.Point(11, 233);
            this.prehledPolozek.Name = "prehledPolozek";
            this.prehledPolozek.Size = new System.Drawing.Size(93, 50);
            this.prehledPolozek.TabIndex = 3;
            this.prehledPolozek.Text = "Přehled položek";
            this.prehledPolozek.UseVisualStyleBackColor = true;
            this.prehledPolozek.Click += new System.EventHandler(this.prehledPolozek_Click);
            // 
            // krmeni
            // 
            this.krmeni.Location = new System.Drawing.Point(11, 65);
            this.krmeni.Name = "krmeni";
            this.krmeni.Size = new System.Drawing.Size(93, 50);
            this.krmeni.TabIndex = 5;
            this.krmeni.Text = "krmeni";
            this.krmeni.UseVisualStyleBackColor = true;
            this.krmeni.Click += new System.EventHandler(this.krmeni_Click);
            // 
            // sqlReload
            // 
            this.sqlReload.Location = new System.Drawing.Point(11, 345);
            this.sqlReload.Name = "sqlReload";
            this.sqlReload.Size = new System.Drawing.Size(93, 50);
            this.sqlReload.TabIndex = 6;
            this.sqlReload.Text = "sql reload";
            this.sqlReload.UseVisualStyleBackColor = true;
            // 
            // pnl_sklad_pridatPolozku
            // 
            this.pnl_sklad_pridatPolozku.Controls.Add(this.btn_sklad_add_home);
            this.pnl_sklad_pridatPolozku.Controls.Add(this.lbl_pridatPolozku_error);
            this.pnl_sklad_pridatPolozku.Controls.Add(this.btn_pridatPolozku_Confirm);
            this.pnl_sklad_pridatPolozku.Controls.Add(this.label6);
            this.pnl_sklad_pridatPolozku.Controls.Add(this.label5);
            this.pnl_sklad_pridatPolozku.Controls.Add(this.label4);
            this.pnl_sklad_pridatPolozku.Controls.Add(this.label3);
            this.pnl_sklad_pridatPolozku.Controls.Add(this.label1);
            this.pnl_sklad_pridatPolozku.Controls.Add(this.txtBox_pridatPolozku_cenaZaKus);
            this.pnl_sklad_pridatPolozku.Controls.Add(this.txtBox_pridatPolozku_hmotnost);
            this.pnl_sklad_pridatPolozku.Controls.Add(this.txtBox_pridatPolozku_polozka);
            this.pnl_sklad_pridatPolozku.Controls.Add(this.cBox_pridatPolozku_kategorie);
            this.pnl_sklad_pridatPolozku.Controls.Add(this.date_pridatPolozku);
            this.pnl_sklad_pridatPolozku.Location = new System.Drawing.Point(11, 404);
            this.pnl_sklad_pridatPolozku.Name = "pnl_sklad_pridatPolozku";
            this.pnl_sklad_pridatPolozku.Size = new System.Drawing.Size(731, 128);
            this.pnl_sklad_pridatPolozku.TabIndex = 7;
            this.pnl_sklad_pridatPolozku.Visible = false;
            // 
            // btn_sklad_add_home
            // 
            this.btn_sklad_add_home.BackgroundImage = global::kurnik.Properties.Resources.blue_home_page_icon_png_icon_png_button_home_11563017221o3yywd2nlp;
            this.btn_sklad_add_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sklad_add_home.Location = new System.Drawing.Point(209, 64);
            this.btn_sklad_add_home.Name = "btn_sklad_add_home";
            this.btn_sklad_add_home.Size = new System.Drawing.Size(50, 50);
            this.btn_sklad_add_home.TabIndex = 18;
            this.btn_sklad_add_home.UseVisualStyleBackColor = true;
            this.btn_sklad_add_home.Click += new System.EventHandler(this.btn_sklad_add_home_Click);
            // 
            // lbl_pridatPolozku_error
            // 
            this.lbl_pridatPolozku_error.AutoSize = true;
            this.lbl_pridatPolozku_error.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_pridatPolozku_error.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_pridatPolozku_error.Location = new System.Drawing.Point(388, 77);
            this.lbl_pridatPolozku_error.Name = "lbl_pridatPolozku_error";
            this.lbl_pridatPolozku_error.Size = new System.Drawing.Size(156, 17);
            this.lbl_pridatPolozku_error.TabIndex = 16;
            this.lbl_pridatPolozku_error.Text = "Něco je špatně zadané!";
            this.lbl_pridatPolozku_error.Visible = false;
            // 
            // btn_pridatPolozku_Confirm
            // 
            this.btn_pridatPolozku_Confirm.Location = new System.Drawing.Point(605, 75);
            this.btn_pridatPolozku_Confirm.Name = "btn_pridatPolozku_Confirm";
            this.btn_pridatPolozku_Confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_pridatPolozku_Confirm.TabIndex = 15;
            this.btn_pridatPolozku_Confirm.Text = "pridat";
            this.btn_pridatPolozku_Confirm.UseVisualStyleBackColor = true;
            this.btn_pridatPolozku_Confirm.Click += new System.EventHandler(this.btn_pridatPolozku_Confirm_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(431, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "POLOŽKA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(323, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "KATEGORIE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(657, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "CZK/KS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(572, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "HMOTNOST";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(209, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "DATUM";
            // 
            // txtBox_pridatPolozku_cenaZaKus
            // 
            this.txtBox_pridatPolozku_cenaZaKus.Location = new System.Drawing.Point(657, 32);
            this.txtBox_pridatPolozku_cenaZaKus.Name = "txtBox_pridatPolozku_cenaZaKus";
            this.txtBox_pridatPolozku_cenaZaKus.Size = new System.Drawing.Size(49, 23);
            this.txtBox_pridatPolozku_cenaZaKus.TabIndex = 5;
            this.txtBox_pridatPolozku_cenaZaKus.TextChanged += new System.EventHandler(this.txtBox_pridatPolozku_cenaZaKus_TextChanged);
            // 
            // txtBox_pridatPolozku_hmotnost
            // 
            this.txtBox_pridatPolozku_hmotnost.Location = new System.Drawing.Point(572, 32);
            this.txtBox_pridatPolozku_hmotnost.Name = "txtBox_pridatPolozku_hmotnost";
            this.txtBox_pridatPolozku_hmotnost.Size = new System.Drawing.Size(79, 23);
            this.txtBox_pridatPolozku_hmotnost.TabIndex = 3;
            this.txtBox_pridatPolozku_hmotnost.TextChanged += new System.EventHandler(this.txtBox_pridatPolozku_hmotnost_TextChanged);
            // 
            // txtBox_pridatPolozku_polozka
            // 
            this.txtBox_pridatPolozku_polozka.Location = new System.Drawing.Point(431, 32);
            this.txtBox_pridatPolozku_polozka.Name = "txtBox_pridatPolozku_polozka";
            this.txtBox_pridatPolozku_polozka.Size = new System.Drawing.Size(135, 23);
            this.txtBox_pridatPolozku_polozka.TabIndex = 2;
            this.txtBox_pridatPolozku_polozka.TextChanged += new System.EventHandler(this.txtBox_pridatPolozku_polozka_TextChanged);
            // 
            // cBox_pridatPolozku_kategorie
            // 
            this.cBox_pridatPolozku_kategorie.FormattingEnabled = true;
            this.cBox_pridatPolozku_kategorie.Location = new System.Drawing.Point(323, 32);
            this.cBox_pridatPolozku_kategorie.Name = "cBox_pridatPolozku_kategorie";
            this.cBox_pridatPolozku_kategorie.Size = new System.Drawing.Size(102, 23);
            this.cBox_pridatPolozku_kategorie.TabIndex = 1;
            // 
            // date_pridatPolozku
            // 
            this.date_pridatPolozku.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_pridatPolozku.Location = new System.Drawing.Point(209, 32);
            this.date_pridatPolozku.Name = "date_pridatPolozku";
            this.date_pridatPolozku.Size = new System.Drawing.Size(108, 23);
            this.date_pridatPolozku.TabIndex = 0;
            // 
            // pnl_sklad_edit
            // 
            this.pnl_sklad_edit.Controls.Add(this.btn_sklad_edit_home);
            this.pnl_sklad_edit.Controls.Add(this.lbl_sklad_edit_error);
            this.pnl_sklad_edit.Controls.Add(this.btn_sklad_edit_confirm);
            this.pnl_sklad_edit.Controls.Add(this.label10);
            this.pnl_sklad_edit.Controls.Add(this.label11);
            this.pnl_sklad_edit.Controls.Add(this.label12);
            this.pnl_sklad_edit.Controls.Add(this.label13);
            this.pnl_sklad_edit.Controls.Add(this.label15);
            this.pnl_sklad_edit.Controls.Add(this.txtb_sklad_edit_cenaZaKus);
            this.pnl_sklad_edit.Controls.Add(this.txtb_sklad_edit_hmotnost);
            this.pnl_sklad_edit.Controls.Add(this.txtb_sklad_edit_polozka);
            this.pnl_sklad_edit.Controls.Add(this.cbox_edit_kategorie);
            this.pnl_sklad_edit.Controls.Add(this.date_sklad_edit);
            this.pnl_sklad_edit.Location = new System.Drawing.Point(10, 403);
            this.pnl_sklad_edit.Name = "pnl_sklad_edit";
            this.pnl_sklad_edit.Size = new System.Drawing.Size(731, 128);
            this.pnl_sklad_edit.TabIndex = 8;
            this.pnl_sklad_edit.Visible = false;
            // 
            // btn_sklad_edit_home
            // 
            this.btn_sklad_edit_home.BackgroundImage = global::kurnik.Properties.Resources.blue_home_page_icon_png_icon_png_button_home_11563017221o3yywd2nlp;
            this.btn_sklad_edit_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sklad_edit_home.Location = new System.Drawing.Point(210, 59);
            this.btn_sklad_edit_home.Name = "btn_sklad_edit_home";
            this.btn_sklad_edit_home.Size = new System.Drawing.Size(50, 50);
            this.btn_sklad_edit_home.TabIndex = 17;
            this.btn_sklad_edit_home.UseVisualStyleBackColor = true;
            this.btn_sklad_edit_home.Click += new System.EventHandler(this.btn_sklad_edit_home_Click);
            // 
            // lbl_sklad_edit_error
            // 
            this.lbl_sklad_edit_error.AutoSize = true;
            this.lbl_sklad_edit_error.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_sklad_edit_error.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_sklad_edit_error.Location = new System.Drawing.Point(396, 81);
            this.lbl_sklad_edit_error.Name = "lbl_sklad_edit_error";
            this.lbl_sklad_edit_error.Size = new System.Drawing.Size(156, 17);
            this.lbl_sklad_edit_error.TabIndex = 16;
            this.lbl_sklad_edit_error.Text = "Něco je špatně zadané!";
            this.lbl_sklad_edit_error.Visible = false;
            // 
            // btn_sklad_edit_confirm
            // 
            this.btn_sklad_edit_confirm.Location = new System.Drawing.Point(605, 75);
            this.btn_sklad_edit_confirm.Name = "btn_sklad_edit_confirm";
            this.btn_sklad_edit_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_sklad_edit_confirm.TabIndex = 15;
            this.btn_sklad_edit_confirm.Text = "Editovat";
            this.btn_sklad_edit_confirm.UseVisualStyleBackColor = true;
            this.btn_sklad_edit_confirm.Click += new System.EventHandler(this.pnl_sklad_edit_confirm_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(431, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "POLOŽKA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(323, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "KATEGORIE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(657, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "CZK/KS";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(572, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 15);
            this.label13.TabIndex = 10;
            this.label13.Text = "HMOTNOST";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(209, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 15);
            this.label15.TabIndex = 8;
            this.label15.Text = "DATUM";
            // 
            // txtb_sklad_edit_cenaZaKus
            // 
            this.txtb_sklad_edit_cenaZaKus.Location = new System.Drawing.Point(657, 31);
            this.txtb_sklad_edit_cenaZaKus.Name = "txtb_sklad_edit_cenaZaKus";
            this.txtb_sklad_edit_cenaZaKus.Size = new System.Drawing.Size(49, 23);
            this.txtb_sklad_edit_cenaZaKus.TabIndex = 5;
            // 
            // txtb_sklad_edit_hmotnost
            // 
            this.txtb_sklad_edit_hmotnost.Location = new System.Drawing.Point(572, 31);
            this.txtb_sklad_edit_hmotnost.Name = "txtb_sklad_edit_hmotnost";
            this.txtb_sklad_edit_hmotnost.Size = new System.Drawing.Size(79, 23);
            this.txtb_sklad_edit_hmotnost.TabIndex = 3;
            // 
            // txtb_sklad_edit_polozka
            // 
            this.txtb_sklad_edit_polozka.Location = new System.Drawing.Point(431, 31);
            this.txtb_sklad_edit_polozka.Name = "txtb_sklad_edit_polozka";
            this.txtb_sklad_edit_polozka.Size = new System.Drawing.Size(135, 23);
            this.txtb_sklad_edit_polozka.TabIndex = 2;
            // 
            // cbox_edit_kategorie
            // 
            this.cbox_edit_kategorie.FormattingEnabled = true;
            this.cbox_edit_kategorie.Location = new System.Drawing.Point(323, 31);
            this.cbox_edit_kategorie.Name = "cbox_edit_kategorie";
            this.cbox_edit_kategorie.Size = new System.Drawing.Size(102, 23);
            this.cbox_edit_kategorie.TabIndex = 1;
            // 
            // date_sklad_edit
            // 
            this.date_sklad_edit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_sklad_edit.Location = new System.Drawing.Point(209, 31);
            this.date_sklad_edit.Name = "date_sklad_edit";
            this.date_sklad_edit.Size = new System.Drawing.Size(108, 23);
            this.date_sklad_edit.TabIndex = 0;
            // 
            // pnl_sklad_home
            // 
            this.pnl_sklad_home.Controls.Add(this.btn_sklad_prehledPolozek_pridat);
            this.pnl_sklad_home.Controls.Add(this.btn_sklad_prehledPolozek_edit);
            this.pnl_sklad_home.Controls.Add(this.btn_sklad_prehledPolozek_remove);
            this.pnl_sklad_home.Location = new System.Drawing.Point(11, 400);
            this.pnl_sklad_home.Name = "pnl_sklad_home";
            this.pnl_sklad_home.Size = new System.Drawing.Size(731, 128);
            this.pnl_sklad_home.TabIndex = 17;
            this.pnl_sklad_home.Visible = false;
            // 
            // btn_sklad_prehledPolozek_pridat
            // 
            this.btn_sklad_prehledPolozek_pridat.BackgroundImage = global::kurnik.Properties.Resources.add;
            this.btn_sklad_prehledPolozek_pridat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sklad_prehledPolozek_pridat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sklad_prehledPolozek_pridat.Location = new System.Drawing.Point(150, 30);
            this.btn_sklad_prehledPolozek_pridat.Name = "btn_sklad_prehledPolozek_pridat";
            this.btn_sklad_prehledPolozek_pridat.Size = new System.Drawing.Size(80, 80);
            this.btn_sklad_prehledPolozek_pridat.TabIndex = 20;
            this.btn_sklad_prehledPolozek_pridat.UseVisualStyleBackColor = true;
            this.btn_sklad_prehledPolozek_pridat.Click += new System.EventHandler(this.btn_sklad_prehledPolozek_pridat_Click);
            // 
            // btn_sklad_prehledPolozek_edit
            // 
            this.btn_sklad_prehledPolozek_edit.BackgroundImage = global::kurnik.Properties.Resources.circle_compose_draw_edit_write_icon_728133;
            this.btn_sklad_prehledPolozek_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sklad_prehledPolozek_edit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sklad_prehledPolozek_edit.Location = new System.Drawing.Point(350, 30);
            this.btn_sklad_prehledPolozek_edit.Name = "btn_sklad_prehledPolozek_edit";
            this.btn_sklad_prehledPolozek_edit.Size = new System.Drawing.Size(80, 80);
            this.btn_sklad_prehledPolozek_edit.TabIndex = 19;
            this.btn_sklad_prehledPolozek_edit.UseVisualStyleBackColor = true;
            this.btn_sklad_prehledPolozek_edit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_sklad_prehledPolozek_remove
            // 
            this.btn_sklad_prehledPolozek_remove.BackgroundImage = global::kurnik.Properties.Resources.delete_icon_symbol_first_aid_sign_logo_transparent_png_1426485;
            this.btn_sklad_prehledPolozek_remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sklad_prehledPolozek_remove.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sklad_prehledPolozek_remove.Location = new System.Drawing.Point(550, 30);
            this.btn_sklad_prehledPolozek_remove.Name = "btn_sklad_prehledPolozek_remove";
            this.btn_sklad_prehledPolozek_remove.Size = new System.Drawing.Size(80, 80);
            this.btn_sklad_prehledPolozek_remove.TabIndex = 18;
            this.btn_sklad_prehledPolozek_remove.UseVisualStyleBackColor = true;
            this.btn_sklad_prehledPolozek_remove.Click += new System.EventHandler(this.btn_sklad_prehledPolozek_remove_Click);
            // 
            // pnl_sklad_doplnky_menu
            // 
            this.pnl_sklad_doplnky_menu.Controls.Add(this.btn_sklad_doplnky_menu_remove);
            this.pnl_sklad_doplnky_menu.Controls.Add(this.btn_sklad_doplnky_menu_add);
            this.pnl_sklad_doplnky_menu.Location = new System.Drawing.Point(12, 400);
            this.pnl_sklad_doplnky_menu.Name = "pnl_sklad_doplnky_menu";
            this.pnl_sklad_doplnky_menu.Size = new System.Drawing.Size(731, 128);
            this.pnl_sklad_doplnky_menu.TabIndex = 21;
            this.pnl_sklad_doplnky_menu.Visible = false;
            // 
            // btn_sklad_doplnky_menu_add
            // 
            this.btn_sklad_doplnky_menu_add.BackgroundImage = global::kurnik.Properties.Resources.add;
            this.btn_sklad_doplnky_menu_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sklad_doplnky_menu_add.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sklad_doplnky_menu_add.Location = new System.Drawing.Point(217, 21);
            this.btn_sklad_doplnky_menu_add.Name = "btn_sklad_doplnky_menu_add";
            this.btn_sklad_doplnky_menu_add.Size = new System.Drawing.Size(80, 80);
            this.btn_sklad_doplnky_menu_add.TabIndex = 21;
            this.btn_sklad_doplnky_menu_add.UseVisualStyleBackColor = true;
            this.btn_sklad_doplnky_menu_add.Click += new System.EventHandler(this.btn_sklad_doplnky_menu_add_Click);
            // 
            // btn_sklad_doplnky_menu_remove
            // 
            this.btn_sklad_doplnky_menu_remove.BackgroundImage = global::kurnik.Properties.Resources.delete_icon_symbol_first_aid_sign_logo_transparent_png_1426485;
            this.btn_sklad_doplnky_menu_remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sklad_doplnky_menu_remove.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sklad_doplnky_menu_remove.Location = new System.Drawing.Point(530, 22);
            this.btn_sklad_doplnky_menu_remove.Name = "btn_sklad_doplnky_menu_remove";
            this.btn_sklad_doplnky_menu_remove.Size = new System.Drawing.Size(80, 80);
            this.btn_sklad_doplnky_menu_remove.TabIndex = 22;
            this.btn_sklad_doplnky_menu_remove.UseVisualStyleBackColor = true;
            // 
            // sklad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sqlReload);
            this.Controls.Add(this.krmeni);
            this.Controls.Add(this.prehledPolozek);
            this.Controls.Add(this.doplnky);
            this.Controls.Add(this.vybaveni);
            this.Controls.Add(this.grid_Sklad);
            this.Controls.Add(this.pnl_sklad_doplnky_menu);
            this.Controls.Add(this.pnl_sklad_home);
            this.Controls.Add(this.pnl_sklad_edit);
            this.Controls.Add(this.pnl_sklad_pridatPolozku);
            this.Name = "sklad";
            this.Size = new System.Drawing.Size(756, 538);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Sklad)).EndInit();
            this.pnl_sklad_pridatPolozku.ResumeLayout(false);
            this.pnl_sklad_pridatPolozku.PerformLayout();
            this.pnl_sklad_edit.ResumeLayout(false);
            this.pnl_sklad_edit.PerformLayout();
            this.pnl_sklad_home.ResumeLayout(false);
            this.pnl_sklad_doplnky_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grid_Sklad;
        private Button vybaveni;
        private Button doplnky;
        private Button prehledPolozek;
        private Button krmeni;
        private Button sqlReload;
        private Panel pnl_sklad_pridatPolozku;
        private TextBox txtBox_pridatPolozku_hmotnost;
        private TextBox txtBox_pridatPolozku_polozka;
        private ComboBox cBox_pridatPolozku_kategorie;
        private DateTimePicker date_pridatPolozku;
        private TextBox txtBox_pridatPolozku_cenaZaKus;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btn_pridatPolozku_Confirm;
        private Label lbl_pridatPolozku_error;
        private Panel pnl_sklad_edit;
        private Label lbl_sklad_edit_error;
        private Button btn_sklad_edit_confirm;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label15;
        private TextBox txtb_sklad_edit_cenaZaKus;
        private TextBox txtb_sklad_edit_hmotnost;
        private TextBox txtb_sklad_edit_polozka;
        private ComboBox cbox_edit_kategorie;
        private DateTimePicker date_sklad_edit;
        private Panel pnl_sklad_home;
        private Button btn_sklad_prehledPolozek_pridat;
        private Button btn_sklad_prehledPolozek_edit;
        private Button btn_sklad_prehledPolozek_remove;
        private Button btn_sklad_edit_home;
        private Button btn_sklad_add_home;
        private Panel pnl_sklad_doplnky_menu;
        private Button btn_sklad_doplnky_menu_remove;
        private Button btn_sklad_doplnky_menu_add;
    }
}
