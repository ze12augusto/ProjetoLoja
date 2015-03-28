using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjetoLojaDesktop.Entity;
using ProjetoLojaDesktop.Data;

namespace ProjetoLojaDesktop
{
    public partial class FormFornecedor : Form
    {
        private ProjetoLojaEntities db;
        private PessoaJuridicaData pJus;
        private PessoaData pessoa;
        private UF_Data uf;
        private EnderecoData ender;
        private TelefoneData telefonedata;
        private TipoTelefoneData tipoTelofoneData;

        private bool editandoFornecedor = false;
        private int idFornEditado = 0;

        private enum statusTelaEndereco : int { Editando, Inserindo, Visualizando }
        private enum statusTelaTelefone : int { Editando, Inserindo, Visualizando }
        private statusTelaEndereco statusEnderecoAtual;
        private statusTelaTelefone statusTelefoneAtual;
        
        public FormFornecedor()
        {
            InitializeComponent();
            
            db = new ProjetoLojaEntities();
            pJus = new PessoaJuridicaData(db);
            pessoa = new PessoaData(db);
            uf = new UF_Data(db);
            ender = new EnderecoData(db);
            telefonedata = new TelefoneData(db);
            //dgvPesquisar.DataSource = pessoa.todasPessoas();
        }

        private void FormFornecedor_Load(object sender, EventArgs e)
        {
            alteraStatusTelaEndereco(statusTelaEndereco.Visualizando);
            alteraStatusTelaTelefone(statusTelaTelefone.Visualizando);
            carregarComboBoxUF();
            carregarComboTipoTelefone();
        }

/*======FORNECEDOR==============================================================================*/
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvPesquisar.DataSource = pJus.buscarPessoaJurica(txtPesquisar.Text.Trim());
            formatarGrid();
        }

        private void formatarGrid()
        {
            dgvPesquisar.Columns["Pessoa"].Visible = false;
            dgvPesquisar.Columns["nomeFantasia"].HeaderText = "Sigla";
            dgvPesquisar.Columns["razaoSocial"].HeaderText = "Razao Social";
            dgvPesquisar.Columns["idPessoa"].Visible = false;
        }

        private void btnNovoPesq_Click(object sender, EventArgs e)
        {
            editandoFornecedor = false;
            limparTelaFornecedor();
            dgvEndereco.DataSource = null;
            dgvEndereco.Rows.Clear();
            dgvEndereco.Columns.Clear();
            Fornecedores.SelectedTab = tabDadosFornecedor;

        }

        private void btnSalvarDadosForn_Click(object sender, EventArgs e)
        {
            if (!editandoFornecedor)
                incluirFornecedor();
            else
                editarFornecedor();
        }

        private void incluirFornecedor()
        {
            string textoErroPesJuri = null;
            if (dadosSaoValidos())
            {
                Pessoa pes = new Pessoa();
                pes.nome = lblNome.Text.Trim();
                pes.email = txtEmail.Text.Trim();
                pes.idTipoPessoa = 2; /*Passar Pessoa Juridica*/
                if (pessoa.adicionarPessoa(pes) == null)
                {
                    PessoaJuridica pesJuri = new PessoaJuridica();
                    pesJuri.idPessoa = pes.idPessoa;
                    pesJuri.nomeFantasia = txtNomeFantasia.Text.Trim();
                    pesJuri.razaoSocial = txtRazaoSocial.Text.Trim();
                    pesJuri.CNPJ = txtCnpj.Text.Trim();
                    textoErroPesJuri = pJus.adicionarPessoaJuridica(pesJuri);
                }
                if (textoErroPesJuri == null)
                {
                    MessageBox.Show("O registro foi salvo com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Fornecedores.SelectedTab = tabEndereco;
                    idFornEditado = pes.idPessoa;
                }
                else
                {
                    pessoa.excluirPessoa(pes);
                    MessageBox.Show("O registro não pôde ser salvo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void editarFornecedor()
        {
            string textoErroPesJuri = null;
            if (dadosSaoValidos())
            {
                Pessoa pes = pessoa.obterPessoa(idFornEditado);
                pes.nome = lblNome.Text.Trim();
                pes.email = txtEmail.Text.Trim();
                pes.idTipoPessoa = 2; /*Passar Pessoa Juridica*/
                //pes.idPessoa = idFornEditado;
                if (pessoa.editarPessoa(pes) == null)
                {
                    PessoaJuridica pesJuri = pJus.obterPessoaJuridica(idFornEditado);
                    pesJuri.idPessoa = pes.idPessoa;
                    pesJuri.nomeFantasia = txtNomeFantasia.Text.Trim();
                    pesJuri.razaoSocial = txtRazaoSocial.Text.Trim();
                    pesJuri.CNPJ = txtCnpj.Text.Trim();
                    textoErroPesJuri = pJus.editarPessoaJuridica(pesJuri);
                    pes.idPessoa = idFornEditado;
                }
                if (textoErroPesJuri == null)
                {
                    MessageBox.Show("O registro foi salvo com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Fornecedores.SelectedTab = tabEndereco;
                }
                else
                {
                    pessoa.excluirPessoa(pes);
                    MessageBox.Show("O registro não pôde ser salvo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool dadosSaoValidos() 
        {
            erroPrv.Clear();
            bool houveErroValidacao = true;
            if (lblNome.Text.Trim().Count() == 0)
            {
                erroPrv.SetError(lblNome, "Campo Obrigatório!");
                houveErroValidacao = false;
            }
            if (txtNomeFantasia.Text.Trim().Count() == 0)
            {
                erroPrv.SetError(txtNomeFantasia, "Campo Obrigatório!");
                houveErroValidacao = false;
            }
            if (txtRazaoSocial.Text.Trim().Count() == 0)
            {
                erroPrv.SetError(txtRazaoSocial, "Campo Obrigatório!");
                houveErroValidacao = false;
            }
            if (txtCnpj.Text.Trim().Count() == 0)
            {
                erroPrv.SetError(txtCnpj, "Campo Obrigatório!");
                houveErroValidacao = false;
            }

            return houveErroValidacao;
        }

        private void btnEditarPesq_Click(object sender, EventArgs e)
        {
            if (dgvPesquisar.Rows.Count > 0)
            {
                try
                {
                    int id = Convert.ToInt32(dgvPesquisar.CurrentRow.Cells["idPessoa"].Value);
                    PessoaJuridica pessoaJuridica = pJus.obterPessoaJuridica(id);
                    carregarDados(pessoaJuridica);
                    
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ação não permitida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void carregarDados(PessoaJuridica pesJurico)
        {
            lblNome.Text = pesJurico.Pessoa.nome.Trim() ;
            txtNomeFantasia.Text = pesJurico.nomeFantasia.Trim();
            txtRazaoSocial.Text = pesJurico.razaoSocial.Trim();
            txtCnpj.Text = pesJurico.CNPJ.Trim();
            txtEmail.Text = pesJurico.Pessoa.email == null ? string.Empty : pesJurico.Pessoa.email;
            idFornEditado = pesJurico.idPessoa;
            editandoFornecedor = true;
            Fornecedores.SelectedTab = tabDadosFornecedor;
            carregarGridEndereco();
            carregarGridTelefone();
        }
/*======FORNECEDOR FIM==========================================================================*/

/*======ENDERECO================================================================================*/
        private void carregarGridEndereco()
        {
            dgvEndereco.DataSource = null;
            dgvEndereco.Rows.Clear();
            dgvEndereco.Columns.Clear();

            dgvEndereco.DataSource = ender.obterEnderecoDaPessoa(idFornEditado);

            dgvEndereco.Columns["idEndereco"].HeaderText = "ID";
            dgvEndereco.Columns["complemento"].HeaderText = "RUA";

            dgvEndereco.Columns["idPessoa"].Visible = false;
            dgvEndereco.Columns["idCidade"].Visible = false;
            dgvEndereco.Columns["idTipoEndereco"].Visible = false;
            dgvEndereco.Columns["Cidade1"].Visible = false;
            dgvEndereco.Columns["Tipoendereco"].Visible = false;
            dgvEndereco.Columns["Unidadefederativa"].Visible = false;
            dgvEndereco.Columns["pessoa"].Visible = false;

            dgvEndereco.Columns["idEndereco"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            dgvEndereco.Columns["complemento"].DisplayIndex = 1;
        }

        private bool validaDadosEndereco()
        {
            bool houveErro = false;
            erroPrv.Clear();
            if (txtRua.Text.Trim().Count() == 0)
            {
                erroPrv.SetError(txtRua, "Campo Obrigatório!");
                houveErro = true;
            }
            if (txtNumero.Text.Trim().Count() == 0)
            {
                erroPrv.SetError(txtNumero, "Campo Obrigatório!");
                houveErro = true;
            }
            if (txtBairro.Text.Trim().Count() == 0)
            {
                erroPrv.SetError(txtBairro, "Campo Obrigatório!");
                houveErro = true;
            }
            if (txtCidade.Text.Trim().Count() == 0)
            {
                erroPrv.SetError(txtCidade, "Campo Obrigatório!");
                houveErro = true;
            }
            if (cbxEstado.SelectedIndex == -1)
            {
                erroPrv.SetError(cbxEstado, "Campo Obrigatório!");
                houveErro = true;
            }
            if (txtCEP.Text.Trim().Count() == 0)
            {
                erroPrv.SetError(txtCEP, "Campo Obrigatório!");
                houveErro = true;
            }
            if (idFornEditado == 0)
            {
                MessageBox.Show("Selecione antes um fornecedor","Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
                houveErro = true;
            }
            return houveErro;
        }

        private void limparTelaEndereco()
        {
            txtRua.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtCidade.Text = string.Empty;
            cbxEstado.SelectedIndex = -1;
            txtCEP.Text = string.Empty;
        }

        private void limparTelaFornecedor()
        {
            lblNome.Text = string.Empty;
            txtNomeFantasia.Text = string.Empty;
            txtRazaoSocial.Text = string.Empty;
            txtCnpj.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        private void alteraStatusTelaEndereco(statusTelaEndereco status)
        {
            statusEnderecoAtual = status;
            if (status == statusTelaEndereco.Editando)
            {
                btnNovoEnd.Enabled = false;
                btnEditarEnd.Enabled = false;
                btnDesativarEnd.Enabled = false;
                btnSalvarEnd.Enabled = true;

                txtRua.Enabled = true;
                txtNumero.Enabled = true;
                txtComplemento.Enabled = true;
                txtBairro.Enabled = true;
                txtCidade.Enabled = true;
                cbxEstado.Enabled = true;
                txtCEP.Enabled = true;

                dgvEndereco.Enabled = false;
            }
            else if(status == statusTelaEndereco.Inserindo)
            {
                btnNovoEnd.Enabled = false;
                btnEditarEnd.Enabled = false;
                btnDesativarEnd.Enabled = false;
                btnSalvarEnd.Enabled = true;

                txtRua.Enabled = true;
                txtNumero.Enabled = true;
                txtComplemento.Enabled = true;
                txtBairro.Enabled = true;
                txtCidade.Enabled = true;
                cbxEstado.Enabled = true;
                txtCEP.Enabled = true;

                dgvEndereco.Enabled = false;
            }
            else if(status == statusTelaEndereco.Visualizando)
            {
                btnNovoEnd.Enabled = true;
                btnEditarEnd.Enabled = true;
                btnDesativarEnd.Enabled = true;
                btnSalvarEnd.Enabled = false;

                txtRua.Enabled = false;
                txtNumero.Enabled = false;
                txtComplemento.Enabled = false;
                txtBairro.Enabled = false;
                txtCidade.Enabled = false;
                cbxEstado.Enabled = false;
                txtCEP.Enabled = false;

                dgvEndereco.Enabled = true;
            }
        }

        private void btnNovoEnd_Click(object sender, EventArgs e)
        {
            alteraStatusTelaEndereco(statusTelaEndereco.Inserindo);
            limparTelaEndereco();
            txtRua.Select();
        }

        private void carregarComboBoxUF()
        {
            cbxEstado.DataSource = uf.todasUnidadesFederativas();
            cbxEstado.DisplayMember = "nome";
            cbxEstado.ValueMember = "UF";
            cbxEstado.SelectedIndex = -1;
        }

        private void btnSalvarEnd_Click(object sender, EventArgs e)
        {
            if (txtRua.Text.Trim().Count() == 0 &&
                txtNumero.Text.Trim().Count() == 0 &&
                txtComplemento.Text.Trim().Count() == 0 &&
                txtBairro.Text.Trim().Count() == 0 &&
                txtCidade.Text.Trim().Count() == 0 &&
                cbxEstado.SelectedIndex == -1 &&
                txtCEP.Text.Trim().Count() == 0)
            {
                erroPrv.Clear();
                limparTelaEndereco();
                alteraStatusTelaEndereco(statusTelaEndereco.Visualizando);
            }
            else
            {
                if (statusEnderecoAtual == statusTelaEndereco.Inserindo)
                    inserirEndereco();
                else
                    editarEndereco();
            }
        }

        private void inserirEndereco()
        {
            if (!validaDadosEndereco())
            {
                try
                {
                    Endereco end = new Endereco();
                    //end.referencia = txtRua.Text.Trim();
                    end.numero = Convert.ToInt32(txtNumero.Text.Trim());
                    end.complemento = txtComplemento.Text.Trim().Count() == 0 ? null : txtComplemento.Text.Trim();
                    end.bairro = txtBairro.Text.Trim();
                    end.idTipoEndereco = 1; /*Falta cadastro*/
                    end.logradouro = txtRua.Text.Trim();
                    end.UF = cbxEstado.SelectedValue.ToString();

                    end.CEP = txtCEP.Text.Trim();
                    end.idPessoa = idFornEditado;
                    end.idCidade = buscarCidade();
                    end.idEndereco = ender.obterUltimoEndereco() == null ? 1 : ender.obterUltimoEndereco().idEndereco + 1;
                    string houveErro = ender.adicionarEndereco(end);
                    if (houveErro == null)
                    {
                        MessageBox.Show("O registro foi salvo com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limparTelaEndereco();
                        alteraStatusTelaEndereco(statusTelaEndereco.Visualizando);
                        carregarGridEndereco();
                        Fornecedores.SelectedTab = tabTelefone;
                    }
                    else
                    {
                        MessageBox.Show("O registro não pôde ser salvo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void editarEndereco()
        {
            //MessageBox.Show(dgvEndereco.CurrentRow.Cells["idEndereco"].Value.ToString());
            if (!validaDadosEndereco())
            {
                try
                {
                    Endereco end = ender.obterEndereco(Convert.ToInt32(dgvEndereco.CurrentRow.Cells["idEndereco"].Value));
                    end.referencia = txtRua.Text.Trim();
                    end.numero = Convert.ToInt32(txtNumero.Text.Trim());
                    end.complemento = txtComplemento.Text.Trim().Count() == 0 ? null : txtComplemento.Text.Trim();
                    end.bairro = txtBairro.Text.Trim();
                    end.idTipoEndereco = 1; /*Falta cadastro*/
                    end.logradouro = txtRua.Text.Trim();
                    end.UF = cbxEstado.SelectedValue.ToString();

                    end.CEP = txtCEP.Text.Trim();
                    end.idPessoa = idFornEditado;
                    end.idCidade = buscarCidade();
                    string houveErro = ender.editarEndereco(end);
                    if (houveErro == null)
                    {
                        MessageBox.Show("O registro foi salvo com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limparTelaEndereco();
                        alteraStatusTelaEndereco(statusTelaEndereco.Visualizando);
                        carregarGridEndereco();
                    }
                    else
                    {
                        MessageBox.Show("O registro não pôde ser salvo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private int buscarCidade()
        {
            CidadeData cid = new CidadeData(db);
            Cidade cidade = cid.obterCidade(txtCidade.Text.Trim());
            if (cidade == null)
            {
                Cidade cidadeNova = new Cidade();
                cidadeNova.nome = txtCidade.Text.Trim();
                cid.adicionarCidade(cidadeNova);
                cidade = null;
                cid = null;
                cid = new CidadeData(db);
                cidade = cid.obterCidade(txtCidade.Text.Trim());
            }
            return cidade.idCidade;
        }

        private void btnEditarEnd_Click(object sender, EventArgs e)
        {
            if (dgvPesquisar.Rows.Count > 0)
            {
                alteraStatusTelaEndereco(statusTelaEndereco.Editando);
                txtRua.Focus();

                Endereco endereco = ender.obterEndereco(Convert.ToInt32(dgvEndereco.CurrentRow.Cells["idEndereco"].Value));
                txtRua.Text = endereco.complemento.Trim();
                txtNumero.Text = endereco.numero.ToString().Trim();
                txtComplemento.Text = endereco.complemento.Trim();
                txtBairro.Text = endereco.bairro.Trim();
                txtCidade.Text = endereco.Cidade1.nome.Trim();
                cbxEstado.SelectedValue = endereco.UF.Trim();
                txtCEP.Text = endereco.CEP.Trim();
            }
        }

        private void btnDesativarEnd_Click(object sender, EventArgs e)
        {
            if (dgvEndereco.Rows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir o registro selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    Endereco endereco = ender.obterEndereco(Convert.ToInt32(dgvEndereco.CurrentRow.Cells["idEndereco"].Value));
                    ender.excluirEndereco(endereco);
                    carregarGridEndereco();
                }
            }
        }
/*======ENDERECO FIM============================================================================*/

/*======TELEFONE================================================================================*/
        private void alteraStatusTelaTelefone(statusTelaTelefone status)
        {
            statusTelefoneAtual = status;
            if (status == statusTelaTelefone.Editando)
            {
                btnNovoTel.Enabled = false;
                btnEditarTel.Enabled = false;
                btnDesativarTel.Enabled = false;
                btnSalvarTel.Enabled = true;

                txtNumeroTel.Enabled = true;
                cbxTipoTel.Enabled = true;

                dgvTelefone.Enabled = false;
                
            }
            else if(status == statusTelaTelefone.Inserindo)
            {
                btnNovoTel.Enabled = false;
                btnEditarTel.Enabled = false;
                btnSalvarTel.Enabled = true;
                btnDesativarTel.Enabled = false;

                txtNumeroTel.Enabled = true;
                cbxTipoTel.Enabled = true;

                dgvTelefone.Enabled = false;
            }
            else if(status == statusTelaTelefone.Visualizando)
            {
                btnNovoTel.Enabled = true;
                btnEditarTel.Enabled = true;
                btnSalvarTel.Enabled = false;
                btnDesativarTel.Enabled = true;

                txtNumeroTel.Enabled = false;
                cbxTipoTel.Enabled = false;

                dgvTelefone.Enabled = true;
            }
        }

        private void carregarComboTipoTelefone()
        {
            tipoTelofoneData = null;
            tipoTelofoneData = new TipoTelefoneData(db);
            cbxTipoTel.DataSource = tipoTelofoneData.todosTiposTelefones();
            cbxTipoTel.DisplayMember = "descricao";
            cbxTipoTel.ValueMember = "idTipoTelefone";
            cbxTipoTel.SelectedIndex = -1;
        }

        private void limparTelaTelefone()
        {
            txtNumeroTel.Text = string.Empty;
            cbxTipoTel.SelectedIndex = -1;
        }

        private void inserirTelefone()
        {
            if (!validaDadosTelefone())
            {
                Telefone tel = new Telefone();
                tel.numero = txtNumeroTel.Text.Trim();
                tel.idTipoTelefone = Convert.ToByte(cbxTipoTel.SelectedValue);
                tel.idPessoa = idFornEditado;
                string houveErro = telefonedata.salvarTelefone(tel);
                if (houveErro == null)
                {
                    MessageBox.Show("O registro foi salvo com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparTelaTelefone();
                    alteraStatusTelaTelefone(statusTelaTelefone.Visualizando);
                    carregarGridTelefone();
                }
                else
                {
                    MessageBox.Show("O registro não pôde ser salvo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void editarTelefone()
        {
            if (!validaDadosTelefone())
            {
                Telefone tel = telefonedata.obterTelefone(Convert.ToInt32(dgvTelefone.CurrentRow.Cells["idTelefone"].Value));
                tel.numero = txtNumeroTel.Text.Trim();
                tel.idTipoTelefone = Convert.ToByte(cbxTipoTel.SelectedValue);
                string houveErro = telefonedata.editarTelefone(tel);
                if (houveErro == null)
                {
                    MessageBox.Show("O registro foi salvo com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparTelaTelefone();
                    alteraStatusTelaTelefone(statusTelaTelefone.Visualizando);
                    carregarGridTelefone();
                }
                else
                {
                    MessageBox.Show("O registro não pôde ser salvo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalvarTel_Click(object sender, EventArgs e)
        {
            if (txtNumeroTel.Text.Trim().Count() == 0 && cbxTipoTel.SelectedIndex == -1)
            {
                erroPrv.Clear();
                limparTelaTelefone();
                alteraStatusTelaTelefone(statusTelaTelefone.Visualizando);
            }
            else
            {
                if (statusTelefoneAtual == statusTelaTelefone.Inserindo)
                    inserirTelefone();
                else
                    editarTelefone();
            }
        }

        private void btnNovoTel_Click(object sender, EventArgs e)
        {
            alteraStatusTelaTelefone(statusTelaTelefone.Inserindo);
            limparTelaTelefone();
            txtNumeroTel.Select();
        }

        private bool validaDadosTelefone()
        {
            bool houveErro = false;
            erroPrv.Clear();
            if (txtNumeroTel.Text.Trim().Count() == 0)
            {
                erroPrv.SetError(txtNumeroTel, "Campo Obrigatório!");
                houveErro = true;
            }
            if (cbxTipoTel.SelectedIndex == -1)
            {
                erroPrv.SetError(cbxTipoTel, "Campo Obrigatório!");
                houveErro = true;
            }
            return houveErro;
        }

        private void carregarGridTelefone()
        {
            dgvTelefone.DataSource = null;
            dgvTelefone.Rows.Clear();
            dgvTelefone.Columns.Clear();

            dgvTelefone.DataSource = telefonedata.obterTelefoneDaPessoa(idFornEditado);

            dgvTelefone.Columns["idPessoa"].Visible = false;
            dgvTelefone.Columns["idTipoTelefone"].Visible = false;
            dgvTelefone.Columns["Pessoa"].Visible = false;
            dgvTelefone.Columns["TipoTelefone"].Visible = false;
        }

        private void btnEditarTel_Click(object sender, EventArgs e)
        {
            if (dgvTelefone.Rows.Count > 0)
            {
                alteraStatusTelaTelefone(statusTelaTelefone.Editando);
                limparTelaTelefone();
                Telefone tel = telefonedata.obterTelefone(Convert.ToInt32(dgvTelefone.CurrentRow.Cells["idTelefone"].Value));
                txtNumeroTel.Text = tel.numero.Trim();
                cbxTipoTel.SelectedValue = tel.idTipoTelefone;
            }
        }

        private void btnDesativarTel_Click(object sender, EventArgs e)
        {
            if(dgvTelefone.Rows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir o registro selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
                {
                    Telefone telefone = telefonedata.obterTelefone(Convert.ToInt32(dgvTelefone.CurrentRow.Cells["idTelefone"].Value));
                    telefonedata.excluirTelefone(telefone);
                    carregarGridTelefone();
                }
            }
        }

        private void carregarGridPessoa()
        {

            dgvPesquisar.DataSource = null;
            dgvPesquisar.Rows.Clear();
            dgvPesquisar.Columns.Clear();

            
            dgvPesquisar.DataSource = pJus.buscarPessoaJurica(txtPesquisar.Text.Trim());
            formatarGrid();
        }



        private void btnDesatiivarPesq_Click(object sender, EventArgs e)
        {
            
        
            if (dgvPesquisar.Rows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir o registro selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    PessoaJuridica Pj = pJus.obterPessoaJuridica(Convert.ToInt32(dgvPesquisar.CurrentRow.Cells["idPessoa"].Value));
   
                    pJus.excluirPessoaJuridica(Pj);
                    carregarGridPessoa();


                }
            }
        
        }



/*======TELEFONE FIM============================================================================*/
    }
}
