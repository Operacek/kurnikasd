namespace kurnik
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVejce = new System.Windows.Forms.Button();
            this.vejce1 = new kurnik.vejce();
            this.button1 = new System.Windows.Forms.Button();
            this.sklad1 = new kurnik.sklad();
            this.SuspendLayout();
            // 
            // btnVejce
            // 
            this.btnVejce.Location = new System.Drawing.Point(28, 120);
            this.btnVejce.Name = "btnVejce";
            this.btnVejce.Size = new System.Drawing.Size(75, 23);
            this.btnVejce.TabIndex = 0;
            this.btnVejce.Text = "Vejce";
            this.btnVejce.UseVisualStyleBackColor = true;
            this.btnVejce.Click += new System.EventHandler(this.btnVejce_Click);
            // 
            // vejce1
            // 
            this.vejce1.Location = new System.Drawing.Point(109, 12);
            this.vejce1.Name = "vejce1";
            this.vejce1.Size = new System.Drawing.Size(756, 491);
            this.vejce1.TabIndex = 3;
            this.vejce1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sklad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sklad1
            // 
            this.sklad1.Location = new System.Drawing.Point(109, 12);
            this.sklad1.Name = "sklad1";
            this.sklad1.Size = new System.Drawing.Size(756, 512);
            this.sklad1.TabIndex = 5;
            this.sklad1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVejce);
            this.Controls.Add(this.sklad1);
            this.Controls.Add(this.vejce1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnVejce;

        private vejce vejce1;
        private Button button1;
        private sklad sklad1;
    }
}