using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjetoLojaData.Entity;
using ProjetoLojaData.Data;

namespace ProjetoLojaDesktop
{
    public partial class FormCadFuncionarios : Form
    {
        ProjetoLojaEntities db;
        private UsuarioData usuarioData;
        private TipoUsuarioData tipoUsuarioData;
        private PessoaData pessoaData;
        private TipoEnderecoData tipoEnderecoData;
        private EnderecoData enderecoData;
        private CidadeData cidadeData;
        private UF_Data ufData;
        private TipoTelefoneData tipoTelefoneData;
        private TelefoneData telefoneData;
        private PessoaFisicaData pessoaFisicaData;

        private Pessoa funcionario;
        private Endereco endereco;
        private Telefone telefone;

        public FormCadFuncionarios()
        {
            InitializeComponent();
            instanciarEntidadesDeFuncionario();
            instanciarClassesData();
            inicializarDataSources();
            endereco = new Endereco();
            telefone = new Telefone();
            atualizarListaDeFuncionarios();
            grpCadastrar.Enabled = false;
            ((Control)this.tabExtras).Enabled = false;
            tabExtras.Enabled = false;
        }

        private void instanciarClassesData()
        {
            db = new ProjetoLojaEntities();
            usuarioData = new UsuarioData(db);
            tipoUsuarioData = new TipoUsuarioData(db);
            pessoaData = new PessoaData(db);
            tipoEnderecoData = new TipoEnderecoData(db);
            enderecoData = new EnderecoData(db);
            cidadeData = new CidadeData(db);
            ufData = new UF_Data(db);
            tipoTelefoneData = new TipoTelefoneData(db);
            telefoneData = new TelefoneData(db);
            pessoaFisicaData = new PessoaFisicaData(db);
        }

        private void inicializarDataSources()
        {
            cbxTipoEndereco.DataSource = tipoEnderecoData.todostipoenderecos();
            cbxTipoEndereco.DisplayMember = "descricao";
            cbxTipoEndereco.ValueMember = "idTipoEndereco";

            cbxUF.DataSource = ufData.todasUnidadesFederativas();
            cbxUF.DisplayMember = "nome";
            cbxUF.ValueMember = "UF";

            cbxCidade.DataSource = cidadeData.todasCidades();
            cbxCidade.DisplayMember = "nome";
            cbxCidade.ValueMember = "idCidade";

            cbxTipoUsuario.DataSource = tipoUsuarioData.todosTipoUsuarios();
            cbxTipoUsuario.DisplayMember = "descricao";
            cbxTipoUsuario.ValueMember = "idTipoUsuario";

            cbxTipoTelefone.DataSource = tipoTelefoneData.todosTiposTelefones();
            cbxTipoTelefone.DisplayMember = "descricao";
            cbxTipoTelefone.ValueMember = "idTipoTelefone";
        }

        //Formulário de Funcionário
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string texto = txtPesquisa.Text;

            if (texto.Length < 3)
            {
                List<Pessoa> pessoas = pessoaData.todasPessoaFisicasPorTipo(2);
                dgvFuncionarios.DataSource = pessoas;
            }
            else
            {
                List<Pessoa> pessoas = pessoaData.buscarPessoasFisicasPorNome(texto);
                dgvFuncionarios.DataSource = pessoas;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string erro = validarCamposFuncionario();

            if (erro == null)
            {
                setarValoresFuncionario();

                string retornoSalvar = usuarioData.salvarUsuario(funcionario);

                if (retornoSalvar == null)
                {
                    MessageBox.Show("Cadastrado com sucesso!", "Sucesso");
                    atualizarListaDeFuncionarios();
                    limparFormFuncionario();
                    grpCadastrar.Enabled = false;
                }
                else
                    MessageBox.Show("Erro ao cadastrar o funcionário!", "Erro");
            } 
            else {
                MessageBox.Show(erro, "Erro");    
            }
        }

        private void dgvFuncionarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            funcionario.idPessoa = ((Pessoa)dgvFuncionarios.CurrentRow.DataBoundItem).idPessoa;
            atualizarListaDeEnderecos();
            atualizarListaDeTelefones();
            tabFuncionarios.SelectedIndex = 1;
            tabExtras.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            grpCadastrar.Enabled = true;
            instanciarEntidadesDeFuncionario();
            limparFormFuncionario();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            grpCadastrar.Enabled = true;
            ((Control)this.tabExtras).Enabled = true;

            if (obterFuncionarioDaLista())
                setarFuncionarioNoFormulario();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botoes = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("Você realmente deseja excluir este funcionário?", "Confirmação de Exclusão", botoes, MessageBoxIcon.Stop);

            if (resultado == DialogResult.Yes)
            {
                if (obterFuncionarioDaLista())
                {
                    string retorno = pessoaData.excluirPessoaFisica(funcionario);

                    if (retorno == null)
                    {
                        MessageBox.Show("Funcionário excluido com sucesso!", "Sucesso");
                        atualizarListaDeFuncionarios();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir o funcionário: " + retorno, "Erro");
                    }
                }
            }
        }

        private void instanciarEntidadesDeFuncionario()
        {
            funcionario = new Pessoa();
            funcionario.Usuario = new Usuario();
            funcionario.PessoaFisica = new PessoaFisica();
        }

        private void setarFuncionarioNoFormulario()
        {
            txtNome.Text = funcionario.nome;
            txtEmail.Text = funcionario.email;
            mtxtCPF.Text = funcionario.PessoaFisica.CPF;
            txtRG.Text = funcionario.PessoaFisica.RG;
            txtSenha.Text = funcionario.Usuario.senha;
            cbxTipoUsuario.SelectedValue = funcionario.Usuario.idTipoUsuario;
        }

        private string validarCamposFuncionario()
        {
            if (txtNome.Text == "")
                return "Nome não pode ser vazio!";
            if (txtEmail.Text == "")
                return "E-mail não pode ser vazio!";
            if (mtxtCPF.TextLength < 11)
                return "O CPF deve ter 11 dígitos!";
            if (cbxTipoUsuario.SelectedIndex == -1)
                return "Selecione um tipo de usuário!";
            if (txtRG.Text == "")
                return "RG não pode ser vazio!";
            if (txtSenha.Text == "")
                return "Senha não pode ser vazia!";
            if (pessoaFisicaData.verificarCPF(funcionario.idPessoa, mtxtCPF.Text) == false)
                return "Já existe um CPF com esse número!";

            return null;
        }

        private bool obterFuncionarioDaLista()
        {
            if (dgvFuncionarios.CurrentRow != null)
            {
                funcionario = (Pessoa) dgvFuncionarios.CurrentRow.DataBoundItem;
                return true;
            }
            else
            {
                MessageBox.Show("Selecione um funcionário antes.", "Erro");
                return false;
            }
        }

        private void limparFormFuncionario()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            mtxtCPF.Text = "";
            txtRG.Text = "";
            txtSenha.Text = "";
            cbxTipoUsuario.SelectedValue = -1;
            instanciarEntidadesDeFuncionario();
        }

        private void setarValoresFuncionario()
        {
            if (funcionario.idPessoa == 0)
            {
                funcionario = new Pessoa();
                funcionario.PessoaFisica = new PessoaFisica();
                funcionario.Usuario = new Usuario();
            }

            funcionario.idTipoPessoa = 2; // 2 é o ID do TipoPessoa funcionário
            funcionario.nome = txtNome.Text;
            funcionario.email = txtEmail.Text;
            funcionario.Usuario.senha = txtSenha.Text;
            funcionario.Usuario.idTipoUsuario = (int)cbxTipoUsuario.SelectedValue;
            funcionario.PessoaFisica.CPF = mtxtCPF.Text;
            funcionario.PessoaFisica.RG = txtRG.Text;
        }
       
        private void atualizarListaDeFuncionarios()
        {
            List<Pessoa> pessoaFisicas = pessoaData.todasPessoaFisicasPorTipo(2);
            dgvFuncionarios.DataSource = pessoaFisicas;
            dgvFuncionarios.Columns[0].Visible = false;
            dgvFuncionarios.Columns[3].Visible = false;
            dgvFuncionarios.Columns[4].Visible = false;
            dgvFuncionarios.Columns[5].Visible = false;
            dgvFuncionarios.Columns[6].Visible = false;
            dgvFuncionarios.Columns[7].Visible = false;
            dgvFuncionarios.Columns[8].Visible = false;
            dgvFuncionarios.Columns[9].Visible = false;
            dgvFuncionarios.Columns[10].Visible = false;
            dgvFuncionarios.Columns[11].Visible = false;

            dgvFuncionarios.Columns[1].HeaderText = "Nome";
            dgvFuncionarios.Columns[1].Width = 304;
            dgvFuncionarios.Columns[2].HeaderText = "E-mail";
            dgvFuncionarios.Columns[2].Width = 304;
        }

        //Formulário de Endereço
        private void btnEditarEndereco_Click(object sender, EventArgs e)
        {
            if (obterEnderecoDaLista())
                setarEnderecoNoFormulario();
        }

        private void btnExcluirEndereco_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botoes = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("Você realmente deseja excluir este endereço?", "Confirmação de Exclusão", botoes, MessageBoxIcon.Stop);

            if (resultado == DialogResult.Yes)
            {
                if (obterEnderecoDaLista())
                {
                    string retorno = enderecoData.excluirEndereco(endereco);

                    if (retorno == null)
                    {
                        MessageBox.Show("Endereço excluido com sucesso!", "Sucesso");
                        limparFormEndereco();
                        atualizarListaDeEnderecos();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir o endereço: " + retorno, "Erro");
                    }
                }
            }
        }

        private void btnNovoEndereco_Click(object sender, EventArgs e)
        {
            limparFormEndereco();
        }

        private void btnSalvarEndereco_Click(object sender, EventArgs e)
        {
            string retornoValidacao = validarCamposEndereco();

            if (retornoValidacao == null)
            {
                preencherEndereco();
                string retornoSalvar = null;

                if (endereco.idEndereco == 0)

                    retornoSalvar = enderecoData.adicionarEndereco(endereco);
                else
                    retornoSalvar = enderecoData.editarEndereco(endereco);

                if (retornoSalvar == null)
                {
                    MessageBox.Show("Endereço salvo com sucesso!", "Sucesso");
                    limparFormEndereco();
                    atualizarListaDeEnderecos();
                }
                else
                    MessageBox.Show("Erro ao salvar o endereço: " + retornoSalvar, "Erro");
            }
            else
            {
                MessageBox.Show(retornoValidacao, "Erro");
            }
        }

        private bool obterEnderecoDaLista()
        {
            if (dgvEndereco.CurrentRow != null)
            {
                endereco = (Endereco)dgvEndereco.CurrentRow.DataBoundItem;
                return true;
            }
            else
            {
                MessageBox.Show("Selecione um endereço antes.", "Erro");
                return false;
            }
        }

        private void setarEnderecoNoFormulario()
        {
            cbxTipoEndereco.SelectedValue = endereco.idTipoEndereco;
            cbxUF.SelectedValue = endereco.UF;
            cbxCidade.SelectedValue = endereco.idCidade;
            txtLogradouro.Text = endereco.logradouro;
            txtNumero.Text = endereco.numero.ToString();
            txtComplemento.Text = endereco.complemento;
            txtReferencia.Text = endereco.referencia;
            txtBairro.Text = endereco.bairro;
            mtxtCEP.Text = endereco.CEP;
        }

        private void atualizarListaDeEnderecos()
        {
            dgvEndereco.DataSource = enderecoData.listarEnderecosPorPessoa(funcionario.idPessoa);

            dgvEndereco.Columns[0].Visible = false;
            dgvEndereco.Columns[1].Visible = false;
            dgvEndereco.Columns[8].Visible = false;
            dgvEndereco.Columns[10].Visible = false;
            dgvEndereco.Columns[11].Visible = false;
            dgvEndereco.Columns[12].Visible = false;
            dgvEndereco.Columns[13].Visible = false;
            dgvEndereco.Columns[14].Visible = false;

            dgvEndereco.Columns[2].HeaderText = "Logradouro";
            dgvEndereco.Columns[2].Width = 153;
            dgvEndereco.Columns[3].HeaderText = "Número";
            dgvEndereco.Columns[3].Width = 50;
            dgvEndereco.Columns[4].HeaderText = "Complemento";
            dgvEndereco.Columns[4].Width = 75;
            dgvEndereco.Columns[5].HeaderText = "Referência";
            dgvEndereco.Columns[5].Width = 120;
            dgvEndereco.Columns[6].HeaderText = "Bairro";
            dgvEndereco.Columns[7].HeaderText = "UF";
            dgvEndereco.Columns[7].Width = 30;
            dgvEndereco.Columns[9].HeaderText = "CEP";
            dgvEndereco.Columns[9].Width = 80;

        }

        private void limparFormEndereco()
        {
            endereco = new Endereco();
            cbxTipoEndereco.SelectedIndex = 0;
            cbxUF.SelectedIndex = 0;
            cbxCidade.SelectedIndex = 0;
            txtLogradouro.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtReferencia.Text = "";
            txtBairro.Text = "";
            mtxtCEP.Text = "";
        }

        private string validarCamposEndereco()
        {
            if (cbxTipoEndereco.SelectedIndex == -1)
                return "Selecione um tipo de endereço";
            if (cbxUF.SelectedIndex == -1)
                return "Selecione um estado";
            if (cbxCidade.SelectedIndex == -1)
                return "Selecione uma cidade";
            if (txtLogradouro.Text == "")
                return "Preencha o campo logradouro";
            if (txtNumero.Text == "")
                return "Preencha o campo número do endereço";
            if (txtBairro.Text == "")
                return "Preencha o campo bairro";
            if (mtxtCEP.Text == "" || mtxtCEP.Text.Length < 8)
                return "Digite um CEP válido";

            return null;
        }

        private Endereco preencherEndereco()
        {
            if (endereco.idEndereco == 0)
            {
                endereco = new Endereco();
            }

            endereco.idPessoa = funcionario.idPessoa;
            endereco.idTipoEndereco = (byte) cbxTipoEndereco.SelectedValue;
            endereco.logradouro = txtLogradouro.Text;
            endereco.numero = Int32.Parse(txtNumero.Text);
            endereco.complemento = txtComplemento.Text;
            endereco.referencia = txtReferencia.Text;
            endereco.bairro = txtBairro.Text;
            endereco.CEP = mtxtCEP.Text;
            endereco.UF =  cbxUF.SelectedValue.ToString();
            endereco.idCidade = (int) cbxCidade.SelectedValue;

            return endereco;
        }

        //Formulário de Telefone
        private void btnNovoTelefone_Click(object sender, EventArgs e)
        {
            limparFormTelefone();
        }

        private void btnSalvarTelefone_Click(object sender, EventArgs e)
        {
            string retornoValidacao = validarCamposTelefone();

            if (retornoValidacao == null)
            {
                preencherTelefone();
                string retornoSalvar = null;

                if (telefone.idTelefone == 0)
                    retornoSalvar = telefoneData.salvarTelefone(telefone);
                else
                    retornoSalvar = telefoneData.editarTelefone(telefone);

                if (retornoSalvar == null)
                {
                    MessageBox.Show("Telefone salvo com sucesso!", "Sucesso");
                    limparFormTelefone();
                    atualizarListaDeTelefones();
                }
                else
                    MessageBox.Show("Erro ao salvar o telefone: " + retornoSalvar, "Erro");
            }
            else
            {
                MessageBox.Show(retornoValidacao, "Erro");
            }
        }

        private void btnEditarTelefone_Click(object sender, EventArgs e)
        {
            if (obterTelefoneDaLista())
                setarTelefoneNoFormulario();
        }

        private void btnExcluirTelefone_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botoes = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("Você realmente deseja excluir este telefone?", "Confirmação de Exclusão", botoes, MessageBoxIcon.Stop);

            if (resultado == DialogResult.Yes)
            {
                if (obterTelefoneDaLista())
                {
                    string retorno = telefoneData.excluirTelefone(telefone);

                    if (retorno == null)
                    {
                        MessageBox.Show("Telefone excluido com sucesso!", "Sucesso");
                        limparFormTelefone();
                        atualizarListaDeTelefones();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir o telefone: " + retorno, "Erro");
                    }
                }
            }
        }

        private string validarCamposTelefone()
        {
            if (cbxTipoTelefone.SelectedIndex == -1)
                return "Selecione um tipo de telefone";
            if (txtTelefone.Text == "" || txtTelefone.Text.Length < 14)
                return "Preencha o campo telefone";
            
            return null;
        }

        private bool obterTelefoneDaLista()
        {
            if (dgvTelefone.CurrentRow != null)
            {
                telefone = (Telefone)dgvTelefone.CurrentRow.DataBoundItem;
                return true;
            }
            else
            {
                MessageBox.Show("Selecione um telefone antes.", "Erro");
                return false;
            }
        }

        private void setarTelefoneNoFormulario()
        {
            cbxTipoTelefone.SelectedValue = telefone.idTipoTelefone;
            txtTelefone.Text = telefone.numero;
        }

        private void atualizarListaDeTelefones()
        {
            dgvTelefone.DataSource = telefoneData.listarTelefonesPorPessoa(funcionario.idPessoa);

            dgvTelefone.Columns[0].Visible = false;
            dgvTelefone.Columns[2].Visible = false;
            dgvTelefone.Columns[3].Visible = false;
            dgvTelefone.Columns[4].Visible = false;
            dgvTelefone.Columns[5].Visible = false;

            dgvTelefone.Columns[1].HeaderText = "Número";
            dgvTelefone.Columns[1].Width = 210;
        }

        private void limparFormTelefone()
        {
            telefone = new Telefone();
            cbxTipoTelefone.SelectedIndex = 0;
            txtTelefone.Text = "";
        }

        private Telefone preencherTelefone()
        {
            if (telefone.idTelefone == 0)
            {
                telefone = new Telefone();
            }

            telefone.idPessoa = funcionario.idPessoa;
            telefone.idTipoTelefone = (byte)cbxTipoTelefone.SelectedValue;
            telefone.numero = txtTelefone.Text;

            return telefone;
        }
    }
}
