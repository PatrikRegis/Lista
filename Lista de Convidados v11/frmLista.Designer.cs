
namespace Lista_de_convidados
{
    partial class frmLista
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLista));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarConformadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarNãoConfirmadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgLista = new System.Windows.Forms.DataGridView();
            this.idList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foneList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.butFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.butNovo = new System.Windows.Forms.Button();
            this.butExcluir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.butSalvar = new System.Windows.Forms.Button();
            this.textId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.butLimpar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbPesquisar = new System.Windows.Forms.TextBox();
            this.butLocalizar2 = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.Label();
            this.textFone = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.relatórioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem1});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarConformadosToolStripMenuItem,
            this.mostrarNãoConfirmadosToolStripMenuItem,
            this.mostrarTodosToolStripMenuItem});
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // mostrarConformadosToolStripMenuItem
            // 
            this.mostrarConformadosToolStripMenuItem.Name = "mostrarConformadosToolStripMenuItem";
            this.mostrarConformadosToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.mostrarConformadosToolStripMenuItem.Text = "Mostrar confirmados";
            this.mostrarConformadosToolStripMenuItem.Click += new System.EventHandler(this.mostrarConformadosToolStripMenuItem_Click);
            // 
            // mostrarNãoConfirmadosToolStripMenuItem
            // 
            this.mostrarNãoConfirmadosToolStripMenuItem.Name = "mostrarNãoConfirmadosToolStripMenuItem";
            this.mostrarNãoConfirmadosToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.mostrarNãoConfirmadosToolStripMenuItem.Text = "Mostrar não confirmados";
            this.mostrarNãoConfirmadosToolStripMenuItem.Click += new System.EventHandler(this.mostrarNãoConfirmadosToolStripMenuItem_Click);
            // 
            // mostrarTodosToolStripMenuItem
            // 
            this.mostrarTodosToolStripMenuItem.Name = "mostrarTodosToolStripMenuItem";
            this.mostrarTodosToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.mostrarTodosToolStripMenuItem.Text = "Mostrar Todos";
            this.mostrarTodosToolStripMenuItem.Click += new System.EventHandler(this.mostrarTodosToolStripMenuItem_Click);
            // 
            // dgLista
            // 
            this.dgLista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idList,
            this.nomeList,
            this.emailList,
            this.foneList,
            this.edit});
            this.dgLista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgLista.Location = new System.Drawing.Point(15, 319);
            this.dgLista.Name = "dgLista";
            this.dgLista.ReadOnly = true;
            this.dgLista.RowHeadersVisible = false;
            this.dgLista.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLista.Size = new System.Drawing.Size(474, 335);
            this.dgLista.TabIndex = 1;
            this.dgLista.TabStop = false;
            this.dgLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgLista.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgLista_CellFormatting);
            // 
            // idList
            // 
            this.idList.Frozen = true;
            this.idList.HeaderText = "ID";
            this.idList.Name = "idList";
            this.idList.ReadOnly = true;
            this.idList.ToolTipText = "ID";
            this.idList.Width = 30;
            // 
            // nomeList
            // 
            this.nomeList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nomeList.FillWeight = 120F;
            this.nomeList.Frozen = true;
            this.nomeList.HeaderText = "NOME";
            this.nomeList.Name = "nomeList";
            this.nomeList.ReadOnly = true;
            this.nomeList.ToolTipText = "NOME";
            this.nomeList.Width = 150;
            // 
            // emailList
            // 
            this.emailList.FillWeight = 130F;
            this.emailList.Frozen = true;
            this.emailList.HeaderText = "E-MAIL";
            this.emailList.Name = "emailList";
            this.emailList.ReadOnly = true;
            this.emailList.ToolTipText = "E-MAIL";
            this.emailList.Width = 150;
            // 
            // foneList
            // 
            this.foneList.HeaderText = "TELEFONE";
            this.foneList.Name = "foneList";
            this.foneList.ReadOnly = true;
            this.foneList.ToolTipText = "TELEFONE";
            this.foneList.Width = 90;
            // 
            // edit
            // 
            this.edit.DataPropertyName = "Editar";
            this.edit.HeaderText = "";
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit.ToolTipText = "Editar";
            this.edit.Width = 50;
            // 
            // butFechar
            // 
            this.butFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butFechar.BackgroundImage")));
            this.butFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butFechar.Location = new System.Drawing.Point(437, 660);
            this.butFechar.Name = "butFechar";
            this.butFechar.Size = new System.Drawing.Size(52, 42);
            this.butFechar.TabIndex = 12;
            this.butFechar.UseVisualStyleBackColor = true;
            this.butFechar.Click += new System.EventHandler(this.butFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // textNome
            // 
            this.textNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNome.Location = new System.Drawing.Point(102, 59);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(387, 26);
            this.textNome.TabIndex = 2;
            // 
            // butNovo
            // 
            this.butNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.butNovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butNovo.BackgroundImage")));
            this.butNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butNovo.Location = new System.Drawing.Point(72, 215);
            this.butNovo.Name = "butNovo";
            this.butNovo.Size = new System.Drawing.Size(87, 42);
            this.butNovo.TabIndex = 5;
            this.butNovo.UseVisualStyleBackColor = false;
            this.butNovo.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butExcluir
            // 
            this.butExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.butExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butExcluir.BackgroundImage")));
            this.butExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butExcluir.Location = new System.Drawing.Point(258, 216);
            this.butExcluir.Name = "butExcluir";
            this.butExcluir.Size = new System.Drawing.Size(87, 42);
            this.butExcluir.TabIndex = 7;
            this.butExcluir.UseVisualStyleBackColor = false;
            this.butExcluir.Click += new System.EventHandler(this.butExcluir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Telefone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "E-mail:";
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.Location = new System.Drawing.Point(15, 111);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(474, 26);
            this.textEmail.TabIndex = 3;
            // 
            // butSalvar
            // 
            this.butSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.butSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butSalvar.BackgroundImage")));
            this.butSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butSalvar.Location = new System.Drawing.Point(165, 216);
            this.butSalvar.Name = "butSalvar";
            this.butSalvar.Size = new System.Drawing.Size(87, 42);
            this.butSalvar.TabIndex = 6;
            this.butSalvar.UseVisualStyleBackColor = false;
            this.butSalvar.Click += new System.EventHandler(this.butSalvar_Click);
            // 
            // textId
            // 
            this.textId.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textId.Location = new System.Drawing.Point(15, 59);
            this.textId.Name = "textId";
            this.textId.ReadOnly = true;
            this.textId.Size = new System.Drawing.Size(79, 26);
            this.textId.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "ID:";
            // 
            // butLimpar
            // 
            this.butLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.butLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butLimpar.BackgroundImage")));
            this.butLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butLimpar.Location = new System.Drawing.Point(351, 217);
            this.butLimpar.Name = "butLimpar";
            this.butLimpar.Size = new System.Drawing.Size(87, 42);
            this.butLimpar.TabIndex = 8;
            this.butLimpar.UseVisualStyleBackColor = false;
            this.butLimpar.Click += new System.EventHandler(this.butLimpar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 26);
            this.label5.TabIndex = 56;
            this.label5.Text = "Convidados Confirmados";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(91, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "NOVO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(179, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "SALVAR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(271, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "EXCLUIR";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(366, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 61;
            this.label10.Text = "LIMPAR";
            // 
            // tbPesquisar
            // 
            this.tbPesquisar.AccessibleName = "";
            this.tbPesquisar.BackColor = System.Drawing.SystemColors.Window;
            this.tbPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPesquisar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbPesquisar.Location = new System.Drawing.Point(342, 292);
            this.tbPesquisar.Name = "tbPesquisar";
            this.tbPesquisar.Size = new System.Drawing.Size(113, 26);
            this.tbPesquisar.TabIndex = 65;
            this.tbPesquisar.Tag = "";
            this.tbPesquisar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.tbPesquisar, "Pesquise por nome");
            this.tbPesquisar.Click += new System.EventHandler(this.tbPesquisar_Click);
            // 
            // butLocalizar2
            // 
            this.butLocalizar2.AccessibleName = "Pesquisar por ID";
            this.butLocalizar2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butLocalizar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(197)))), ((int)(((byte)(109)))));
            this.butLocalizar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butLocalizar2.BackgroundImage")));
            this.butLocalizar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butLocalizar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.butLocalizar2.Location = new System.Drawing.Point(458, 291);
            this.butLocalizar2.Margin = new System.Windows.Forms.Padding(0);
            this.butLocalizar2.Name = "butLocalizar2";
            this.butLocalizar2.Size = new System.Drawing.Size(28, 27);
            this.butLocalizar2.TabIndex = 64;
            this.butLocalizar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butLocalizar2.UseVisualStyleBackColor = false;
            this.butLocalizar2.Click += new System.EventHandler(this.butLocalizar2_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.AutoSize = true;
            this.txtPesquisar.BackColor = System.Drawing.Color.White;
            this.txtPesquisar.ForeColor = System.Drawing.Color.Silver;
            this.txtPesquisar.Location = new System.Drawing.Point(396, 299);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(53, 13);
            this.txtPesquisar.TabIndex = 66;
            this.txtPesquisar.Text = "Pesquisar";
            // 
            // textFone
            // 
            this.textFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFone.Location = new System.Drawing.Point(16, 168);
            this.textFone.Name = "textFone";
            this.textFone.Size = new System.Drawing.Size(470, 26);
            this.textFone.TabIndex = 67;
            this.textFone.Tag = "FONE";
            this.textFone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFone_KeyPress_1);
            // 
            // frmLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(502, 714);
            this.Controls.Add(this.textFone);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.tbPesquisar);
            this.Controls.Add(this.butLocalizar2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.butLimpar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.dgLista);
            this.Controls.Add(this.butSalvar);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butExcluir);
            this.Controls.Add(this.butNovo);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butFechar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de convidados";
            this.Load += new System.EventHandler(this.frmLista_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dgLista;
        private System.Windows.Forms.Button butFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Button butNovo;
        private System.Windows.Forms.Button butExcluir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Button butSalvar;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butLimpar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button butLocalizar2;
        private System.Windows.Forms.TextBox tbPesquisar;
        private System.Windows.Forms.Label txtPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idList;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailList;
        private System.Windows.Forms.DataGridViewTextBoxColumn foneList;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.TextBox textFone;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarConformadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarNãoConfirmadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarTodosToolStripMenuItem;
    }
}

