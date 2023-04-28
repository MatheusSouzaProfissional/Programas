namespace Posot_de_Gasolina
{
    partial class Form1
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rbtGasolinaComum = new System.Windows.Forms.RadioButton();
            this.rbtEtanol = new System.Windows.Forms.RadioButton();
            this.rbtGasolinaAdtivada = new System.Windows.Forms.RadioButton();
            this.lblCombustivel = new System.Windows.Forms.Label();
            this.lblCombustivelEscolhido = new System.Windows.Forms.Label();
            this.lblValores = new System.Windows.Forms.Label();
            this.lblLitros = new System.Windows.Forms.Label();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEtanol = new System.Windows.Forms.Label();
            this.lblGasolinaAdtivada = new System.Windows.Forms.Label();
            this.lblGasolinaComum = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancelarCompra = new System.Windows.Forms.Button();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.lblTotalaPagar = new System.Windows.Forms.Label();
            this.lblValorTotalaPagar = new System.Windows.Forms.Label();
            this.lblTotalValorParcela = new System.Windows.Forms.Label();
            this.lblValorParcela = new System.Windows.Forms.Label();
            this.cboParcelamento = new System.Windows.Forms.ComboBox();
            this.cboMetododePagamento = new System.Windows.Forms.ComboBox();
            this.chkParcelamento = new System.Windows.Forms.CheckBox();
            this.lblMetododePagamento = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvNota = new System.Windows.Forms.DataGridView();
            this.colCombustivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLitros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMetododepagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parcelamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalAPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNota)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Red;
            this.lblTitulo.ImageKey = "(nenhum/a)";
            this.lblTitulo.Location = new System.Drawing.Point(96, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(289, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Posto de gasolina";
            // 
            // rbtGasolinaComum
            // 
            this.rbtGasolinaComum.AutoSize = true;
            this.rbtGasolinaComum.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtGasolinaComum.Location = new System.Drawing.Point(29, 15);
            this.rbtGasolinaComum.Name = "rbtGasolinaComum";
            this.rbtGasolinaComum.Size = new System.Drawing.Size(145, 22);
            this.rbtGasolinaComum.TabIndex = 1;
            this.rbtGasolinaComum.TabStop = true;
            this.rbtGasolinaComum.Text = "Gasolina Comum";
            this.rbtGasolinaComum.UseVisualStyleBackColor = true;
            this.rbtGasolinaComum.CheckedChanged += new System.EventHandler(this.rbtGasolinaComum_CheckedChanged);
            // 
            // rbtEtanol
            // 
            this.rbtEtanol.AutoSize = true;
            this.rbtEtanol.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtEtanol.Location = new System.Drawing.Point(367, 15);
            this.rbtEtanol.Name = "rbtEtanol";
            this.rbtEtanol.Size = new System.Drawing.Size(71, 22);
            this.rbtEtanol.TabIndex = 2;
            this.rbtEtanol.TabStop = true;
            this.rbtEtanol.Text = "Etanol";
            this.rbtEtanol.UseVisualStyleBackColor = true;
            this.rbtEtanol.CheckedChanged += new System.EventHandler(this.rbtEtanol_CheckedChanged);
            // 
            // rbtGasolinaAdtivada
            // 
            this.rbtGasolinaAdtivada.AutoSize = true;
            this.rbtGasolinaAdtivada.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtGasolinaAdtivada.Location = new System.Drawing.Point(194, 15);
            this.rbtGasolinaAdtivada.Name = "rbtGasolinaAdtivada";
            this.rbtGasolinaAdtivada.Size = new System.Drawing.Size(152, 22);
            this.rbtGasolinaAdtivada.TabIndex = 3;
            this.rbtGasolinaAdtivada.TabStop = true;
            this.rbtGasolinaAdtivada.Text = "Gasolina Adtivada";
            this.rbtGasolinaAdtivada.UseVisualStyleBackColor = true;
            this.rbtGasolinaAdtivada.CheckedChanged += new System.EventHandler(this.rbtGasolinaAdtivada_CheckedChanged);
            // 
            // lblCombustivel
            // 
            this.lblCombustivel.AutoSize = true;
            this.lblCombustivel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombustivel.Location = new System.Drawing.Point(6, 105);
            this.lblCombustivel.Name = "lblCombustivel";
            this.lblCombustivel.Size = new System.Drawing.Size(80, 15);
            this.lblCombustivel.TabIndex = 10;
            this.lblCombustivel.Text = "Combustível:";
            // 
            // lblCombustivelEscolhido
            // 
            this.lblCombustivelEscolhido.AutoSize = true;
            this.lblCombustivelEscolhido.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombustivelEscolhido.Location = new System.Drawing.Point(92, 105);
            this.lblCombustivelEscolhido.Name = "lblCombustivelEscolhido";
            this.lblCombustivelEscolhido.Size = new System.Drawing.Size(0, 15);
            this.lblCombustivelEscolhido.TabIndex = 11;
            // 
            // lblValores
            // 
            this.lblValores.AutoSize = true;
            this.lblValores.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValores.Location = new System.Drawing.Point(6, 47);
            this.lblValores.Name = "lblValores";
            this.lblValores.Size = new System.Drawing.Size(51, 15);
            this.lblValores.TabIndex = 12;
            this.lblValores.Text = "Valores:";
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLitros.Location = new System.Drawing.Point(333, 105);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(43, 15);
            this.lblLitros.TabIndex = 13;
            this.lblLitros.Text = "Litros:";
            // 
            // txtLitros
            // 
            this.txtLitros.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLitros.Location = new System.Drawing.Point(379, 103);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(59, 21);
            this.txtLitros.TabIndex = 14;
            this.txtLitros.TextChanged += new System.EventHandler(this.txtLitros_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEtanol);
            this.groupBox1.Controls.Add(this.lblGasolinaAdtivada);
            this.groupBox1.Controls.Add(this.lblGasolinaComum);
            this.groupBox1.Controls.Add(this.rbtGasolinaComum);
            this.groupBox1.Controls.Add(this.txtLitros);
            this.groupBox1.Controls.Add(this.rbtGasolinaAdtivada);
            this.groupBox1.Controls.Add(this.lblLitros);
            this.groupBox1.Controls.Add(this.rbtEtanol);
            this.groupBox1.Controls.Add(this.lblCombustivelEscolhido);
            this.groupBox1.Controls.Add(this.lblValores);
            this.groupBox1.Controls.Add(this.lblCombustivel);
            this.groupBox1.Location = new System.Drawing.Point(2, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 138);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // lblEtanol
            // 
            this.lblEtanol.AutoSize = true;
            this.lblEtanol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblEtanol.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtanol.Location = new System.Drawing.Point(366, 45);
            this.lblEtanol.Name = "lblEtanol";
            this.lblEtanol.Size = new System.Drawing.Size(79, 17);
            this.lblEtanol.TabIndex = 16;
            this.lblEtanol.Text = "R$ 4,29 / L";
            // 
            // lblGasolinaAdtivada
            // 
            this.lblGasolinaAdtivada.AutoSize = true;
            this.lblGasolinaAdtivada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblGasolinaAdtivada.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGasolinaAdtivada.Location = new System.Drawing.Point(227, 45);
            this.lblGasolinaAdtivada.Name = "lblGasolinaAdtivada";
            this.lblGasolinaAdtivada.Size = new System.Drawing.Size(79, 17);
            this.lblGasolinaAdtivada.TabIndex = 15;
            this.lblGasolinaAdtivada.Text = "R$ 6,29 / L";
            // 
            // lblGasolinaComum
            // 
            this.lblGasolinaComum.AutoSize = true;
            this.lblGasolinaComum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblGasolinaComum.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGasolinaComum.Location = new System.Drawing.Point(72, 45);
            this.lblGasolinaComum.Name = "lblGasolinaComum";
            this.lblGasolinaComum.Size = new System.Drawing.Size(79, 17);
            this.lblGasolinaComum.TabIndex = 9;
            this.lblGasolinaComum.Text = "R$ 4,79 / L";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpHora);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.lblTotalValorParcela);
            this.groupBox2.Controls.Add(this.lblValorParcela);
            this.groupBox2.Controls.Add(this.cboParcelamento);
            this.groupBox2.Controls.Add(this.cboMetododePagamento);
            this.groupBox2.Controls.Add(this.chkParcelamento);
            this.groupBox2.Controls.Add(this.lblMetododePagamento);
            this.groupBox2.Location = new System.Drawing.Point(2, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 231);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "                                                                   Pagamento";
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(379, 19);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(66, 20);
            this.dtpHora.TabIndex = 8;
            this.dtpHora.ValueChanged += new System.EventHandler(this.dtpHora_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCancelarCompra);
            this.groupBox3.Controls.Add(this.btnFinalizarCompra);
            this.groupBox3.Controls.Add(this.lblTotalaPagar);
            this.groupBox3.Controls.Add(this.lblValorTotalaPagar);
            this.groupBox3.Location = new System.Drawing.Point(6, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(452, 100);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // btnCancelarCompra
            // 
            this.btnCancelarCompra.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCompra.Location = new System.Drawing.Point(319, 56);
            this.btnCancelarCompra.Name = "btnCancelarCompra";
            this.btnCancelarCompra.Size = new System.Drawing.Size(113, 33);
            this.btnCancelarCompra.TabIndex = 7;
            this.btnCancelarCompra.Text = "Cancelar compra";
            this.btnCancelarCompra.UseVisualStyleBackColor = true;
            this.btnCancelarCompra.Click += new System.EventHandler(this.btnCancelarCompra_Click);
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarCompra.Location = new System.Drawing.Point(319, 17);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(113, 33);
            this.btnFinalizarCompra.TabIndex = 6;
            this.btnFinalizarCompra.Text = "Finalizar compra";
            this.btnFinalizarCompra.UseVisualStyleBackColor = true;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.btnFinalizarCompra_Click);
            // 
            // lblTotalaPagar
            // 
            this.lblTotalaPagar.AutoSize = true;
            this.lblTotalaPagar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalaPagar.Location = new System.Drawing.Point(41, 22);
            this.lblTotalaPagar.Name = "lblTotalaPagar";
            this.lblTotalaPagar.Size = new System.Drawing.Size(108, 19);
            this.lblTotalaPagar.TabIndex = 4;
            this.lblTotalaPagar.Text = "Total á Pagar";
            // 
            // lblValorTotalaPagar
            // 
            this.lblValorTotalaPagar.AutoSize = true;
            this.lblValorTotalaPagar.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotalaPagar.ForeColor = System.Drawing.Color.Red;
            this.lblValorTotalaPagar.Location = new System.Drawing.Point(63, 49);
            this.lblValorTotalaPagar.Name = "lblValorTotalaPagar";
            this.lblValorTotalaPagar.Size = new System.Drawing.Size(71, 33);
            this.lblValorTotalaPagar.TabIndex = 5;
            this.lblValorTotalaPagar.Text = "0,00";
            // 
            // lblTotalValorParcela
            // 
            this.lblTotalValorParcela.AutoSize = true;
            this.lblTotalValorParcela.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValorParcela.Location = new System.Drawing.Point(365, 83);
            this.lblTotalValorParcela.Name = "lblTotalValorParcela";
            this.lblTotalValorParcela.Size = new System.Drawing.Size(39, 18);
            this.lblTotalValorParcela.TabIndex = 7;
            this.lblTotalValorParcela.Text = "0,00";
            // 
            // lblValorParcela
            // 
            this.lblValorParcela.AutoSize = true;
            this.lblValorParcela.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorParcela.Location = new System.Drawing.Point(274, 84);
            this.lblValorParcela.Name = "lblValorParcela";
            this.lblValorParcela.Size = new System.Drawing.Size(85, 15);
            this.lblValorParcela.TabIndex = 6;
            this.lblValorParcela.Text = "Valor parcela:";
            // 
            // cboParcelamento
            // 
            this.cboParcelamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParcelamento.Enabled = false;
            this.cboParcelamento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboParcelamento.FormattingEnabled = true;
            this.cboParcelamento.Items.AddRange(new object[] {
            "",
            "",
            "2x",
            "3x",
            "4x",
            "5x",
            "6x"});
            this.cboParcelamento.Location = new System.Drawing.Point(152, 79);
            this.cboParcelamento.Name = "cboParcelamento";
            this.cboParcelamento.Size = new System.Drawing.Size(88, 23);
            this.cboParcelamento.TabIndex = 3;
            this.cboParcelamento.SelectedIndexChanged += new System.EventHandler(this.cboParcelamento_SelectedIndexChanged);
            // 
            // cboMetododePagamento
            // 
            this.cboMetododePagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMetododePagamento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMetododePagamento.FormattingEnabled = true;
            this.cboMetododePagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "Pix",
            "Débito",
            "Crédito"});
            this.cboMetododePagamento.Location = new System.Drawing.Point(152, 45);
            this.cboMetododePagamento.Name = "cboMetododePagamento";
            this.cboMetododePagamento.Size = new System.Drawing.Size(88, 23);
            this.cboMetododePagamento.TabIndex = 2;
            this.cboMetododePagamento.SelectedIndexChanged += new System.EventHandler(this.cboMetododePagamento_SelectedIndexChanged);
            // 
            // chkParcelamento
            // 
            this.chkParcelamento.AutoSize = true;
            this.chkParcelamento.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkParcelamento.Enabled = false;
            this.chkParcelamento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkParcelamento.Location = new System.Drawing.Point(37, 83);
            this.chkParcelamento.Name = "chkParcelamento";
            this.chkParcelamento.Size = new System.Drawing.Size(109, 19);
            this.chkParcelamento.TabIndex = 1;
            this.chkParcelamento.Text = "Parcelamento:";
            this.chkParcelamento.UseVisualStyleBackColor = true;
            this.chkParcelamento.CheckedChanged += new System.EventHandler(this.chkParcelamento_CheckedChanged);
            // 
            // lblMetododePagamento
            // 
            this.lblMetododePagamento.AutoSize = true;
            this.lblMetododePagamento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetododePagamento.Location = new System.Drawing.Point(10, 48);
            this.lblMetododePagamento.Name = "lblMetododePagamento";
            this.lblMetododePagamento.Size = new System.Drawing.Size(136, 15);
            this.lblMetododePagamento.TabIndex = 0;
            this.lblMetododePagamento.Text = "Método de pagamento:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvNota);
            this.groupBox4.Location = new System.Drawing.Point(2, 438);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(464, 177);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            // 
            // dgvNota
            // 
            this.dgvNota.AllowUserToAddRows = false;
            this.dgvNota.AllowUserToDeleteRows = false;
            this.dgvNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCombustivel,
            this.colValor,
            this.colLitros,
            this.colMetododepagamento,
            this.Parcelamento,
            this.colTotalAPagar,
            this.colHorario});
            this.dgvNota.Location = new System.Drawing.Point(6, 16);
            this.dgvNota.Name = "dgvNota";
            this.dgvNota.ReadOnly = true;
            this.dgvNota.Size = new System.Drawing.Size(449, 155);
            this.dgvNota.TabIndex = 0;
            // 
            // colCombustivel
            // 
            this.colCombustivel.HeaderText = "Combústivel";
            this.colCombustivel.Name = "colCombustivel";
            this.colCombustivel.ReadOnly = true;
            // 
            // colValor
            // 
            this.colValor.HeaderText = "Valor p/ Litro";
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            // 
            // colLitros
            // 
            this.colLitros.HeaderText = "Litros";
            this.colLitros.Name = "colLitros";
            this.colLitros.ReadOnly = true;
            // 
            // colMetododepagamento
            // 
            this.colMetododepagamento.HeaderText = "Pagamento";
            this.colMetododepagamento.Name = "colMetododepagamento";
            this.colMetododepagamento.ReadOnly = true;
            // 
            // Parcelamento
            // 
            this.Parcelamento.HeaderText = "Parcelamento";
            this.Parcelamento.Name = "Parcelamento";
            this.Parcelamento.ReadOnly = true;
            // 
            // colTotalAPagar
            // 
            this.colTotalAPagar.HeaderText = "Total á Pagar";
            this.colTotalAPagar.Name = "colTotalAPagar";
            this.colTotalAPagar.ReadOnly = true;
            // 
            // colHorario
            // 
            this.colHorario.HeaderText = "Horário";
            this.colHorario.Name = "colHorario";
            this.colHorario.ReadOnly = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(338, 618);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(102, 29);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 651);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rbtGasolinaComum;
        private System.Windows.Forms.RadioButton rbtEtanol;
        private System.Windows.Forms.RadioButton rbtGasolinaAdtivada;
        private System.Windows.Forms.Label lblCombustivel;
        private System.Windows.Forms.Label lblCombustivelEscolhido;
        private System.Windows.Forms.Label lblValores;
        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.TextBox txtLitros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMetododePagamento;
        private System.Windows.Forms.Label lblTotalaPagar;
        private System.Windows.Forms.ComboBox cboParcelamento;
        private System.Windows.Forms.ComboBox cboMetododePagamento;
        private System.Windows.Forms.CheckBox chkParcelamento;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancelarCompra;
        private System.Windows.Forms.Button btnFinalizarCompra;
        private System.Windows.Forms.Label lblValorTotalaPagar;
        private System.Windows.Forms.Label lblTotalValorParcela;
        private System.Windows.Forms.Label lblValorParcela;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.DataGridView dgvNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCombustivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLitros;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMetododepagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parcelamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalAPagar;
        private System.Windows.Forms.Label lblGasolinaComum;
        private System.Windows.Forms.Label lblEtanol;
        private System.Windows.Forms.Label lblGasolinaAdtivada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHorario;
        private System.Windows.Forms.Button btnExcluir;
    }
}

