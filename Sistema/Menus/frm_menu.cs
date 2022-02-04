using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Produtos_Click(object sender, EventArgs e)
        {
            frm_Produtos frm = new frm_Produtos();
            frm.Show();
        }


        private void btn_categorias_Click(object sender, EventArgs e)
        {
            frm_Categorias Frm = new frm_Categorias();
            Frm.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Produtos frm = new frm_Produtos();
            frm.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Categorias Frm = new frm_Categorias();
            Frm.Show();
        }

        
    }
}
