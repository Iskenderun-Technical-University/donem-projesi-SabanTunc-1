using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace AkuSecimOtomasyonu
{
    public partial class Form2 : Form
    {
        private bool prevent_cms = true;
        private readonly DbOperation _db;
        public Form2()
        {
            _db = new DbOperation();
            InitializeComponent();
            refreshMarkaList();
            aku_dgw.DataSource = _db.AkuleriGetir();
            aku_dgw.Columns["UretimYil"].Visible = false;
            aku_dgw.Columns["Id"].Visible = false;
            aku_dgw.Columns["Value"].HeaderText = "Akü Tipi";
        }

        private void refreshMarkaList()
        {
            marka_dgw.DataSource = model_markalar_cb.DataSource = altGroup_marka_cb.DataSource = _db.MarkalariGetir();
            model_markalar_cb.DisplayMember = altGroup_marka_cb.DisplayMember = "Value";
            model_markalar_cb.ValueMember = altGroup_marka_cb.ValueMember = "Id";
            foreach (DataGridViewColumn column in marka_dgw.Columns)
            {
                column.HeaderText = column.HeaderText == "Value" ? "Markalar" : column.HeaderText;
                column.Visible = column.HeaderText == "Markalar";
            }
            model_markalar_cb.Refresh();
            altGroup_marka_cb.Refresh();
            altGroup_model_cb.Refresh();
            
            altGroup_dgw.DataSource = _db.AltModelleriGetir(altGroup_model_cb.SelectedValue as int? ?? 0);
            model_dgw.DataSource = _db.ModelleriGetir(model_markalar_cb.SelectedValue as int? ?? 0);
        }
        private void refreshModelList()
        {
            model_dgw.DataSource = _db.ModelleriGetir(model_markalar_cb.SelectedValue as int? ?? 0);

            altGroup_model_cb.DataSource = _db.ModelleriGetir(altGroup_marka_cb.SelectedValue as int? ?? 0);
            altGroup_model_cb.DisplayMember = "Value";
            altGroup_model_cb.ValueMember = "Id";
            foreach (DataGridViewColumn column in model_dgw.Columns)
            {
                column.HeaderText = column.HeaderText == "Value" ? "Modeller" : column.HeaderText;
                column.Visible = column.HeaderText == "Modeller";
            }


            altGroup_model_cb.Refresh();
            altGroup_dgw.DataSource = _db.AltModelleriGetir(altGroup_model_cb.SelectedValue as int? ?? 0);
        }
        private void markaEkle_btn_Click(object sender, EventArgs e)
        {
            var list = _db.MarkalariGetir();
            var yeniMarka = markaEkle_tb.Text.Trim();
            if (list.Any(c => string.Equals(c.Value, yeniMarka, StringComparison.CurrentCultureIgnoreCase)))
            {
                MessageBox.Show("Bu marka zaten ekli");
                return;
            }
            _db.MarkaEkle(yeniMarka);
            refreshMarkaList();
        }

        private void model_markalar_cb_SelectedValueChanged(object sender, EventArgs e)
        {
            model_dgw.DataSource = _db.ModelleriGetir(model_markalar_cb.SelectedValue as int? ?? 0);
            foreach (DataGridViewColumn column in model_dgw.Columns)
            {
                column.HeaderText = column.HeaderText == "Value" ? "Modeller" : column.HeaderText;
                column.Visible = column.HeaderText == "Modeller";
            }
        }

        private void modelEkle_btn_Click(object sender, EventArgs e)
        {
            var markaId = model_markalar_cb.SelectedValue as int? ?? 0;
            var list = _db.ModelleriGetir(markaId);
            var yeniModel = modelEkle_tb.Text.Trim();
            if (list.Any(c => string.Equals(c.Value, yeniModel, StringComparison.CurrentCultureIgnoreCase)))
            {
                MessageBox.Show("Bu model zaten ekli");
                return;
            }
            _db.ModelEkle(yeniModel, markaId);
            refreshModelList();
        }

        private void altGroup_marka_cb_SelectedValueChanged(object sender, EventArgs e)
        {
            altGroup_model_cb.DataSource = _db.ModelleriGetir(altGroup_marka_cb.SelectedValue as int? ?? 0);
            altGroup_model_cb.DisplayMember = "Value";
            altGroup_model_cb.ValueMember = "Id";
            altGroup_model_cb.Refresh();
        }

        private void altGroup_model_cb_SelectedValueChanged(object sender, EventArgs e)
        {
            altGroup_dgw.DataSource = _db.AltModelleriGetir(altGroup_model_cb.SelectedValue as int? ?? 0);
            altGroup_dgw.Columns[0].Visible = false;
        }

        private void numeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void altGroupEkle_btn_Click(object sender, EventArgs e)
        {
            int.TryParse(en_tb.Text, out int en);
            int.TryParse(boy_tb.Text, out int boy);
            int.TryParse(yukseklik_tb.Text, out int yukseklik);
            int.TryParse(minYil_tb.Text, out int minYil);
            int.TryParse(maxYil_tb.Text, out int maxYil);
            _db.AltGroupEkle(altGroupEkle_tb.Text, (int)altGroup_model_cb.SelectedValue, en, boy, yukseklik, minYil, maxYil);
            altGroup_dgw.DataSource = _db.AltModelleriGetir(altGroup_model_cb.SelectedValue as int? ?? 0);
        }

        private void akuEkle_btn_Click(object sender, EventArgs e)
        {
            int.TryParse(akuEn_tb.Text, out int en);
            int.TryParse(akuBoy_tb.Text, out int boy);
            int.TryParse(akuYukseklik_tb.Text, out int yukseklik);
            _db.AkuEkle(aku_tb.Text, en, boy, yukseklik);
            aku_dgw.DataSource = _db.AkuleriGetir();

        }

        private void dgw_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)

        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {

                prevent_cms = false;
                ((DataGridView)sender).ClearSelection();
                ((DataGridView)sender).Rows[e.RowIndex].Selected = true;
            }
        }

        private void dgw_MouseDown(object sender, MouseEventArgs e)
        {
            prevent_cms = true;
        }

        private void aku_cms_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = prevent_cms;
        }


        private void aku_cms_VisibleChanged(object sender, EventArgs e)
        {
            prevent_cms = true;

        }


        private void guncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dgw = (DataGridView)((ContextMenuStrip)((ToolStripMenuItem)sender).GetCurrentParent()).SourceControl;
            var row = dgw.SelectedCells[0].RowIndex;
            var id = dgw.Rows[row].Cells["Id"].Value as int? ?? 0;
            switch (dgw.Name)
            {
                case "aku_dgw":
                    {
                        aku_tb.Text = dgw.Rows[row].Cells["Value"].Value.ToString();
                        akuEn_tb.Text = dgw.Rows[row].Cells["En"].Value.ToString();
                        akuBoy_tb.Text = dgw.Rows[row].Cells["Boy"].Value.ToString();
                        akuYukseklik_tb.Text = dgw.Rows[row].Cells["Yukseklik"].Value.ToString();

                        akuGuncelle_btn.Visible = akuVazgec_btn.Visible = !(dgw.Enabled = akuEkle_btn.Visible = false);

                        break;
                    }

                case "altGroup_dgw":
                    {
                        altGroupEkle_tb.Text = dgw.Rows[row].Cells["Value"].Value.ToString();
                        en_tb.Text = dgw.Rows[row].Cells["En"].Value.ToString();
                        boy_tb.Text = dgw.Rows[row].Cells["Boy"].Value.ToString();
                        yukseklik_tb.Text = dgw.Rows[row].Cells["Yukseklik"].Value.ToString();
                        var uretimYil = dgw.Rows[row].Cells["UretimYil"].Value.ToString();
                        minYil_tb.Text = uretimYil.Split('-')[0];
                        maxYil_tb.Text = uretimYil.Split('-')[1];


                        altGroupGuncelle_btn.Visible = altGroupVazgec_btn.Visible = !(dgw.Enabled = altGroupEkle_btn.Visible = false);

                        break;
                    }
                case "model_dgw":
                    {
                        modelEkle_tb.Text = dgw.Rows[row].Cells["Value"].Value.ToString();
                        modelGuncelle_btn.Visible = modelVazgec_btn.Visible = !(model_dgw.Enabled = modelEkle_btn.Visible = false);
                        break;
                    }
                case "marka_dgw":
                    {
                        markaEkle_tb.Text = dgw.Rows[row].Cells["Value"].Value.ToString();
                        markaGuncelle_btn.Visible = markaVazgec_btn.Visible = !(marka_dgw.Enabled = markaEkle_btn.Visible = false);
                        break;
                    }
            }
        }

        private void akuVazgec_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Kaydedilmeyen değişiklikleriniz kaybolacaktır. Devam edilsin mi?",
                "Dikkat",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            aku_tb.Text = akuEn_tb.Text = akuBoy_tb.Text = akuYukseklik_tb.Text = "";

            akuGuncelle_btn.Visible = akuVazgec_btn.Visible = !(aku_dgw.Enabled = akuEkle_btn.Visible = true);
        }

        private void akuGuncelle_btn_Click(object sender, EventArgs e)
        {
            int.TryParse(akuEn_tb.Text, out int en);
            int.TryParse(akuBoy_tb.Text, out int boy);
            int.TryParse(akuYukseklik_tb.Text, out int yukseklik);
            var id = aku_dgw.SelectedRows[0].Cells["Id"].Value as int? ?? 0;
            _db.AkuGuncelle(id, aku_tb.Text, en, boy, yukseklik);
            aku_dgw.DataSource = _db.AkuleriGetir();
            aku_tb.Text = akuEn_tb.Text = akuBoy_tb.Text = akuYukseklik_tb.Text = "";

            akuGuncelle_btn.Visible = akuVazgec_btn.Visible = !(aku_dgw.Enabled = akuEkle_btn.Visible = true);
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Bu işlem geri alınamaz. Onaylıyor musunuz?",
                "Dikkat",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            var dgw = (DataGridView)((ContextMenuStrip)((ToolStripMenuItem)sender).GetCurrentParent()).SourceControl;
            var row = dgw.SelectedCells[0].RowIndex;
            var id = dgw.Rows[row].Cells["Id"].Value as int? ?? 0;
            switch (dgw.Name)
            {
                case "aku_dgw":
                    {
                        _db.AkuSil(id);
                        aku_dgw.DataSource = _db.AkuleriGetir();
                        break;
                    }
                case "altGroup_dgw":
                    {
                        _db.AltGroupSil(id);
                        altGroup_dgw.DataSource = _db.AltModelleriGetir(altGroup_model_cb.SelectedValue as int? ?? 0);
                        break;
                    }
                case "model_dgw":
                    {
                        _db.ModelSil(id);
                        model_dgw.DataSource = _db.ModelleriGetir(model_markalar_cb.SelectedValue as int? ?? 0);
                        refreshModelList();
                        break;
                    }
                case "marka_dgw":
                    {
                        _db.MarkaSil(id);
                        marka_dgw.DataSource = _db.MarkalariGetir();
                        refreshMarkaList();
                        break;
                    }
            }
        }
        private void altGroupGuncelle_btn_Click(object sender, EventArgs e)
        {

            int.TryParse(en_tb.Text, out int en);
            int.TryParse(boy_tb.Text, out int boy);
            int.TryParse(yukseklik_tb.Text, out int yukseklik);
            int.TryParse(minYil_tb.Text, out int minYil);
            int.TryParse(maxYil_tb.Text, out int maxYil);
            var id = altGroup_dgw.SelectedRows[0].Cells["Id"].Value as int? ?? 0;
            _db.AltGroupGuncelle(id, altGroupEkle_tb.Text, en, boy, yukseklik, minYil, maxYil);
            altGroup_dgw.DataSource = _db.AltModelleriGetir(altGroup_model_cb.SelectedValue as int? ?? 0);
            altGroupEkle_tb.Text = en_tb.Text = boy_tb.Text = yukseklik_tb.Text = minYil_tb.Text = maxYil_tb.Text = "";

            akuGuncelle_btn.Visible = akuVazgec_btn.Visible = !(aku_dgw.Enabled = akuEkle_btn.Visible = true);
        }

        private void altGroupVazgec_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Kaydedilmeyen değişiklikleriniz kaybolacaktır. Devam edilsin mi?",
                "Dikkat",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            altGroupEkle_tb.Text = en_tb.Text = boy_tb.Text = yukseklik_tb.Text = minYil_tb.Text = maxYil_tb.Text = "";

            altGroupGuncelle_btn.Visible = altGroupVazgec_btn.Visible = !(altGroup_dgw.Enabled = altGroupEkle_btn.Visible = true);
        }

        private void modelGuncelle_btn_Click(object sender, EventArgs e)
        {
            var id = model_dgw.SelectedRows[0].Cells["Id"].Value as int? ?? 0;
            _db.ModelGuncelle(id, modelEkle_tb.Text);
            model_dgw.DataSource = _db.ModelleriGetir(model_markalar_cb.SelectedValue as int? ?? 0);
            modelEkle_tb.Text = "";
            modelGuncelle_btn.Visible = modelVazgec_btn.Visible = !(model_dgw.Enabled = modelEkle_btn.Visible = true);
            refreshModelList();
        }

        private void modelVazgec_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
               "Kaydedilmeyen değişiklikleriniz kaybolacaktır. Devam edilsin mi?",
               "Dikkat",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            modelEkle_tb.Text = "";

            modelGuncelle_btn.Visible = modelVazgec_btn.Visible = !(model_dgw.Enabled = modelEkle_btn.Visible = true);
        }

        private void markaGuncelle_btn_Click(object sender, EventArgs e)
        {
            var id = marka_dgw.SelectedRows[0].Cells["Id"].Value as int? ?? 0;
            _db.MarkaGuncelle(id, markaEkle_tb.Text);
            marka_dgw.DataSource = _db.MarkalariGetir();
            markaEkle_tb.Text = "";
            markaGuncelle_btn.Visible = markaVazgec_btn.Visible = !(marka_dgw.Enabled = markaEkle_btn.Visible = true);
            refreshMarkaList();
        }

        private void markaVazgec_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
              "Kaydedilmeyen değişiklikleriniz kaybolacaktır. Devam edilsin mi?",
              "Dikkat",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            markaEkle_tb.Text = "";

            markaGuncelle_btn.Visible = markaVazgec_btn.Visible = !(marka_dgw.Enabled = markaEkle_btn.Visible = true);
        }
    }
}
