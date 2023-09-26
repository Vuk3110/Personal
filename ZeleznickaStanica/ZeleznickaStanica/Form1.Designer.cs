namespace ZeleznickaStanica
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lbl_MestoPolaska = new System.Windows.Forms.Label();
            this.lbl_MestoDolaska = new System.Windows.Forms.Label();
            this.lbl_TipKarte = new System.Windows.Forms.Label();
            this.rdbtn_JedanPravac = new System.Windows.Forms.RadioButton();
            this.rdbtn_Povratna = new System.Windows.Forms.RadioButton();
            this.btn_Dodaj = new System.Windows.Forms.Button();
            this.btn_Obrisi = new System.Windows.Forms.Button();
            this.btn_Izmeni = new System.Windows.Forms.Button();
            this.txt_Filter = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zELEZNICKASTANICADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zELEZNICKA_STANICADataSet = new ZeleznickaStanica.ZELEZNICKA_STANICADataSet();
            this.cbox_MestoP = new System.Windows.Forms.CheckBox();
            this.cbox_MestoD = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zELEZNICKASTANICADataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zELEZNICKA_STANICADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(142, 106);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(142, 153);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 1;
            // 
            // lbl_MestoPolaska
            // 
            this.lbl_MestoPolaska.AutoSize = true;
            this.lbl_MestoPolaska.Location = new System.Drawing.Point(40, 106);
            this.lbl_MestoPolaska.Name = "lbl_MestoPolaska";
            this.lbl_MestoPolaska.Size = new System.Drawing.Size(96, 16);
            this.lbl_MestoPolaska.TabIndex = 3;
            this.lbl_MestoPolaska.Text = "Mesto polaska";
            // 
            // lbl_MestoDolaska
            // 
            this.lbl_MestoDolaska.AutoSize = true;
            this.lbl_MestoDolaska.Location = new System.Drawing.Point(40, 159);
            this.lbl_MestoDolaska.Name = "lbl_MestoDolaska";
            this.lbl_MestoDolaska.Size = new System.Drawing.Size(96, 16);
            this.lbl_MestoDolaska.TabIndex = 4;
            this.lbl_MestoDolaska.Text = "Mesto dolaska";
            // 
            // lbl_TipKarte
            // 
            this.lbl_TipKarte.AutoSize = true;
            this.lbl_TipKarte.Location = new System.Drawing.Point(40, 220);
            this.lbl_TipKarte.Name = "lbl_TipKarte";
            this.lbl_TipKarte.Size = new System.Drawing.Size(60, 16);
            this.lbl_TipKarte.TabIndex = 5;
            this.lbl_TipKarte.Text = "Tip karte";
            // 
            // rdbtn_JedanPravac
            // 
            this.rdbtn_JedanPravac.AutoSize = true;
            this.rdbtn_JedanPravac.Location = new System.Drawing.Point(139, 197);
            this.rdbtn_JedanPravac.Name = "rdbtn_JedanPravac";
            this.rdbtn_JedanPravac.Size = new System.Drawing.Size(111, 20);
            this.rdbtn_JedanPravac.TabIndex = 6;
            this.rdbtn_JedanPravac.TabStop = true;
            this.rdbtn_JedanPravac.Text = "Jedan pravac";
            this.rdbtn_JedanPravac.UseVisualStyleBackColor = true;
            // 
            // rdbtn_Povratna
            // 
            this.rdbtn_Povratna.AutoSize = true;
            this.rdbtn_Povratna.Location = new System.Drawing.Point(139, 224);
            this.rdbtn_Povratna.Name = "rdbtn_Povratna";
            this.rdbtn_Povratna.Size = new System.Drawing.Size(85, 20);
            this.rdbtn_Povratna.TabIndex = 7;
            this.rdbtn_Povratna.TabStop = true;
            this.rdbtn_Povratna.Text = "Povratna ";
            this.rdbtn_Povratna.UseVisualStyleBackColor = true;
            // 
            // btn_Dodaj
            // 
            this.btn_Dodaj.Location = new System.Drawing.Point(12, 273);
            this.btn_Dodaj.Name = "btn_Dodaj";
            this.btn_Dodaj.Size = new System.Drawing.Size(75, 23);
            this.btn_Dodaj.TabIndex = 8;
            this.btn_Dodaj.Text = "DODAJ";
            this.btn_Dodaj.UseVisualStyleBackColor = true;
            // 
            // btn_Obrisi
            // 
            this.btn_Obrisi.Location = new System.Drawing.Point(103, 273);
            this.btn_Obrisi.Name = "btn_Obrisi";
            this.btn_Obrisi.Size = new System.Drawing.Size(75, 23);
            this.btn_Obrisi.TabIndex = 9;
            this.btn_Obrisi.Text = "OBRISI";
            this.btn_Obrisi.UseVisualStyleBackColor = true;
            // 
            // btn_Izmeni
            // 
            this.btn_Izmeni.Location = new System.Drawing.Point(212, 273);
            this.btn_Izmeni.Name = "btn_Izmeni";
            this.btn_Izmeni.Size = new System.Drawing.Size(75, 23);
            this.btn_Izmeni.TabIndex = 10;
            this.btn_Izmeni.Text = "IZMENI";
            this.btn_Izmeni.UseVisualStyleBackColor = true;
            // 
            // txt_Filter
            // 
            this.txt_Filter.Location = new System.Drawing.Point(23, 357);
            this.txt_Filter.Name = "txt_Filter";
            this.txt_Filter.Size = new System.Drawing.Size(275, 22);
            this.txt_Filter.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.zELEZNICKASTANICADataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(418, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(423, 349);
            this.dataGridView1.TabIndex = 12;
            // 
            // zELEZNICKASTANICADataSetBindingSource
            // 
            this.zELEZNICKASTANICADataSetBindingSource.DataSource = this.zELEZNICKA_STANICADataSet;
            this.zELEZNICKASTANICADataSetBindingSource.Position = 0;
            // 
            // zELEZNICKA_STANICADataSet
            // 
            this.zELEZNICKA_STANICADataSet.DataSetName = "ZELEZNICKA_STANICADataSet";
            this.zELEZNICKA_STANICADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbox_MestoP
            // 
            this.cbox_MestoP.AutoSize = true;
            this.cbox_MestoP.Location = new System.Drawing.Point(12, 302);
            this.cbox_MestoP.Name = "cbox_MestoP";
            this.cbox_MestoP.Size = new System.Drawing.Size(119, 20);
            this.cbox_MestoP.TabIndex = 13;
            this.cbox_MestoP.Text = "Mesto Polaska";
            this.cbox_MestoP.UseVisualStyleBackColor = true;
            this.cbox_MestoP.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbox_MestoD
            // 
            this.cbox_MestoD.AutoSize = true;
            this.cbox_MestoD.Location = new System.Drawing.Point(192, 302);
            this.cbox_MestoD.Name = "cbox_MestoD";
            this.cbox_MestoD.Size = new System.Drawing.Size(120, 20);
            this.cbox_MestoD.TabIndex = 14;
            this.cbox_MestoD.Text = "Mesto Dolaska";
            this.cbox_MestoD.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(874, 498);
            this.Controls.Add(this.cbox_MestoD);
            this.Controls.Add(this.cbox_MestoP);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_Filter);
            this.Controls.Add(this.btn_Izmeni);
            this.Controls.Add(this.btn_Obrisi);
            this.Controls.Add(this.btn_Dodaj);
            this.Controls.Add(this.rdbtn_Povratna);
            this.Controls.Add(this.rdbtn_JedanPravac);
            this.Controls.Add(this.lbl_TipKarte);
            this.Controls.Add(this.lbl_MestoDolaska);
            this.Controls.Add(this.lbl_MestoPolaska);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zELEZNICKASTANICADataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zELEZNICKA_STANICADataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lbl_MestoPolaska;
        private System.Windows.Forms.Label lbl_MestoDolaska;
        private System.Windows.Forms.Label lbl_TipKarte;
        private System.Windows.Forms.RadioButton rdbtn_JedanPravac;
        private System.Windows.Forms.RadioButton rdbtn_Povratna;
        private System.Windows.Forms.Button btn_Dodaj;
        private System.Windows.Forms.Button btn_Obrisi;
        private System.Windows.Forms.Button btn_Izmeni;
        private System.Windows.Forms.TextBox txt_Filter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource zELEZNICKASTANICADataSetBindingSource;
        private ZELEZNICKA_STANICADataSet zELEZNICKA_STANICADataSet;
        private System.Windows.Forms.CheckBox cbox_MestoP;
        private System.Windows.Forms.CheckBox cbox_MestoD;
    }
}

