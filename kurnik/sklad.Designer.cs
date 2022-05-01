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
            this.pridatPolozku = new System.Windows.Forms.Button();
            this.krmeni = new System.Windows.Forms.Button();
            this.sqlReload = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_pridatPolozku_cenaCelkem = new System.Windows.Forms.TextBox();
            this.txtBox_pridatPolozku_kusy = new System.Windows.Forms.TextBox();
            this.txtBox_pridatPolozku_cenaZaKus = new System.Windows.Forms.TextBox();
            this.txtBox_pridatPolozku_hmotnost = new System.Windows.Forms.TextBox();
            this.txtBox_pridatPolozku_polozka = new System.Windows.Forms.TextBox();
            this.cBox_pridatPolozku_kategorie = new System.Windows.Forms.ComboBox();
            this.date_pridatPolozku = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_pridatPolozku_Confirm = new System.Windows.Forms.Button();
            this.lbl_pridatPolozku_error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Sklad)).BeginInit();
            this.panel1.SuspendLayout();
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
            // 
            // vybaveni
            // 
            this.vybaveni.Location = new System.Drawing.Point(11, 121);
            this.vybaveni.Name = "vybaveni";
            this.vybaveni.Size = new System.Drawing.Size(93, 50);
            this.vybaveni.TabIndex = 1;
            this.vybaveni.Text = "vybaveni";
            this.vybaveni.UseVisualStyleBackColor = true;
            // 
            // doplnky
            // 
            this.doplnky.Location = new System.Drawing.Point(11, 177);
            this.doplnky.Name = "doplnky";
            this.doplnky.Size = new System.Drawing.Size(93, 50);
            this.doplnky.TabIndex = 2;
            this.doplnky.Text = "doplnky";
            this.doplnky.UseVisualStyleBackColor = true;
            // 
            // prehledPolozek
            // 
            this.prehledPolozek.Location = new System.Drawing.Point(11, 233);
            this.prehledPolozek.Name = "prehledPolozek";
            this.prehledPolozek.Size = new System.Drawing.Size(93, 50);
            this.prehledPolozek.TabIndex = 3;
            this.prehledPolozek.Text = "Přehled položek";
            this.prehledPolozek.UseVisualStyleBackColor = true;
            // 
            // pridatPolozku
            // 
            this.pridatPolozku.Location = new System.Drawing.Point(11, 289);
            this.pridatPolozku.Name = "pridatPolozku";
            this.pridatPolozku.Size = new System.Drawing.Size(93, 50);
            this.pridatPolozku.TabIndex = 4;
            this.pridatPolozku.Text = "Přidat položku";
            this.pridatPolozku.UseVisualStyleBackColor = true;
            // 
            // krmeni
            // 
            this.krmeni.Location = new System.Drawing.Point(11, 65);
            this.krmeni.Name = "krmeni";
            this.krmeni.Size = new System.Drawing.Size(93, 50);
            this.krmeni.TabIndex = 5;
            this.krmeni.Text = "krmeni";
            this.krmeni.UseVisualStyleBackColor = true;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_pridatPolozku_error);
            this.panel1.Controls.Add(this.btn_pridatPolozku_Confirm);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBox_pridatPolozku_cenaCelkem);
            this.panel1.Controls.Add(this.txtBox_pridatPolozku_kusy);
            this.panel1.Controls.Add(this.txtBox_pridatPolozku_cenaZaKus);
            this.panel1.Controls.Add(this.txtBox_pridatPolozku_hmotnost);
            this.panel1.Controls.Add(this.txtBox_pridatPolozku_polozka);
            this.panel1.Controls.Add(this.cBox_pridatPolozku_kategorie);
            this.panel1.Controls.Add(this.date_pridatPolozku);
            this.panel1.Location = new System.Drawing.Point(11, 404);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 128);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "DATUM";
            // 
            // txtBox_pridatPolozku_cenaCelkem
            // 
            this.txtBox_pridatPolozku_cenaCelkem.Location = new System.Drawing.Point(574, 33);
            this.txtBox_pridatPolozku_cenaCelkem.Name = "txtBox_pridatPolozku_cenaCelkem";
            this.txtBox_pridatPolozku_cenaCelkem.ReadOnly = true;
            this.txtBox_pridatPolozku_cenaCelkem.Size = new System.Drawing.Size(84, 23);
            this.txtBox_pridatPolozku_cenaCelkem.TabIndex = 7;
            this.txtBox_pridatPolozku_cenaCelkem.TextChanged += new System.EventHandler(this.txtBox_pridatPolozku_cenaCelkem_TextChanged);
            // 
            // txtBox_pridatPolozku_kusy
            // 
            this.txtBox_pridatPolozku_kusy.Location = new System.Drawing.Point(519, 33);
            this.txtBox_pridatPolozku_kusy.Name = "txtBox_pridatPolozku_kusy";
            this.txtBox_pridatPolozku_kusy.Size = new System.Drawing.Size(49, 23);
            this.txtBox_pridatPolozku_kusy.TabIndex = 6;
            this.txtBox_pridatPolozku_kusy.TextChanged += new System.EventHandler(this.txtBox_pridatPolozku_kusy_TextChanged);
            // 
            // txtBox_pridatPolozku_cenaZaKus
            // 
            this.txtBox_pridatPolozku_cenaZaKus.Location = new System.Drawing.Point(464, 33);
            this.txtBox_pridatPolozku_cenaZaKus.Name = "txtBox_pridatPolozku_cenaZaKus";
            this.txtBox_pridatPolozku_cenaZaKus.Size = new System.Drawing.Size(49, 23);
            this.txtBox_pridatPolozku_cenaZaKus.TabIndex = 5;
            this.txtBox_pridatPolozku_cenaZaKus.TextChanged += new System.EventHandler(this.txtBox_pridatPolozku_cenaZaKus_TextChanged);
            // 
            // txtBox_pridatPolozku_hmotnost
            // 
            this.txtBox_pridatPolozku_hmotnost.Location = new System.Drawing.Point(379, 33);
            this.txtBox_pridatPolozku_hmotnost.Name = "txtBox_pridatPolozku_hmotnost";
            this.txtBox_pridatPolozku_hmotnost.Size = new System.Drawing.Size(79, 23);
            this.txtBox_pridatPolozku_hmotnost.TabIndex = 3;
            this.txtBox_pridatPolozku_hmotnost.TextChanged += new System.EventHandler(this.txtBox_pridatPolozku_hmotnost_TextChanged);
            // 
            // txtBox_pridatPolozku_polozka
            // 
            this.txtBox_pridatPolozku_polozka.Location = new System.Drawing.Point(238, 33);
            this.txtBox_pridatPolozku_polozka.Name = "txtBox_pridatPolozku_polozka";
            this.txtBox_pridatPolozku_polozka.Size = new System.Drawing.Size(135, 23);
            this.txtBox_pridatPolozku_polozka.TabIndex = 2;
            this.txtBox_pridatPolozku_polozka.TextChanged += new System.EventHandler(this.txtBox_pridatPolozku_polozka_TextChanged);
            // 
            // cBox_pridatPolozku_kategorie
            // 
            this.cBox_pridatPolozku_kategorie.FormattingEnabled = true;
            this.cBox_pridatPolozku_kategorie.Location = new System.Drawing.Point(130, 33);
            this.cBox_pridatPolozku_kategorie.Name = "cBox_pridatPolozku_kategorie";
            this.cBox_pridatPolozku_kategorie.Size = new System.Drawing.Size(102, 23);
            this.cBox_pridatPolozku_kategorie.TabIndex = 1;
            // 
            // date_pridatPolozku
            // 
            this.date_pridatPolozku.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_pridatPolozku.Location = new System.Drawing.Point(16, 33);
            this.date_pridatPolozku.Name = "date_pridatPolozku";
            this.date_pridatPolozku.Size = new System.Drawing.Size(108, 23);
            this.date_pridatPolozku.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(531, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "KS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(379, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "HMOTNOST";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(464, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "CZK/KS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(130, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "KATEGORIE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(238, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "POLOŽKA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(574, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "CENA CELKEM";
            this.label7.Click += new System.EventHandler(this.label7_Click);
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
            // lbl_pridatPolozku_error
            // 
            this.lbl_pridatPolozku_error.AutoSize = true;
            this.lbl_pridatPolozku_error.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_pridatPolozku_error.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_pridatPolozku_error.Location = new System.Drawing.Point(396, 81);
            this.lbl_pridatPolozku_error.Name = "lbl_pridatPolozku_error";
            this.lbl_pridatPolozku_error.Size = new System.Drawing.Size(156, 17);
            this.lbl_pridatPolozku_error.TabIndex = 16;
            this.lbl_pridatPolozku_error.Text = "Něco je špatně zadané!";
            this.lbl_pridatPolozku_error.Visible = false;
            // 
            // sklad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sqlReload);
            this.Controls.Add(this.krmeni);
            this.Controls.Add(this.pridatPolozku);
            this.Controls.Add(this.prehledPolozek);
            this.Controls.Add(this.doplnky);
            this.Controls.Add(this.vybaveni);
            this.Controls.Add(this.grid_Sklad);
            this.Name = "sklad";
            this.Size = new System.Drawing.Size(756, 538);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Sklad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grid_Sklad;
        private Button vybaveni;
        private Button doplnky;
        private Button prehledPolozek;
        private Button pridatPolozku;
        private Button krmeni;
        private Button sqlReload;
        private Panel panel1;
        private TextBox txtBox_pridatPolozku_hmotnost;
        private TextBox txtBox_pridatPolozku_polozka;
        private ComboBox cBox_pridatPolozku_kategorie;
        private DateTimePicker date_pridatPolozku;
        private TextBox txtBox_pridatPolozku_kusy;
        private TextBox txtBox_pridatPolozku_cenaZaKus;
        private Label label1;
        private TextBox txtBox_pridatPolozku_cenaCelkem;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btn_pridatPolozku_Confirm;
        private Label lbl_pridatPolozku_error;
    }
}
