namespace Dizajn
{
    partial class KartaForma
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
            txt_MestoP = new TextBox();
            txt_MestoD = new TextBox();
            lbl_MestoPolaska = new Label();
            lbl_MestoDolaska = new Label();
            lbl_TipKarte = new Label();
            rdbtn_JedanPravac = new RadioButton();
            rdbtn_Povratna = new RadioButton();
            btn_Dodaj = new Button();
            btn_Obrisi = new Button();
            btn_Izmeni = new Button();
            txt_Filter = new TextBox();
            dataGridView1 = new DataGridView();
            dateTimePicker = new DateTimePicker();
            btn_Filter = new Button();
            txtId = new TextBox();
            cb_mestoP = new CheckBox();
            cb_mestoD = new CheckBox();
            cb_tip = new CheckBox();
            btn_reset = new Button();
            btn_izmena = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txt_MestoP
            // 
            txt_MestoP.Location = new Point(142, 58);
            txt_MestoP.Name = "txt_MestoP";
            txt_MestoP.Size = new Size(193, 27);
            txt_MestoP.TabIndex = 0;
            txt_MestoP.KeyPress += txt_MestoP_KeyPress;
            // 
            // txt_MestoD
            // 
            txt_MestoD.Location = new Point(142, 99);
            txt_MestoD.Name = "txt_MestoD";
            txt_MestoD.Size = new Size(193, 27);
            txt_MestoD.TabIndex = 1;
            txt_MestoD.KeyPress += txt_MestoD_KeyPress;
            // 
            // lbl_MestoPolaska
            // 
            lbl_MestoPolaska.AutoSize = true;
            lbl_MestoPolaska.Location = new Point(15, 58);
            lbl_MestoPolaska.Name = "lbl_MestoPolaska";
            lbl_MestoPolaska.Size = new Size(108, 20);
            lbl_MestoPolaska.TabIndex = 3;
            lbl_MestoPolaska.Text = "Mesto polaska:";
            // 
            // lbl_MestoDolaska
            // 
            lbl_MestoDolaska.AutoSize = true;
            lbl_MestoDolaska.Location = new Point(15, 99);
            lbl_MestoDolaska.Name = "lbl_MestoDolaska";
            lbl_MestoDolaska.Size = new Size(108, 20);
            lbl_MestoDolaska.TabIndex = 4;
            lbl_MestoDolaska.Text = "Mesto dolaska:";
            // 
            // lbl_TipKarte
            // 
            lbl_TipKarte.AutoSize = true;
            lbl_TipKarte.Location = new Point(46, 212);
            lbl_TipKarte.Name = "lbl_TipKarte";
            lbl_TipKarte.Size = new Size(70, 20);
            lbl_TipKarte.TabIndex = 5;
            lbl_TipKarte.Text = "Tip karte:";
            // 
            // rdbtn_JedanPravac
            // 
            rdbtn_JedanPravac.AutoSize = true;
            rdbtn_JedanPravac.Location = new Point(139, 197);
            rdbtn_JedanPravac.Name = "rdbtn_JedanPravac";
            rdbtn_JedanPravac.Size = new Size(116, 24);
            rdbtn_JedanPravac.TabIndex = 6;
            rdbtn_JedanPravac.TabStop = true;
            rdbtn_JedanPravac.Text = "Jedan pravac";
            rdbtn_JedanPravac.UseVisualStyleBackColor = true;
            rdbtn_JedanPravac.Checked = true;
            // 
            // rdbtn_Povratna
            // 
            rdbtn_Povratna.AutoSize = true;
            rdbtn_Povratna.Location = new Point(139, 224);
            rdbtn_Povratna.Name = "rdbtn_Povratna";
            rdbtn_Povratna.Size = new Size(91, 24);
            rdbtn_Povratna.TabIndex = 7;
            rdbtn_Povratna.TabStop = true;
            rdbtn_Povratna.Text = "Povratna ";
            rdbtn_Povratna.UseVisualStyleBackColor = true;
            // 
            // btn_Dodaj
            // 
            btn_Dodaj.Location = new Point(12, 273);
            btn_Dodaj.Name = "btn_Dodaj";
            btn_Dodaj.Size = new Size(85, 40);
            btn_Dodaj.TabIndex = 8;
            btn_Dodaj.Text = "DODAJ";
            btn_Dodaj.UseVisualStyleBackColor = true;
            btn_Dodaj.Click += btn_Dodaj_Click;
            // 
            // btn_Obrisi
            // 
            btn_Obrisi.Location = new Point(103, 273);
            btn_Obrisi.Name = "btn_Obrisi";
            btn_Obrisi.Size = new Size(88, 40);
            btn_Obrisi.TabIndex = 9;
            btn_Obrisi.Text = "OBRISI";
            btn_Obrisi.UseVisualStyleBackColor = true;
            btn_Obrisi.Click += btn_Obrisi_Click;
            // 
            // btn_Izmeni
            // 
            btn_Izmeni.Location = new Point(206, 273);
            btn_Izmeni.Name = "btn_Izmeni";
            btn_Izmeni.Size = new Size(93, 40);
            btn_Izmeni.TabIndex = 10;
            btn_Izmeni.Text = "IZMENI";
            btn_Izmeni.UseVisualStyleBackColor = true;
            btn_Izmeni.Click += btn_Izmeni_Click;
            // 
            // txt_Filter
            // 
            txt_Filter.Location = new Point(15, 410);
            txt_Filter.Name = "txt_Filter";
            txt_Filter.Size = new Size(384, 27);
            txt_Filter.TabIndex = 11;
            txt_Filter.KeyPress += txt_Filter_KeyPress;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(467, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(602, 433);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(142, 149);
            dateTimePicker.MinDate = new DateTime(2023, 9, 7, 14, 15, 44, 0);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(193, 27);
            dateTimePicker.TabIndex = 16;
            dateTimePicker.Value = new DateTime(2023, 9, 7, 14, 15, 44, 0);
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // btn_Filter
            // 
            btn_Filter.Location = new Point(305, 273);
            btn_Filter.Name = "btn_Filter";
            btn_Filter.Size = new Size(94, 40);
            btn_Filter.TabIndex = 17;
            btn_Filter.Text = "FILTRIRAJ";
            btn_Filter.UseVisualStyleBackColor = true;
            btn_Filter.Click += btn_Filter_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(145, 25);
            txtId.Name = "txtId";
            txtId.Size = new Size(190, 27);
            txtId.TabIndex = 19;
            txtId.Visible = false;
            // 
            // cb_mestoP
            // 
            cb_mestoP.AutoSize = true;
            cb_mestoP.Location = new Point(12, 363);
            cb_mestoP.Name = "cb_mestoP";
            cb_mestoP.Size = new Size(127, 24);
            cb_mestoP.TabIndex = 20;
            cb_mestoP.Text = "Mesto polaska";
            cb_mestoP.UseVisualStyleBackColor = true;
            // 
            // cb_mestoD
            // 
            cb_mestoD.AutoSize = true;
            cb_mestoD.Location = new Point(157, 363);
            cb_mestoD.Name = "cb_mestoD";
            cb_mestoD.Size = new Size(127, 24);
            cb_mestoD.TabIndex = 21;
            cb_mestoD.Text = "Mesto dolaska";
            cb_mestoD.UseVisualStyleBackColor = true;
            // 
            // cb_tip
            // 
            cb_tip.AutoSize = true;
            cb_tip.Location = new Point(328, 363);
            cb_tip.Name = "cb_tip";
            cb_tip.Size = new Size(89, 24);
            cb_tip.TabIndex = 22;
            cb_tip.Text = "Tip karte";
            cb_tip.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(145, 319);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(102, 38);
            btn_reset.TabIndex = 23;
            btn_reset.Text = "RESET";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // btn_izmena
            // 
            btn_izmena.Location = new Point(362, 70);
            btn_izmena.Name = "btn_izmena";
            btn_izmena.Size = new Size(37, 34);
            btn_izmena.TabIndex = 24;
            btn_izmena.Text = "⇅";
            btn_izmena.UseVisualStyleBackColor = true;
            btn_izmena.Click += btn_izmena_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 155);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 25;
            label4.Text = "Vreme polaska:";
            // 
            // KartaForma
            // 
            ClientSize = new Size(1100, 498);
            Controls.Add(label4);
            Controls.Add(btn_izmena);
            Controls.Add(btn_reset);
            Controls.Add(cb_tip);
            Controls.Add(cb_mestoD);
            Controls.Add(cb_mestoP);
            Controls.Add(txtId);
            Controls.Add(btn_Filter);
            Controls.Add(dateTimePicker);
            Controls.Add(dataGridView1);
            Controls.Add(txt_Filter);
            Controls.Add(btn_Izmeni);
            Controls.Add(btn_Obrisi);
            Controls.Add(btn_Dodaj);
            Controls.Add(rdbtn_Povratna);
            Controls.Add(rdbtn_JedanPravac);
            Controls.Add(lbl_TipKarte);
            Controls.Add(lbl_MestoDolaska);
            Controls.Add(lbl_MestoPolaska);
            Controls.Add(txt_MestoD);
            Controls.Add(txt_MestoP);
            Name = "KartaForma";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox txt_MestoP;
        private TextBox txt_MestoD;
        private Label lbl_MestoPolaska;
        private Label lbl_MestoDolaska;
        private Label lbl_TipKarte;
        private RadioButton rdbtn_JedanPravac;
        private RadioButton rdbtn_Povratna;
        private Button btn_Dodaj;
        private Button btn_Obrisi;
        private Button btn_Izmeni;
        private TextBox txt_Filter;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker;
        private Button btn_Filter;
        private CheckBox cb_mestoP;
        private CheckBox cb_mestoD;
        private CheckBox cb_tip;
        private Button btn_reset;
        private Button btn_izmena;
        private Label label4;
    }
}

