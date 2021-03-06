﻿using System;
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

        //getter целой части
        public int Numerator
        {
            get { return this.numerator;}
        }

        //знаменатель

        private int denominator;

        //getter знаменателя
        public int Denominator
        {
            get { return this.denominator; }
        }

        //целая часть

        private int integerPart;

        //getter числителя
        public int IntegerPart
        {
            get { return this.integerPart; }
        }
            

        //конструктор

        public Fraction( int integerPart = 0 , int numerator = 0 , int denominator = 1 )
        {
            this.integerPart = integerPart;
            this.numerator = numerator;
            this.denominator = denominator;
        }

        // функция заполнения дроби

        public void SetFraction(int integerPart, int numerator, int denominator)
        {
            this.integerPart = integerPart;
            this.numerator = numerator;
            this.denominator = denominator;
        }
         
        //функция обнуления дроби

        public void CleanFraction()
        {
            this.integerPart = 0;
            this.denominator = 1;
            this.numerator = 0;
        }


        //операцию внесения целой части

        private void OperationRemoveIntPart()
        {
            if (this.denominator != 0)
            {
                this.numerator = this.numerator + (this.integerPart * this.denominator);
            }else
            {
                this.denominator = 1;
                this.OperationRemoveIntPart();
            }
        }
        // операцию сложения

        public Fraction OperationPlus(Fraction secondFraction)
        {
            this.OperationRemoveIntPart();
            secondFraction.OperationRemoveIntPart();

            Fraction result = new Fraction();

            result.numerator = (this.numerator * secondFraction.denominator) + (this.denominator * secondFraction.numerator);
            result.denominator = this.denominator * secondFraction.denominator;

            result.OperaritonAllotmantIntPart();

            return result;
        }
        // операцию вычитания

        public Fraction OperationMinus(Fraction secondFraction)
        {
            this.OperationRemoveIntPart();
            secondFraction.OperationRemoveIntPart();

            Fraction result = new Fraction();

            result.numerator = (this.numerator * secondFraction.denominator) - (this.denominator * secondFraction.numerator);
            result.denominator = this.denominator * secondFraction.denominator;

            result.OperaritonAllotmantIntPart();

            return result;
        }
        // операцию деления

        public Fraction OperationDivision(Fraction secondFraction)
        {
            this.OperationRemoveIntPart();
            secondFraction.OperationRemoveIntPart();

            Fraction result = new Fraction();

            result.numerator = this.numerator * secondFraction.denominator;
            result.denominator = this.denominator * secondFraction.numerator;

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
            result.denominator = this.denominator * secondFraction.denominator;

            result.OperaritonAllotmantIntPart();

            return result;
        }
        // метод выделения целой части

        private void OperaritonAllotmantIntPart()
        {
            try
            {
                this.integerPart = this.numerator / this.denominator;
                this.numerator = this.numerator % this.denominator;
            }catch(DivideByZeroException e)
            {
                this.denominator = 1;
                this.OperaritonAllotmantIntPart();
            }
        }



    }
}
