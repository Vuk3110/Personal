using Entity.Servisi;
using System.Data;
using Entity.Entiteti;


namespace Dizajn
{
    public partial class KartaForma : Form
    {
        private readonly KartaServis kartaServis;
        public KartaForma(KartaServis kartaServis)
        {
            InitializeComponent();
            this.kartaServis = kartaServis;
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
           await PopuniDataGridViewAsync();
        }

        private async void RestartujPolja()
        {
            txt_MestoP.Text = "";
            txt_MestoD.Text = "";
            txt_Filter.Text = "";
            rdbtn_JedanPravac.Checked=true;
        }

        private async Task PopuniDataGridViewAsync()
        {
            var Karte = await kartaServis.PreuzmiKarte();

            DataTable table = new DataTable();

            table.Columns.Add("Id", typeof(Guid));
            table.Columns.Add("MestoPolaska", typeof(string));
            table.Columns.Add("MestoDolaska", typeof(string));
            table.Columns.Add("VremePolaska", typeof(DateTime));
            table.Columns.Add("TipKarte", typeof(string));


            foreach (var karta in Karte)
            {
                table.Rows.Add(karta.ID, karta.MestoPolaska, karta.MestoDolaska, karta.VremePolaska, karta.TipKarte);
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.DataSource = table;
        }

        private async void btn_Dodaj_Click(object sender, EventArgs e)
        {
            try
            {
                Guid guid = Guid.NewGuid();
                string mestoP = txt_MestoP.Text;
                string mestoD = txt_MestoD.Text;
                DateTime vreme = dateTimePicker.Value;
                string tip = "";
                if (rdbtn_JedanPravac.Checked)
                {
                    tip = "Jedan pravac";
                }
                else if (rdbtn_Povratna.Checked)
                {
                    tip = "Povratna";
                }

                if (string.IsNullOrWhiteSpace(mestoD) ||
                    string.IsNullOrWhiteSpace(mestoP) ||
                    string.IsNullOrWhiteSpace(tip)
                    )
                {
                    MessageBox.Show("Unos ne sme biti prazan ili sadržati samo beline.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    Karta karta = new Karta(guid, mestoP, mestoD, vreme, tip);

                    await kartaServis.DodajKartu(karta);
                    MessageBox.Show("Karta uspesno dodata!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dodavanje karte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            await PopuniDataGridViewAsync();
            RestartujPolja();
        }

        private async void btn_Obrisi_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da zelite obrisati kartu?", "Brisanje karte", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;

            if (String.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Nijedana karta nije obelezena!");
                return;
            }

            if (Guid.TryParse(txtId.Text, out Guid parsedGuid))
            {
                try
                {
                    await kartaServis.ObrisiKartu(parsedGuid);
                    MessageBox.Show("Uspesno obrisana karta!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Brisanje karte nije uspelo", "Brisanje karte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            await PopuniDataGridViewAsync();
            RestartujPolja();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string tip;
            try
            {
                DataGridViewRow selektovaniRed = dataGridView1.Rows[e.RowIndex];
                txtId.Text = selektovaniRed.Cells[0].Value.ToString();
                txt_MestoP.Text = selektovaniRed.Cells[1].Value.ToString();
                txt_MestoD.Text = selektovaniRed.Cells[2].Value.ToString();
                tip = selektovaniRed.Cells[4].Value.ToString();

                if (tip == "Jedan pravac")
                {
                    rdbtn_JedanPravac.Checked = true;
                }
                else
                {
                    rdbtn_Povratna.Checked = true;
                }

            }
            catch (Exception ex)
            {
            }
        }

        private async void btn_Izmeni_Click(object sender, EventArgs e)
        {
            if (Guid.TryParse(txtId.Text, out Guid parsedGuid))
            {
                try
                {
                    string mestoPolaska = txt_MestoP.Text;
                    string mestoDolaska = txt_MestoD.Text;
                    DateTime vremePolaska = dateTimePicker.Value;
                    string tip = "";
                    if (rdbtn_JedanPravac.Checked)
                    {
                        tip = "Jedan pravac";
                    }
                    else if (rdbtn_Povratna.Checked)
                    {
                        tip = "Povratna";
                    }
                    if (string.IsNullOrWhiteSpace(mestoDolaska) ||
                    string.IsNullOrWhiteSpace(mestoPolaska) ||
                    string.IsNullOrWhiteSpace(tip)
                    )
                    {
                        MessageBox.Show("Unos ne sme biti prazan ili sadržati samo beline.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        Karta staraKarta = new(Guid.NewGuid(),
                            mestoPolaska,
                            mestoDolaska,
                            vremePolaska,
                            tip);

                        await kartaServis.IzmeniKartu(parsedGuid, staraKarta);
                        MessageBox.Show("Uspesno izmenjena karta!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Izmena karte nije uspelo", "Izmena karte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            await PopuniDataGridViewAsync();
            RestartujPolja();
        }

        private async void btn_Filter_Click(object sender, EventArgs e)
        {
            IEnumerable<Karta>? filtrirano;

            if (txt_Filter.Text.Trim() == String.Empty)
            {
                await PopuniDataGridViewAsync();
            }
            if (!cb_mestoP.Checked && !cb_mestoD.Checked && !cb_tip.Checked)
            {
                await PopuniDataGridViewAsync();
            }

            try
            {
                if (cb_mestoP.Checked)
                {
                    cb_mestoD.Checked = false;
                    cb_tip.Checked = false;

                    filtrirano = await kartaServis.PreuzmiKarte(txt_Filter.Text);
                }
                else if (cb_mestoD.Checked)
                {
                    cb_mestoP.Checked = false;
                    cb_tip.Checked = false;

                    filtrirano = await kartaServis.PreuzmiKarte(null, txt_Filter.Text);
                }

                else if (cb_tip.Checked)
                {
                    cb_mestoP.Checked = false;
                    cb_mestoD.Checked = false;

                    filtrirano = await kartaServis.PreuzmiKarte(null, null, default, txt_Filter.Text);
                }
                else
                {
                    filtrirano = null;
                }
            }
            catch (Exception)
            {
                throw new ArgumentNullException();
            }

            if (filtrirano is not null)
            {
                DataTable table = new DataTable();

                table.Columns.Add("Id", typeof(Guid));
                table.Columns.Add("MestoPolaska", typeof(string));
                table.Columns.Add("MestoDolaska", typeof(string));
                table.Columns.Add("VremePolaska", typeof(DateTime));
                table.Columns.Add("TipKarte", typeof(string));

                foreach (var item in filtrirano)
                {
                    table.Rows.Add(item.ID, item.MestoPolaska, item.MestoDolaska, item.VremePolaska, item.TipKarte);
                }

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AllowUserToResizeColumns = false;
                dataGridView1.AllowUserToResizeRows = false;
                dataGridView1.DataSource = table;
            }


        }

        private async void btn_reset_Click(object sender, EventArgs e)
        {
            cb_mestoD.Checked = false;
            cb_mestoP.Checked = false;
            cb_tip.Checked = false;

            txt_Filter.Text = "";
            await PopuniDataGridViewAsync();
        }

        private void btn_izmena_Click(object sender, EventArgs e)
        {
            string izmena;
            izmena = txt_MestoP.Text;
            txt_MestoP.Text = txt_MestoD.Text;
            txt_MestoD.Text = izmena;

        }

        private void txt_MestoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void txt_MestoD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void txt_Filter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker.MinDate = DateTime.Today; 
        }
    }
}