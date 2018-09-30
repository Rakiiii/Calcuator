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
        //объявляем первую дробь
        Fraction firstFraction = new Fraction();
        //объявляем вторую дробь
        Fraction secondFraction = new Fraction();
        //обявляем результирующую дробь
        Fraction result = new Fraction();
        //объявляем строку опрделения операции
        String operation = "";
        //объявляем переменную для запоминания на каком текстбоксе фокус
        Control lastFocus;
        //объявляем форму для лицензии
        Licens LForm = new Licens();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //ввод целой части
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
                label1.Text = "Ops you broke some thing";
            }
        }
        //ввод информайии о числители 
        private void txtbNumerator_KeyPress(object sender, KeyPressEventArgs e)
        {
            //отлавливаем неизвестные ошибки
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
                label1.Text = "Ops you broke some thing";
            }
        }
        //ввод информации об операции
        private void txtbOperation_KeyPress(object sender, KeyPressEventArgs e)
        {

            //отлавливаем случайные ошибки
            try
            {
                //запрещаем все кроме символов операции
                if ((e.KeyChar != '.') && ((e.KeyChar == '+') || (e.KeyChar == '-') || (e.KeyChar == '/') || (e.KeyChar == '*'))
                    && (txtbOperation.Text.Length == 0))
                {
                    return;
                }
                if(e.KeyChar == '.')
                {
                    e.Handled = true;
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
                //возможность введения второй дроби после введения операции первой дроби и нажатия enter
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
                        //двиагаем фокус на textbox целой части
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
                label1.Text = "Ops you broke some thing";
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
                label1.Text = "Ops you broke some thing";
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
            //отлавливаем не предусмотренный исключения
            try
            {
                //проверяем введена ли вторая дробь 
                if(
                    (txtbIntegerPart.Text != "") &&
                    (txtbNumerator.Text != "") &&
                    (txtbDenominator.Text != "")
                  )
                {
                    //запоминаем информацию о втрой дроби
                    secondFraction.SetFraction(integerPart: Convert.ToInt32(txtbIntegerPart.Text),
                        denominator: Convert.ToInt32(txtbDenominator.Text),
                        numerator: Convert.ToInt32(txtbNumerator.Text));
                    //запоминаем необходимую операцию
                    operation = txtbOperation.Text;
                    switch(operation)
                    {
                        //складываем два числа и кладем результат в Fraction result
                        case "+":
                            result = firstFraction.OperationPlus(secondFraction);
                            break;
                        //вычитаем два числа и кладем результат в Fraction result
                        case "-":
                            result = firstFraction.OperationMinus(secondFraction);
                            break;
                       //делим два числа и кладем результат в Fraction result
                        case "/":
                            result = firstFraction.OperationDivision(secondFraction);
                            break;
                        //перемнодаем два числа и кладем результат в Fraction result
                        case "*":
                            result = firstFraction.OperationMultiplication(secondFraction);
                            break;
                        default:
                            label1.Text = "unknown operation";
                            break;
                    }
                    //очищаем информацию об операции
                    operation = "";
                    //чистим textbox операции
                    txtbOperation.Text = "";
                    //выводим результат
                    txtbIntegerPart.Text = result.IntegerPart.ToString();
                    txtbNumerator.Text = result.Numerator.ToString();
                    txtbDenominator.Text = result.Denominator.ToString();
                    //чистим информацию о дробях
                    firstFraction.CleanFraction();
                    secondFraction.CleanFraction();
                    result.CleanFraction();
                    //двигаем фокус обратно на textbox целой части
                    lastFocus = txtbIntegerPart;

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
            //обрабатываем непредведенный ошибки
            try
            {
                //если первая дробть введена
                if (
                     (firstFraction.Numerator == 0) &&
                     (firstFraction.IntegerPart == 0) && 
                     (txtbIntegerPart.Text !="") &&
                     (txtbNumerator.Text != "") &&
                     (txtbDenominator.Text != "")
                    )
                {
                    //запоминаем первую дробь

                    firstFraction.SetFraction(integerPart: Convert.ToInt32(txtbIntegerPart.Text),
                        denominator: Convert.ToInt32(txtbDenominator.Text),
                        numerator: Convert.ToInt32(txtbNumerator.Text));

                    //чистим текст боксы и переходим к чтению второй дроби

                    txtbIntegerPart.Text = "";
                    txtbNumerator.Text = "";
                    txtbDenominator.Text = "";
                    //двигаем фокус обратно на textbox целой части
                    lastFocus = txtbIntegerPart;


                }
            }
            catch(Exception b)
            { label1.Text = b.ToString(); }
            //заполняем textbox операции значения сложения
            txtbOperation.Text = "+";
        }
        //обработку ситуации когда нажатием на кнопку надо поставить минус в значении дроби
        private void btnOperationMinus_Click(object sender, EventArgs e)
        {
            //обрабатываем непонятные ошбики
            try
            {
                //если фокус ввода на textbox для операторов 
                if (lastFocus == txtbOperation)
                {
                    //проверяем введена ли первая дробь
                    if (
                         (firstFraction.Numerator == 0) &&
                         (firstFraction.IntegerPart == 0) &&
                         (txtbIntegerPart.Text != "") &&
                         (txtbNumerator.Text != "") &&
                         (txtbDenominator.Text != "")
                        )
                    {
                        //запоминаем первую дробь

                        firstFraction.SetFraction(integerPart: Convert.ToInt32(txtbIntegerPart.Text),
                            denominator: Convert.ToInt32(txtbDenominator.Text),
                            numerator: Convert.ToInt32(txtbNumerator.Text));

                        //чистим текст боксы

                        txtbIntegerPart.Text = "";
                        txtbNumerator.Text = "";
                        txtbDenominator.Text = "";
                        //двигаем фокус обратно на textbox целой части
                        lastFocus = txtbIntegerPart;
                        //заполняем textbox операции значение для операции вычитание
                        txtbOperation.Text = "-";
                    }
                    else
                    //если фокус на textbox для оперции , но первая дробь не введена ,то просто заполняем textbox для оперций 
                    {
                        txtbOperation.Text = "-";
                    }
                }
                else
                //если фокус указывает не на textbox для оперций,то проверяем первым ли символом будет минус и единственный ли он
                {
                    if((lastFocus.Text.Length <= 0) && (lastFocus.Text.IndexOf('-') == -1))
                    {
                        //дописываем минус в textbox на который установили фокус
                        lastFocus.Text += '-';
                    }
                }
            }
            catch (Exception b)
            { label1.Text = b.ToString(); }
        }
    

        private void btnOperationMultiplication_Click(object sender, EventArgs e)
        {
            //отлавливаем неизвестные ошибки
            try
            {
                //проверяем введена ли первая дробь
                if (
                     (firstFraction.Numerator == 0) &&
                     (firstFraction.IntegerPart == 0) &&
                     (txtbIntegerPart.Text != "") &&
                     (txtbNumerator.Text != "") &&
                     (txtbDenominator.Text != "")
                    )
                {
                    //запоминаем первую дробь

                    firstFraction.SetFraction(integerPart: Convert.ToInt32(txtbIntegerPart.Text),
                        denominator: Convert.ToInt32(txtbDenominator.Text),
                        numerator: Convert.ToInt32(txtbNumerator.Text));

                    //чистим текст боксы

                    txtbIntegerPart.Text = "";
                    txtbNumerator.Text = "";
                    txtbDenominator.Text = "";
                    //двигаем фокус обратно на textbox целой части
                    lastFocus = txtbIntegerPart;

                }
            }
            catch (Exception b)
            { label1.Text = b.ToString(); }
            //заполняем textbox оперцаии знаком *
            txtbOperation.Text = "*";
        }
    

        private void btnOperationDivision_Click(object sender, EventArgs e)
        {
            //отлавливаем случайные ошибки
            try
            {
                //проверяем введена ли первая дробь
                if (
                     (firstFraction.Numerator == 0) &&
                     (firstFraction.IntegerPart == 0) &&
                     (txtbIntegerPart.Text != "") &&
                     (txtbNumerator.Text != "") &&
                     (txtbDenominator.Text != "")
                    )
                {
                    //запоминаем первую дробь

                    firstFraction.SetFraction(integerPart: Convert.ToInt32(txtbIntegerPart.Text),
                        denominator: Convert.ToInt32(txtbDenominator.Text),
                        numerator: Convert.ToInt32(txtbNumerator.Text));

                    //чистим текст боксы

                    txtbIntegerPart.Text = "";
                    txtbNumerator.Text = "";
                    txtbDenominator.Text = "";
                    //двигаем фокус обратно на textbox целой части
                    lastFocus = txtbIntegerPart;

                }
            }
            catch (Exception b)
            { label1.Text = b.ToString(); }
            //заполняем textbox операции
            txtbOperation.Text = "/";
        }
         
        //обрабатываем переход фокуса на текст бокс с помошью мыши
        private void txtbIntegerPart_Enter(object sender, EventArgs e)
        {
            //двигаем акуальный фокус

            lastFocus = (Control)sender;
            label1.Text = "";

        }

        //обрабатываем переход фокуса на текст бокс с помошью мыши
        private void txtbNumerator_Enter(object sender, EventArgs e)
        {
            //двигаем акуальный фокус

            lastFocus = (Control)sender;
            label1.Text = "";

        }

        //обрабатываем переход фокуса на текст бокс с помошью мыши
        private void txtbDenominator_Enter(object sender, EventArgs e)
        {
            //двигаем акуальный фокус

            lastFocus = (Control)sender;
            label1.Text = "";

        }

        //обрабатываем переход фокуса на текст бокс с помошью мыши
        private void txtbOperation_Enter(object sender, EventArgs e)
        {
            //двигаем акуальный фокус

            lastFocus = (Control)sender;
            label1.Text = "";

        }

        //обарабатываем нажатие на кнопку 2
        private void btnNumber2_Click(object sender, EventArgs e)
        {
            //если фокус не на textbox операции
            if (lastFocus != txtbOperation)
            {
                //дописываем к последнему textbox в фокусе цифру 2
                lastFocus.Text += '2';
            }
        }

        //обарабатываем нажатие на кнопку 3
        private void btnNumber3_Click(object sender, EventArgs e)
        {
            //если фокус не на textbox операции
            if (lastFocus != txtbOperation)
            {
                //дописываем к последнему textbox в фокусе цифру 3
                lastFocus.Text += '3';
            }
        }

        //обарабатываем нажатие на кнопку 4
        private void btnNumber4_Click(object sender, EventArgs e)
        {
            //если фокус не на textbox операции
            if (lastFocus != txtbOperation)
            {
                //дописываем к последнему textbox в фокусе цифру 4
                lastFocus.Text += '4';
            }
        }

        //обарабатываем нажатие на кнопку 5
        private void btnNumber5_Click(object sender, EventArgs e)
        {
            //если фокус не на textbox операции
            if (lastFocus != txtbOperation)
            {
                //дописываем к последнему textbox в фокусе цифру 5
                lastFocus.Text += '5';
            }
        }

        //обарабатываем нажатие на кнопку 6
        private void btnNumber6_Click(object sender, EventArgs e)
        {
            //если фокус не на textbox операции
            if (lastFocus != txtbOperation)
            {
                //дописываем к последнему textbox в фокусе цифру 6
                lastFocus.Text += '6';
            }
        }

        //обарабатываем нажатие на кнопку 6
        private void btnNumber7_Click(object sender, EventArgs e)
        {
            //если фокус не на textbox операции
            if (lastFocus != txtbOperation)
            {
                //дописываем к последнему textbox в фокусе цифру 6
                lastFocus.Text += '7';
            }
        }

        //обарабатываем нажатие на кнопку 8
        private void btnNumber8_Click(object sender, EventArgs e)
        {
            //если фокус не на textbox операции
            if (lastFocus != txtbOperation)
            {
                //дописываем к последнему textbox в фокусе цифру 8
                lastFocus.Text += '8';
            }
        }

        //обарабатываем нажатие на кнопку 9
        private void btnNumber9_Click(object sender, EventArgs e)
        {
            //если фокус не на textbox операции
            if (lastFocus != txtbOperation)
            {
                //дописываем к последнему textbox в фокусе цифру 9
                lastFocus.Text += '9';
            }
        }

        //обарабатываем нажатие на кнопку 0
        private void btnNumber0_Click(object sender, EventArgs e)
        {
            if (lastFocus != txtbOperation)
            {
                //если фокус не на textbox операции
                if ((lastFocus != txtbDenominator) || (txtbDenominator.Text.Length >= 1))
                {
                    //дописываем к последнему textbox в фокусе цифру 0
                    lastFocus.Text += '0';
                }
            }   
        }
        //кнопка очистки всех значений
        private void btnClear_Click(object sender, EventArgs e)
        {
            //чистим textbox'ы
            txtbIntegerPart.Text = "";
            txtbNumerator.Text = "";
            txtbDenominator.Text = "";
            txtbOperation.Text = "";
            //чистим информацию о дробях
            firstFraction.CleanFraction();
            secondFraction.CleanFraction();
            result.CleanFraction();
            //чистим информацию об операции
            operation = "";
        }

        //обрабатываем нажатие на close в всплывающем меню File
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //закрываем вторую форму
            LForm.Close();
            //закрываем приложение в целом
            Application.Exit();
            
        }

        //обрабытваем нажатие на informstion в всплывающем меню Help
        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //показываем вторую форму в зависимом режиме
            LForm.ShowDialog();
        }
    }
}
