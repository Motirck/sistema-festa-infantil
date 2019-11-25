namespace UIWindows
{
    partial class AluguelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AluguelForm));
            this.btnListar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbTema = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNumeroPessoas = new System.Windows.Forms.TextBox();
            this.txtValorAluguel = new System.Windows.Forms.TextBox();
            this.aluguelDataGridView = new System.Windows.Forms.DataGridView();
            this.lblcod = new System.Windows.Forms.Label();
            this.lblende = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mtxtData = new System.Windows.Forms.MaskedTextBox();
            this.mtxtHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.mtxtHoraFim = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.aluguelDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(373, 225);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 26;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(292, 225);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 25;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(211, 225);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 24;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Location = new System.Drawing.Point(130, 225);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 23;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(49, 225);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // cmbCliente
            // 
            this.cmbCliente.DisplayMember = "Nome";
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(440, 33);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(240, 21);
            this.cmbCliente.TabIndex = 27;
            this.cmbCliente.ValueMember = "Codigo";
            // 
            // cmbTema
            // 
            this.cmbTema.DisplayMember = "Nome";
            this.cmbTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTema.FormattingEnabled = true;
            this.cmbTema.Location = new System.Drawing.Point(440, 86);
            this.cmbTema.Name = "cmbTema";
            this.cmbTema.Size = new System.Drawing.Size(240, 21);
            this.cmbTema.TabIndex = 28;
            this.cmbTema.ValueMember = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(37, 33);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 29;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(211, 33);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(100, 20);
            this.txtEndereco.TabIndex = 32;
            // 
            // txtNumeroPessoas
            // 
            this.txtNumeroPessoas.Location = new System.Drawing.Point(211, 86);
            this.txtNumeroPessoas.Name = "txtNumeroPessoas";
            this.txtNumeroPessoas.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroPessoas.TabIndex = 33;
            // 
            // txtValorAluguel
            // 
            this.txtValorAluguel.Location = new System.Drawing.Point(440, 138);
            this.txtValorAluguel.Name = "txtValorAluguel";
            this.txtValorAluguel.Size = new System.Drawing.Size(100, 20);
            this.txtValorAluguel.TabIndex = 35;
            // 
            // aluguelDataGridView
            // 
            this.aluguelDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aluguelDataGridView.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.aluguelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aluguelDataGridView.Location = new System.Drawing.Point(37, 254);
            this.aluguelDataGridView.Name = "aluguelDataGridView";
            this.aluguelDataGridView.ReadOnly = true;
            this.aluguelDataGridView.Size = new System.Drawing.Size(1037, 150);
            this.aluguelDataGridView.TabIndex = 36;
            this.aluguelDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.aluguelDataGridView_CellClick);
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.BackColor = System.Drawing.Color.Transparent;
            this.lblcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcod.Location = new System.Drawing.Point(34, 17);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(46, 13);
            this.lblcod.TabIndex = 37;
            this.lblcod.Text = "Codigo";
            // 
            // lblende
            // 
            this.lblende.AutoSize = true;
            this.lblende.BackColor = System.Drawing.Color.Transparent;
            this.lblende.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblende.Location = new System.Drawing.Point(208, 17);
            this.lblende.Name = "lblende";
            this.lblende.Size = new System.Drawing.Size(61, 13);
            this.lblende.TabIndex = 38;
            this.lblende.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Hora Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(208, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Hora Fim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(437, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Valor Do Aluguel";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.BackColor = System.Drawing.Color.Transparent;
            this.lbldata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.Location = new System.Drawing.Point(34, 70);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(65, 13);
            this.lbldata.TabIndex = 42;
            this.lbldata.Text = "DataFesta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(208, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Numero de Pessoas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(437, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Cliente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(437, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Tema";
            // 
            // mtxtData
            // 
            this.mtxtData.Location = new System.Drawing.Point(37, 87);
            this.mtxtData.Mask = "00/00/0000";
            this.mtxtData.Name = "mtxtData";
            this.mtxtData.Size = new System.Drawing.Size(100, 20);
            this.mtxtData.TabIndex = 46;
            this.mtxtData.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtHoraInicio
            // 
            this.mtxtHoraInicio.Location = new System.Drawing.Point(37, 138);
            this.mtxtHoraInicio.Mask = "00:00";
            this.mtxtHoraInicio.Name = "mtxtHoraInicio";
            this.mtxtHoraInicio.Size = new System.Drawing.Size(100, 20);
            this.mtxtHoraInicio.TabIndex = 47;
            this.mtxtHoraInicio.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtHoraFim
            // 
            this.mtxtHoraFim.Location = new System.Drawing.Point(210, 138);
            this.mtxtHoraFim.Mask = "00:00";
            this.mtxtHoraFim.Name = "mtxtHoraFim";
            this.mtxtHoraFim.Size = new System.Drawing.Size(100, 20);
            this.mtxtHoraFim.TabIndex = 48;
            this.mtxtHoraFim.ValidatingType = typeof(System.DateTime);
            // 
            // AluguelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UIWindows.Properties.Resources.aaaajjjjjjjj;
            this.ClientSize = new System.Drawing.Size(1086, 450);
            this.Controls.Add(this.mtxtHoraFim);
            this.Controls.Add(this.mtxtHoraInicio);
            this.Controls.Add(this.mtxtData);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblende);
            this.Controls.Add(this.lblcod);
            this.Controls.Add(this.aluguelDataGridView);
            this.Controls.Add(this.txtValorAluguel);
            this.Controls.Add(this.txtNumeroPessoas);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.cmbTema);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnLimpar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AluguelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AluguelForm";
            this.Load += new System.EventHandler(this.AluguelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aluguelDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbTema;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNumeroPessoas;
        private System.Windows.Forms.TextBox txtValorAluguel;
        private System.Windows.Forms.DataGridView aluguelDataGridView;
        private System.Windows.Forms.Label lblcod;
        private System.Windows.Forms.Label lblende;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mtxtData;
        private System.Windows.Forms.MaskedTextBox mtxtHoraInicio;
        private System.Windows.Forms.MaskedTextBox mtxtHoraFim;
    }
}