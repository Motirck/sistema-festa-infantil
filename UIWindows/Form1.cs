using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIWindows;

namespace FestaInfantil.UIWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioForm obj = new UsuarioForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void temaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TemaForm form = new TemaForm();
            form.MdiParent = this;
            form.Show();
        }

        private void itensDoTemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItensTemaForm form = new ItensTemaForm();
            form.MdiParent = this;
            form.Show();
        }

        private void aluguelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AluguelForm form = new AluguelForm();
            form.MdiParent = this;
            form.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            UsuarioForm obj = new UsuarioForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void btnAluguel_Click(object sender, EventArgs e)
        {
            AluguelForm form = new AluguelForm();
            form.MdiParent = this;
            form.Show();
        }

        private void btnTema_Click(object sender, EventArgs e)
        {
            TemaForm form = new TemaForm();
            form.MdiParent = this;
            form.Show();
        }

        private void btnItensDoTema_Click(object sender, EventArgs e)
        {
            ItensTemaForm form = new ItensTemaForm();
            form.MdiParent = this;
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
