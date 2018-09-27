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
        Fraction result = new Fraction(1,1,1);
        String operation = "";
        Control lastFocus;
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
                            lastFocus = txtbNumerator;
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

            try
            {
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
                        if ((txtbNumerator.TextLength > 0) || (txtbNumerator.Text.IndexOf('-') != -1))
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
                            lastFocus = txtbDenominator;
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
                if((txtbOperation.Text != "") && (e.KeyChar == (char)Keys.Enter))
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

                        txtbIntegerPart.Focus();
                        lastFocus = txtbIntegerPart;

                    }
                    else
                    {
                        btnOperationEqual.Focus();
                    }
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
                    if((e.KeyChar == '0') && (txtbDenominator.Text.Length == 0))
                    {
                        e.Handled = true;
                    }
                    return;
                }
                else
                {
                    //проверяем на минус
                    if (e.KeyChar == '-')
                    {
                        //если не первый или ужее введен запрещаем ввод
                        if ( (txtbDenominator.TextLength > 0) || (txtbDenominator.Text.IndexOf('-') != -1))
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
        // обраюотку ситуации нажатия на кнопку 0-9
        private void btnNumber1_Click(object sender, EventArgs e)
        {
            if (lastFocus != txtbOperation)
            { 
                lastFocus.Text += '1';
            }
            
        }
        //обработку нажатия на кнопку =
        private void btnOperationEqual_Click(object sender, EventArgs e)
        {
            try
            {
                if(
                    (txtbIntegerPart.Text != "") &&
                    (txtbNumerator.Text != "") &&
                    (txtbDenominator.Text != "")
                  )
                {
                    secondFraction.SetFraction(integerPart: Convert.ToInt32(txtbIntegerPart.Text),
                        denominator: Convert.ToInt32(txtbDenominator.Text),
                        numerator: Convert.ToInt32(txtbNumerator.Text));
                    operation = txtbOperation.Text;
                    switch(operation)
                    {
                        case "+":
                            result = firstFraction.OperationPlus(secondFraction);
                            break;
                        case "-":
                            result = firstFraction.OperationMinus(secondFraction);
                            break;
                        case "/":
                            result = firstFraction.OperationDivision(secondFraction);
                            break;
                        case "*":
                            result = firstFraction.OperationMultiplication(secondFraction);
                            break;
                        default: break;
                    }

                    operation = "";
                    txtbOperation.Text = "";
                    txtbIntegerPart.Text = result.IntegerPart.ToString();
                    txtbNumerator.Text = result.Numerator.ToString();
                    txtbDenominator.Text = result.Denominator.ToString();

                    firstFraction.CleanFraction();
                    secondFraction.CleanFraction();


                }
            }
            catch(Exception b)
            {
                label1.Text = b.ToString();
            }
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
        //обработку ситуации когда нажатием на кнопку надо поставить минус в значении дроби
        private void btnOperationMinus_Click(object sender, EventArgs e)
        {
            try
            {
                if (lastFocus == txtbOperation)
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

                        operation = "-";
                        txtbOperation.Text = "-";
                    }
                    else
                    {
                        operation = "-";
                        txtbOperation.Text = "-";
                    }
                }else
                {
                    if((lastFocus.Text.Length <= 0) && (lastFocus.Text.IndexOf('-') == -1))
                    {
                        lastFocus.Text += '-';
                    }
                }
            }
            catch (Exception b)
            { label1.Text = b.ToString(); }
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

        private void txtbIntegerPart_Enter(object sender, EventArgs e)
        {
            //двигаем акуальный фокус

            lastFocus = (Control)sender;

        }

        private void txtbNumerator_Enter(object sender, EventArgs e)
        {
            //двигаем акуальный фокус

            lastFocus = (Control)sender;

        }

        private void txtbDenominator_Enter(object sender, EventArgs e)
        {
            //двигаем акуальный фокус

            lastFocus = (Control)sender;

        }

        private void txtbOperation_Enter(object sender, EventArgs e)
        {
            //двигаем акуальный фокус

            lastFocus = (Control)sender;

        }

        private void btnNumber2_Click(object sender, EventArgs e)
        {
            if (lastFocus != txtbOperation)
            {
                lastFocus.Text += '2';
            }
        }

        private void btnNumber3_Click(object sender, EventArgs e)
        {
            if (lastFocus != txtbOperation)
            {
                lastFocus.Text += '3';
            }
        }

        private void btnNumber4_Click(object sender, EventArgs e)
        {
            if (lastFocus != txtbOperation)
            {
                lastFocus.Text += '4';
            }
        }

        private void btnNumber5_Click(object sender, EventArgs e)
        {
            if (lastFocus != txtbOperation)
            {
                lastFocus.Text += '5';
            }
        }

        private void btnNumber6_Click(object sender, EventArgs e)
        {
            if (lastFocus != txtbOperation)
            {
                lastFocus.Text += '6';
            }
        }

        private void btnNumber7_Click(object sender, EventArgs e)
        {
            if (lastFocus != txtbOperation)
            {
                lastFocus.Text += '7';
            }
        }

        private void btnNumber8_Click(object sender, EventArgs e)
        {
            if (lastFocus != txtbOperation)
            {
                lastFocus.Text += '8';
            }
        }

        private void btnNumber9_Click(object sender, EventArgs e)
        {
            if (lastFocus != txtbOperation)
            {
                lastFocus.Text += '9';
            }
        }

        private void btnNumber0_Click(object sender, EventArgs e)
        {
            if (lastFocus != txtbOperation)
            {
                if ((lastFocus != txtbDenominator) || (txtbDenominator.Text.Length >= 1))
                {
                    lastFocus.Text += '0';
                }
            }   
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbIntegerPart.Text = "";
            txtbNumerator.Text = "";
            txtbDenominator.Text = "";
            txtbOperation.Text = "";
            firstFraction.CleanFraction();
            secondFraction.CleanFraction();
            operation = "";
        }
    }
}
