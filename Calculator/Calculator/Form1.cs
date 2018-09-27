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
    //TODO : написать вторую форму с лицензией
    public partial class Form1 : Form
    {
        Fraction firstFraction = new Fraction();
        Fraction secondFraction = new Fraction();
        String operation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //ввод операции о целой части
        private void txtbIntegerPart_KeyPress(object sender, KeyPressEventArgs e)
        {
            //отлавливаем случайные ошибки
            try
            {
                //отсеиваем все кроме чисел
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                {
                    return;
                }
                else
                {
                    //преверяем на минус
                    if (e.KeyChar == '-')
                    {
                        //если уже входил или пишется не первым,то не даем ввести
                        if ( (txtbIntegerPart.TextLength > 0) || (txtbIntegerPart.Text.IndexOf('-') != -1))
                        {
                                e.Handled = true;
                                return;   
                        }
                    }
                    else
                    {
                        //разарешаем удаление 
                        if (e.KeyChar == '\b')
                        {
                            return;
                        }
                        //двигаем фокус на следующий элемент
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
        //ввод информайии о числители 
        private void txtbNumerator_KeyPress(object sender, KeyPressEventArgs e)
        {
            try {
                //отсеиваем все кроме чисел
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                {
                    return;
                }
                else
                {
                    //проверяем все на минус
                    if (e.KeyChar == '-')
                    {
                        //блокируем ввод если не первый либо если уже введен
                        if ((txtbNumerator.TextLength > 0) || (txtbIntegerPart.Text.IndexOf('-') != -1))
                        {
                            e.Handled = true;
                            return;
                        }
                    }
                    else
                    {
                        //разрешаем удаление
                        if (e.KeyChar == '\b')
                        {
                            return;
                        }
                        //двигаем фокус по энтеру на следующий элемент
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
        //ввод информации об операции
        private void txtbOperation_KeyPress(object sender, KeyPressEventArgs e)
        {
            //отлавливаем случайные ошибки
            try
            {
                //запрещаем все кроме символов операции
                if (((e.KeyChar == '+') || (e.KeyChar == '-') || (e.KeyChar == '/') || (e.KeyChar == '*')) && (txtbOperation.Text.Length == 0))
                {
                    return;
                }
                //разрешаем удаление
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
        //ввод информации о знаменателе
        private void txtbDenominator_KeyPress(object sender, KeyPressEventArgs e)
        {
            //отлавливаем случайные ошибки
            try
            {
                //отсеиваем все не цифры
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                {
                    return;
                }
                else
                {
                    //проверяем на минус
                    if (e.KeyChar == '-')
                    {
                        //если не первый или ужее введен запрещаем ввод
                        if ( (txtbDenominator.TextLength > 0) || (txtbIntegerPart.Text.IndexOf('-') != -1))
                        {
                            e.Handled = true;
                            return;
                        }
                    }
                    else
                    {
                        //разрешаем удаление
                        if (e.KeyChar == '\b')
                        {
                            return;
                        }
                        //двигаем фокус
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
        //TODO : написать обраюотку ситуации нажатия на кнопку 0-9
        private void btnNumber1_Click(object sender, EventArgs e)
        {
            if( txtbIntegerPart.Focused)
            {
                txtbIntegerPart.Text += '1';
            }
        }
        //TODO : написать обработку нажатия на кнопку =
        private void btnOperationEqual_Click(object sender, EventArgs e)
        {

        }
        //обрабатываем нажатие на кнопку +
        private void btnOperationPlus_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                     (firstFraction.Numerator == 0) &&
                     (firstFraction.IntegerPart == 0) && 
                     (txtbIntegerPart.Text !="") &&
                     (txtbNumerator.Text != "") &&
                     (txtbDenominator.Text != "")
                    )
                {
                    //создаем новую дробь

                    firstFraction.SetFraction(integerPart: Convert.ToInt32(txtbIntegerPart.Text),
                        denominator: Convert.ToInt32(txtbDenominator.Text),
                        numerator: Convert.ToInt32(txtbNumerator.Text));

                    //чистим текст боксы

                    txtbIntegerPart.Text = "";
                    txtbNumerator.Text = "";
                    txtbDenominator.Text = "";


                }
            }
            catch(Exception b)
            { label1.Text = b.ToString(); }


            operation = "+";
            txtbOperation.Text = "+";
        }
        //TODO : написать обработку ситуации когда нажатием на кнопку надо поставить минус в значении дроби
        private void btnOperationMinus_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                     (firstFraction.Numerator == 0) &&
                     (firstFraction.IntegerPart == 0) &&
                     (txtbIntegerPart.Text != "") &&
                     (txtbNumerator.Text != "") &&
                     (txtbDenominator.Text != "")
                    )
                {
                    //создаем новую дробь

                    firstFraction.SetFraction(integerPart: Convert.ToInt32(txtbIntegerPart.Text),
                        denominator: Convert.ToInt32(txtbDenominator.Text),
                        numerator: Convert.ToInt32(txtbNumerator.Text));

                    //чистим текст боксы

                    txtbIntegerPart.Text = "";
                    txtbNumerator.Text = "";
                    txtbDenominator.Text = "";


                }
            }
            catch (Exception b)
            { label1.Text = b.ToString(); }


            operation = "-";
            txtbOperation.Text = "-";
        }
    

        private void btnOperationMultiplication_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                     (firstFraction.Numerator == 0) &&
                     (firstFraction.IntegerPart == 0) &&
                     (txtbIntegerPart.Text != "") &&
                     (txtbNumerator.Text != "") &&
                     (txtbDenominator.Text != "")
                    )
                {
                    //создаем новую дробь

                    firstFraction.SetFraction(integerPart: Convert.ToInt32(txtbIntegerPart.Text),
                        denominator: Convert.ToInt32(txtbDenominator.Text),
                        numerator: Convert.ToInt32(txtbNumerator.Text));

                    //чистим текст боксы

                    txtbIntegerPart.Text = "";
                    txtbNumerator.Text = "";
                    txtbDenominator.Text = "";


                }
            }
            catch (Exception b)
            { label1.Text = b.ToString(); }


            operation = "*";
            txtbOperation.Text = "*";
        }
    

        private void btnOperationDivision_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                     (firstFraction.Numerator == 0) &&
                     (firstFraction.IntegerPart == 0) &&
                     (txtbIntegerPart.Text != "") &&
                     (txtbNumerator.Text != "") &&
                     (txtbDenominator.Text != "")
                    )
                {
                    //создаем новую дробь

                    firstFraction.SetFraction(integerPart: Convert.ToInt32(txtbIntegerPart.Text),
                        denominator: Convert.ToInt32(txtbDenominator.Text),
                        numerator: Convert.ToInt32(txtbNumerator.Text));

                    //чистим текст боксы

                    txtbIntegerPart.Text = "";
                    txtbNumerator.Text = "";
                    txtbDenominator.Text = "";


                }
            }
            catch (Exception b)
            { label1.Text = b.ToString(); }


            operation = "/";
            txtbOperation.Text = "/";
        }
    
    }
}
