using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Fraction
    {
        //числитель

        private int numerator;
        
        //знаменатель

        private int decimator;
        
        //целая часть

        private int integerPart;

        //конструктор

        public Fraction( int integerPart = 0 , int numerator = 0 , int decimator = 1 )
        {
            this.integerPart = integerPart;
            this.numerator = numerator;
            this.decimator = decimator;
        }


        //операцию внесения целой части

        private void OperationRemoveIntPart()
        {
            if (this.decimator != 0)
            {
                this.numerator = this.numerator + (this.integerPart * this.decimator);
            }else
            {
                this.decimator = 1;
                this.OperationRemoveIntPart();
            }
        }
        // операцию сложения

        public Fraction OperationPlus(Fraction secondFraction)
        {
            this.OperationRemoveIntPart();
            secondFraction.OperationRemoveIntPart();

            Fraction result = new Fraction();

            result.numerator = (this.numerator * secondFraction.decimator) + (this.decimator * secondFraction.numerator);
            result.decimator = this.decimator * secondFraction.decimator;

            result.OperaritonAllotmantIntPart();

            return result;
        }
        // операцию вычитания

        public Fraction OperationMinus(Fraction secondFraction)
        {
            this.OperationRemoveIntPart();
            secondFraction.OperationRemoveIntPart();

            Fraction result = new Fraction();

            result.numerator = (this.numerator * secondFraction.decimator) - (this.decimator * secondFraction.numerator);
            result.decimator = this.decimator * secondFraction.decimator;

            result.OperaritonAllotmantIntPart();

            return result;
        }
        // операцию деления

        public Fraction OperationDivision(Fraction secondFraction)
        {
            this.OperationRemoveIntPart();
            secondFraction.OperationRemoveIntPart();

            Fraction result = new Fraction();

            result.numerator = this.numerator * secondFraction.decimator;
            result.decimator = this.decimator * secondFraction.numerator;

            result.OperaritonAllotmantIntPart();

            return result;
        }
        // операцию умножения

        public Fraction OperationMultiplication(Fraction secondFraction)
        {
            this.OperationRemoveIntPart();
            secondFraction.OperationRemoveIntPart();

            Fraction result = new Fraction();

            result.numerator = this.numerator * secondFraction.numerator;
            result.decimator = this.decimator * secondFraction.decimator;

            result.OperaritonAllotmantIntPart();

            return result;
        }
        // метод выделения целой части

        private void OperaritonAllotmantIntPart()
        {
            try
            {
                this.integerPart = this.numerator / this.decimator;
                this.numerator = this.numerator % this.decimator;
            }catch(DivideByZeroException e)
            {
                this.decimator = 1;
                this.OperaritonAllotmantIntPart();
            }
        }



    }
}
