// Gabriel Willian Bartmanovicz - 21234
// João Pero Ferreira Barbosa - 21687

using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace apJogoDaForca
{
    public partial class FrmJogoDaForca : Form
    {
        /////////////////////////////////////   Variáveis  /////////////////////////////////////

        VetorDicionario dicio;

        int posicaoDeInclusao;
        int indiceAleatorio;

        int tempoForca;

        int pontos = 0;
        int erros = 0;

        bool arduino = false;

        bool emJogo;

        string inspiracao = "Inspirado em http://www.velhosamigos.com.br/jogos/forca.htm";
        string nome;

        Button[] letraPressionada = new Button[30];
        int qualLetra = 0;

        /////////////////////////////////////   Formulário  /////////////////////////////////////

        public FrmJogoDaForca()
        {
            InitializeComponent();
        }

        private void FrmJogoDaForca_Load(object sender, EventArgs e)
        {
            ResetarJogo(); // o jogo é resetado no load do forms
            ResetarImagens(); // as imagens são resetadas no load do forms

            int indice = 0;
            tsBotoes.ImageList = imlBotoes;
            foreach (ToolStripItem item in tsBotoes.Items) // atribui as imagens aos seus respectivos botões
                if (item is ToolStripButton)
                    (item as ToolStripButton).ImageIndex = indice++;

            bool repetirDialogo = true;
            while (repetirDialogo) // enquanto o resultado do diálogo for diferente de OK, o diálogo se repete, exibindo a opção de parar o programa para o usuário
            {
                if (dlgAbrir.ShowDialog() == DialogResult.OK) // se o resultado do diálogo for OK, repetirDialogo recebe false e a repetição é encerrada
                    repetirDialogo = false;

                else if (MessageBox.Show("O arquivo indicado não é válido.\r\n\r\nDeseja tentar novamente?", "Erro: Arquivo inválido", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                    System.Environment.Exit(0); // se o resultado do MessageBox for No, o formulário é fechado. Se o resultado for sim, tem-se a repetição
            }

            dicio = new VetorDicionario(200); // instancia com vetor dados com 200 posições
            var arquivo = new StreamReader(dlgAbrir.FileName);
            while (!arquivo.EndOfStream) // lê e armazena todos os dados do arquivo indicado
            {
                Dicionario dadoLido = new Dicionario();
                dadoLido.LerDados(arquivo);
                dicio.Incluir(dadoLido);
            }
            arquivo.Close();
        }

        private void FrmJogoDaForca_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (arduino) // verifica se o usuário está usando a integração com o Arduino
                EncerrarArduino(); // se sim, ele é encerrado

            if (dlgAbrir.FileName != "")  // verifica se foi selecionado um arquivo com dados
                dicio.GravarDados(dlgAbrir.FileName); // se sim, ele é salvo
        }

        private void tmrStatusStrip_Tick(object sender, EventArgs e) // a cada tick de 1s do tmrStatusStrip
        {
            string data = DateTime.Now.ToLongDateString(); // a string data recebe a data atualizada no formato ToLongDateString() (dia da semana, mês dia numérico, ano)
            string hora = DateTime.Now.ToLongTimeString(); // a string hora recebe a hora atualizada no formato ToLongTimeString() (hh:mm:ss AM/PM)

            if (tabJogoDaForca.SelectedTab == tabForca) // se a aba atual do tabJogoDaForca for a Forca
                lbMensagem.Text = $"Mensagem: Data: {data}  Hora: {hora}   {inspiracao}"; // então, a lbMensagem recebe os novos parâmetros de data
        }

        /////////////////////////////////////   Arduino   /////////////////////////////////////

        //  Tabela de atribuição dos valores possíveis para a variável char key do Arduino
        //
        //   Caracter     Significado
        //  '---------+-----------'
        //          i                   iniciar
        //          p                 parar
        //          f                  fechar
        //          e                 erro

        private void chkComArduino_CheckedChanged(object sender, EventArgs e) // habilita e desabilita os controles relacionados com o arduino conforme o chkComArduino varia
        {
            arduino = lbPortaSerial.Enabled = txtPortaSerial.Enabled = chkComArduino.Checked;
        }

        private void txtPortaSerial_TextChanged(object sender, EventArgs e)
        {
            if (txtPortaSerial.Text.Length > 3) // permite a conexão com a porta serial quando o txtPortaSerial tiver mais que 3 carcteres. Ex.: COM3
                btnConectarArduino.Enabled = true;

            else
                btnConectarArduino.Enabled = false;
        }

        private void btnConectarArduino_Click(object sender, EventArgs e)
        {
            IniciarArduino();
        }

        public void IniciarArduino()
        {
            if (VerificarPorta()) // verifica se a porta inserida se encontra em um formato correto
            {
                sp.Close(); // fecha a porta
                sp.PortName = txtPortaSerial.Text.ToUpper(); // atribui a porta inserida, em letra maiúscula, à porta serial. Ex.: com3 --> COM3

                if (sp.IsOpen) // caso a porta serial já esteja aberta, solicita-se ao usuário para que a feche e tente novamente
                {
                    MessageBox.Show($"A porta serial {txtPortaSerial.Text.ToUpper()} já está aberta. Feche-a e tente novamente.", "Erro: Porta serial já aberta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    arduino = false;
                }

                else // abre a porta e informa o usuário sobre o êxito
                {
                    sp.Open();
                    MessageBox.Show($"A porta serial {txtPortaSerial.Text} foi conectada com sucesso.", "Sucesso: Porta serial conectada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    arduino = true;
                    sp.Write("p");
                }
            }

            else // se a porta não for válida, o usuário é informado e o txtPortaSerial é restaurado e focado
            {
                MessageBox.Show($"{txtPortaSerial.Text.ToUpper()} não é uma porta serial válida.\r\n\r\nPor favor, insira uma nova porta no formato 'COM3', por exemplo.", "Erro: Porta serial inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sp.Close();
                txtPortaSerial.Text = "COM";
                txtPortaSerial.Focus();
            }
        }

        public bool VerificarPorta()
        {
            int numeroPorta;
            bool porta = false;

            if (txtPortaSerial.Text.Substring(0, 3).ToUpper() == "COM") // verifica se os três primeiros caracteres formam a string "COM"
                if (int.TryParse(txtPortaSerial.Text.Substring(3, txtPortaSerial.Text.Length - 3), out numeroPorta)) // tenta converter os caracteres inseridos após "COM" para inteiro
                    if (numeroPorta >= 0 && numeroPorta <= 99) // se os caracteres inseridos após "COM" são números, é verificado se esse número está compreendido entre 1 e 99. Ex.: COM1 a COM99
                        porta = true;

            return porta;
        }

        public void EncerrarArduino()
        {
            if (sp.IsOpen) // se a porta serial está aberta, apaga-se os leds enviado "f" e, em seguida, ela é fechada
            {
                sp.Write("f");
                sp.Close();
            }
        }

        /////////////////////////////////////   Forca   /////////////////////////////////////

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "") // se o usuário não inseriu um nome antes de começar a jogar
            {
                MessageBox.Show("Por favor, insira um nome válido antes de começar a jogar.", "Aviso: Nome inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning); // um MessageBox o alerta
                txtNome.Focus(); // txt nome é focado
                return; // a inicialização é cancelada
            }

            if (arduino) // se o usuário está usando a integração com arduino
            {
                if (!sp.IsOpen) // mas não conectou a porta serial
                {
                    MessageBox.Show("Conecte a por serial antes de começar a jogar ou desmarque a opção 'Com Arduino'.", "Aviso: Porta serial não conectada", MessageBoxButtons.OK, MessageBoxIcon.Warning); // é mostrado um MessageBox o informando
                    return; // a inicialização é cancelada
                }
            }

            Random rdn = new Random();
            indiceAleatorio = rdn.Next(dicio.Tamanho); // escolhe um índice aleatório do VetorDicionario
            string palavraSorteada = dicio[indiceAleatorio].Palavra.TrimEnd(); // TrimEnd() = remove os espaços em branco no fim da string
            string dicaDaPalavraSorteada = dicio[indiceAleatorio].Dica;

            if (chkComDica.Checked) // verifica se o usuário jogará com dica
            {
                tempoForca = 60; // seta o tempo para 60 segundos
                tmrForca.Enabled = true; // habilita o timer
                lbDica.Text = "Dica: " + dicaDaPalavraSorteada; // printa a dica na lbDica
            }

            else
            {
                lbDica.Enabled = false; // a lbDica é desativada
                lbTempo.Enabled = false; // a lbTempo é desativada
            }

            emJogo = true; // a variável emJogo recebe true, impedindo que o usuário acesse a guia 'Cadastro'

            btnIniciar.Enabled = false; // o btnIniciar recebe false, uma vez que um jogo não pode ser iniciado duas vezes
            panelTeclado.Enabled = true; // o panelTeclado, que contém todas as letras, é habilitado

            nome = txtNome.Text; // a variável nome recebe o valor do txtNome
            txtNome.Enabled = false; // o txtNome é desabilitado para evitar que o usuário troque de nome em jogo

            chkComDica.Enabled = false; // o chkComDica é desabilitado para evitar que o usuário o marque já depois que o jogo foi iniciado

            chkComArduino.Enabled = false; // o chkComArduino é desabilitado para evitar que o usuário o marque já depois que o jogo foi iniciado

            lbErros.Text = "Erros: 0"; // a lbErros é zerada
            lbPontos.Text = "Pontos: 0"; // a lbPontos é zerada

            ResetarImagens(); // reinicia as imagens

            if (arduino) // verifica se o usuário está usando a integração com Arduino
            {
                sp.Write("i"); // inicia e prepara o Arduino para a forca enviando "i"

                // desabilita os controles relacionados ao Arduino
                lbPortaSerial.Enabled = false;
                txtPortaSerial.Enabled = false;
                btnConectarArduino.Enabled = false;
            }

            dgvPalavra.ColumnCount = palavraSorteada.Length; // define o número de colunas do DataGridView de acordo com o tamanho da palavra
            dgvPalavra.BackgroundColor = System.Drawing.Color.White; // seta a cor de fundo como branco

            for (int i = 0; i < dgvPalavra.ColumnCount; i++)
                dgvPalavra.Columns[i].Width = 31; // define uma largura para cada coluna do DataGridView

        }

        private void btnLetra_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button); // atribui a letra clicada à variável btn
            btn.Enabled = false; // define a letra clicada como false para que não seja possível clicar mais de uma vez na mesma letra
            char letra = btn.Text[0]; // atribui o texto do botão à variável letra

            letraPressionada[qualLetra] = btn; // a letra pressionada é incluida no vetor de botões letraPressionada[] indexado de qualLetra
            qualLetra++; // o indice do vetor é avançado

            string palavra = dicio[indiceAleatorio].Palavra.TrimEnd();
            bool achouLetra = false;

            for (int i = 0; i < palavra.Length; i++) // procura a letra pressionada dentro do comprimento da palavra sorteada
            {
                if (letra == palavra[i]) // se a letra for igual a palavra indexada de i
                {
                    pontos++; // pontos é acrescido
                    achouLetra = true;
                    dgvPalavra.Columns[i].HeaderText = letra.ToString(); // a coluna indexada de i recebe a letra
                    dicio[indiceAleatorio].Acertou[i] = true; // define como true a posição i no vetor acertou do objeto Dicionario
                }
            }

            if (!achouLetra) // se a letra não foi achada
            {
                erros++; // erros é acrescido

                if (arduino) // se o usuário estiver usando a integração com arduino
                    sp.Write("e"); // "e" é enviado, simbolizando erro

                btn.BackColor = System.Drawing.Color.Red; // a letra pressionada tem a cor de funda setada como vermelha

                lbErros.Text = "Erros: " + erros; // a lbErros é atualizada

                ComputarImagens(erros); // a imagem de erro repectiva é computada

                if (erros == 8) // se o usuário errou 8 vezes,  o usuário perde
                {
                    MessageBox.Show($"Ah, não, {nome}! Que pena, parece que não foi dessa vez.", "GAME OVER!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // e é alertado 
                    ResetarJogo(); // reinicia o jogo
                }
            }

            else // se a letra for encontrada
            {
                btn.BackColor = System.Drawing.Color.Green; // a letra pressionada tem a cor de funda setada como verde
                lbPontos.Text = "Pontos: " + pontos; // a lbPontos é atualizada

                if (pontos == palavra.Length) // se o número de pontos é o mesmo do número caracteres, o usuário ganha
                {
                    ImagensGanhou(); // as imagens de vitória são exibidas
                    MessageBox.Show($"Parabéns, {nome}! Você ganhou, uhul!", "GOOD GAME!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // e é alertado
                    ResetarJogo(); // reinicia o jogo
                }
            }
        }

        private void tmrForca_Tick(object sender, EventArgs e)
        {
            lbTempo.Text = "Tempo Restante: " + --tempoForca + "s"; // a cada tick de 1s do timer, diminui-se 1 do contador, criando um temporizador de 60s

            if (tempoForca == 0) // se o tempo chegar a zero, o jogo acaba e é reiniciado
            {
                tmrForca.Enabled = false; // o timer é desativado
                ImagensPerdeu(); // as imagens de derrota exibidas
                MessageBox.Show($"Ah, não, {nome}! É uma pena, mas o tempo acabou.", "GAME OVER!", MessageBoxButtons.OK, MessageBoxIcon.Information); // o usuário alertado
                ResetarJogo(); // e o jogo reiniciado
            }
        }

        public void ResetarJogo()
        {
            if (arduino) // se o usuário está usando a integração com Arduino
            {
                sp.Write("p"); // ele é parado - "p"

                // e os controles relacionados habilitados
                lbPortaSerial.Enabled = true;
                txtPortaSerial.Enabled = true;
                btnConectarArduino.Enabled = true;
            }

            emJogo = false; // emJogo recebe false

            ResetarImagens(); // as imagens resetadas
            ResetarTeclado(); // o teclado resetado
            ResetarDgv(); // e o DataGridView resetado

            panelTeclado.Enabled = false; // o teclado desabilitado
            tmrForca.Enabled = false; // o tmrForca desabilitado
            txtNome.Enabled = true; // o txtNome habilitado
            chkComDica.Enabled = true; // o chkComDica habilitado
            chkComArduino.Enabled = true; // o chkComArduino habilitado
            btnIniciar.Enabled = true; // o btnIniciar habilitado
            lbTempo.Enabled = true;  // a lbTempo habilitada
            lbDica.Enabled = true; // e a lbDica habilitada

            // o conteúdo das labels resetado
            lbDica.Text = "Dica:____________________________________________________________";
            lbPontos.Text = "Pontos: ____";
            lbErros.Text = "Erros: ____";
            lbTempo.Text = "Tempo Restante:___s";

            pontos = 0; // os pontos resetados
            erros = 0; // os erros resetados
        }

        public void ResetarTeclado()
        {
            for (int i = 0; i < qualLetra; i++)
            {
                letraPressionada[i].Enabled = true; // habilita a letra pressionada novamente
                letraPressionada[i].BackColor = System.Drawing.Color.White; // seta a cor de fundo da letra pressionada de volta para branco
            }
            qualLetra = 0; // zera o indice do vetor de tipo button
        }

        void ResetarDgv()
        {
            Color dgvBackground = Color.FromArgb(192, 192, 255); // a variável dgvBackground assume o código argb da cor de fundo original do dgv

            dgvPalavra.ColumnCount = 0; // volta o número de colunas pra 0
            dgvPalavra.BackgroundColor = dgvBackground; // seta a cor de fundo de volta para a original
        }

        ///////    Imagens    ///////

        public void ComputarImagens(int erro)
        {
            switch (erro)
            {
                case 1:
                    picEnforcadoUm.Visible = true;
                    break;
                case 2:
                    picEnforcadoDois.Visible = true;
                    break;
                case 3:
                    picEnforcadoTres.Visible = true;
                    break;
                case 4:
                    picEnforcadoQuatro.Visible = true;
                    break;
                case 5:
                    picEnforcadoCinco.Visible = true;
                    break;
                case 6:
                    picEnforcadoSeis.Visible = true;
                    break;
                case 7:
                    picEnforcadoSete.Visible = true;
                    break;
                case 8: // caso erros chegue a 8, o usuário perde
                    ImagensPerdeu(); // e as imagens correspondentes são exibidas
                    break;
            }
        }

        public void ResetarImagens()
        {
            // reseta as imagens, deixando a forca visível e o enforcado e o vivo invisíveis
            SetarForca(true);
            SetarEnforcado(false);
            SetarVivo(false);

            // a picEspirito é resetada, ficando invisível e tendo sua localização restaurada
            picEspirito.Visible = false;
            picEspirito.Left = 108;
            picEspirito.Top = 129;
            tmrEspirito.Enabled = false;
        }

        public void SetarForca(bool estado) // muda a visibilidade da forca de acordo com a variável bool estado
        {
            picForcaUm.Visible = estado;
            picForcaDois.Visible = estado;
            picForcaTres.Visible = estado;
            picForcaQuatro.Visible = estado;
            picForcaCinco.Visible = estado;
            picForcaSeis.Visible = estado;
            picForcaSete.Visible = estado;
        }

        public void SetarEnforcado(bool estado) // muda a visibilidade da forca de acordo com a variável bool estado
        {
            picEnforcadoUm.Visible = estado;
            picEnforcadoDois.Visible = estado;
            picEnforcadoTres.Visible = estado;
            picEnforcadoQuatro.Visible = estado;
            picEnforcadoCinco.Visible = estado;
            picEnforcadoSeis.Visible = estado;
            picEnforcadoSete.Visible = estado;
            picEnforcadoOito.Visible = estado;
            picEnforcadoMorto.Visible = estado;
        }

        public void SetarVivo(bool estado) // muda a visibilidade do vivo de acordo com a variável bool estado
        {
            picVivo.Visible = estado;
            picBandeiraUm.Visible = estado;
            picBandeiraDois.Visible = estado;
        }

        public void ImagensGanhou() // combinação imagens de vitória
        {
            SetarForca(false);
            SetarEnforcado(false);
            SetarVivo(true);
        }

        public void ImagensPerdeu() // combinação imagens de derrota
        {
            SetarEnforcado(true);

            picEspirito.Visible = true;
            tmrEspirito.Enabled = true;
        }

        private void tmrEspirito_Tick(object sender, EventArgs e) // a cada tick de 25ms do tmrEspirito, a picEspirito se afasta da esquerda e se aproxima da parte superior
        {
            picEspirito.Left++;
            picEspirito.Top--;
        }

        /////////////////////////////////////   Cadastro    /////////////////////////////////////

        private void tabCadastro_Enter(object sender, EventArgs e)
        {
            if (emJogo) // se o usuário tentar entrar na aba cadastro em jogo
            {
                MessageBox.Show("Não é possível acessar a aba 'Cadastro' em jogo.", "Aba bloqueada", MessageBoxButtons.OK, MessageBoxIcon.Warning); // uma mensagem é exibida o alertando
                tabJogoDaForca.SelectedTab = tabForca; // volta à aba 'Forca'
            }

            else // se não, a execução segue
            {
                dicio.ExibirDados(dgvPalavrasEDicas);
                dicio.PosicionarNoPrimeiro();
                AtualizarTela();
            }
        }

        private void TestarBotoes()
        {
            btnInicio.Enabled = true;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnUltimo.Enabled = true;

            if (dicio.EstaNoInicio)
            {
                btnInicio.Enabled = false;
                btnAnterior.Enabled = false;
            }

            if (dicio.EstaNoFim)
            {
                btnProximo.Enabled = false;
                btnUltimo.Enabled = false;
            }
        }

        private void LimparTela()
        {
            txtPalavra.Clear();
            txtDica.Clear();
        }

        private void AtualizarTela()
        {
            if (!dicio.EstaVazio)
            {
                int indice = dicio.PosicaoAtual;
                txtPalavra.Text = dicio[indice].Palavra + "";
                txtDica.Text = dicio[indice].Dica;
                TestarBotoes();
                dicio.ExibirDados(dgvPalavrasEDicas); // Atualiza os dados da tela
                lbMensagem.Text = "Mensagem: Registro " + (dicio.PosicaoAtual + 1) + "/" + dicio.Tamanho + "   " + inspiracao;
            }
        }

        private void txtPalavra_Leave(object sender, EventArgs e)
        {
            if (dicio.SituacaoAtual == Situacao.incluindo ||
                dicio.SituacaoAtual == Situacao.pesquisando)
                if (txtPalavra.Text == "")
                {
                    MessageBox.Show("Digite uma palavra válida!", "Erro: Palavra inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPalavra.Focus();
                }
                else  // temos um valor digitado no txtPalavra
                {
                    string palavraProcurada = txtPalavra.Text.ToUpper().PadRight(15);
                    int posicao;
                    bool achouRegistro = dicio.Existe(palavraProcurada, out posicao);
                    switch (dicio.SituacaoAtual)
                    {
                        case Situacao.incluindo:
                            if (achouRegistro)
                            {
                                MessageBox.Show("Palavra repetida! Inclusão cancelada.");
                                dicio.SituacaoAtual = Situacao.navegando;
                                AtualizarTela(); // exibe novamente o registro que estava na tela antes de esta ser limpa
                            }
                            else  // a palavra não existe e podemos incluí-la no índice ondeIncluir
                            {     // incluí-la no índice ondeIncluir do vetor interno dados de dicio
                                txtDica.ReadOnly = false;
                                txtDica.Focus();
                                stlbMensagem.Text = "Digite os demais dados e pressione [Salvar].";
                                btnSalvar.Enabled = true;  // habilita quando é possível incluir
                                posicaoDeInclusao = posicao;  // guarda índice de inclusão em variável global
                            }
                            break;

                        case Situacao.pesquisando:
                            if (achouRegistro)
                            {
                                dicio.PosicaoAtual = posicao;   // reposiciona o índice da posição visitada
                                AtualizarTela();
                                dgvPalavrasEDicas.CurrentCell = dgvPalavrasEDicas.Rows[dicio.PosicaoAtual].Cells[0]; // posiciona no item pesquisado
                            }
                            else
                            {
                                MessageBox.Show("Palavra digitada não foi encontrada.");
                                AtualizarTela();  // reexibir o registro que aparecia antes de limparmos a tela
                            }

                            dicio.SituacaoAtual = Situacao.navegando;
                            txtPalavra.ReadOnly = true;
                            txtDica.ReadOnly = true;
                            break;
                    }
                }
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            dicio.PosicionarNoPrimeiro();
            dgvPalavrasEDicas.CurrentCell = dgvPalavrasEDicas.Rows[dicio.PosicaoAtual].Cells[0];
            AtualizarTela();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            dicio.RetrocederPosicao();
            dgvPalavrasEDicas.CurrentCell = dgvPalavrasEDicas.Rows[dicio.PosicaoAtual].Cells[0];
            AtualizarTela();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            dicio.AvancarPosicao();
            dgvPalavrasEDicas.CurrentCell = dgvPalavrasEDicas.Rows[dicio.PosicaoAtual].Cells[0];
            AtualizarTela();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            dicio.PosicionarNoUltimo();
            dgvPalavrasEDicas.CurrentCell = dgvPalavrasEDicas.Rows[dicio.PosicaoAtual].Cells[0];
            AtualizarTela();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dicio.SituacaoAtual = Situacao.pesquisando;  // entramos no modo de busca
            LimparTela();
            txtPalavra.ReadOnly = false;
            txtPalavra.Focus();
            lbMensagem.Text = "Mensagem: Digite a palavra que deseja procurar.";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            // saímos do modo de navegação e entramos no modo de inclusão:
            dicio.SituacaoAtual = Situacao.incluindo;

            // preparamos a tela para que seja possível digitar dados da nova palavra
            LimparTela();

            txtPalavra.ReadOnly = false;
            // colocamos o cursor no campo palavra
            txtPalavra.Focus();

            // Exibimos mensagem no statusStrip para instruir o usuário a digitar dados
            lbMensagem.Text = $"Mensagem: Digite a nova palavra para o jogo da forca";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // permitimos ao usuario editar o registro atualmente
            // exibido na tela
            dicio.SituacaoAtual = Situacao.editando;
            txtDica.Focus();
            lbMensagem.Text = $"Mensagem: Digite a nova dica e pressione [Salvar] {inspiracao}";
            btnSalvar.Enabled = true;
            txtPalavra.ReadOnly = true;  // não deixamos usuário alterar a palavra (chave primária)
            txtDica.ReadOnly = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (btnSalvar.Enabled == true || txtDica.ReadOnly == false) // Retorna ao padrão visual do Situacao.Navegando 
            {
                btnSalvar.Enabled = false;
                txtDica.ReadOnly = true;
            }
            dicio.SituacaoAtual = Situacao.navegando;
            AtualizarTela();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dicio.SituacaoAtual == Situacao.incluindo)  // só guarda novo funcionário no vetor se estiver incluindo
            {
                // criamos objeto com o registro da nova palavra digitada no formulário
                var novaPalavra = new Dicionario(txtPalavra.Text.ToUpper().PadRight(15), txtDica.Text);

                dicio.Incluir(novaPalavra, posicaoDeInclusao);

                dicio.SituacaoAtual = Situacao.navegando;  // voltamos ao modo de navegação

                dicio.PosicaoAtual = posicaoDeInclusao;

                AtualizarTela();
            }
            else
                if (dicio.SituacaoAtual == Situacao.editando)
            {
                dicio[dicio.PosicaoAtual].Palavra = txtPalavra.Text;
                dicio[dicio.PosicaoAtual].Dica = txtDica.Text;
                dicio.SituacaoAtual = Situacao.navegando;
            }
            btnSalvar.Enabled = false;    // desabilita pois a inclusão terminou
            txtPalavra.ReadOnly = true;
            txtDica.ReadOnly = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir?", "Exclusão",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dicio.Excluir(dicio.PosicaoAtual);
                if (dicio.PosicaoAtual >= dicio.Tamanho)
                    dicio.PosicionarNoUltimo();
                AtualizarTela();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (arduino) // verifica se o usuário está usando a integração com o Arduino
                EncerrarArduino(); // se sim, ele é encerrado

            if (dlgAbrir.FileName != "")  // verifica se foi selecionado um arquivo com dados
                dicio.GravarDados(dlgAbrir.FileName); // se sim, ele é salvo
            Close();
        }
    }
}