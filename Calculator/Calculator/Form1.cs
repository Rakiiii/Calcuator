using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtbIntegerPart_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                {
                    return;
                }
                else
                {
                    if (e.KeyChar == '-')
                    {
                        if ((txtbIntegerPart.Text.IndexOf('-') != -1))
                        {
                            e.Handled = true;
                            return;
                        }
                    }
                    else
                    {
                        if (e.KeyChar == '\b')
                        {
                            return;
                        }
                        if (e.KeyChar == (char)Keys.Enter)
                        {
                            txtbNumerator.Focus();
                        }
                        else
                        {
                            e.Handled = true;
                            return;
                        }
                    }
                }
            }
            catch(Exception InputE)
            {
                txtbIntegerPart.Text = "Ops you broke some thing";
            }
        }

        private void txtbNumerator_KeyPress(object sender, KeyPressEventArgs e)
        {
            try {
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                {
                    return;
                }
                else
                {
                    if (e.KeyChar == '-')
                    {
                        if ((txtbIntegerPart.Text.IndexOf('-') != -1))
                        {
                            e.Handled = true;
                            return;
                        }
                    }
                    else
                    {
                        if (e.KeyChar == '\b')
                        {
                            return;
                        }
                        if (e.KeyChar == (char)Keys.Enter)
                        {
                            txtbDenominator.Focus();
                        }
                        else
                        {
                            e.Handled = true;
                            return;
                        }
                    }
                }
            }
            catch(Exception InputE)
            {
                txtbNumerator.Text = "Ops you broke some thing";
            }
        }

        private void txtbOperation_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (((e.KeyChar == '+') || (e.KeyChar == '-') || (e.KeyChar == '/') || (e.KeyChar == '*')) && (txtbOperation.Text.Length == 0))
                {
                    return;
                }
                if((e.KeyChar == '\b') || (e.KeyChar == (char)Keys.Delete))
                {
                    return;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch(Exception InputE)
            {
                txtbOperation.Text = "Ops you broke some thing";
            }
        }

        private void txtbDenominator_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                {
                    return;
                }
                else
                {
                    if (e.KeyChar == '-')
                    {
                        if ((txtbIntegerPart.Text.IndexOf('-') != -1))
                        {
                            e.Handled = true;
                            return;
                        }
                    }
                    else
                    {
                        if (e.KeyChar == '\b')
                        {
                            return;
                        }
                        if (e.KeyChar == (char)Keys.Enter)
                        {
                            txtbOperation.Focus();
                        }
                        else
                        {
                            e.Handled = true;
                            return;
                        }
                    }
                }
            }
            catch(Exception InputE)
            {
                txtbDenominator.Text = "Ops you broke some thing";
            }
        }
    }
}
