using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Posot_de_Gasolina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
                        
        }



        private void rbtGasolinaComum_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtGasolinaComum.Checked == true)

            {
                rbtGasolinaAdtivada.Checked = false;
                rbtEtanol.Checked = false;
                lblCombustivelEscolhido.Text = "Gasolina Comum";

            }
        }

        private void rbtGasolinaAdtivada_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtGasolinaAdtivada.Checked == true)
            {
                rbtGasolinaComum.Checked = false;
                rbtEtanol.Checked = false;
                lblCombustivelEscolhido.Text = "Gasolina Adtivada";
            }
        }

        private void rbtEtanol_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtEtanol.Checked == true)
            {
                rbtGasolinaComum.Checked = false;
                rbtGasolinaAdtivada.Checked = false;
                lblCombustivelEscolhido.Text = "Etanol";
            }
        }

        decimal valor;
        decimal litros;
        decimal valorParcelas;
        decimal parcelas;
        private void txtLitros_TextChanged(object sender, EventArgs e)
        {            
            decimal comum = 4.79m;
            decimal adtivada = 6.29m;
            decimal etanol = 4.49m;
            

            if (rbtGasolinaComum.Checked == true && txtLitros.Text != "")
            {
                litros = Convert.ToDecimal(txtLitros.Text);
                valor = litros * comum;
                lblValorTotalaPagar.Text = valor.ToString("F");
            }   

            if (rbtGasolinaAdtivada.Checked == true && txtLitros.Text != "")
            {
                litros = Convert.ToDecimal(txtLitros.Text);
                valor = adtivada * litros;
                lblValorTotalaPagar.Text = valor.ToString("F");
            }

            if (rbtEtanol.Checked == true && txtLitros.Text != "" )
            {
                litros = Convert.ToDecimal(txtLitros.Text);
                valor = etanol * litros;
                lblValorTotalaPagar.Text = valor.ToString("F");
            }
            if (txtLitros.Text == "" && rbtGasolinaAdtivada.Checked == false && rbtEtanol.Checked == false && rbtGasolinaComum.Checked == false)
            {
                lblValorTotalaPagar.Text = "R$ 0,00";
            }
            
        }

        private void cboMetododePagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMetododePagamento.SelectedIndex == 3)
            {
                chkParcelamento.Enabled = true;
                chkParcelamento.Checked = false;
            }
            
        }

        
        

        private void cboParcelamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cboParcelamento.Enabled == true)
            {
                if (lblValorTotalaPagar.Text != "" && cboParcelamento.Text != "" && txtLitros.Text != "")
                {
                    
                    valor = Convert.ToDecimal(txtLitros.Text);
                    parcelas = Convert.ToDecimal(cboParcelamento.SelectedIndex);
                    valorParcelas = valor / parcelas;
                    lblTotalValorParcela.Text = valorParcelas.ToString("F");
                    
                }
               
            }
        }

        private void chkParcelamento_CheckedChanged(object sender, EventArgs e)
        {
            if (chkParcelamento.Checked == true)
            {
                cboParcelamento.Enabled = true;
            }
        }
        string combustivel;
        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            rbtEtanol.ForeColor = Color.Black;
            rbtGasolinaComum.ForeColor = Color.Black;
            rbtGasolinaAdtivada.ForeColor = Color.Black;
            lblLitros.ForeColor = Color.Black;
            lblMetododePagamento.ForeColor = Color.Black;
            chkParcelamento.ForeColor = Color.Black;

            if (lblValorTotalaPagar.Text != "" && txtLitros.Text != "" && cboMetododePagamento.Text != "")
            {
                if (cboMetododePagamento.SelectedIndex == 3 && chkParcelamento.Checked == true && cboParcelamento.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chkParcelamento.ForeColor = Color.Red;
                }
                else
                {
                    DialogResult = MessageBox.Show("Deseja finaizar a compra?", "", MessageBoxButtons.YesNo);

                    if (rbtGasolinaComum.Checked == true)
                    {
                        combustivel = lblGasolinaComum.Text;
                    }
                    if (rbtGasolinaAdtivada.Checked == true)
                    {
                        combustivel = lblGasolinaAdtivada.Text;
                    }
                    if (rbtEtanol.Checked == true)
                    {
                        combustivel = lblEtanol.Text;
                    }

                    switch (DialogResult)
                    {

                        case DialogResult.Ignore:
                            break;
                        case DialogResult.Yes:
                            dgvNota.Rows.Add(lblCombustivelEscolhido.Text, combustivel, txtLitros.Text, cboMetododePagamento.Text, cboParcelamento.Text, lblValorTotalaPagar.Text, dtpHora.Text);
                            
                            break;
                        case DialogResult.No:
                            break;
                    }
                }


                

            }
            else
            {
                MessageBox.Show("Preencha todos os campos", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (rbtEtanol.Checked == false && rbtGasolinaComum.Checked == false && rbtGasolinaAdtivada.Checked == false)
            {
                rbtEtanol.ForeColor = Color.Red;
                rbtGasolinaComum.ForeColor = Color.Red;
                rbtGasolinaAdtivada.ForeColor = Color.Red;
            }
            if (txtLitros.Text == "")
            {
                lblLitros.ForeColor = Color.Red;
            }
            if (cboMetododePagamento.Text == "")
            {
                lblMetododePagamento.ForeColor = Color.Red;
            }

            rbtGasolinaAdtivada.Checked = false;
            rbtGasolinaComum.Checked = false;
            rbtEtanol.Checked = false;
            lblCombustivelEscolhido.Text = "";
            txtLitros.Clear();
            cboMetododePagamento.Text = "";
            cboParcelamento.Text = "";
            lblValorTotalaPagar.Text = "0,00";
            lblTotalValorParcela.Text = "0,00";
            cboParcelamento.Enabled = false;
            chkParcelamento.Checked = false;

        }

        private void btnCancelarCompra_Click(object sender, EventArgs e)
        {
            rbtEtanol.ForeColor = Color.Black;
            rbtGasolinaComum.ForeColor = Color.Black;
            rbtGasolinaAdtivada.ForeColor = Color.Black;
            lblLitros.ForeColor = Color.Black;
            lblMetododePagamento.ForeColor = Color.Black;
            chkParcelamento.ForeColor = Color.Black;

            if (lblValorTotalaPagar.Text != "" && txtLitros.Text != "" && cboMetododePagamento.Text != "")
            {
                DialogResult = MessageBox.Show("Quer mesmo Cancelar a compra?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                switch (DialogResult)
                {

                    case DialogResult.Ignore:
                        break;
                    case DialogResult.Yes:
                        rbtGasolinaAdtivada.Checked = false;
                        rbtGasolinaComum.Checked = false;
                        rbtEtanol.Checked = false;
                        lblCombustivelEscolhido.Text = "";
                        txtLitros.Clear();
                        cboMetododePagamento.Text = "";
                        cboParcelamento.Text = "";
                        lblValorTotalaPagar.Text = "0,00";
                        lblTotalValorParcela.Text = "0,00";
                        break;
                    case DialogResult.No:
                        break;

                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (rbtEtanol.Checked == false && rbtGasolinaComum.Checked == false && rbtGasolinaAdtivada.Checked == false )
            {
                rbtEtanol.ForeColor = Color.Red;
                rbtGasolinaComum.ForeColor = Color.Red;
                rbtGasolinaAdtivada.ForeColor = Color.Red;
            }
            if (txtLitros.Text == "")
            {
                lblLitros.ForeColor = Color.Red;
            }
            if (cboMetododePagamento.Text == "")
            {
                lblMetododePagamento.ForeColor = Color.Red;
            }
            if (cboMetododePagamento.SelectedIndex == 3 && chkParcelamento.Checked == true && cboParcelamento.Text == ""  )
            {
                chkParcelamento.ForeColor = Color.Red;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvNota.Rows.Count > 0)
            {
                //Remover a linha selecionada ao DataGridView
                dgvNota.Rows.RemoveAt(dgvNota.CurrentRow.Index);
            }
        }

        private void dtpHora_ValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
