namespace Projeto_Esroque
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cd_produtoLabel;
            System.Windows.Forms.Label nm_produtoLabel;
            System.Windows.Forms.Label sg_unidadeLabel;
            System.Windows.Forms.Label qt_estoqueLabel;
            System.Windows.Forms.Label vl_custoLabel;
            System.Windows.Forms.Label vl_vendaLabel;
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnProx = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.estoqueDataDataSet1 = new Projeto_Esroque.estoqueDataDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tb_ProdutoTableAdapter = new Projeto_Esroque.estoqueDataDataSetTableAdapters.tb_ProdutoTableAdapter();
            this.tableAdapterManager = new Projeto_Esroque.estoqueDataDataSetTableAdapters.TableAdapterManager();
            this.cd_produtoTextBox = new System.Windows.Forms.TextBox();
            this.nm_produtoTextBox = new System.Windows.Forms.TextBox();
            this.sg_unidadeTextBox = new System.Windows.Forms.TextBox();
            this.qt_estoqueTextBox = new System.Windows.Forms.TextBox();
            this.vl_custoTextBox = new System.Windows.Forms.TextBox();
            this.vl_vendaTextBox = new System.Windows.Forms.TextBox();
            cd_produtoLabel = new System.Windows.Forms.Label();
            nm_produtoLabel = new System.Windows.Forms.Label();
            sg_unidadeLabel = new System.Windows.Forms.Label();
            qt_estoqueLabel = new System.Windows.Forms.Label();
            vl_custoLabel = new System.Windows.Forms.Label();
            vl_vendaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.YellowGreen;
            this.btnExit.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(566, 350);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 34);
            this.btnExit.TabIndex = 43;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.YellowGreen;
            this.btnPrint.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(441, 350);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(77, 34);
            this.btnPrint.TabIndex = 42;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSearch.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(313, 350);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(77, 34);
            this.btnSearch.TabIndex = 41;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCancel.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(170, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 34);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSave.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(26, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 34);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.YellowGreen;
            this.btnDel.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(566, 294);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(77, 34);
            this.btnDel.TabIndex = 38;
            this.btnDel.Text = "Excluir";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.YellowGreen;
            this.btnChange.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(441, 294);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(77, 34);
            this.btnChange.TabIndex = 37;
            this.btnChange.Text = "Alterar";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.YellowGreen;
            this.btnNew.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(313, 293);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(77, 34);
            this.btnNew.TabIndex = 36;
            this.btnNew.Text = "Novo";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnProx
            // 
            this.btnProx.BackColor = System.Drawing.Color.YellowGreen;
            this.btnProx.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProx.Location = new System.Drawing.Point(170, 294);
            this.btnProx.Name = "btnProx";
            this.btnProx.Size = new System.Drawing.Size(77, 34);
            this.btnProx.TabIndex = 35;
            this.btnProx.Text = "Próximo";
            this.btnProx.UseVisualStyleBackColor = false;
            this.btnProx.Click += new System.EventHandler(this.btnProx_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAnterior.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(26, 294);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(77, 34);
            this.btnAnterior.TabIndex = 34;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // estoqueDataDataSet1
            // 
            this.estoqueDataDataSet1.DataSetName = "estoqueDataDataSet";
            this.estoqueDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tb_Produto";
            this.bindingSource1.DataSource = this.estoqueDataDataSet1;
            // 
            // tb_ProdutoTableAdapter
            // 
            this.tb_ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.tb_clienteTableAdapter = null;
            this.tableAdapterManager.tb_fornecedorTableAdapter = null;
            this.tableAdapterManager.tb_ProdutoTableAdapter = this.tb_ProdutoTableAdapter;
            this.tableAdapterManager.tb_UsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_Esroque.estoqueDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cd_produtoLabel
            // 
            cd_produtoLabel.AutoSize = true;
            cd_produtoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_produtoLabel.Location = new System.Drawing.Point(31, 35);
            cd_produtoLabel.Name = "cd_produtoLabel";
            cd_produtoLabel.Size = new System.Drawing.Size(71, 24);
            cd_produtoLabel.TabIndex = 43;
            cd_produtoLabel.Text = "Código";
            cd_produtoLabel.Click += new System.EventHandler(this.cd_produtoLabel_Click);
            // 
            // cd_produtoTextBox
            // 
            this.cd_produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "cd_produto", true));
            this.cd_produtoTextBox.Location = new System.Drawing.Point(121, 40);
            this.cd_produtoTextBox.Name = "cd_produtoTextBox";
            this.cd_produtoTextBox.Size = new System.Drawing.Size(100, 20);
            this.cd_produtoTextBox.TabIndex = 44;
            // 
            // nm_produtoLabel
            // 
            nm_produtoLabel.AutoSize = true;
            nm_produtoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_produtoLabel.Location = new System.Drawing.Point(31, 66);
            nm_produtoLabel.Name = "nm_produtoLabel";
            nm_produtoLabel.Size = new System.Drawing.Size(67, 24);
            nm_produtoLabel.TabIndex = 45;
            nm_produtoLabel.Text = "Nome:";
            // 
            // nm_produtoTextBox
            // 
            this.nm_produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "nm_produto", true));
            this.nm_produtoTextBox.Location = new System.Drawing.Point(121, 66);
            this.nm_produtoTextBox.Name = "nm_produtoTextBox";
            this.nm_produtoTextBox.Size = new System.Drawing.Size(100, 20);
            this.nm_produtoTextBox.TabIndex = 46;
            // 
            // sg_unidadeLabel
            // 
            sg_unidadeLabel.AutoSize = true;
            sg_unidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sg_unidadeLabel.Location = new System.Drawing.Point(31, 106);
            sg_unidadeLabel.Name = "sg_unidadeLabel";
            sg_unidadeLabel.Size = new System.Drawing.Size(86, 24);
            sg_unidadeLabel.TabIndex = 47;
            sg_unidadeLabel.Text = "Unidade:";
            sg_unidadeLabel.Click += new System.EventHandler(this.sg_unidadeLabel_Click);
            // 
            // sg_unidadeTextBox
            // 
            this.sg_unidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "sg_unidade", true));
            this.sg_unidadeTextBox.Location = new System.Drawing.Point(121, 111);
            this.sg_unidadeTextBox.Name = "sg_unidadeTextBox";
            this.sg_unidadeTextBox.Size = new System.Drawing.Size(100, 20);
            this.sg_unidadeTextBox.TabIndex = 48;
            // 
            // qt_estoqueLabel
            // 
            qt_estoqueLabel.AutoSize = true;
            qt_estoqueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qt_estoqueLabel.Location = new System.Drawing.Point(31, 142);
            qt_estoqueLabel.Name = "qt_estoqueLabel";
            qt_estoqueLabel.Size = new System.Drawing.Size(42, 24);
            qt_estoqueLabel.TabIndex = 49;
            qt_estoqueLabel.Text = "QT:";
            // 
            // qt_estoqueTextBox
            // 
            this.qt_estoqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "qt_estoque", true));
            this.qt_estoqueTextBox.Location = new System.Drawing.Point(121, 147);
            this.qt_estoqueTextBox.Name = "qt_estoqueTextBox";
            this.qt_estoqueTextBox.Size = new System.Drawing.Size(100, 20);
            this.qt_estoqueTextBox.TabIndex = 50;
            // 
            // vl_custoLabel
            // 
            vl_custoLabel.AutoSize = true;
            vl_custoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vl_custoLabel.Location = new System.Drawing.Point(30, 182);
            vl_custoLabel.Name = "vl_custoLabel";
            vl_custoLabel.Size = new System.Drawing.Size(112, 24);
            vl_custoLabel.TabIndex = 51;
            vl_custoLabel.Text = "Valor Custo:";
            // 
            // vl_custoTextBox
            // 
            this.vl_custoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "vl_custo", true));
            this.vl_custoTextBox.Location = new System.Drawing.Point(148, 187);
            this.vl_custoTextBox.Name = "vl_custoTextBox";
            this.vl_custoTextBox.Size = new System.Drawing.Size(100, 20);
            this.vl_custoTextBox.TabIndex = 52;
            // 
            // vl_vendaLabel
            // 
            vl_vendaLabel.AutoSize = true;
            vl_vendaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vl_vendaLabel.Location = new System.Drawing.Point(30, 221);
            vl_vendaLabel.Name = "vl_vendaLabel";
            vl_vendaLabel.Size = new System.Drawing.Size(120, 24);
            vl_vendaLabel.TabIndex = 53;
            vl_vendaLabel.Text = "Valor Venda:";
            // 
            // vl_vendaTextBox
            // 
            this.vl_vendaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "vl_venda", true));
            this.vl_vendaTextBox.Location = new System.Drawing.Point(156, 225);
            this.vl_vendaTextBox.Name = "vl_vendaTextBox";
            this.vl_vendaTextBox.Size = new System.Drawing.Size(100, 20);
            this.vl_vendaTextBox.TabIndex = 54;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(718, 451);
            this.Controls.Add(cd_produtoLabel);
            this.Controls.Add(this.cd_produtoTextBox);
            this.Controls.Add(nm_produtoLabel);
            this.Controls.Add(this.nm_produtoTextBox);
            this.Controls.Add(sg_unidadeLabel);
            this.Controls.Add(this.sg_unidadeTextBox);
            this.Controls.Add(qt_estoqueLabel);
            this.Controls.Add(this.qt_estoqueTextBox);
            this.Controls.Add(vl_custoLabel);
            this.Controls.Add(this.vl_custoTextBox);
            this.Controls.Add(vl_vendaLabel);
            this.Controls.Add(this.vl_vendaTextBox);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnProx);
            this.Controls.Add(this.btnAnterior);
            this.Name = "Form5";
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnProx;
        private System.Windows.Forms.Button btnAnterior;
        private estoqueDataDataSet estoqueDataDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private estoqueDataDataSetTableAdapters.tb_ProdutoTableAdapter tb_ProdutoTableAdapter;
        private estoqueDataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cd_produtoTextBox;
        private System.Windows.Forms.TextBox nm_produtoTextBox;
        private System.Windows.Forms.TextBox sg_unidadeTextBox;
        private System.Windows.Forms.TextBox qt_estoqueTextBox;
        private System.Windows.Forms.TextBox vl_custoTextBox;
        private System.Windows.Forms.TextBox vl_vendaTextBox;
    }
}