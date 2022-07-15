namespace Calculadora1
{
    public partial class MiniCalculadora : Form
    {
        public MiniCalculadora()
        {
            InitializeComponent();
        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {
                e.Handled = true;

            }
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            if ((txtNum1.Text != string.Empty) && (txtNum2.Text != string.Empty))
            {
                btnDivide.Enabled = true;
                btnSoma.Enabled = true;
                btnSubtrai.Enabled = true;
                btnMultiplica.Enabled = true;

            }
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            if ((txtNum1.Text != string.Empty) && (txtNum2.Text != string.Empty))
            {
                btnDivide.Enabled = true;
                btnSoma.Enabled = true;
                btnSubtrai.Enabled = true;
                btnMultiplica.Enabled = true;

            }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            float num1, num2, result;
            num1 = float.Parse(txtNum1.Text);
            num2 = float.Parse(txtNum2.Text);
            result = num1 + num2;
            txtResultado.Text = result.ToString();
        }

        private void btnSubtrai_Click(object sender, EventArgs e)
        {
            float num1, num2, result;
            num1 = float.Parse(txtNum1.Text);
            num2 = float.Parse(txtNum2.Text);
            result = num1 - num2;
            txtResultado.Text = result.ToString();
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            float num1, num2, result;
            num1 = float.Parse(txtNum1.Text);
            num2 = float.Parse(txtNum2.Text);
            result = num1 * num2;
            txtResultado.Text = result.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            float num1, num2, result;
            num1 = float.Parse(txtNum1.Text);
            num2 = float.Parse(txtNum2.Text);
            result = num1 / num2;
            txtResultado.Text = result.ToString();
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}