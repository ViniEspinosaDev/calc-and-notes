using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcAnotsTotale
{
    public partial class FrmMenu : Form
    {
        string tituloAnterior = string.Empty;

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dataHora = DateTime.Now;
            lblDateTime.Text = dataHora.ToLongDateString().ToUpper() + " - " + dataHora.ToLongTimeString().ToUpper();
        }

        private void anotaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesabilitaTodosOsPanels();
            HabilitaPanel(pnlAnotacoes);
            ConfiguraTelaDeAnotacoesDesativaComponentes(2);
        }

        private void ConfiguraTelaDeAnotacoesDesativaComponentes(int opcao)
        {
            switch (opcao)
            {
                case 1: // Adicionar

                    ConfiguraTelaParaAdicaoDeNota();
                    btnSalvarAnotacao.Visible = true;
                    txtBoxTituloNota.Enabled = true;
                    txtBoxAnotacao.Enabled = true;
                    cmbEscolhaNota.Enabled = false;
                    btnCopiarNota.Enabled = false;

                    break;

                case 2: // Apenas olhar nota

                    btnSalvarAnotacao.Visible = false;
                    cmbEscolhaNota.Enabled = true;
                    txtBoxTituloNota.Enabled = false;
                    txtBoxAnotacao.Enabled = false;
                    chkBoxModificar.Checked = false;
                    btnCopiarNota.Enabled = false;

                    break;

                case 3: // Modificar nota

                    tituloAnterior = txtBoxTituloNota.Text;
                    btnSalvarAnotacao.Visible = true;
                    txtBoxTituloNota.Enabled = true;
                    txtBoxAnotacao.Enabled = true;
                    cmbEscolhaNota.Enabled = false;
                    btnCopiarNota.Enabled = false;

                    break;
            }

        }

        private void ConfiguraTelaParaAdicaoDeNota()
        {
            txtBoxTituloNota.Text = string.Empty;
            txtBoxAnotacao.Text = string.Empty;
        }

        #region Administrando os panels


        private void HabilitaPanel(Panel panel)
        {
            panel.Enabled = true;
            panel.Visible = true;
            panel.BringToFront();
        }

        private void DesabilitaTodosOsPanels()
        {
            pnlMenu.Visible = false;
            pnlMenu.Enabled = false;

            pnlAnotacoes.Visible = false;
            pnlAnotacoes.Enabled = false;

            pnlConfigs.Visible = false;
            pnlConfigs.Enabled = false;
        }

        #endregion

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            DesabilitaTodosOsPanels();
            HabilitaPanel(pnlMenu);
            txtPathConfig.Text = @"C:\Users\vinie\Documents\Arquivos\Vinicius\Desenvolvimento\CalcAnotsTotale";
        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesabilitaTodosOsPanels();
            HabilitaPanel(pnlConfigs);
        }

        private void calculosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chkBoxModificar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxModificar.Checked)
            {
                ConfiguraTelaDeAnotacoesDesativaComponentes(3);
            }
            else
            {
                ConfiguraTelaDeAnotacoesDesativaComponentes(2);
            }
        }

        private void btnNovaNota_Click(object sender, EventArgs e)
        {
            ConfiguraTelaDeAnotacoesDesativaComponentes(1);
        }

        private void btnSalvarAnotacao_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja salvar essa nota?", "Atenção", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string path = txtPathConfig.Text;

                // Fazer validação se o último caractere é igual a '\'

                string tituloDaNota = txtBoxTituloNota.Text;
                string caminhoComANota = path + "\\" + tituloDaNota;

                if (string.IsNullOrEmpty(path))
                {
                    MessageBox.Show("Adicione um caminho para salvar seus arquivos na aba 'Configurações'.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(tituloDaNota))
                {
                    MessageBox.Show("O titulo da nota não pode ser vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Evento de 'Modificar'
                if (chkBoxModificar.Checked)
                {
                    try
                    {
                        string conteudoDaNota = txtBoxAnotacao.Text;

                        File.Delete(caminhoComANota);
                        File.WriteAllText(caminhoComANota, conteudoDaNota);

                        MessageBox.Show($"Aparentemente sua modificação foi feita com exito.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Desculpe, ocorreu um erro: {ex.Message}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Evento de 'Nova Nota'
                if (txtBoxTituloNota.Enabled && !chkBoxModificar.Checked)
                {
                    try
                    {
                        string conteudoDaNota = txtBoxAnotacao.Text;

                        if (File.Exists(caminhoComANota + ".txt"))
                        {
                            MessageBox.Show($"Infelizmente já existe uma nota com esse nome.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            File.WriteAllText(caminhoComANota + ".txt", conteudoDaNota);

                            MessageBox.Show($"Aparentemente sua modificação foi feita com exito.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Desculpe, ocorreu um erro: {ex.Message}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            ConfiguraTelaDeAnotacoesDesativaComponentes(2);
        }

        private void cmbEscolhaNota_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string titulo = cmbEscolhaNota.Text;
                string path = txtPathConfig.Text;
                string caminhoComANota = path + "\\" + titulo;

                txtBoxTituloNota.Text = titulo;

                if (!string.IsNullOrEmpty(titulo))
                    txtBoxAnotacao.Text = File.ReadAllText(caminhoComANota);
                else
                    txtBoxAnotacao.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Desculpe, ocorreu um erro: {ex.Message}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbEscolhaNota_Enter(object sender, EventArgs e)
        {
            cmbEscolhaNota.Items.Clear();
            string caminhoDasNotas = txtPathConfig.Text;

            DirectoryInfo diretorio = new DirectoryInfo(caminhoDasNotas);
            FileInfo[] arquivos = diretorio.GetFiles();

            cmbEscolhaNota.Items.Add(string.Empty);

            foreach (var arquivo in arquivos)
            {
                if (arquivo.Extension.Equals(".txt"))
                    cmbEscolhaNota.Items.Add(arquivo.Name);
            }
        }

        private void cmbEscolhaNota_Click(object sender, EventArgs e)
        {
            cmbEscolhaNota_Enter(sender, e);
        }

        private void txtBoxAnotacao_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxAnotacao.Text))
            {
                btnCopiarNota.Enabled = true;
            }
            else
            {
                btnCopiarNota.Enabled = false;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:

                    CopiaConteudoDaNota();

                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void CopiaConteudoDaNota()
        {
            try
            {
                string conteudoDoTxtAnotacao = txtBoxAnotacao.Text;

                if (!string.IsNullOrEmpty(conteudoDoTxtAnotacao))
                {
                    Clipboard.SetText(conteudoDoTxtAnotacao);
                    AutoClosingMessageBox.Show("COPIADOO !!!!", "COPIADO :)", 500);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao copiar conteudo da nota - Retorno: {ex.Message}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCopiarNota_Click(object sender, EventArgs e)
        {
            CopiaConteudoDaNota();
        }
    }


    #region Macumba pra fazer uma message Box desaparecer depois de alguns segundos :)

    public class AutoClosingMessageBox
    {
        System.Threading.Timer _timeoutTimer;
        string _caption;
        DialogResult _result;
        DialogResult _timerResult;
        AutoClosingMessageBox(string text, string caption, int timeout, MessageBoxButtons buttons = MessageBoxButtons.OK, DialogResult timerResult = DialogResult.None)
        {
            _caption = caption;
            _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                null, timeout, System.Threading.Timeout.Infinite);
            _timerResult = timerResult;
            using (_timeoutTimer)
                _result = MessageBox.Show(text, caption, buttons);
        }
        public static DialogResult Show(string text, string caption, int timeout, MessageBoxButtons buttons = MessageBoxButtons.OK, DialogResult timerResult = DialogResult.None)
        {
            return new AutoClosingMessageBox(text, caption, timeout, buttons, timerResult)._result;
        }
        void OnTimerElapsed(object state)
        {
            IntPtr mbWnd = FindWindow("#32770", _caption); // lpClassName is #32770 for MessageBox
            if (mbWnd != IntPtr.Zero)
                SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            _timeoutTimer.Dispose();
            _result = _timerResult;
        }
        const int WM_CLOSE = 0x0010;
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
    }

    #endregion
}