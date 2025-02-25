using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMelhoradaMelhora
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btResult.Enabled = false;
            btSegue.Enabled = false;
            lblOperResult.Text = "Select some operaton";
        }

        public void lblStatus(string op)
        {
            lblOper.Text = op;
        }

        private void btMais_Click(object sender, EventArgs e)
        {
            lblStatus(btMais.Text);
            Conditions();
        }

        private void btMenos_Click(object sender, EventArgs e)
        {
            lblStatus(btMenos.Text);
            Conditions();
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            lblStatus(btDiv.Text);
            Conditions();
        }

        private void btMulti_Click(object sender, EventArgs e)
        {
            lblStatus(btMulti.Text);
            Conditions();
        }

         private void btExp_Click(object sender, EventArgs e)
        {
            lblStatus(btExp.Text);
            Conditions();
        }

        public void Conditions()
        {
            if (oP2.Value == 0 && lblOper.Text == btDiv.Text || oP1.Value == 0 && oP2.Value == 0 && lblOper.Text == btExp.Text)
            {
                btResult.Enabled = false;
                lblOperResult.Text = "indeterminate";
            }
            else if(lblOper.Text.Length > 0)
            {
                btResult.Enabled = true;
                lblOperResult.Text = "";
            }
            
                
        }

        public decimal expo(decimal a, decimal b)
        {
            decimal result = 1;
            if (b >= 0)
                for (int i = 0; i < b; i++)
                    result *= a;
            else
                for (int i = 0; i > b; i--)
                    result /= a;
                return result;
        }

        private void oP2_ValueChanged(object sender, EventArgs e)
        {
            Conditions();
        }

        private void oP1_ValueChanged(object sender, EventArgs e)
        {
            Conditions();
        }

        private void OpResult_Click(object sender, EventArgs e)
        {

        }

        private void btSegue_Click(object sender, EventArgs e)
        {
            btSegue.Enabled = false;
            try
            {
                oP1.Value = Decimal.Parse(lblOperResult.Text);
            }
            catch(Exception a)
            {
                lblOperResult.Text = $"ERROR:{a.Message}";
                
            }
        }

        private void btLimpa_Click(object sender, EventArgs e)
        {
            oP1.Value = 0;
            oP2.Value = 0;
            lblOper.Text = "";
            lblOperResult.Text = "Select some operation";
            btResult.Enabled = false;
        }

        private void btResult_Click(object sender, EventArgs e)
        {
            btSegue.Enabled = true;
            try
            {
                if (lblOper.Text == btMais.Text)
                    lblOperResult.Text = (oP1.Value + oP2.Value).ToString();
                if (lblOper.Text == btMenos.Text)
                    lblOperResult.Text = (oP1.Value - oP2.Value).ToString();
                if (lblOper.Text == btDiv.Text)
                    lblOperResult.Text = (oP1.Value / oP2.Value).ToString();
                if (lblOper.Text == btMulti.Text)
                    lblOperResult.Text = (oP1.Value * oP2.Value).ToString();
                if (lblOper.Text == btExp.Text)
                    lblOperResult.Text = (expo(oP1.Value, oP2.Value)).ToString();
            }
            catch (Exception a)
            {
                lblOperResult.Text = $"ERROR: {a.Message}";
            }
        }
    }
}
