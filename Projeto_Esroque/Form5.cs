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
    public partial class Form5 : System.Windows.Forms.Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estoqueDataDataSet1.tb_Produto' table. You can move, or remove it, as needed.
            this.tb_ProdutoTableAdapter.Fill(this.estoqueDataDataSet1.tb_Produto);
            desabilita();

        }

        private void nm_produtoTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void habilita()
        {
            cd_produtoTextBox.Enabled = true;
            nm_produtoTextBox.Enabled = true;
            sg_unidadeTextBox.Enabled = true;
            qt_estoqueTextBox.Enabled = true;
            vl_custoTextBox.Enabled = true;
            vl_vendaTextBox.Enabled = true;
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

            cd_produtoTextBox.Enabled = false;
            nm_produtoTextBox.Enabled = false;
            sg_unidadeTextBox.Enabled = false;
            qt_estoqueTextBox.Enabled = false;
            vl_custoTextBox.Enabled = false;
            vl_vendaTextBox.Enabled = false;
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

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
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

        private void btnChange_Click(object sender, EventArgs e)
        {
            habilita();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            tb_ProdutoTableAdapter.Update(estoqueDataDataSet1.tb_Produto);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            desabilita();
            bindingSource1.EndEdit();
            tb_ProdutoTableAdapter.Update(estoqueDataDataSet1.tb_Produto);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            desabilita();
            bindingSource1.CancelEdit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void vl_vendaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cd_produtoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cd_produtoLabel_Click(object sender, EventArgs e)
        {

        }

        private void sg_unidadeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
