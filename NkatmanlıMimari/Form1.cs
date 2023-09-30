using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entitylayer;
using dataacceslayer;
using LogicLayer;


namespace NkatmanlıMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            List<entitypersonel> perlist = LogicPersonel.llpersonellistesi();
            dataGridView1.DataSource= perlist;

        }


        private void button1_Click_2(object sender, EventArgs e)
        {
            entitypersonel ent = new entitypersonel();
            ent.Ad = txtad.Text;
            ent.Soyad = txtsoyad.Text;
            ent.Sehir = txtsehir.Text;
            ent.Maas = short.Parse(txtmaas.Text);
            ent.Gorev = txtgorev.Text;
            LogicPersonel.llpersonelekle(ent);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            entitypersonel ent =new entitypersonel();
            ent.Id = Convert.ToInt32(txtıd.Text);
            LogicPersonel.llpersonelsil(ent.Id);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            entitypersonel ent = new entitypersonel();
            ent.Id = Convert.ToInt32(txtıd.Text);
            ent.Ad = txtad.Text;
            ent.Soyad = txtsoyad.Text;
            ent.Sehir = txtsehir.Text;
            ent.Maas = short.Parse(txtmaas.Text);
            ent.Gorev = txtgorev.Text;
            LogicPersonel.llpersonelguncelle(ent);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txtıd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtsehir.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtgorev.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtmaas.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
