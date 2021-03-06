using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Hamburger.Formlar;

namespace UI_Hamburger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void childForm(Form _childForm)
        {
            this.Width = _childForm.Width + 22;
            this.Height = _childForm.Height + 60;
            bool durum = false;

            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text == _childForm.Text)
                {
                    durum = true;
                    frm.Activate();
                }
                else
                {
                    frm.Close();
                }

            }

            if (durum == false)
            {
                _childForm.MdiParent = this;
                _childForm.StartPosition = FormStartPosition.Manual;
                _childForm.WindowState = FormWindowState.Maximized;
                _childForm.FormBorderStyle = FormBorderStyle.None;
                _childForm.Show();
            }
        }

        private void hamburgerMenuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new MenuEkle());
        }

        private void ekstraEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new EkstraEkle());
        }

        private void siparisVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new SiparisOlustur());
        }

        private void raporlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new Raporla());
        }
    }
}
