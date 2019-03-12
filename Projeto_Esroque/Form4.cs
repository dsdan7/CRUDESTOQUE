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
    public partial class Form4 : System.Windows.Forms.Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estoqueDataDataSet1.tb_fornecedor' table. You can move, or remove it, as needed.
            this.tb_fornecedorTableAdapter.Fill(this.estoqueDataDataSet1.tb_fornecedor);
            desabilita();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bindingSource1.AddNew();
            habilita();
        }

        private void habilita()
        {
            nm_fornecedorTextBox.Enabled = true;
            ds_enderecoTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            sg_estadoTextBox.Enabled = true;
            cd_cepTextBox.Enabled = true;
            cd_cnpjTextBox.Enabled = true;
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
            nm_fornecedorTextBox.Enabled = false;
            ds_enderecoTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            nm_fornecedorTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            sg_estadoTextBox.Enabled = false;
            cd_cepTextBox.Enabled = false;
            cd_cnpjTextBox.Enabled = false;
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

        private void btnChange_Click(object sender, EventArgs e)
        {
            habilita();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            tb_fornecedorTableAdapter.Update(estoqueDataDataSet1.tb_fornecedor);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            desabilita();
            bindingSource1.EndEdit();
            tb_fornecedorTableAdapter.Update(estoqueDataDataSet1.tb_fornecedor);
        }

        private void btnCancel_Click(object sender, EventArgs e)
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

        private void btnProx_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }
    }
}
