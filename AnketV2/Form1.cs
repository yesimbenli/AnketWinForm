using DAL;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnketV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Soru s = new Soru();
            s.SoruCumlesi = textBox2.Text;
            AnketContext db = new AnketContext();
            db.Sorular.Add(s);
            db.SaveChanges();
            MessageBox.Show("Soru Eklendi");
        }
        AnketContext db = new AnketContext();
        public void Yenile()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = db.Sorular.ToList();
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Clear();
            foreach (Soru soru in db.Sorular)
            {
                Label lbl = new Label();
                lbl.AutoSize = true;
                lbl.Text = soru.SoruCumlesi;
                flowLayoutPanel1.Controls.Add(lbl);

         
               RadioButton r1 = new RadioButton();
               r1.Text = "Evet";
               //flowLayoutPanel1.Controls.Add(r1);
             
               RadioButton r2= new RadioButton();
               r2.Text = "Hayır";
                //flowLayoutPanel1.Controls.Add(r2);

                FlowLayoutPanel p = new FlowLayoutPanel();
                p.Width = 300;
                p.Height = 100;
                p.Controls.Add(r1);
                p.Controls.Add(r2);
                flowLayoutPanel1.Controls.Add(p);
             
               /*ComboBox c1 = new ComboBox();
                c1.Items.Add("Evet");
                c1.Items.Add("Hayır");
                flowLayoutPanel1.Controls.Add(c1);
                flowLayoutPanel1.SetFlowBreak(c1, true);*/

            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Yenile();
        }
    }
}
