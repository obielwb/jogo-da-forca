// Gabriel Willian Bartmanovicz - 21234
// João Pero Ferreira Barbosa - 21687


namespace apJogoDaForca
{
    partial class FrmJogoDaForca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJogoDaForca));
            this.imlBotoes = new System.Windows.Forms.ImageList(this.components);
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.sp = new System.IO.Ports.SerialPort(this.components);
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.tsBotoes = new System.Windows.Forms.ToolStrip();
            this.btnInicio = new System.Windows.Forms.ToolStripButton();
            this.btnAnterior = new System.Windows.Forms.ToolStripButton();
            this.btnProximo = new System.Windows.Forms.ToolStripButton();
            this.btnUltimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnProcurar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.txtDica = new System.Windows.Forms.TextBox();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.dgvPalavrasEDicas = new System.Windows.Forms.DataGridView();
            this.colPalavra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbDicaCadastro = new System.Windows.Forms.Label();
            this.lbPalavraCadastro = new System.Windows.Forms.Label();
            this.tabForca = new System.Windows.Forms.TabPage();
            this.picEspirito = new System.Windows.Forms.PictureBox();
            this.panelTeclado = new System.Windows.Forms.Panel();
            this.btnLetraA = new System.Windows.Forms.Button();
            this.btnLetraAComTio = new System.Windows.Forms.Button();
            this.btnLetraAComAcentoCircunflexo = new System.Windows.Forms.Button();
            this.btnLetraAComAcentoAgudo = new System.Windows.Forms.Button();
            this.btnLetraEComAcentoAgudo = new System.Windows.Forms.Button();
            this.btnLetraÇ = new System.Windows.Forms.Button();
            this.btnLetraEComAcentoCircuflexo = new System.Windows.Forms.Button();
            this.btnLetraIComAcentoAgudo = new System.Windows.Forms.Button();
            this.btnLetraOComAcentoAgudo = new System.Windows.Forms.Button();
            this.btnLetraOComAcentoCircunflexo = new System.Windows.Forms.Button();
            this.btnLetraOComTio = new System.Windows.Forms.Button();
            this.btnLetraUComAcentoAgudo = new System.Windows.Forms.Button();
            this.btnHifen = new System.Windows.Forms.Button();
            this.btnEspaco = new System.Windows.Forms.Button();
            this.btnLetraL = new System.Windows.Forms.Button();
            this.btnLetraK = new System.Windows.Forms.Button();
            this.btnLetraJ = new System.Windows.Forms.Button();
            this.btnLetraZ = new System.Windows.Forms.Button();
            this.btnLetraI = new System.Windows.Forms.Button();
            this.btnLetraN = new System.Windows.Forms.Button();
            this.btnLetraM = new System.Windows.Forms.Button();
            this.btnLetraO = new System.Windows.Forms.Button();
            this.btnLetraH = new System.Windows.Forms.Button();
            this.btnLetraP = new System.Windows.Forms.Button();
            this.btnLetraG = new System.Windows.Forms.Button();
            this.btnLetraQ = new System.Windows.Forms.Button();
            this.btnLetraF = new System.Windows.Forms.Button();
            this.btnLetraR = new System.Windows.Forms.Button();
            this.btnLetraE = new System.Windows.Forms.Button();
            this.btnLetraS = new System.Windows.Forms.Button();
            this.btnLetraD = new System.Windows.Forms.Button();
            this.btnLetraX = new System.Windows.Forms.Button();
            this.btnLetraC = new System.Windows.Forms.Button();
            this.btnLetraT = new System.Windows.Forms.Button();
            this.btnLetraB = new System.Windows.Forms.Button();
            this.btnLetraU = new System.Windows.Forms.Button();
            this.btnLetraY = new System.Windows.Forms.Button();
            this.btnLetraV = new System.Windows.Forms.Button();
            this.btnLetraW = new System.Windows.Forms.Button();
            this.picBandeiraUm = new System.Windows.Forms.PictureBox();
            this.picBandeiraDois = new System.Windows.Forms.PictureBox();
            this.picEnforcadoMorto = new System.Windows.Forms.PictureBox();
            this.picEnforcadoOito = new System.Windows.Forms.PictureBox();
            this.picEnforcadoSete = new System.Windows.Forms.PictureBox();
            this.picEnforcadoSeis = new System.Windows.Forms.PictureBox();
            this.picEnforcadoQuatro = new System.Windows.Forms.PictureBox();
            this.picEnforcadoCinco = new System.Windows.Forms.PictureBox();
            this.picEnforcadoTres = new System.Windows.Forms.PictureBox();
            this.picEnforcadoDois = new System.Windows.Forms.PictureBox();
            this.picEnforcadoUm = new System.Windows.Forms.PictureBox();
            this.lbForca = new System.Windows.Forms.Label();
            this.lbAdivinhe = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.dgvPalavra = new System.Windows.Forms.DataGridView();
            this.lbTempo = new System.Windows.Forms.Label();
            this.lbErros = new System.Windows.Forms.Label();
            this.lbPontos = new System.Windows.Forms.Label();
            this.lbDica = new System.Windows.Forms.Label();
            this.chkComDica = new System.Windows.Forms.CheckBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.picForcaSete = new System.Windows.Forms.PictureBox();
            this.picForcaSeis = new System.Windows.Forms.PictureBox();
            this.picForcaCinco = new System.Windows.Forms.PictureBox();
            this.picForcaQuatro = new System.Windows.Forms.PictureBox();
            this.picForcaTres = new System.Windows.Forms.PictureBox();
            this.picForcaDois = new System.Windows.Forms.PictureBox();
            this.picForcaUm = new System.Windows.Forms.PictureBox();
            this.lbPortaSerial = new System.Windows.Forms.Label();
            this.btnConectarArduino = new System.Windows.Forms.Button();
            this.txtPortaSerial = new System.Windows.Forms.TextBox();
            this.chkComArduino = new System.Windows.Forms.CheckBox();
            this.picVivo = new System.Windows.Forms.PictureBox();
            this.tabJogoDaForca = new System.Windows.Forms.TabControl();
            this.ssMensagem = new System.Windows.Forms.StatusStrip();
            this.lbMensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.stlbMensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrStatusStrip = new System.Windows.Forms.Timer(this.components);
            this.tmrForca = new System.Windows.Forms.Timer(this.components);
            this.tmrEspirito = new System.Windows.Forms.Timer(this.components);
            this.tabCadastro.SuspendLayout();
            this.tsBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalavrasEDicas)).BeginInit();
            this.tabForca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEspirito)).BeginInit();
            this.panelTeclado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBandeiraUm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBandeiraDois)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnforcadoMorto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnforcadoOito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnforcadoSete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnforcadoSeis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnforcadoQuatro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnforcadoCinco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnforcadoTres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnforcadoDois)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnforcadoUm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalavra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForcaSete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForcaSeis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForcaCinco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForcaQuatro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForcaTres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForcaDois)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForcaUm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVivo)).BeginInit();
            this.tabJogoDaForca.SuspendLayout();
            this.ssMensagem.SuspendLayout();
            this.SuspendLayout();
            // 
            // imlBotoes
            // 
            this.imlBotoes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlBotoes.ImageStream")));
            this.imlBotoes.TransparentColor = System.Drawing.Color.Transparent;
            this.imlBotoes.Images.SetKeyName(0, "inicio.bmp");
            this.imlBotoes.Images.SetKeyName(1, "anterior.bmp");
            this.imlBotoes.Images.SetKeyName(2, "proximo.bmp");
            this.imlBotoes.Images.SetKeyName(3, "ultimo.bmp");
            this.imlBotoes.Images.SetKeyName(4, "buscar.bmp");
            this.imlBotoes.Images.SetKeyName(5, "novo.bmp");
            this.imlBotoes.Images.SetKeyName(6, "editar.BMP");
            this.imlBotoes.Images.SetKeyName(7, "cancelar.BMP");
            this.imlBotoes.Images.SetKeyName(8, "salvar.bmp");
            this.imlBotoes.Images.SetKeyName(9, "excluir.bmp");
            this.imlBotoes.Images.SetKeyName(10, "sair.BMP");
            // 
            // dlgAbrir
            // 
            this.dlgAbrir.DefaultExt = "*.txt";
            // 
            // sp
            // 
            this.sp.PortName = "COM";
            // 
            // tabCadastro
            // 
            this.tabCadastro.BackColor = System.Drawing.Color.Bisque;
            this.tabCadastro.Controls.Add(this.tsBotoes);
            this.tabCadastro.Controls.Add(this.txtDica);
            this.tabCadastro.Controls.Add(this.txtPalavra);
            this.tabCadastro.Controls.Add(this.dgvPalavrasEDicas);
            this.tabCadastro.Controls.Add(this.lbDicaCadastro);
            this.tabCadastro.Controls.Add(this.lbPalavraCadastro);
            this.tabCadastro.Location = new System.Drawing.Point(4, 29);
            this.tabCadastro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabCadastro.Size = new System.Drawing.Size(909, 559);
            this.tabCadastro.TabIndex = 1;
            this.tabCadastro.Text = "Cadastro";
            this.tabCadastro.Enter += new System.EventHandler(this.tabCadastro_Enter);
            // 
            // tsBotoes
            // 
            this.tsBotoes.BackColor = System.Drawing.Color.Silver;
            this.tsBotoes.Font = new System.Drawing.Font("Arial", 9F);
            this.tsBotoes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsBotoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInicio,
            this.btnAnterior,
            this.btnProximo,
            this.btnUltimo,
            this.toolStripSeparator1,
            this.btnProcurar,
            this.toolStripSeparator2,
            this.btnNovo,
            this.btnEditar,
            this.btnCancelar,
            this.btnSalvar,
            this.toolStripSeparator3,
            this.btnExcluir,
            this.toolStripSeparator4,
            this.btnSair});
            this.tsBotoes.Location = new System.Drawing.Point(4, 5);
            this.tsBotoes.Name = "tsBotoes";
            this.tsBotoes.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tsBotoes.Size = new System.Drawing.Size(901, 42);
            this.tsBotoes.TabIndex = 12;
            this.tsBotoes.Text = "Ultimo";
            // 
            // btnInicio
            // 
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(40, 39);
            this.btnInicio.Text = "Início";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInicio.ToolTipText = "Vai à primeira palavra";
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(53, 39);
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAnterior.ToolTipText = "Vai à palavra anterior";
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Image = ((System.Drawing.Image)(resources.GetObject("btnProximo.Image")));
            this.btnProximo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(56, 39);
            this.btnProximo.Text = "Próximo";
            this.btnProximo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProximo.ToolTipText = "Vai à próxima palavra";
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnUltimo.Image")));
            this.btnUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(47, 39);
            this.btnUltimo.Text = "Último";
            this.btnUltimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUltimo.ToolTipText = "Vai à última palavra";
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Image = ((System.Drawing.Image)(resources.GetObject("btnProcurar.Image")));
            this.btnProcurar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(50, 39);
            this.btnProcurar.Text = "Buscar";
            this.btnProcurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProcurar.ToolTipText = "Busca pela palavra atual";
            this.btnProcurar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(39, 39);
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovo.ToolTipText = "Inicia inclusão de nova palavra";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(43, 39);
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.ToolTipText = "Altera palavra atual";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(61, 39);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.ToolTipText = "Cancela a operação atual";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(45, 39);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.ToolTipText = "Salva as alterações feitas";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 42);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(47, 39);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.ToolTipText = "Exclui a palavra atual";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 42);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(33, 39);
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.ToolTipText = "Fecha o programa";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtDica
            // 
            this.txtDica.Location = new System.Drawing.Point(135, 151);
            this.txtDica.MaxLength = 100;
            this.txtDica.Name = "txtDica";
            this.txtDica.ReadOnly = true;
            this.txtDica.Size = new System.Drawing.Size(463, 29);
            this.txtDica.TabIndex = 11;
            // 
            // txtPalavra
            // 
            this.txtPalavra.Location = new System.Drawing.Point(135, 84);
            this.txtPalavra.MaxLength = 30;
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.ReadOnly = true;
            this.txtPalavra.Size = new System.Drawing.Size(188, 29);
            this.txtPalavra.TabIndex = 10;
            this.txtPalavra.Leave += new System.EventHandler(this.txtPalavra_Leave);
            // 
            // dgvPalavrasEDicas
            // 
            this.dgvPalavrasEDicas.AllowUserToOrderColumns = true;
            this.dgvPalavrasEDicas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPalavrasEDicas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPalavrasEDicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalavrasEDicas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPalavra,
            this.colDica});
            this.dgvPalavrasEDicas.Location = new System.Drawing.Point(7, 207);
            this.dgvPalavrasEDicas.Name = "dgvPalavrasEDicas";
            this.dgvPalavrasEDicas.RowHeadersWidth = 51;
            this.dgvPalavrasEDicas.RowTemplate.Height = 24;
            this.dgvPalavrasEDicas.Size = new System.Drawing.Size(894, 344);
            this.dgvPalavrasEDicas.TabIndex = 1;
            // 
            // colPalavra
            // 
            this.colPalavra.HeaderText = "Palavra";
            this.colPalavra.MinimumWidth = 200;
            this.colPalavra.Name = "colPalavra";
            this.colPalavra.Width = 200;
            // 
            // colDica
            // 
            this.colDica.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDica.HeaderText = "Dica";
            this.colDica.Name = "colDica";
            // 
            // lbDicaCadastro
            // 
            this.lbDicaCadastro.AutoSize = true;
            this.lbDicaCadastro.Font = new System.Drawing.Font("Microsoft JhengHei", 14F);
            this.lbDicaCadastro.Location = new System.Drawing.Point(52, 151);
            this.lbDicaCadastro.Name = "lbDicaCadastro";
            this.lbDicaCadastro.Size = new System.Drawing.Size(52, 24);
            this.lbDicaCadastro.TabIndex = 8;
            this.lbDicaCadastro.Text = "Dica:";
            // 
            // lbPalavraCadastro
            // 
            this.lbPalavraCadastro.AutoSize = true;
            this.lbPalavraCadastro.Font = new System.Drawing.Font("Microsoft JhengHei", 14F);
            this.lbPalavraCadastro.Location = new System.Drawing.Point(52, 84);
            this.lbPalavraCadastro.Name = "lbPalavraCadastro";
            this.lbPalavraCadastro.Size = new System.Drawing.Size(77, 24);
            this.lbPalavraCadastro.TabIndex = 6;
            this.lbPalavraCadastro.Text = "Palavra:";
            // 
            // tabForca
            // 
            this.tabForca.Controls.Add(this.picEspirito);
            this.tabForca.Controls.Add(this.panelTeclado);
            this.tabForca.Controls.Add(this.picBandeiraUm);
            this.tabForca.Controls.Add(this.picBandeiraDois);
            this.tabForca.Controls.Add(this.picEnforcadoMorto);
            this.tabForca.Controls.Add(this.picEnforcadoOito);
            this.tabForca.Controls.Add(this.picEnforcadoSete);
            this.tabForca.Controls.Add(this.picEnforcadoSeis);
            this.tabForca.Controls.Add(this.picEnforcadoQuatro);
            this.tabForca.Controls.Add(this.picEnforcadoCinco);
            this.tabForca.Controls.Add(this.picEnforcadoTres);
            this.tabForca.Controls.Add(this.picEnforcadoDois);
            this.tabForca.Controls.Add(this.picEnforcadoUm);
            this.tabForca.Controls.Add(this.lbForca);
            this.tabForca.Controls.Add(this.lbAdivinhe);
            this.tabForca.Controls.Add(this.txtNome);
            this.tabForca.Controls.Add(this.lbNome);
            this.tabForca.Controls.Add(this.dgvPalavra);
            this.tabForca.Controls.Add(this.lbTempo);
            this.tabForca.Controls.Add(this.lbErros);
            this.tabForca.Controls.Add(this.lbPontos);
            this.tabForca.Controls.Add(this.lbDica);
            this.tabForca.Controls.Add(this.chkComDica);
            this.tabForca.Controls.Add(this.btnIniciar);
            this.tabForca.Controls.Add(this.picForcaSete);
            this.tabForca.Controls.Add(this.picForcaSeis);
            this.tabForca.Controls.Add(this.picForcaCinco);
            this.tabForca.Controls.Add(this.picForcaQuatro);
            this.tabForca.Controls.Add(this.picForcaTres);
            this.tabForca.Controls.Add(this.picForcaDois);
            this.tabForca.Controls.Add(this.picForcaUm);
            this.tabForca.Controls.Add(this.lbPortaSerial);
            this.tabForca.Controls.Add(this.btnConectarArduino);
            this.tabForca.Controls.Add(this.txtPortaSerial);
            this.tabForca.Controls.Add(this.chkComArduino);
            this.tabForca.Controls.Add(this.picVivo);
            this.tabForca.Location = new System.Drawing.Point(4, 29);
            this.tabForca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabForca.Name = "tabForca";
            this.tabForca.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabForca.Size = new System.Drawing.Size(909, 559);
            this.tabForca.TabIndex = 0;
            this.tabForca.Text = "Forca";
            this.tabForca.UseVisualStyleBackColor = true;
            // 
            // picEspirito
            // 
            this.picEspirito.Image = ((System.Drawing.Image)(resources.GetObject("picEspirito.Image")));
            this.picEspirito.Location = new System.Drawing.Point(91, 122);
            this.picEspirito.Name = "picEspirito";
            this.picEspirito.Size = new System.Drawing.Size(169, 337);
            this.picEspirito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picEspirito.TabIndex = 119;
            this.picEspirito.TabStop = false;
            // 
            // panelTeclado
            // 
            this.panelTeclado.Controls.Add(this.btnLetraA);
            this.panelTeclado.Controls.Add(this.btnLetraAComTio);
            this.panelTeclado.Controls.Add(this.btnLetraAComAcentoCircunflexo);
            this.panelTeclado.Controls.Add(this.btnLetraAComAcentoAgudo);
            this.panelTeclado.Controls.Add(this.btnLetraEComAcentoAgudo);
            this.panelTeclado.Controls.Add(this.btnLetraÇ);
            this.panelTeclado.Controls.Add(this.btnLetraEComAcentoCircuflexo);
            this.panelTeclado.Controls.Add(this.btnLetraIComAcentoAgudo);
            this.panelTeclado.Controls.Add(this.btnLetraOComAcentoAgudo);
            this.panelTeclado.Controls.Add(this.btnLetraOComAcentoCircunflexo);
            this.panelTeclado.Controls.Add(this.btnLetraOComTio);
            this.panelTeclado.Controls.Add(this.btnLetraUComAcentoAgudo);
            this.panelTeclado.Controls.Add(this.btnHifen);
            this.panelTeclado.Controls.Add(this.btnEspaco);
            this.panelTeclado.Controls.Add(this.btnLetraL);
            this.panelTeclado.Controls.Add(this.btnLetraK);
            this.panelTeclado.Controls.Add(this.btnLetraJ);
            this.panelTeclado.Controls.Add(this.btnLetraZ);
            this.panelTeclado.Controls.Add(this.btnLetraI);
            this.panelTeclado.Controls.Add(this.btnLetraN);
            this.panelTeclado.Controls.Add(this.btnLetraM);
            this.panelTeclado.Controls.Add(this.btnLetraO);
            this.panelTeclado.Controls.Add(this.btnLetraH);
            this.panelTeclado.Controls.Add(this.btnLetraP);
            this.panelTeclado.Controls.Add(this.btnLetraG);
            this.panelTeclado.Controls.Add(this.btnLetraQ);
            this.panelTeclado.Controls.Add(this.btnLetraF);
            this.panelTeclado.Controls.Add(this.btnLetraR);
            this.panelTeclado.Controls.Add(this.btnLetraE);
            this.panelTeclado.Controls.Add(this.btnLetraS);
            this.panelTeclado.Controls.Add(this.btnLetraD);
            this.panelTeclado.Controls.Add(this.btnLetraX);
            this.panelTeclado.Controls.Add(this.btnLetraC);
            this.panelTeclado.Controls.Add(this.btnLetraT);
            this.panelTeclado.Controls.Add(this.btnLetraB);
            this.panelTeclado.Controls.Add(this.btnLetraU);
            this.panelTeclado.Controls.Add(this.btnLetraY);
            this.panelTeclado.Controls.Add(this.btnLetraV);
            this.panelTeclado.Controls.Add(this.btnLetraW);
            this.panelTeclado.Location = new System.Drawing.Point(455, 214);
            this.panelTeclado.Name = "panelTeclado";
            this.panelTeclado.Size = new System.Drawing.Size(354, 103);
            this.panelTeclado.TabIndex = 126;
            // 
            // btnLetraA
            // 
            this.btnLetraA.BackColor = System.Drawing.Color.White;
            this.btnLetraA.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraA.FlatAppearance.BorderSize = 10;
            this.btnLetraA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraA.Location = new System.Drawing.Point(0, 0);
            this.btnLetraA.Name = "btnLetraA";
            this.btnLetraA.Size = new System.Drawing.Size(29, 30);
            this.btnLetraA.TabIndex = 53;
            this.btnLetraA.Text = "A";
            this.btnLetraA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraA.UseVisualStyleBackColor = false;
            this.btnLetraA.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraAComTio
            // 
            this.btnLetraAComTio.BackColor = System.Drawing.Color.White;
            this.btnLetraAComTio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraAComTio.FlatAppearance.BorderSize = 10;
            this.btnLetraAComTio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraAComTio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraAComTio.Location = new System.Drawing.Point(81, 72);
            this.btnLetraAComTio.Name = "btnLetraAComTio";
            this.btnLetraAComTio.Size = new System.Drawing.Size(30, 30);
            this.btnLetraAComTio.TabIndex = 80;
            this.btnLetraAComTio.Text = "Ã";
            this.btnLetraAComTio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraAComTio.UseVisualStyleBackColor = false;
            this.btnLetraAComTio.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraAComAcentoCircunflexo
            // 
            this.btnLetraAComAcentoCircunflexo.BackColor = System.Drawing.Color.White;
            this.btnLetraAComAcentoCircunflexo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraAComAcentoCircunflexo.FlatAppearance.BorderSize = 10;
            this.btnLetraAComAcentoCircunflexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraAComAcentoCircunflexo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraAComAcentoCircunflexo.Location = new System.Drawing.Point(54, 72);
            this.btnLetraAComAcentoCircunflexo.Name = "btnLetraAComAcentoCircunflexo";
            this.btnLetraAComAcentoCircunflexo.Size = new System.Drawing.Size(30, 30);
            this.btnLetraAComAcentoCircunflexo.TabIndex = 81;
            this.btnLetraAComAcentoCircunflexo.Text = "Â";
            this.btnLetraAComAcentoCircunflexo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraAComAcentoCircunflexo.UseVisualStyleBackColor = false;
            this.btnLetraAComAcentoCircunflexo.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraAComAcentoAgudo
            // 
            this.btnLetraAComAcentoAgudo.BackColor = System.Drawing.Color.White;
            this.btnLetraAComAcentoAgudo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraAComAcentoAgudo.FlatAppearance.BorderSize = 10;
            this.btnLetraAComAcentoAgudo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraAComAcentoAgudo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraAComAcentoAgudo.Location = new System.Drawing.Point(27, 72);
            this.btnLetraAComAcentoAgudo.Name = "btnLetraAComAcentoAgudo";
            this.btnLetraAComAcentoAgudo.Size = new System.Drawing.Size(30, 30);
            this.btnLetraAComAcentoAgudo.TabIndex = 79;
            this.btnLetraAComAcentoAgudo.Text = "Á";
            this.btnLetraAComAcentoAgudo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraAComAcentoAgudo.UseVisualStyleBackColor = false;
            this.btnLetraAComAcentoAgudo.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraEComAcentoAgudo
            // 
            this.btnLetraEComAcentoAgudo.BackColor = System.Drawing.Color.White;
            this.btnLetraEComAcentoAgudo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraEComAcentoAgudo.FlatAppearance.BorderSize = 10;
            this.btnLetraEComAcentoAgudo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraEComAcentoAgudo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraEComAcentoAgudo.Location = new System.Drawing.Point(109, 72);
            this.btnLetraEComAcentoAgudo.Name = "btnLetraEComAcentoAgudo";
            this.btnLetraEComAcentoAgudo.Size = new System.Drawing.Size(30, 30);
            this.btnLetraEComAcentoAgudo.TabIndex = 82;
            this.btnLetraEComAcentoAgudo.Text = "É";
            this.btnLetraEComAcentoAgudo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraEComAcentoAgudo.UseVisualStyleBackColor = false;
            this.btnLetraEComAcentoAgudo.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraÇ
            // 
            this.btnLetraÇ.BackColor = System.Drawing.Color.White;
            this.btnLetraÇ.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraÇ.FlatAppearance.BorderSize = 10;
            this.btnLetraÇ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraÇ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraÇ.Location = new System.Drawing.Point(0, 72);
            this.btnLetraÇ.Name = "btnLetraÇ";
            this.btnLetraÇ.Size = new System.Drawing.Size(30, 30);
            this.btnLetraÇ.TabIndex = 78;
            this.btnLetraÇ.Text = "Ç";
            this.btnLetraÇ.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraÇ.UseVisualStyleBackColor = false;
            this.btnLetraÇ.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraEComAcentoCircuflexo
            // 
            this.btnLetraEComAcentoCircuflexo.BackColor = System.Drawing.Color.White;
            this.btnLetraEComAcentoCircuflexo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraEComAcentoCircuflexo.FlatAppearance.BorderSize = 10;
            this.btnLetraEComAcentoCircuflexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraEComAcentoCircuflexo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraEComAcentoCircuflexo.Location = new System.Drawing.Point(136, 72);
            this.btnLetraEComAcentoCircuflexo.Name = "btnLetraEComAcentoCircuflexo";
            this.btnLetraEComAcentoCircuflexo.Size = new System.Drawing.Size(30, 30);
            this.btnLetraEComAcentoCircuflexo.TabIndex = 83;
            this.btnLetraEComAcentoCircuflexo.Text = "Ê";
            this.btnLetraEComAcentoCircuflexo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraEComAcentoCircuflexo.UseVisualStyleBackColor = false;
            this.btnLetraEComAcentoCircuflexo.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraIComAcentoAgudo
            // 
            this.btnLetraIComAcentoAgudo.BackColor = System.Drawing.Color.White;
            this.btnLetraIComAcentoAgudo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraIComAcentoAgudo.FlatAppearance.BorderSize = 10;
            this.btnLetraIComAcentoAgudo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraIComAcentoAgudo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraIComAcentoAgudo.Location = new System.Drawing.Point(163, 72);
            this.btnLetraIComAcentoAgudo.Name = "btnLetraIComAcentoAgudo";
            this.btnLetraIComAcentoAgudo.Size = new System.Drawing.Size(30, 30);
            this.btnLetraIComAcentoAgudo.TabIndex = 84;
            this.btnLetraIComAcentoAgudo.Text = "Í";
            this.btnLetraIComAcentoAgudo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraIComAcentoAgudo.UseVisualStyleBackColor = false;
            this.btnLetraIComAcentoAgudo.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraOComAcentoAgudo
            // 
            this.btnLetraOComAcentoAgudo.BackColor = System.Drawing.Color.White;
            this.btnLetraOComAcentoAgudo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraOComAcentoAgudo.FlatAppearance.BorderSize = 10;
            this.btnLetraOComAcentoAgudo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraOComAcentoAgudo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraOComAcentoAgudo.Location = new System.Drawing.Point(190, 72);
            this.btnLetraOComAcentoAgudo.Name = "btnLetraOComAcentoAgudo";
            this.btnLetraOComAcentoAgudo.Size = new System.Drawing.Size(30, 30);
            this.btnLetraOComAcentoAgudo.TabIndex = 85;
            this.btnLetraOComAcentoAgudo.Text = "Ó";
            this.btnLetraOComAcentoAgudo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraOComAcentoAgudo.UseVisualStyleBackColor = false;
            this.btnLetraOComAcentoAgudo.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraOComAcentoCircunflexo
            // 
            this.btnLetraOComAcentoCircunflexo.BackColor = System.Drawing.Color.White;
            this.btnLetraOComAcentoCircunflexo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraOComAcentoCircunflexo.FlatAppearance.BorderSize = 10;
            this.btnLetraOComAcentoCircunflexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraOComAcentoCircunflexo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraOComAcentoCircunflexo.Location = new System.Drawing.Point(217, 72);
            this.btnLetraOComAcentoCircunflexo.Name = "btnLetraOComAcentoCircunflexo";
            this.btnLetraOComAcentoCircunflexo.Size = new System.Drawing.Size(30, 30);
            this.btnLetraOComAcentoCircunflexo.TabIndex = 86;
            this.btnLetraOComAcentoCircunflexo.Text = "Ô";
            this.btnLetraOComAcentoCircunflexo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraOComAcentoCircunflexo.UseVisualStyleBackColor = false;
            this.btnLetraOComAcentoCircunflexo.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraOComTio
            // 
            this.btnLetraOComTio.BackColor = System.Drawing.Color.White;
            this.btnLetraOComTio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraOComTio.FlatAppearance.BorderSize = 10;
            this.btnLetraOComTio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraOComTio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraOComTio.Location = new System.Drawing.Point(244, 72);
            this.btnLetraOComTio.Name = "btnLetraOComTio";
            this.btnLetraOComTio.Size = new System.Drawing.Size(30, 30);
            this.btnLetraOComTio.TabIndex = 87;
            this.btnLetraOComTio.Text = "Õ";
            this.btnLetraOComTio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraOComTio.UseVisualStyleBackColor = false;
            this.btnLetraOComTio.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraUComAcentoAgudo
            // 
            this.btnLetraUComAcentoAgudo.BackColor = System.Drawing.Color.White;
            this.btnLetraUComAcentoAgudo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraUComAcentoAgudo.FlatAppearance.BorderSize = 10;
            this.btnLetraUComAcentoAgudo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraUComAcentoAgudo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraUComAcentoAgudo.Location = new System.Drawing.Point(271, 72);
            this.btnLetraUComAcentoAgudo.Name = "btnLetraUComAcentoAgudo";
            this.btnLetraUComAcentoAgudo.Size = new System.Drawing.Size(30, 30);
            this.btnLetraUComAcentoAgudo.TabIndex = 89;
            this.btnLetraUComAcentoAgudo.Text = "Ú";
            this.btnLetraUComAcentoAgudo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraUComAcentoAgudo.UseVisualStyleBackColor = false;
            this.btnLetraUComAcentoAgudo.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnHifen
            // 
            this.btnHifen.BackColor = System.Drawing.Color.White;
            this.btnHifen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHifen.FlatAppearance.BorderSize = 10;
            this.btnHifen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHifen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHifen.Location = new System.Drawing.Point(298, 72);
            this.btnHifen.Name = "btnHifen";
            this.btnHifen.Size = new System.Drawing.Size(30, 30);
            this.btnHifen.TabIndex = 90;
            this.btnHifen.Text = "-";
            this.btnHifen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHifen.UseVisualStyleBackColor = false;
            this.btnHifen.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnEspaco
            // 
            this.btnEspaco.BackColor = System.Drawing.Color.White;
            this.btnEspaco.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEspaco.FlatAppearance.BorderSize = 10;
            this.btnEspaco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEspaco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEspaco.Location = new System.Drawing.Point(324, 72);
            this.btnEspaco.Name = "btnEspaco";
            this.btnEspaco.Size = new System.Drawing.Size(30, 30);
            this.btnEspaco.TabIndex = 91;
            this.btnEspaco.Text = " ";
            this.btnEspaco.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEspaco.UseVisualStyleBackColor = false;
            this.btnEspaco.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraL
            // 
            this.btnLetraL.BackColor = System.Drawing.Color.White;
            this.btnLetraL.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraL.FlatAppearance.BorderSize = 10;
            this.btnLetraL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraL.Location = new System.Drawing.Point(297, 0);
            this.btnLetraL.Name = "btnLetraL";
            this.btnLetraL.Size = new System.Drawing.Size(30, 30);
            this.btnLetraL.TabIndex = 68;
            this.btnLetraL.Text = "L";
            this.btnLetraL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraL.UseVisualStyleBackColor = false;
            this.btnLetraL.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraK
            // 
            this.btnLetraK.BackColor = System.Drawing.Color.White;
            this.btnLetraK.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraK.FlatAppearance.BorderSize = 10;
            this.btnLetraK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraK.Location = new System.Drawing.Point(271, 0);
            this.btnLetraK.Name = "btnLetraK";
            this.btnLetraK.Size = new System.Drawing.Size(29, 30);
            this.btnLetraK.TabIndex = 67;
            this.btnLetraK.Text = "K";
            this.btnLetraK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraK.UseVisualStyleBackColor = false;
            this.btnLetraK.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraJ
            // 
            this.btnLetraJ.BackColor = System.Drawing.Color.White;
            this.btnLetraJ.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraJ.FlatAppearance.BorderSize = 10;
            this.btnLetraJ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraJ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraJ.Location = new System.Drawing.Point(244, 0);
            this.btnLetraJ.Name = "btnLetraJ";
            this.btnLetraJ.Size = new System.Drawing.Size(29, 30);
            this.btnLetraJ.TabIndex = 66;
            this.btnLetraJ.Text = "J";
            this.btnLetraJ.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraJ.UseVisualStyleBackColor = false;
            this.btnLetraJ.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraZ
            // 
            this.btnLetraZ.BackColor = System.Drawing.Color.White;
            this.btnLetraZ.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraZ.FlatAppearance.BorderSize = 10;
            this.btnLetraZ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraZ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraZ.Location = new System.Drawing.Point(324, 36);
            this.btnLetraZ.Name = "btnLetraZ";
            this.btnLetraZ.Size = new System.Drawing.Size(29, 30);
            this.btnLetraZ.TabIndex = 77;
            this.btnLetraZ.Text = "Z";
            this.btnLetraZ.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraZ.UseVisualStyleBackColor = false;
            this.btnLetraZ.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraI
            // 
            this.btnLetraI.BackColor = System.Drawing.Color.White;
            this.btnLetraI.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraI.FlatAppearance.BorderSize = 10;
            this.btnLetraI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraI.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraI.Location = new System.Drawing.Point(217, 0);
            this.btnLetraI.Name = "btnLetraI";
            this.btnLetraI.Size = new System.Drawing.Size(29, 30);
            this.btnLetraI.TabIndex = 65;
            this.btnLetraI.Text = "I";
            this.btnLetraI.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraI.UseVisualStyleBackColor = false;
            this.btnLetraI.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraN
            // 
            this.btnLetraN.BackColor = System.Drawing.Color.White;
            this.btnLetraN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraN.FlatAppearance.BorderSize = 10;
            this.btnLetraN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraN.Location = new System.Drawing.Point(0, 36);
            this.btnLetraN.Name = "btnLetraN";
            this.btnLetraN.Size = new System.Drawing.Size(29, 30);
            this.btnLetraN.TabIndex = 62;
            this.btnLetraN.Text = "N";
            this.btnLetraN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraN.UseVisualStyleBackColor = false;
            this.btnLetraN.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraM
            // 
            this.btnLetraM.BackColor = System.Drawing.Color.White;
            this.btnLetraM.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraM.FlatAppearance.BorderSize = 10;
            this.btnLetraM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraM.Location = new System.Drawing.Point(324, 0);
            this.btnLetraM.Name = "btnLetraM";
            this.btnLetraM.Size = new System.Drawing.Size(30, 30);
            this.btnLetraM.TabIndex = 61;
            this.btnLetraM.Text = "M";
            this.btnLetraM.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraM.UseVisualStyleBackColor = false;
            this.btnLetraM.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraO
            // 
            this.btnLetraO.BackColor = System.Drawing.Color.White;
            this.btnLetraO.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraO.FlatAppearance.BorderSize = 10;
            this.btnLetraO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraO.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraO.Location = new System.Drawing.Point(27, 36);
            this.btnLetraO.Name = "btnLetraO";
            this.btnLetraO.Size = new System.Drawing.Size(29, 30);
            this.btnLetraO.TabIndex = 63;
            this.btnLetraO.Text = "O";
            this.btnLetraO.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraO.UseVisualStyleBackColor = false;
            this.btnLetraO.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraH
            // 
            this.btnLetraH.BackColor = System.Drawing.Color.White;
            this.btnLetraH.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraH.FlatAppearance.BorderSize = 10;
            this.btnLetraH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraH.Location = new System.Drawing.Point(190, 0);
            this.btnLetraH.Name = "btnLetraH";
            this.btnLetraH.Size = new System.Drawing.Size(29, 30);
            this.btnLetraH.TabIndex = 60;
            this.btnLetraH.Text = "H";
            this.btnLetraH.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraH.UseVisualStyleBackColor = false;
            this.btnLetraH.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraP
            // 
            this.btnLetraP.BackColor = System.Drawing.Color.White;
            this.btnLetraP.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraP.FlatAppearance.BorderSize = 10;
            this.btnLetraP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraP.Location = new System.Drawing.Point(54, 36);
            this.btnLetraP.Name = "btnLetraP";
            this.btnLetraP.Size = new System.Drawing.Size(29, 30);
            this.btnLetraP.TabIndex = 64;
            this.btnLetraP.Text = "P";
            this.btnLetraP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraP.UseVisualStyleBackColor = false;
            this.btnLetraP.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraG
            // 
            this.btnLetraG.BackColor = System.Drawing.Color.White;
            this.btnLetraG.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraG.FlatAppearance.BorderSize = 10;
            this.btnLetraG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraG.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraG.Location = new System.Drawing.Point(163, 0);
            this.btnLetraG.Name = "btnLetraG";
            this.btnLetraG.Size = new System.Drawing.Size(29, 30);
            this.btnLetraG.TabIndex = 59;
            this.btnLetraG.Text = "G";
            this.btnLetraG.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraG.UseVisualStyleBackColor = false;
            this.btnLetraG.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraQ
            // 
            this.btnLetraQ.BackColor = System.Drawing.Color.White;
            this.btnLetraQ.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraQ.FlatAppearance.BorderSize = 10;
            this.btnLetraQ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraQ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraQ.Location = new System.Drawing.Point(81, 36);
            this.btnLetraQ.Name = "btnLetraQ";
            this.btnLetraQ.Size = new System.Drawing.Size(29, 30);
            this.btnLetraQ.TabIndex = 69;
            this.btnLetraQ.Text = "Q";
            this.btnLetraQ.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraQ.UseVisualStyleBackColor = false;
            this.btnLetraQ.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraF
            // 
            this.btnLetraF.BackColor = System.Drawing.Color.White;
            this.btnLetraF.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraF.FlatAppearance.BorderSize = 10;
            this.btnLetraF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraF.Location = new System.Drawing.Point(136, 0);
            this.btnLetraF.Name = "btnLetraF";
            this.btnLetraF.Size = new System.Drawing.Size(29, 30);
            this.btnLetraF.TabIndex = 58;
            this.btnLetraF.Text = "F";
            this.btnLetraF.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraF.UseVisualStyleBackColor = false;
            this.btnLetraF.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraR
            // 
            this.btnLetraR.BackColor = System.Drawing.Color.White;
            this.btnLetraR.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraR.FlatAppearance.BorderSize = 10;
            this.btnLetraR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraR.Location = new System.Drawing.Point(109, 36);
            this.btnLetraR.Name = "btnLetraR";
            this.btnLetraR.Size = new System.Drawing.Size(29, 30);
            this.btnLetraR.TabIndex = 70;
            this.btnLetraR.Text = "R";
            this.btnLetraR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraR.UseVisualStyleBackColor = false;
            this.btnLetraR.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraE
            // 
            this.btnLetraE.BackColor = System.Drawing.Color.White;
            this.btnLetraE.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraE.FlatAppearance.BorderSize = 10;
            this.btnLetraE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraE.Location = new System.Drawing.Point(109, 0);
            this.btnLetraE.Name = "btnLetraE";
            this.btnLetraE.Size = new System.Drawing.Size(29, 30);
            this.btnLetraE.TabIndex = 57;
            this.btnLetraE.Text = "E";
            this.btnLetraE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraE.UseVisualStyleBackColor = false;
            this.btnLetraE.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraS
            // 
            this.btnLetraS.BackColor = System.Drawing.Color.White;
            this.btnLetraS.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraS.FlatAppearance.BorderSize = 10;
            this.btnLetraS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraS.Location = new System.Drawing.Point(136, 36);
            this.btnLetraS.Name = "btnLetraS";
            this.btnLetraS.Size = new System.Drawing.Size(29, 30);
            this.btnLetraS.TabIndex = 71;
            this.btnLetraS.Text = "S";
            this.btnLetraS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraS.UseVisualStyleBackColor = false;
            this.btnLetraS.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraD
            // 
            this.btnLetraD.BackColor = System.Drawing.Color.White;
            this.btnLetraD.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraD.FlatAppearance.BorderSize = 10;
            this.btnLetraD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraD.Location = new System.Drawing.Point(81, 0);
            this.btnLetraD.Name = "btnLetraD";
            this.btnLetraD.Size = new System.Drawing.Size(29, 30);
            this.btnLetraD.TabIndex = 56;
            this.btnLetraD.Text = "D";
            this.btnLetraD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraD.UseVisualStyleBackColor = false;
            this.btnLetraD.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraX
            // 
            this.btnLetraX.BackColor = System.Drawing.Color.White;
            this.btnLetraX.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraX.FlatAppearance.BorderSize = 10;
            this.btnLetraX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraX.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraX.Location = new System.Drawing.Point(271, 36);
            this.btnLetraX.Name = "btnLetraX";
            this.btnLetraX.Size = new System.Drawing.Size(29, 30);
            this.btnLetraX.TabIndex = 88;
            this.btnLetraX.Text = "X";
            this.btnLetraX.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraX.UseVisualStyleBackColor = false;
            this.btnLetraX.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraC
            // 
            this.btnLetraC.BackColor = System.Drawing.Color.White;
            this.btnLetraC.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraC.FlatAppearance.BorderSize = 10;
            this.btnLetraC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraC.Location = new System.Drawing.Point(54, 0);
            this.btnLetraC.Name = "btnLetraC";
            this.btnLetraC.Size = new System.Drawing.Size(29, 30);
            this.btnLetraC.TabIndex = 55;
            this.btnLetraC.Text = "C";
            this.btnLetraC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraC.UseVisualStyleBackColor = false;
            this.btnLetraC.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraT
            // 
            this.btnLetraT.BackColor = System.Drawing.Color.White;
            this.btnLetraT.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraT.FlatAppearance.BorderSize = 10;
            this.btnLetraT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraT.Location = new System.Drawing.Point(163, 36);
            this.btnLetraT.Name = "btnLetraT";
            this.btnLetraT.Size = new System.Drawing.Size(29, 30);
            this.btnLetraT.TabIndex = 72;
            this.btnLetraT.Text = "T";
            this.btnLetraT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraT.UseVisualStyleBackColor = false;
            this.btnLetraT.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraB
            // 
            this.btnLetraB.BackColor = System.Drawing.Color.White;
            this.btnLetraB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraB.FlatAppearance.BorderSize = 10;
            this.btnLetraB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraB.Location = new System.Drawing.Point(27, 0);
            this.btnLetraB.Name = "btnLetraB";
            this.btnLetraB.Size = new System.Drawing.Size(29, 30);
            this.btnLetraB.TabIndex = 54;
            this.btnLetraB.Text = "B";
            this.btnLetraB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraB.UseVisualStyleBackColor = false;
            this.btnLetraB.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraU
            // 
            this.btnLetraU.BackColor = System.Drawing.Color.White;
            this.btnLetraU.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraU.FlatAppearance.BorderSize = 10;
            this.btnLetraU.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraU.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraU.Location = new System.Drawing.Point(190, 36);
            this.btnLetraU.Name = "btnLetraU";
            this.btnLetraU.Size = new System.Drawing.Size(29, 30);
            this.btnLetraU.TabIndex = 73;
            this.btnLetraU.Text = "U";
            this.btnLetraU.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraU.UseVisualStyleBackColor = false;
            this.btnLetraU.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraY
            // 
            this.btnLetraY.BackColor = System.Drawing.Color.White;
            this.btnLetraY.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraY.FlatAppearance.BorderSize = 10;
            this.btnLetraY.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraY.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraY.Location = new System.Drawing.Point(298, 36);
            this.btnLetraY.Name = "btnLetraY";
            this.btnLetraY.Size = new System.Drawing.Size(29, 30);
            this.btnLetraY.TabIndex = 76;
            this.btnLetraY.Text = "Y";
            this.btnLetraY.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraY.UseVisualStyleBackColor = false;
            this.btnLetraY.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraV
            // 
            this.btnLetraV.BackColor = System.Drawing.Color.White;
            this.btnLetraV.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraV.FlatAppearance.BorderSize = 10;
            this.btnLetraV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraV.Location = new System.Drawing.Point(217, 36);
            this.btnLetraV.Name = "btnLetraV";
            this.btnLetraV.Size = new System.Drawing.Size(29, 30);
            this.btnLetraV.TabIndex = 74;
            this.btnLetraV.Text = "V";
            this.btnLetraV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraV.UseVisualStyleBackColor = false;
            this.btnLetraV.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnLetraW
            // 
            this.btnLetraW.BackColor = System.Drawing.Color.White;
            this.btnLetraW.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLetraW.FlatAppearance.BorderSize = 10;
            this.btnLetraW.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLetraW.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetraW.Location = new System.Drawing.Point(244, 36);
            this.btnLetraW.Name = "btnLetraW";
            this.btnLetraW.Size = new System.Drawing.Size(29, 30);
            this.btnLetraW.TabIndex = 75;
            this.btnLetraW.Text = "W";
            this.btnLetraW.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLetraW.UseVisualStyleBackColor = false;
            this.btnLetraW.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // picBandeiraUm
            // 
            this.picBandeiraUm.Image = ((System.Drawing.Image)(resources.GetObject("picBandeiraUm.Image")));
            this.picBandeiraUm.Location = new System.Drawing.Point(126, 237);
            this.picBandeiraUm.Name = "picBandeiraUm";
            this.picBandeiraUm.Size = new System.Drawing.Size(22, 94);
            this.picBandeiraUm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBandeiraUm.TabIndex = 124;
            this.picBandeiraUm.TabStop = false;
            // 
            // picBandeiraDois
            // 
            this.picBandeiraDois.Image = ((System.Drawing.Image)(resources.GetObject("picBandeiraDois.Image")));
            this.picBandeiraDois.Location = new System.Drawing.Point(57, 237);
            this.picBandeiraDois.Name = "picBandeiraDois";
            this.picBandeiraDois.Size = new System.Drawing.Size(69, 192);
            this.picBandeiraDois.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBandeiraDois.TabIndex = 123;
            this.picBandeiraDois.TabStop = false;
            // 
            // picEnforcadoMorto
            // 
            this.picEnforcadoMorto.Image = ((System.Drawing.Image)(resources.GetObject("picEnforcadoMorto.Image")));
            this.picEnforcadoMorto.Location = new System.Drawing.Point(138, 122);
            this.picEnforcadoMorto.Name = "picEnforcadoMorto";
            this.picEnforcadoMorto.Size = new System.Drawing.Size(101, 94);
            this.picEnforcadoMorto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picEnforcadoMorto.TabIndex = 120;
            this.picEnforcadoMorto.TabStop = false;
            // 
            // picEnforcadoOito
            // 
            this.picEnforcadoOito.Image = ((System.Drawing.Image)(resources.GetObject("picEnforcadoOito.Image")));
            this.picEnforcadoOito.Location = new System.Drawing.Point(209, 230);
            this.picEnforcadoOito.Name = "picEnforcadoOito";
            this.picEnforcadoOito.Size = new System.Drawing.Size(68, 58);
            this.picEnforcadoOito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picEnforcadoOito.TabIndex = 118;
            this.picEnforcadoOito.TabStop = false;
            // 
            // picEnforcadoSete
            // 
            this.picEnforcadoSete.Image = ((System.Drawing.Image)(resources.GetObject("picEnforcadoSete.Image")));
            this.picEnforcadoSete.Location = new System.Drawing.Point(91, 214);
            this.picEnforcadoSete.Name = "picEnforcadoSete";
            this.picEnforcadoSete.Size = new System.Drawing.Size(57, 40);
            this.picEnforcadoSete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picEnforcadoSete.TabIndex = 117;
            this.picEnforcadoSete.TabStop = false;
            // 
            // picEnforcadoSeis
            // 
            this.picEnforcadoSeis.Image = ((System.Drawing.Image)(resources.GetObject("picEnforcadoSeis.Image")));
            this.picEnforcadoSeis.Location = new System.Drawing.Point(114, 360);
            this.picEnforcadoSeis.Name = "picEnforcadoSeis";
            this.picEnforcadoSeis.Size = new System.Drawing.Size(68, 91);
            this.picEnforcadoSeis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picEnforcadoSeis.TabIndex = 116;
            this.picEnforcadoSeis.TabStop = false;
            // 
            // picEnforcadoQuatro
            // 
            this.picEnforcadoQuatro.Image = ((System.Drawing.Image)(resources.GetObject("picEnforcadoQuatro.Image")));
            this.picEnforcadoQuatro.Location = new System.Drawing.Point(147, 311);
            this.picEnforcadoQuatro.Name = "picEnforcadoQuatro";
            this.picEnforcadoQuatro.Size = new System.Drawing.Size(63, 50);
            this.picEnforcadoQuatro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picEnforcadoQuatro.TabIndex = 115;
            this.picEnforcadoQuatro.TabStop = false;
            // 
            // picEnforcadoCinco
            // 
            this.picEnforcadoCinco.Image = ((System.Drawing.Image)(resources.GetObject("picEnforcadoCinco.Image")));
            this.picEnforcadoCinco.Location = new System.Drawing.Point(181, 360);
            this.picEnforcadoCinco.Name = "picEnforcadoCinco";
            this.picEnforcadoCinco.Size = new System.Drawing.Size(58, 91);
            this.picEnforcadoCinco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picEnforcadoCinco.TabIndex = 114;
            this.picEnforcadoCinco.TabStop = false;
            // 
            // picEnforcadoTres
            // 
            this.picEnforcadoTres.Image = ((System.Drawing.Image)(resources.GetObject("picEnforcadoTres.Image")));
            this.picEnforcadoTres.Location = new System.Drawing.Point(147, 230);
            this.picEnforcadoTres.Name = "picEnforcadoTres";
            this.picEnforcadoTres.Size = new System.Drawing.Size(63, 82);
            this.picEnforcadoTres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picEnforcadoTres.TabIndex = 113;
            this.picEnforcadoTres.TabStop = false;
            // 
            // picEnforcadoDois
            // 
            this.picEnforcadoDois.Image = ((System.Drawing.Image)(resources.GetObject("picEnforcadoDois.Image")));
            this.picEnforcadoDois.Location = new System.Drawing.Point(147, 215);
            this.picEnforcadoDois.Name = "picEnforcadoDois";
            this.picEnforcadoDois.Size = new System.Drawing.Size(92, 16);
            this.picEnforcadoDois.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picEnforcadoDois.TabIndex = 112;
            this.picEnforcadoDois.TabStop = false;
            // 
            // picEnforcadoUm
            // 
            this.picEnforcadoUm.Image = ((System.Drawing.Image)(resources.GetObject("picEnforcadoUm.Image")));
            this.picEnforcadoUm.Location = new System.Drawing.Point(138, 122);
            this.picEnforcadoUm.Name = "picEnforcadoUm";
            this.picEnforcadoUm.Size = new System.Drawing.Size(101, 94);
            this.picEnforcadoUm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picEnforcadoUm.TabIndex = 111;
            this.picEnforcadoUm.TabStop = false;
            // 
            // lbForca
            // 
            this.lbForca.AutoSize = true;
            this.lbForca.Font = new System.Drawing.Font("Curlz MT", 50F, System.Drawing.FontStyle.Bold);
            this.lbForca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(104)))), ((int)(((byte)(225)))));
            this.lbForca.Location = new System.Drawing.Point(535, 21);
            this.lbForca.Name = "lbForca";
            this.lbForca.Size = new System.Drawing.Size(198, 89);
            this.lbForca.TabIndex = 110;
            this.lbForca.Text = "Forca!";
            // 
            // lbAdivinhe
            // 
            this.lbAdivinhe.AutoSize = true;
            this.lbAdivinhe.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdivinhe.ForeColor = System.Drawing.Color.Blue;
            this.lbAdivinhe.Location = new System.Drawing.Point(542, 110);
            this.lbAdivinhe.Name = "lbAdivinhe";
            this.lbAdivinhe.Size = new System.Drawing.Size(189, 24);
            this.lbAdivinhe.TabIndex = 109;
            this.lbAdivinhe.Text = "Adivinhe a palavra!";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(550, 158);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(209, 29);
            this.txtNome.TabIndex = 108;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(455, 161);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(89, 20);
            this.lbNome.TabIndex = 107;
            this.lbNome.Text = "Seu nome:";
            // 
            // dgvPalavra
            // 
            this.dgvPalavra.AllowUserToAddRows = false;
            this.dgvPalavra.AllowUserToDeleteRows = false;
            this.dgvPalavra.AllowUserToResizeColumns = false;
            this.dgvPalavra.AllowUserToResizeRows = false;
            this.dgvPalavra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvPalavra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPalavra.ColumnHeadersHeight = 30;
            this.dgvPalavra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPalavra.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvPalavra.Location = new System.Drawing.Point(401, 352);
            this.dgvPalavra.Name = "dgvPalavra";
            this.dgvPalavra.ReadOnly = true;
            this.dgvPalavra.RowHeadersVisible = false;
            this.dgvPalavra.RowHeadersWidth = 31;
            this.dgvPalavra.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPalavra.Size = new System.Drawing.Size(465, 30);
            this.dgvPalavra.TabIndex = 0;
            this.dgvPalavra.TabStop = false;
            // 
            // lbTempo
            // 
            this.lbTempo.AutoSize = true;
            this.lbTempo.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.lbTempo.ForeColor = System.Drawing.Color.Red;
            this.lbTempo.Location = new System.Drawing.Point(564, 488);
            this.lbTempo.Name = "lbTempo";
            this.lbTempo.Size = new System.Drawing.Size(168, 21);
            this.lbTempo.TabIndex = 105;
            this.lbTempo.Text = "Tempo Restante:___s";
            // 
            // lbErros
            // 
            this.lbErros.AutoSize = true;
            this.lbErros.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErros.ForeColor = System.Drawing.Color.Red;
            this.lbErros.Location = new System.Drawing.Point(395, 488);
            this.lbErros.Name = "lbErros";
            this.lbErros.Size = new System.Drawing.Size(85, 21);
            this.lbErros.TabIndex = 104;
            this.lbErros.Text = "Erros: ____";
            // 
            // lbPontos
            // 
            this.lbPontos.AutoSize = true;
            this.lbPontos.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPontos.ForeColor = System.Drawing.Color.Green;
            this.lbPontos.Location = new System.Drawing.Point(394, 450);
            this.lbPontos.Name = "lbPontos";
            this.lbPontos.Size = new System.Drawing.Size(100, 21);
            this.lbPontos.TabIndex = 103;
            this.lbPontos.Text = "Pontos: ____";
            // 
            // lbDica
            // 
            this.lbDica.AutoSize = true;
            this.lbDica.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDica.ForeColor = System.Drawing.Color.Purple;
            this.lbDica.Location = new System.Drawing.Point(394, 404);
            this.lbDica.Name = "lbDica";
            this.lbDica.Size = new System.Drawing.Size(467, 21);
            this.lbDica.TabIndex = 102;
            this.lbDica.Text = "Dica:____________________________________________________________";
            // 
            // chkComDica
            // 
            this.chkComDica.AutoSize = true;
            this.chkComDica.Font = new System.Drawing.Font("Microsoft JhengHei", 12F);
            this.chkComDica.Location = new System.Drawing.Point(567, 449);
            this.chkComDica.Name = "chkComDica";
            this.chkComDica.Size = new System.Drawing.Size(99, 24);
            this.chkComDica.TabIndex = 101;
            this.chkComDica.Text = "Com dica";
            this.chkComDica.UseVisualStyleBackColor = true;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Image = ((System.Drawing.Image)(resources.GetObject("btnIniciar.Image")));
            this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciar.Location = new System.Drawing.Point(773, 445);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(93, 30);
            this.btnIniciar.TabIndex = 100;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // picForcaSete
            // 
            this.picForcaSete.Image = ((System.Drawing.Image)(resources.GetObject("picForcaSete.Image")));
            this.picForcaSete.Location = new System.Drawing.Point(147, 229);
            this.picForcaSete.Name = "picForcaSete";
            this.picForcaSete.Size = new System.Drawing.Size(63, 82);
            this.picForcaSete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picForcaSete.TabIndex = 98;
            this.picForcaSete.TabStop = false;
            // 
            // picForcaSeis
            // 
            this.picForcaSeis.Image = ((System.Drawing.Image)(resources.GetObject("picForcaSeis.Image")));
            this.picForcaSeis.Location = new System.Drawing.Point(147, 215);
            this.picForcaSeis.Name = "picForcaSeis";
            this.picForcaSeis.Size = new System.Drawing.Size(92, 16);
            this.picForcaSeis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picForcaSeis.TabIndex = 97;
            this.picForcaSeis.TabStop = false;
            // 
            // picForcaCinco
            // 
            this.picForcaCinco.Image = ((System.Drawing.Image)(resources.GetObject("picForcaCinco.Image")));
            this.picForcaCinco.Location = new System.Drawing.Point(138, 122);
            this.picForcaCinco.Name = "picForcaCinco";
            this.picForcaCinco.Size = new System.Drawing.Size(101, 94);
            this.picForcaCinco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picForcaCinco.TabIndex = 96;
            this.picForcaCinco.TabStop = false;
            // 
            // picForcaQuatro
            // 
            this.picForcaQuatro.Image = ((System.Drawing.Image)(resources.GetObject("picForcaQuatro.Image")));
            this.picForcaQuatro.Location = new System.Drawing.Point(147, 69);
            this.picForcaQuatro.Name = "picForcaQuatro";
            this.picForcaQuatro.Size = new System.Drawing.Size(131, 54);
            this.picForcaQuatro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picForcaQuatro.TabIndex = 95;
            this.picForcaQuatro.TabStop = false;
            // 
            // picForcaTres
            // 
            this.picForcaTres.Image = ((System.Drawing.Image)(resources.GetObject("picForcaTres.Image")));
            this.picForcaTres.Location = new System.Drawing.Point(22, 69);
            this.picForcaTres.Name = "picForcaTres";
            this.picForcaTres.Size = new System.Drawing.Size(126, 54);
            this.picForcaTres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picForcaTres.TabIndex = 94;
            this.picForcaTres.TabStop = false;
            // 
            // picForcaDois
            // 
            this.picForcaDois.Image = ((System.Drawing.Image)(resources.GetObject("picForcaDois.Image")));
            this.picForcaDois.Location = new System.Drawing.Point(22, 122);
            this.picForcaDois.Name = "picForcaDois";
            this.picForcaDois.Size = new System.Drawing.Size(69, 192);
            this.picForcaDois.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picForcaDois.TabIndex = 93;
            this.picForcaDois.TabStop = false;
            // 
            // picForcaUm
            // 
            this.picForcaUm.Image = ((System.Drawing.Image)(resources.GetObject("picForcaUm.Image")));
            this.picForcaUm.Location = new System.Drawing.Point(22, 313);
            this.picForcaUm.Name = "picForcaUm";
            this.picForcaUm.Size = new System.Drawing.Size(69, 160);
            this.picForcaUm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picForcaUm.TabIndex = 92;
            this.picForcaUm.TabStop = false;
            // 
            // lbPortaSerial
            // 
            this.lbPortaSerial.AutoSize = true;
            this.lbPortaSerial.Enabled = false;
            this.lbPortaSerial.Location = new System.Drawing.Point(563, 526);
            this.lbPortaSerial.Name = "lbPortaSerial";
            this.lbPortaSerial.Size = new System.Drawing.Size(97, 20);
            this.lbPortaSerial.TabIndex = 3;
            this.lbPortaSerial.Text = "Porta serial:";
            // 
            // btnConectarArduino
            // 
            this.btnConectarArduino.Enabled = false;
            this.btnConectarArduino.Location = new System.Drawing.Point(774, 521);
            this.btnConectarArduino.Name = "btnConectarArduino";
            this.btnConectarArduino.Size = new System.Drawing.Size(93, 30);
            this.btnConectarArduino.TabIndex = 0;
            this.btnConectarArduino.TabStop = false;
            this.btnConectarArduino.Text = "Conectar";
            this.btnConectarArduino.UseVisualStyleBackColor = true;
            this.btnConectarArduino.Click += new System.EventHandler(this.btnConectarArduino_Click);
            // 
            // txtPortaSerial
            // 
            this.txtPortaSerial.Enabled = false;
            this.txtPortaSerial.Location = new System.Drawing.Point(666, 523);
            this.txtPortaSerial.MaxLength = 5;
            this.txtPortaSerial.Name = "txtPortaSerial";
            this.txtPortaSerial.Size = new System.Drawing.Size(65, 29);
            this.txtPortaSerial.TabIndex = 1;
            this.txtPortaSerial.Text = "COM";
            this.txtPortaSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPortaSerial.TextChanged += new System.EventHandler(this.txtPortaSerial_TextChanged);
            // 
            // chkComArduino
            // 
            this.chkComArduino.AutoSize = true;
            this.chkComArduino.Location = new System.Drawing.Point(399, 525);
            this.chkComArduino.Name = "chkComArduino";
            this.chkComArduino.Size = new System.Drawing.Size(129, 24);
            this.chkComArduino.TabIndex = 0;
            this.chkComArduino.Text = "Com Arduino";
            this.chkComArduino.UseVisualStyleBackColor = true;
            this.chkComArduino.CheckedChanged += new System.EventHandler(this.chkComArduino_CheckedChanged);
            // 
            // picVivo
            // 
            this.picVivo.Image = ((System.Drawing.Image)(resources.GetObject("picVivo.Image")));
            this.picVivo.Location = new System.Drawing.Point(66, 217);
            this.picVivo.Name = "picVivo";
            this.picVivo.Size = new System.Drawing.Size(242, 329);
            this.picVivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picVivo.TabIndex = 125;
            this.picVivo.TabStop = false;
            // 
            // tabJogoDaForca
            // 
            this.tabJogoDaForca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabJogoDaForca.Controls.Add(this.tabForca);
            this.tabJogoDaForca.Controls.Add(this.tabCadastro);
            this.tabJogoDaForca.Location = new System.Drawing.Point(4, 3);
            this.tabJogoDaForca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabJogoDaForca.Name = "tabJogoDaForca";
            this.tabJogoDaForca.SelectedIndex = 0;
            this.tabJogoDaForca.Size = new System.Drawing.Size(917, 592);
            this.tabJogoDaForca.TabIndex = 0;
            // 
            // ssMensagem
            // 
            this.ssMensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ssMensagem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbMensagem,
            this.stlbMensagem});
            this.ssMensagem.Location = new System.Drawing.Point(0, 597);
            this.ssMensagem.Name = "ssMensagem";
            this.ssMensagem.Size = new System.Drawing.Size(921, 22);
            this.ssMensagem.TabIndex = 1;
            this.ssMensagem.Text = "Mensagem:";
            // 
            // lbMensagem
            // 
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Size = new System.Drawing.Size(69, 17);
            this.lbMensagem.Text = "Mensagem:";
            // 
            // stlbMensagem
            // 
            this.stlbMensagem.Name = "stlbMensagem";
            this.stlbMensagem.Size = new System.Drawing.Size(0, 17);
            // 
            // tmrStatusStrip
            // 
            this.tmrStatusStrip.Enabled = true;
            this.tmrStatusStrip.Tick += new System.EventHandler(this.tmrStatusStrip_Tick);
            // 
            // tmrForca
            // 
            this.tmrForca.Interval = 1000;
            this.tmrForca.Tick += new System.EventHandler(this.tmrForca_Tick);
            // 
            // tmrEspirito
            // 
            this.tmrEspirito.Interval = 25;
            this.tmrEspirito.Tick += new System.EventHandler(this.tmrEspirito_Tick);
            // 
            // FrmJogoDaForca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 619);
            this.Controls.Add(this.ssMensagem);
            this.Controls.Add(this.tabJogoDaForca);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(937, 658);
            this.MinimumSize = new System.Drawing.Size(937, 658);
            this.Name = "FrmJogoDaForca";
            this.Text = "Jogo da forca";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmJogoDaForca_FormClosing);
            this.Load += new System.EventHandler(this.FrmJogoDaForca_Load);
            this.tabCadastro.ResumeLayout(false);
            this.tabCadastro.PerformLayout();
            this.tsBotoes.ResumeLayout(false);
            this.tsBotoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalavrasEDicas)).EndInit();
            this.tabForca.ResumeLayout(false);
            this.tabForca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEspirito)).EndInit();
            this.panelTeclado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBandeiraUm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBandeiraDois)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnforcadoMorto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnforcadoOito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnforcadoSete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnforcadoSeis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnforcadoQuatro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnforcadoCinco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnforcadoTres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnforcadoDois)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnforcadoUm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalavra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForcaSete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForcaSeis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForcaCinco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForcaQuatro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForcaTres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForcaDois)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForcaUm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVivo)).EndInit();
            this.tabJogoDaForca.ResumeLayout(false);
            this.ssMensagem.ResumeLayout(false);
            this.ssMensagem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imlBotoes;
        private System.Windows.Forms.OpenFileDialog dlgAbrir;
        private System.IO.Ports.SerialPort sp;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.TextBox txtDica;
        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.DataGridView dgvPalavrasEDicas;
        private System.Windows.Forms.Label lbDicaCadastro;
        private System.Windows.Forms.Label lbPalavraCadastro;
        private System.Windows.Forms.TabPage tabForca;
        private System.Windows.Forms.TextBox txtPortaSerial;
        private System.Windows.Forms.CheckBox chkComArduino;
        private System.Windows.Forms.TabControl tabJogoDaForca;
        private System.Windows.Forms.Button btnConectarArduino;
        private System.Windows.Forms.Label lbPortaSerial;
        private System.Windows.Forms.Button btnLetraZ;
        private System.Windows.Forms.Button btnLetraA;
        private System.Windows.Forms.Button btnLetraB;
        private System.Windows.Forms.Button btnLetraC;
        private System.Windows.Forms.Button btnLetraD;
        private System.Windows.Forms.Button btnLetraE;
        private System.Windows.Forms.Button btnLetraF;
        private System.Windows.Forms.Button btnLetraG;
        private System.Windows.Forms.Button btnLetraH;
        private System.Windows.Forms.Button btnLetraM;
        private System.Windows.Forms.Button btnLetraN;
        private System.Windows.Forms.Button btnLetraO;
        private System.Windows.Forms.Button btnLetraP;
        private System.Windows.Forms.Button btnLetraI;
        private System.Windows.Forms.Button btnLetraJ;
        private System.Windows.Forms.Button btnLetraK;
        private System.Windows.Forms.Button btnLetraL;
        private System.Windows.Forms.Button btnEspaco;
        private System.Windows.Forms.Button btnLetraQ;
        private System.Windows.Forms.Button btnHifen;
        private System.Windows.Forms.Button btnLetraR;
        private System.Windows.Forms.Button btnLetraUComAcentoAgudo;
        private System.Windows.Forms.Button btnLetraS;
        private System.Windows.Forms.Button btnLetraX;
        private System.Windows.Forms.Button btnLetraT;
        private System.Windows.Forms.Button btnLetraOComTio;
        private System.Windows.Forms.Button btnLetraU;
        private System.Windows.Forms.Button btnLetraOComAcentoCircunflexo;
        private System.Windows.Forms.Button btnLetraV;
        private System.Windows.Forms.Button btnLetraOComAcentoAgudo;
        private System.Windows.Forms.Button btnLetraW;
        private System.Windows.Forms.Button btnLetraIComAcentoAgudo;
        private System.Windows.Forms.Button btnLetraY;
        private System.Windows.Forms.Button btnLetraEComAcentoCircuflexo;
        private System.Windows.Forms.Button btnLetraÇ;
        private System.Windows.Forms.Button btnLetraEComAcentoAgudo;
        private System.Windows.Forms.Button btnLetraAComAcentoAgudo;
        private System.Windows.Forms.Button btnLetraAComAcentoCircunflexo;
        private System.Windows.Forms.Button btnLetraAComTio;
        private System.Windows.Forms.ToolStrip tsBotoes;
        private System.Windows.Forms.ToolStripButton btnInicio;
        private System.Windows.Forms.ToolStripButton btnAnterior;
        private System.Windows.Forms.ToolStripButton btnProximo;
        private System.Windows.Forms.ToolStripButton btnUltimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnProcurar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.StatusStrip ssMensagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPalavra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDica;
        private System.Windows.Forms.ToolStripStatusLabel lbMensagem;
        private System.Windows.Forms.Timer tmrStatusStrip;
        private System.Windows.Forms.Timer tmrForca;
        private System.Windows.Forms.PictureBox picForcaSete;
        private System.Windows.Forms.PictureBox picForcaSeis;
        private System.Windows.Forms.PictureBox picForcaCinco;
        private System.Windows.Forms.PictureBox picForcaQuatro;
        private System.Windows.Forms.PictureBox picForcaTres;
        private System.Windows.Forms.PictureBox picForcaDois;
        private System.Windows.Forms.PictureBox picForcaUm;
        private System.Windows.Forms.DataGridView dgvPalavra;
        private System.Windows.Forms.Label lbTempo;
        private System.Windows.Forms.Label lbErros;
        private System.Windows.Forms.Label lbPontos;
        private System.Windows.Forms.Label lbDica;
        private System.Windows.Forms.CheckBox chkComDica;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbForca;
        private System.Windows.Forms.Label lbAdivinhe;
        private System.Windows.Forms.ToolStripStatusLabel stlbMensagem;
        private System.Windows.Forms.PictureBox picEnforcadoQuatro;
        private System.Windows.Forms.PictureBox picEnforcadoCinco;
        private System.Windows.Forms.PictureBox picEnforcadoTres;
        private System.Windows.Forms.PictureBox picEnforcadoDois;
        private System.Windows.Forms.PictureBox picEnforcadoUm;
        private System.Windows.Forms.PictureBox picEnforcadoSeis;
        private System.Windows.Forms.PictureBox picEnforcadoSete;
        private System.Windows.Forms.PictureBox picEnforcadoOito;
        private System.Windows.Forms.PictureBox picEspirito;
        private System.Windows.Forms.PictureBox picEnforcadoMorto;
        private System.Windows.Forms.PictureBox picBandeiraDois;
        private System.Windows.Forms.PictureBox picBandeiraUm;
        private System.Windows.Forms.PictureBox picVivo;
        private System.Windows.Forms.Panel panelTeclado;
        private System.Windows.Forms.Timer tmrEspirito;
    }
}

