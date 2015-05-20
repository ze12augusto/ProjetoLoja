using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjetoLojaDesktop.Data;
using ProjetoLojaDesktop.Entity;
using CrystalDecisions.CrystalReports.Engine;

namespace ProjetoLojaDesktop.Views.Relatorios.Pagamento_Cartão
{
    public partial class FormRelatorioPagamentoCartao : Form
    {
        private TransacaoData transacaoData;
        private PagamentoData pagamentoData;
        private PagamentoCataoData pagamentoCartaoData;
        private ProjetoLojaEntities1 db;

        public FormRelatorioPagamentoCartao()
        {
            db = new ProjetoLojaEntities1();
        
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DateTime? dataInicio = null;
            DateTime? dataFim = null;

            if(chkDataInicio.Checked)
            {
                dataInicio= dtpDataInicio.Value;
            }
            if (chkDataFim.Checked)
            {
                dataFim = dtpDataFim.Value;
            }

            var lista = from p in db.Pagamento 
                        join t in db.Transacao on p.idTransacao equals t.idTransacao
                        join pc in db.PagamentoCartao on p.idTransacao equals pc.idTransacao
                        join pf in db.Pessoa on t.idCliente equals pf.idPessoa
                        where (dataInicio == null || p.Transacao.data >= dataInicio)
                        && (dataFim == null || p.Transacao.data >= dataFim)
                        select new
                        
                      {
                            IdCliente = pf.idPessoa,
                            Data = t.data,
                            NumeroTransacao = pc.numeroTransacao,
                            QuantidadeParcelas = pc.qtdParcelas,
                            TipoCartao = pc.tipoCartao,
                            ValorParcela = pc.valorParcela,
                            ValorTotao = p.valorTotal
                        };

                        

            ReportDocument rpt = new ReportDocument();
            rpt.FileName = "C:\\Documents and Settings\\a11025687\\Desktop\\ProjetoLoja-master\\ProjetoLojaDesktop\\ProjetoLojaDesktop\\Views\\Relatorios\\Produto\\ProdutoReport.rpt";
            rpt.SetDataSource(lista.ToList());
            rptProduto.ReportSource = rpt;
            tabPagamentoCartao.SelectedIndex = 1;
        }

     
        

        
   }
    }

