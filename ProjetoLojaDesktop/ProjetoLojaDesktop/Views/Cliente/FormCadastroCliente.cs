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
            
            
        }



        public void limparDadosPessoais()
        {
            txtNomeFantasia.Text = "";
            txtRazaoSocial.Text = "";
            txtEmail.Text = "";
            txtCpf.Text = "";
            txtRg.Text = "";
            txtEmail.Text = "";
            cbxTipoPessoa.SelectedIndex = -1;
        }

        public void limparEndereco()
        {
            txtLogradouro.Text = "";
            txtBairro.Text = "";
            txtNumero.Text = "";
            txtCep.Text = "";
            txtComplemento.Text = "";
            txtReferencia.Text = "";
            cbxTipoEndereco.SelectedIndex = -1;
            cbxCidade.SelectedIndex = -1;
        }

        public void limparTelefone()
        {
            txtNumero.Text = "";
            cbxTipoTelefone.SelectedIndex = -1;
        }

        public void limparTodosCampos()
        {
            limparDadosPessoais();
            limparEndereco();
            limparTelefone();
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
            pessoa.idTipoPessoa = 1; 
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
            
            dgvPesquisaCliente.Columns[0].Visible = false;
            dgvPesquisaCliente.Columns[1].HeaderText = "Nome";
        }

        public void atualizarTelefone(List<Telefone> telefones)

        {

            var lista = from t in telefones
                        join tp in tipoTelefoneData.todosTiposTelefones()
                        on t.idTipoTelefone equals tp.idTipoTelefone
                        join p in pessoaData.todasPessoas()
                        on t.idPessoa equals p.idPessoa
                        join pf in pessoaFisicaData.todasPessoaFisicas()
                            on t.idPessoa equals pf.idPessoa
                        join pj in pessoaJuridicaData.todasPessoasJuridicas()
                            on t.idPessoa equals pj.idPessoa
                        select new
                        {
                            Telefone = t,
                            Pessoa = p,
                            TipoTelefone = tp,
                            Nome = p.nome,                           
                           Numero = t.numero,
                           Tipo = tp.descricao
                        };
            
            
            dgvTelefone.DataSource = telefones;

            dgvTelefone.Columns[0].Visible = false;
            dgvTelefone.Columns[1].HeaderText = "Nome";
        }

        public void atualizarEndereco(List<Endereco> enderecos)
        {
            var lista = from e in enderecos
                        join p in pessoaData.todasPessoas()
                        on e.idPessoa equals p.idPessoa
                        join pf in pessoaFisicaData.todasPessoaFisicas()
                            on e.idPessoa equals pf.idPessoa
                        join pj in pessoaJuridicaData.todasPessoasJuridicas()
                            on e.idPessoa equals pj.idPessoa
                        join c in cidadeData.todasCidades()
                        on e.idCidade equals c.idCidade
                        select new
                        {
                            Endereco = e,
                            Pessoa = p,
                            Nome = p.nome,
                           Bairro = e.bairro,
                           Cidade = c,
                           Numero = e.numero                      
                        };
            dgvEndereco.DataSource = enderecos;

            dgvEndereco.Columns[0].Visible = false;
            dgvEndereco.Columns[1].HeaderText = "Nome";
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

        public bool validarDadosPessoaisPF()
        {
            if (txtRazaoSocial.Text == null || txtRazaoSocial.Text == "")
            {
                MessageBox.Show("Favor inserir um nome.");
                return false;
            }
            if (txtEmail.Text == null || txtEmail.Text == "")
            {
                MessageBox.Show("Favor inserir um e-mail.");
                return false;
            }
            if (txtRg.Text == null || txtRg.Text == "")
            {
                MessageBox.Show("Favor inserir um RG.");
                return false;
            }
            if (txtCpf.Text == null || txtCpf.Text == "")
            {
                MessageBox.Show("Favor inserir um CPF.");
                return false;
            }
            return true;
        }

        public bool validarDadosPessoaisPJ()
        {
            if (txtRazaoSocial.Text == null || txtRazaoSocial.Text == "")
            {
                MessageBox.Show("Favor inserir uma razão social.");
                return false;
            }
            if (txtNomeFantasia.Text == null || txtNomeFantasia.Text == "")
            {
                MessageBox.Show("Favor inserir um nome fantasia.");
                return false;
            }
            if (txtEmail.Text == null || txtEmail.Text == "")
            {
                MessageBox.Show("Favor inserir um e-mail.");
                return false;
            }
            if (txtCpf.Text == null || txtCpf.Text == "")
            {
                MessageBox.Show("Favor inserir um CNPJ.");
                return false;
            }
            return true;
        }

        public bool validarEndereco()
        {
            if (txtLogradouro.Text == null || txtLogradouro.Text == "")
            {
                MessageBox.Show("Favor inserir um logradouro.");
                return false;
            }
            if (txtBairro.Text == null || txtBairro.Text == "")
            {
                MessageBox.Show("Favor inserir um bairro.");
                return false;
            }
            if (txtCep.Text == null || txtCep.Text == "")
            {
                MessageBox.Show("Favor inserir um CEP.");
                return false;
            }
            if (txtNumero.Text == null || txtNumero.Text == "")
            {
                MessageBox.Show("Favor inserir um número.");
                return false;
            }
            if (cbxCidade.SelectedValue == null || (int) cbxCidade.SelectedValue == 0)
            {
                MessageBox.Show("Favor selecionar uma cidade.");
                return false;
            }
            if (cbxUf.SelectedValue == null || (int)cbxUf.SelectedValue == 0)
            {
                MessageBox.Show("Favor selecionar uma UF.");
                return false;
            }
            return true;
        }

        public bool validarTelefone()
        {
            if (txtNumero.Text == null || txtNumero.Text == "")
            {
                MessageBox.Show("Favor inserir um número.");
                return false;
            }
            //if(cbxTipoTelefone.SelectedValue == null || (int) cbxTipoTelefone.SelectedValue == 0)
            //{
            //    MessageBox.Show("Favor selecionar um tipo de telefone.");
            //    return false;
            //}
            return true;
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
            pessoa = new Pessoa();
            tabDadosPessoais.Enabled = true;
            tabCadastroCliente.SelectedIndex = 1;
        }



        private void btnSalvarDadosPessoais_Click(object sender, EventArgs e)
        {
            obterDadosPessoais();
            string erro = null;

            if ((int)cbxTipoPessoa.SelectedIndex == 0)
            {
                erro = pessoaData.adicionarPessoaFisica(pessoa);
            }
            else
            {
                erro = pessoaData.adicionarPessoaJuridica(pessoa);
            }

                if (erro == null)
                {
                    MessageBox.Show("Salvo com sucesso!");
                    atualizarPesquisaClientes(pessoaData.todasPessoas());
                    limparDadosPessoais();
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro: " + erro);
                }
            tabCadastroCliente.SelectedIndex = 2;
        }

        private void btnSalvarTelefone_Click(object sender, EventArgs e)
        {
            obterTelefone();
            if (validarTelefone())
            {
                telefone.idPessoa = pessoa.idPessoa;
                string erro = telefoneData.salvarTelefone(telefone);
                if (erro == null)
                {
                    MessageBox.Show("Salvo com sucesso!");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro: " + erro);
                }
            }
            atualizarTelefone(pessoa.Telefone.ToList());
            atualizarPesquisaClientes(pessoaData.todasPessoas());
            limparTelefone();
        }

        private void btnSalvarEndereco_Click(object sender, EventArgs e)
        {
            obterEndereco();
            endereco.idPessoa = pessoa.idPessoa;
            string erro = enderecoData.adicionarEndereco(endereco);
            if (erro == null)
            {
                MessageBox.Show("Salvo com sucesso");
            }
            else
            {
                MessageBox.Show("Ocorreu um erro:" + erro);
            }
            atualizarEndereco(pessoa.Endereco.ToList());
            atualizarPesquisaClientes(pessoaData.todasPessoas());
            limparEndereco();
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

      
        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (obterClienteDaLista())
            {
                atribuirPessoa(pessoa);
                tabDadosPessoais.Enabled = true;
                tabCadastroCliente.SelectedIndex = 1;
                tabEndereco.Enabled = true;
                tabTelefone.Enabled = true;
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
            if (dgvEndereco.CurrentRow == null)
            {
                MessageBox.Show("Selecione um endereço para editar!");
                return;
            }
            atribuirEndereco((Endereco)dgvEndereco.CurrentRow.Cells[0].Value);
        }

        private void btnEditarTenefone_Click(object sender, EventArgs e)
            
        {
         if (dgvTelefone.CurrentRow == null)
            {
                MessageBox.Show("Selecione um telefone para editar!");
                return;
            }
         atribuirTelefone((Telefone)dgvTelefone.CurrentRow.Cells[0].Value);
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
                atualizarEndereco(enderecoData.todosEnderecos());
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
                atualizarTelefone(telefoneData.todosTelefones());
            }
        }       
    }
}
