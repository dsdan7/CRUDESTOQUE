using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Esroque
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estoqueDataDataSet1.tb_Usuario' table. You can move, or remove it, as needed.
            this.tb_UsuarioTableAdapter.Fill(this.estoqueDataDataSet1.tb_Usuario);
            desabilita();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            
            bindingSource1.MovePrevious();
            txtConf.Text = txtSenha.Text;

        }

        private void btnProx_Click(object sender, EventArgs e)
        {
            
            bindingSource1.MoveNext();
            txtConf.Text = txtSenha.Text;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bindingSource1.AddNew();
            habilita();
            txtConf.Text = null;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            desabilita();
            bindingSource1.EndEdit();
            tb_UsuarioTableAdapter.Update(estoqueDataDataSet1.tb_Usuario);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            desabilita();
            bindingSource1.CancelEdit();
        }
        private void habilita()
        {
            txtNome.Enabled = true;
            txtLogin.Enabled = true;
            txtNv.Enabled = true;
            txtSenha.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            txtConf.Enabled = true;
            btnAnterior.Enabled = false;
            btnProx.Enabled = false;
            btnExit.Enabled = false;
            btnPrint.Enabled = false;
            btnDel.Enabled = false;
            btnSearch.Enabled = false;
            btnChange.Enabled = false;
            btnExit.Enabled = false;
        }

        private void desabilita()
        {
            
            txtNome.Enabled = false;
            txtLogin.Enabled = false;
            txtNv.Enabled = false;
            txtSenha.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnAnterior.Enabled = true;
            btnProx.Enabled = true;
            btnExit.Enabled = true;
            btnPrint.Enabled = true;
            btnDel.Enabled = true;
            btnSearch.Enabled = true;
            btnChange.Enabled = true;
            btnExit.Enabled = true;
            txtConf.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void txtNv_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            habilita();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            tb_UsuarioTableAdapter.Update(estoqueDataDataSet1.tb_Usuario);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
