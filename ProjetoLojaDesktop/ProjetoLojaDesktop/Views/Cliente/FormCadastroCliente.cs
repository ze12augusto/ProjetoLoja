using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjetoLojaData.Data;
using ProjetoLojaData.Entity;

namespace ProjetoLojaDesktop
{
    public partial class FormCadastroCliente : Form
    {
        private Pessoa pessoa;
        private CidadeData cidadeData;
        private EnderecoData enderecoData;
        private Endereco endereco;
        private PessoaData pessoaData;
        private PessoaFisicaData pessoaFisicaData;
        private PessoaFisica pessoaFisica;
        private PessoaJuridica pessoaJuridica;
        private PessoaJuridicaData pessoaJuridicaData;
        private TelefoneData telefoneData;
        private Telefone telefone;
        private Cidade cidade;
        private UnidadeFederativa uf;
        private TipoTelefone tipoTelefone;
        private TipoEnderecoData tipoEnderecoData;
        private TipoEndereco tipoEndereco;
        private TipoPessoaData tipoPessoaData;
        private TipoTelefoneData tipoTelefoneData;
        private UF_Data ufData;
        private ProjetoLojaEntities db;

        public FormCadastroCliente()
        {
            InitializeComponent();
            pessoa = new Pessoa();
            pessoaFisica = new PessoaFisica();
            pessoaJuridica = new PessoaJuridica();
            telefone = new Telefone();
            tipoTelefone = new TipoTelefone();
            endereco = new Endereco();
            cidade = new Cidade();
            uf = new UnidadeFederativa();
            tipoEndereco = new TipoEndereco();
            db = new ProjetoLojaEntities();
            this.pessoaData = new PessoaData(db);
            this.cidadeData = new CidadeData(db);
            this.enderecoData = new EnderecoData(db);
            this.pessoaFisicaData = new PessoaFisicaData(db);
            this.pessoaJuridicaData = new PessoaJuridicaData(db);
            this.telefoneData = new TelefoneData(db);
            this.tipoEnderecoData = new TipoEnderecoData(db);
            this.tipoPessoaData = new TipoPessoaData();
            this.tipoTelefoneData = new TipoTelefoneData(db);
            this.ufData = new UF_Data(db);
            
            tabDadosPessoais.Enabled = false;
            tabEndereco.Enabled = false;
            tabTelefone.Enabled = false;

            txtNomeFantasia.Enabled = false;
            txtRazaoSocial.Enabled = false;
            txtEmail.Enabled = false;
            txtRg.Enabled = false;
            txtCpf.Enabled = false;

            cbxTipoTelefone.DataSource = tipoTelefoneData.todosTiposTelefones();
            cbxTipoTelefone.DisplayMember = "descricao";
            cbxTipoTelefone.ValueMember = "idTipoTelefone";
            cbxUf.DataSource = ufData.todasUnidadesFederativas();            
            cbxUf.DisplayMember = "nome";
            cbxUf.ValueMember = "UF";
            cbxCidade.DataSource = cidadeData.todasCidades();
            cbxCidade.DisplayMember = "nome";
            cbxCidade.ValueMember = "idCidade";
            cbxTipoEndereco.DataSource = tipoEnderecoData.todostipoenderecos();
            cbxTipoEndereco.DisplayMember = "descricao";
            cbxTipoEndereco.ValueMember = "idTipoEndereco";
            
            atualizarPesquisaClientes(pessoaData.todasPessoas());
            inicializar();
        }

        private void inicializar()
        {
            preencherCbxTipoPessoa();
        }

        private void resetarCamposCliente()
        {
            pessoa = new Pessoa();
            pessoaFisica = new PessoaFisica();
            pessoaJuridica = new PessoaJuridica();
            cbxTipoPessoa.SelectedIndex = -1;
            txtRazaoSocial.Text = "";
            txtNomeFantasia.Text = "";
            txtEmail.Text = "";
            txtCpf.Text = "";
            txtRg.Text = "";
        }

        public void resetarEndereco()
        {
            endereco = new Endereco();
            txtLogradouro.Text = "";
            txtBairro.Text = "";
            txtNumero.Text = "";
            txtCep.Text = "";
            txtComplemento.Text = "";
            txtReferencia.Text = "";
            cbxTipoEndereco.SelectedIndex = -1;
            cbxCidade.SelectedIndex = -1;
        }

        public void resetarTelefone()
        {
            telefone = new Telefone();
            txtTelefone.Text = "";
            cbxTipoTelefone.SelectedIndex = -1;
        }

        public void limparTodosCampos()
        {
            resetarCamposCliente();
            resetarEndereco();
            resetarTelefone();
        }

        private void preencherCbxTipoPessoa()
        {
            cbxTipoPessoa.DataSource = tipoPessoaData.todasTipoPessoas();
            cbxTipoPessoa.DisplayMember = "descricao";
            cbxTipoPessoa.ValueMember = "idTipoPessoa";
        }

        public void obterDadosPessoais()
        {
            pessoaFisica = (PessoaFisica)pessoaFisicaData.obterPessoaFisica(pessoa.idPessoa);
            pessoaJuridica = (PessoaJuridica)pessoaJuridicaData.obterPessoaJuridica(pessoa.idPessoa);

            if (pessoa.idPessoa == 0)
            {
                pessoa = new Pessoa();
                pessoa.PessoaFisica = new PessoaFisica();
                pessoa.PessoaJuridica = new PessoaJuridica();
            }

            // 1 é o ID do TipoPessoa Cliente
            pessoa.idTipoPessoa = (byte)cbxTipoPessoa.SelectedValue;
            pessoa.nome = txtRazaoSocial.Text;
            pessoa.email = txtEmail.Text;

            if (cbxTipoPessoa.SelectedIndex == 0)
            {
                pessoa.PessoaFisica.CPF = txtCpf.Text;
                pessoa.PessoaFisica.RG = txtRg.Text;
                pessoa.PessoaJuridica = null;
                //cbxTipoPessoa.SelectedIndex = 0;
            }
            else
            {
                pessoa.PessoaJuridica.nomeFantasia = txtNomeFantasia.Text;
                pessoa.PessoaJuridica.CNPJ = txtCpf.Text;
                pessoa.PessoaJuridica.razaoSocial = txtRazaoSocial.Text;
                pessoa.PessoaFisica = null;
                //cbxTipoPessoa.SelectedIndex = 1;
            }
        }

        public void obterEndereco()
        {
            endereco.logradouro = txtLogradouro.Text;
            endereco.bairro = txtBairro.Text;
            endereco.CEP = txtCep.Text;
            endereco.idCidade = (int)cbxCidade.SelectedValue;
            endereco.referencia = txtReferencia.Text;
            endereco.numero = Convert.ToInt32(txtNumero.Text);
            endereco.complemento = txtComplemento.Text;
            endereco.UF = (string)cbxUf.SelectedValue;
            endereco.idTipoEndereco = (byte)cbxTipoEndereco.SelectedValue;
        }

        public void obterTelefone()
        {
            telefone.numero = txtTelefone.Text;
            telefone.idTipoTelefone = (byte)cbxTipoTelefone.SelectedValue;            
        }



        public void atualizarPesquisaClientes(List<Pessoa> pessoas)
        {
            var lista = from p in pessoas
                        join pf in pessoaFisicaData.todasPessoaFisicas()
                            on p.idPessoa equals pf.idPessoa
                        join pj in pessoaJuridicaData.todasPessoasJuridicas()
                            on p.idPessoa equals pj.idPessoa
                        select new
                        {
                            Pessoa = p,
                            Email = p.email,
                            CPF = pf.CPF,
                            CNPJ = pj.CNPJ
                        };
            
            dgvPesquisaCliente.DataSource = pessoas;
        }

        public void atualizarTelefone() 
        {
            List<Telefone> telefone = telefoneData.listarTelefonesPorPessoa(pessoa.idPessoa);
            dgvTelefone.DataSource = telefone;
            dgvTelefone.Columns[0].Visible = false;
            dgvTelefone.Columns[3].Visible = false;

            dgvTelefone.Columns[1].HeaderText = "TipoTelefone";
            dgvTelefone.Columns[1].Width = 304;
            dgvTelefone.Columns[2].HeaderText = "Telefone";
            dgvTelefone.Columns[2].Width = 304;
            
        }

        public void atualizarEndereco()
        {
            List<Endereco> enderecos = enderecoData.listarEnderecosPorPessoa(pessoa.idPessoa);
            dgvEndereco.DataSource = enderecos;
        }

        public void atribuirTelefone(Telefone t)
        {
            telefone = t;
            txtTelefone.Text = t.numero;
            cbxTipoTelefone.SelectedValue = t.idTipoTelefone;
        }

        public void atribuirEndereco(Endereco e)
        {
            endereco = e;
            txtLogradouro.Text = e.logradouro;
            txtBairro.Text = e.bairro;
            txtCep.Text = e.CEP;
            txtComplemento.Text = e.complemento;
            txtReferencia.Text = e.referencia;
            txtNumero.Text = e.numero.ToString();
            cbxCidade.SelectedValue = e.idCidade;
            cbxUf.SelectedValue = e.UF;
        }

        public void atribuirPessoa(Pessoa p)
        {
            pessoaFisica = (PessoaFisica)pessoaFisicaData.obterPessoaFisica(pessoa.idPessoa);
            pessoaJuridica = (PessoaJuridica)pessoaJuridicaData.obterPessoaJuridica(pessoa.idPessoa);

            txtRazaoSocial.Text = p.nome;
            txtEmail.Text = p.email;

            if ((pessoaFisica != null) && (pessoaJuridica == null))
            {
                txtCpf.Text = pessoaFisica.CPF;
                txtRg.Text = pessoaFisica.RG;
                cbxTipoPessoa.SelectedIndex = 0;
            }
            else
            {
                txtNomeFantasia.Text = pessoaJuridica.nomeFantasia;
                txtCpf.Text = pessoaJuridica.CNPJ;
                cbxTipoPessoa.SelectedIndex = 1;
            }
        }

        public string validarDadosPessoaisPF()
        {
            if (txtRazaoSocial.Text == null || txtRazaoSocial.Text == "")
            {
                return "Favor inserir um nome.";
            }
            if (txtEmail.Text == null || txtEmail.Text == "")
            {
                return "Favor inserir um e-mail.";
            }
            if (txtRg.Text == null || txtRg.Text == "")
            {
                return "Favor inserir um RG.";
            }
            if (txtCpf.Text.Replace("/", "").Replace(".", "").Replace("_", "").Replace(" ", "").Replace("-", "") == "")
            {
                return "Favor inserir um CPF.";
            }
            return null;
        }

        public string validarDadosPessoaisPJ()
        {
            if (txtRazaoSocial.Text == null || txtRazaoSocial.Text == "")
            {
                return "Favor inserir uma razão social.";
            }
            if (txtNomeFantasia.Text == null || txtNomeFantasia.Text == "")
            {
                return "Favor inserir um nome fantasia.";
            }
            if (txtEmail.Text == null || txtEmail.Text == "")
            {
                return "Favor inserir um e-mail.";
            }
            if (txtCpf.Text.Replace("/", "").Replace(".", "").Replace("_", "").Replace(" ", "").Replace("-", "") == "")
            {
                return "Favor inserir um CNPJ.";
            }
            return null;
        }

        public string validarEndereco()
        {
            if (txtLogradouro.Text == null || txtLogradouro.Text == "")
            {
                return "Favor inserir um logradouro.";
            }
            if (txtBairro.Text == null || txtBairro.Text == "")
            {
                return "Favor inserir um bairro.";
            }
            if (txtCep.Text == null || txtCep.Text == "")
            {
                return "Favor inserir um CEP.";
            }
            if (txtNumero.Text == null || txtNumero.Text == "")
            {
                return "Favor inserir um número.";
            }
            
            return null;
        }

        public string validarTelefone()
        {
            if (txtTelefone.Text.Replace("(", "").Replace(")","").Replace("_","").Replace(" ","").Replace("-","") == "")
            {
                return "Favor inserir um número.";
            }
            return null;
        }

        private void txtConsultaCliente_TextChanged(object sender, EventArgs e)
        {
            atualizarPesquisaClientes(pessoaData.pesquisarPessoaPorNome(txtConsultaCliente.Text));
        }

        private void cbx_tipoPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoPessoa.SelectedIndex == 0)
            {
                txtCpf.Enabled = true;
                txtCpf.Mask = "999,999,999-99";
                txtNomeFantasia.Enabled = false;
                txtRg.Enabled = true;
                txtRazaoSocial.Enabled = true;
                txtEmail.Enabled = true;

            }
            else 
            {
                txtCpf.Enabled = true;
                txtCpf.Mask = "99,999,999/9999-99";
                txtNomeFantasia.Enabled = true;
                txtRazaoSocial.Enabled = true;
                txtEmail.Enabled = true;
                txtRg.Enabled = false;
            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = !e.TabPage.Enabled;
            if(tabCadastroCliente.SelectedIndex == 0){
                tabDadosPessoais.Enabled = false;
                tabEndereco.Enabled = false;
                tabTelefone.Enabled = false;
            }
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabCadastroCliente.SelectedIndex = 0;
        }

        private void btnCancelarEndereco_Click(object sender, EventArgs e)
        {
            tabCadastroCliente.SelectedIndex = 0;
        }

        private void btnCancelarTelefone_Click(object sender, EventArgs e)
        {
            tabCadastroCliente.SelectedIndex = 0;
        }



        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            tabDadosPessoais.Enabled = true;
            tabCadastroCliente.SelectedIndex = 1;
            resetarCamposCliente();
        }



        private void btnSalvarDadosPessoais_Click(object sender, EventArgs e)
        {

            string retorno = null;
            if (Convert.ToInt32(cbxTipoPessoa.SelectedValue) == 1)
            {
                retorno = validarDadosPessoaisPF();
            }
            else
            {
                retorno = validarDadosPessoaisPJ();
            }

            if (retorno == null)
            {
                obterDadosPessoais();
                string erro = null;

                if (pessoa.idPessoa == 0)
                {

                    if (Convert.ToInt32(cbxTipoPessoa.SelectedValue) == 1)
                    {
                        erro = pessoaData.adicionarPessoaFisica(pessoa);
                    }
                    else if (Convert.ToInt32(cbxTipoPessoa.SelectedValue) == 2)
                    {
                        erro = pessoaData.adicionarPessoaJuridica(pessoa);
                    }
                }
                else
                {
                    erro = pessoaData.editarPessoa(pessoa);
                }

                if (erro == null)
                {
                    MessageBox.Show("Salvo com sucesso!");
                    atualizarPesquisaClientes(pessoaData.todasPessoas());
                    limparTodosCampos();
                    
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro: " + erro);
                }

                tabCadastroCliente.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show(retorno);
            }
            tabCadastroCliente.SelectedIndex = 1;
            
        }

        private void btnSalvarTelefone_Click(object sender, EventArgs e)
        {
            string retorno = validarTelefone();

            if (retorno == null)
            {
                obterTelefone();
                string erro = null;
                telefone.idPessoa = pessoa.idPessoa;
                if (telefone.idTelefone == 0)
                {

                    erro = telefoneData.salvarTelefone(telefone);
                }
                else
                {
                    erro = telefoneData.editarTelefone(telefone);
                }

                if (erro == null)
                {
                    MessageBox.Show("Salvo com sucesso!");
                    atualizarTelefone();
                    resetarTelefone();
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro: " + erro);
                }
            }
            else
            {
                MessageBox.Show(retorno);
            }
           

            tabCadastroCliente.SelectedIndex = 3;                                 
        }

        private void btnSalvarEndereco_Click(object sender, EventArgs e)
        {
            string retorno = validarEndereco();

            if (retorno == null)
            {
                obterEndereco();
                string erro = null;
                endereco.idPessoa = pessoa.idPessoa;
                if (endereco.idEndereco == 0)
                {

                    erro = enderecoData.adicionarEndereco(endereco);
                }
                else
                {
                    erro = enderecoData.editarEndereco(endereco);
                }

                if (erro == null)
                {
                    MessageBox.Show("Salvo com sucesso!");
                    atualizarEndereco();
                    resetarEndereco();
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro: " + erro);
                }
            }
            else
            {
                MessageBox.Show(retorno);
            }
            

            tabCadastroCliente.SelectedIndex = 2;          
          
        }

        private bool obterClienteDaLista()
        {
            if (dgvPesquisaCliente.CurrentRow != null)
            {
                pessoa = (Pessoa)dgvPesquisaCliente.CurrentRow.DataBoundItem;
                return true;
            }
            else
            {
                MessageBox.Show("Selecione um cliente antes.", "Erro");
                return false;
            }
        }
        private bool obterEndereçoDaLista()
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

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (obterClienteDaLista())
            {
                    atribuirPessoa(pessoa);
                    tabDadosPessoais.Enabled = true;
                    tabCadastroCliente.SelectedIndex = 1;
                    tabEndereco.Enabled = true;
                    tabTelefone.Enabled = true;
                    cbxTipoPessoa.Enabled = false;
            }
         }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            if (dgvPesquisaCliente.CurrentRow == null)
            {
                MessageBox.Show("Selecione um cliente para excluir!");
                return;
            }
            if (MessageBox.Show("Tem certeza que deseja excluir?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string erro = pessoaData.excluirPessoa((Pessoa)dgvPesquisaCliente.CurrentRow.DataBoundItem);
                if (erro == null)
                {
                    MessageBox.Show("Excluído com sucesso!");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro: " + erro);
                }
                atualizarPesquisaClientes(pessoaData.todasPessoas());
            }
        }

        private void btnEditarEndereco_Click(object sender, EventArgs e)
        {
            if (obterEndereçoDaLista())
            {
                atribuirEndereco(endereco);
                tabDadosPessoais.Enabled = true;
                tabCadastroCliente.SelectedIndex = 2;
                tabEndereco.Enabled = true;
                tabTelefone.Enabled = true;
                cbxTipoPessoa.Enabled = false;
            }
        }

      

        private void btnEditarTenefone_Click(object sender, EventArgs e)
            
        {
            if (obterTelefoneDaLista())
            {
                atribuirTelefone(telefone);
                tabDadosPessoais.Enabled = true;
                tabCadastroCliente.SelectedIndex = 3;
                tabEndereco.Enabled = true;
                tabTelefone.Enabled = true;
                cbxTipoPessoa.Enabled = false;
            }
        }

        private void btnExcluirEndereco_Click(object sender, EventArgs e)
        {
            if (dgvEndereco.CurrentRow == null)
            {
                MessageBox.Show("Selecione um endereço para excluir!");
                return;
            }
            if (MessageBox.Show("Tem certeza que deseja excluir?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string erro = enderecoData.excluirEndereco((Endereco)dgvEndereco.CurrentRow.DataBoundItem);
                if (erro == null)
                {
                    MessageBox.Show("Excluído com sucesso!");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro: " + erro);
                }
                atualizarEndereco();
            }
        }

        private void btnRemoverTelefone_Click(object sender, EventArgs e)
        {
            if (dgvTelefone.CurrentRow == null)
            {
                MessageBox.Show("Selecione um telefone para excluir!");
                return;
            }
            if (MessageBox.Show("Tem certeza que deseja excluir?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string erro = telefoneData.excluirTelefone((Telefone)dgvTelefone.CurrentRow.DataBoundItem);
                if (erro == null)
                {
                    MessageBox.Show("Excluído com sucesso!");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro: " + erro);
                }
                atualizarTelefone();
            }
        }

        private void btnNovoEndereco_Click(object sender, EventArgs e)
        {
            tabEndereco.Enabled = true;
            tabCadastroCliente.SelectedIndex = 2;         
            limparTodosCampos();
        }

        private void btnAdicionarTelefone_Click(object sender, EventArgs e)
        {
            tabTelefone.Enabled = true;
            tabCadastroCliente.SelectedIndex = 3;
            limparTodosCampos();
        }

        private void dgvPesquisaCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pessoa.idPessoa = ((Pessoa)dgvPesquisaCliente.CurrentRow.DataBoundItem).idPessoa;
            atualizarTelefone();
            atualizarEndereco();
            tabCadastroCliente.SelectedIndex = 2;

            tabDadosPessoais.Enabled = true;
            tabEndereco.Enabled = true;
            tabTelefone.Enabled = true;
        }

        private void dgvEndereco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            atualizarEndereco();
        }

        private void dgvTelefone_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            atualizarTelefone();
        }       
    }
}
