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
    public partial class Form3 : System.Windows.Forms.Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estoqueDataDataSet1.tb_cliente' table. You can move, or remove it, as needed.
            this.tb_clienteTableAdapter.Fill(this.estoqueDataDataSet1.tb_cliente);
            desabilita();
            cd_clienteTextBox.Enabled = false;

        }

        private void btnProx_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bindingSource1.AddNew();
            habilita();
        }
        private void habilita()
        {
            nm_clienteTextBox.Enabled = true;
            ds_enderecoTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            nm__cidadeTextBox.Enabled = true;
            sg_EstadoTextBox.Enabled = true;
            cd_cepTextBox.Enabled = true;
            cd_cpfTextBox.Enabled = true;
            ds_telefoneTextBox.Enabled = true;
            ds_emailTextBox.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
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
            ds_emailTextBox.Enabled = false;
            nm_clienteTextBox.Enabled = false;
            ds_enderecoTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            nm__cidadeTextBox.Enabled = false;
            sg_EstadoTextBox.Enabled = false;
            cd_cepTextBox.Enabled = false;
            cd_cpfTextBox.Enabled = false;
            ds_telefoneTextBox.Enabled = false;
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

        }

        private void txtConf_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            habilita();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            tb_clienteTableAdapter.Update(estoqueDataDataSet1.tb_cliente);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            desabilita();
            bindingSource1.EndEdit();
            tb_clienteTableAdapter.Update(estoqueDataDataSet1.tb_cliente);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            desabilita();
            bindingSource1.CancelEdit();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
