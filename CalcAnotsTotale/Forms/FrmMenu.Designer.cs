namespace CalcAnotsTotale
{
    partial class FrmMenu
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
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblCopyright = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anotaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.grpBoxCriacao = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAnotacoes = new System.Windows.Forms.Panel();
            this.btnCopiarNota = new System.Windows.Forms.Button();
            this.btnNovaNota = new System.Windows.Forms.Button();
            this.txtBoxTituloNota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvarAnotacao = new System.Windows.Forms.Button();
            this.txtBoxAnotacao = new System.Windows.Forms.TextBox();
            this.chkBoxModificar = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbEscolhaNota = new System.Windows.Forms.ComboBox();
            this.lblEscolhaAnotacao = new System.Windows.Forms.Label();
            this.pnlConfigs = new System.Windows.Forms.Panel();
            this.btnSaveConfigs = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPathConfig = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.grpBoxCriacao.SuspendLayout();
            this.pnlAnotacoes.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlConfigs.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(12, 442);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(28, 17);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "     ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(818, 442);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(102, 17);
            this.lblCopyright.TabIndex = 1;
            this.lblCopyright.Text = "@GrupoTotale";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculosToolStripMenuItem,
            this.anotaçõesToolStripMenuItem,
            this.configuraçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(932, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calculosToolStripMenuItem
            // 
            this.calculosToolStripMenuItem.Name = "calculosToolStripMenuItem";
            this.calculosToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.calculosToolStripMenuItem.Text = "Calculos";
            this.calculosToolStripMenuItem.Click += new System.EventHandler(this.calculosToolStripMenuItem_Click);
            // 
            // anotaçõesToolStripMenuItem
            // 
            this.anotaçõesToolStripMenuItem.Name = "anotaçõesToolStripMenuItem";
            this.anotaçõesToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.anotaçõesToolStripMenuItem.Text = "Anotações";
            this.anotaçõesToolStripMenuItem.Click += new System.EventHandler(this.anotaçõesToolStripMenuItem_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            this.configuraçõesToolStripMenuItem.Click += new System.EventHandler(this.configuraçõesToolStripMenuItem_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlMenu.Controls.Add(this.grpBoxCriacao);
            this.pnlMenu.Location = new System.Drawing.Point(0, 31);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(932, 396);
            this.pnlMenu.TabIndex = 3;
            // 
            // grpBoxCriacao
            // 
            this.grpBoxCriacao.Controls.Add(this.label1);
            this.grpBoxCriacao.Location = new System.Drawing.Point(662, 283);
            this.grpBoxCriacao.Name = "grpBoxCriacao";
            this.grpBoxCriacao.Size = new System.Drawing.Size(258, 101);
            this.grpBoxCriacao.TabIndex = 0;
            this.grpBoxCriacao.TabStop = false;
            this.grpBoxCriacao.Text = "Criado Por";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "• Vinícius Espinosa\r\n• viniespinosa.developer@gmail.com\r\n• (15) 99782-6699";
            // 
            // pnlAnotacoes
            // 
            this.pnlAnotacoes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlAnotacoes.Controls.Add(this.btnCopiarNota);
            this.pnlAnotacoes.Controls.Add(this.btnNovaNota);
            this.pnlAnotacoes.Controls.Add(this.txtBoxTituloNota);
            this.pnlAnotacoes.Controls.Add(this.label3);
            this.pnlAnotacoes.Controls.Add(this.btnSalvarAnotacao);
            this.pnlAnotacoes.Controls.Add(this.txtBoxAnotacao);
            this.pnlAnotacoes.Controls.Add(this.chkBoxModificar);
            this.pnlAnotacoes.Controls.Add(this.groupBox2);
            this.pnlAnotacoes.Location = new System.Drawing.Point(0, 31);
            this.pnlAnotacoes.Name = "pnlAnotacoes";
            this.pnlAnotacoes.Size = new System.Drawing.Size(932, 396);
            this.pnlAnotacoes.TabIndex = 4;
            // 
            // btnCopiarNota
            // 
            this.btnCopiarNota.Location = new System.Drawing.Point(783, 342);
            this.btnCopiarNota.Name = "btnCopiarNota";
            this.btnCopiarNota.Size = new System.Drawing.Size(112, 26);
            this.btnCopiarNota.TabIndex = 7;
            this.btnCopiarNota.Text = "Copiar";
            this.btnCopiarNota.UseVisualStyleBackColor = true;
            this.btnCopiarNota.Click += new System.EventHandler(this.btnCopiarNota_Click);
            // 
            // btnNovaNota
            // 
            this.btnNovaNota.Location = new System.Drawing.Point(797, 11);
            this.btnNovaNota.Name = "btnNovaNota";
            this.btnNovaNota.Size = new System.Drawing.Size(112, 34);
            this.btnNovaNota.TabIndex = 6;
            this.btnNovaNota.Text = "Nova nota";
            this.btnNovaNota.UseVisualStyleBackColor = true;
            this.btnNovaNota.Click += new System.EventHandler(this.btnNovaNota_Click);
            // 
            // txtBoxTituloNota
            // 
            this.txtBoxTituloNota.Location = new System.Drawing.Point(474, 65);
            this.txtBoxTituloNota.Name = "txtBoxTituloNota";
            this.txtBoxTituloNota.Size = new System.Drawing.Size(269, 22);
            this.txtBoxTituloNota.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Titulo da nota:";
            // 
            // btnSalvarAnotacao
            // 
            this.btnSalvarAnotacao.Location = new System.Drawing.Point(797, 51);
            this.btnSalvarAnotacao.Name = "btnSalvarAnotacao";
            this.btnSalvarAnotacao.Size = new System.Drawing.Size(112, 34);
            this.btnSalvarAnotacao.TabIndex = 3;
            this.btnSalvarAnotacao.Text = "Salvar";
            this.btnSalvarAnotacao.UseVisualStyleBackColor = true;
            this.btnSalvarAnotacao.Click += new System.EventHandler(this.btnSalvarAnotacao_Click);
            // 
            // txtBoxAnotacao
            // 
            this.txtBoxAnotacao.Location = new System.Drawing.Point(21, 117);
            this.txtBoxAnotacao.Multiline = true;
            this.txtBoxAnotacao.Name = "txtBoxAnotacao";
            this.txtBoxAnotacao.Size = new System.Drawing.Size(888, 261);
            this.txtBoxAnotacao.TabIndex = 2;
            this.txtBoxAnotacao.TextChanged += new System.EventHandler(this.txtBoxAnotacao_TextChanged);
            // 
            // chkBoxModificar
            // 
            this.chkBoxModificar.AutoSize = true;
            this.chkBoxModificar.Location = new System.Drawing.Point(372, 31);
            this.chkBoxModificar.Name = "chkBoxModificar";
            this.chkBoxModificar.Size = new System.Drawing.Size(87, 21);
            this.chkBoxModificar.TabIndex = 1;
            this.chkBoxModificar.Text = "Modificar";
            this.chkBoxModificar.UseVisualStyleBackColor = true;
            this.chkBoxModificar.CheckedChanged += new System.EventHandler(this.chkBoxModificar_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbEscolhaNota);
            this.groupBox2.Controls.Add(this.lblEscolhaAnotacao);
            this.groupBox2.Location = new System.Drawing.Point(21, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 78);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Anotação";
            // 
            // cmbEscolhaNota
            // 
            this.cmbEscolhaNota.FormattingEnabled = true;
            this.cmbEscolhaNota.Location = new System.Drawing.Point(118, 33);
            this.cmbEscolhaNota.Name = "cmbEscolhaNota";
            this.cmbEscolhaNota.Size = new System.Drawing.Size(198, 24);
            this.cmbEscolhaNota.TabIndex = 1;
            this.cmbEscolhaNota.SelectedIndexChanged += new System.EventHandler(this.cmbEscolhaNota_SelectedIndexChanged);
            this.cmbEscolhaNota.Click += new System.EventHandler(this.cmbEscolhaNota_Click);
            this.cmbEscolhaNota.Enter += new System.EventHandler(this.cmbEscolhaNota_Enter);
            // 
            // lblEscolhaAnotacao
            // 
            this.lblEscolhaAnotacao.AutoSize = true;
            this.lblEscolhaAnotacao.Location = new System.Drawing.Point(6, 36);
            this.lblEscolhaAnotacao.Name = "lblEscolhaAnotacao";
            this.lblEscolhaAnotacao.Size = new System.Drawing.Size(106, 17);
            this.lblEscolhaAnotacao.TabIndex = 0;
            this.lblEscolhaAnotacao.Text = "Escolha a nota:";
            // 
            // pnlConfigs
            // 
            this.pnlConfigs.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlConfigs.Controls.Add(this.btnSaveConfigs);
            this.pnlConfigs.Controls.Add(this.groupBox1);
            this.pnlConfigs.Location = new System.Drawing.Point(0, 31);
            this.pnlConfigs.Name = "pnlConfigs";
            this.pnlConfigs.Size = new System.Drawing.Size(932, 396);
            this.pnlConfigs.TabIndex = 5;
            // 
            // btnSaveConfigs
            // 
            this.btnSaveConfigs.Location = new System.Drawing.Point(797, 346);
            this.btnSaveConfigs.Name = "btnSaveConfigs";
            this.btnSaveConfigs.Size = new System.Drawing.Size(117, 32);
            this.btnSaveConfigs.TabIndex = 1;
            this.btnSaveConfigs.Text = "Salvar";
            this.btnSaveConfigs.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPathConfig);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caminho";
            // 
            // txtPathConfig
            // 
            this.txtPathConfig.Location = new System.Drawing.Point(184, 45);
            this.txtPathConfig.Name = "txtPathConfig";
            this.txtPathConfig.Size = new System.Drawing.Size(677, 22);
            this.txtPathConfig.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "• Local das anotações:";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 468);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlAnotacoes);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlConfigs);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(950, 515);
            this.MinimumSize = new System.Drawing.Size(950, 515);
            this.Name = "FrmMenu";
            this.Text = "Gerenciador Totale";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.grpBoxCriacao.ResumeLayout(false);
            this.grpBoxCriacao.PerformLayout();
            this.pnlAnotacoes.ResumeLayout(false);
            this.pnlAnotacoes.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlConfigs.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anotaçõesToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlAnotacoes;
        private System.Windows.Forms.GroupBox grpBoxCriacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.Panel pnlConfigs;
        private System.Windows.Forms.Button btnSaveConfigs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPathConfig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbEscolhaNota;
        private System.Windows.Forms.Label lblEscolhaAnotacao;
        private System.Windows.Forms.CheckBox chkBoxModificar;
        private System.Windows.Forms.TextBox txtBoxAnotacao;
        private System.Windows.Forms.Button btnSalvarAnotacao;
        private System.Windows.Forms.Button btnNovaNota;
        private System.Windows.Forms.TextBox txtBoxTituloNota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCopiarNota;
        private System.Windows.Forms.Timer timer2;
    }
}

