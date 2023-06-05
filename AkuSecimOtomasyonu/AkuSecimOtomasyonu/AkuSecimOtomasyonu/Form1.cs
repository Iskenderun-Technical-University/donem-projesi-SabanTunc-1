using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkuSecimOtomasyonu
{
    public partial class Form1 : Form
    {
        readonly DbOperation db;
        public Form1()
        {
            InitializeComponent();
            //this.IsMdiContainer = true;
            model_cb.Text = "Araç Modelini Seçiniz...";
            altModel_cb.Text = "Model Alt Grup Seçiniz...";
            marka_cb.Text = "Araç Markası Seçiniz...";
            for (var yil = 2000; yil < 2024; yil++)
            {
                yil_cb.Items.Add(yil);
            }
            db = new DbOperation();
            marka_cb.Items.Clear();
            marka_cb.DisplayMember = "Value";
            marka_cb.ValueMember = "Id";
            foreach (var item in db.MarkalariGetir())
            {
                marka_cb.Items.Add(item);
            }

        }

        private void marka_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            model_cb.Items.Clear();
            model_cb.DisplayMember = "Value";
            model_cb.ValueMember = "Id";
            foreach (var item in db.ModelleriGetir(((DbOperation.ValueModel)marka_cb.SelectedItem).Id))
            {
                model_cb.Items.Add(item);
            }

            model_cb.Enabled = true;
            altModel_cb.Enabled = bul_btn.Enabled = false;
            model_cb.Text = "Araç Modelini Seçiniz...";
            altModel_cb.Text = "Model Alt Grup Seçiniz...";
            en_lbl.Text = boy_lbl.Text = yukseklik_lbl.Text = akuTipi_lbl.Text = "";
        }

        private void model_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            altModel_cb.Items.Clear();
            altModel_cb.DisplayMember = "Value";
            altModel_cb.ValueMember = "Id";
            foreach (var item in db.AltModelleriGetir(((DbOperation.ValueModel)model_cb.SelectedItem).Id, (int)yil_cb.SelectedItem))
            {
                altModel_cb.Items.Add(item);
            }
            altModel_cb.Enabled = true;
            bul_btn.Enabled = false;
            altModel_cb.Text = "Model Alt Grup Seçiniz...";
            en_lbl.Text = boy_lbl.Text = yukseklik_lbl.Text = akuTipi_lbl.Text = "";
        }

        private void yil_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            marka_cb.Enabled = true;
            model_cb.Enabled = altModel_cb.Enabled = bul_btn.Enabled = false;
            marka_cb.Text = "Araç Markası Seçiniz...";
            model_cb.Text = "Araç Modelini Seçiniz...";
            altModel_cb.Text = "Model Alt Grup Seçiniz...";
            en_lbl.Text = boy_lbl.Text = yukseklik_lbl.Text = akuTipi_lbl.Text = "";
        }

        private void altModel_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            bul_btn.Enabled = true;
            en_lbl.Text = boy_lbl.Text = yukseklik_lbl.Text = akuTipi_lbl.Text = "";
        }

        private void bul_btn_Click(object sender, EventArgs e)
        {
            var item = (DbOperation.ValueModel)altModel_cb.SelectedItem;
            en_lbl.Text = item.En.ToString();
            boy_lbl.Text = item.Boy.ToString();
            yukseklik_lbl.Text = item.Yukseklik.ToString();
            akuTipi_lbl.Text = db.AkuBul(item.En, item.Boy, item.Yukseklik);
        }

        private void dbKayit_btn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();            
        }
    }
}
