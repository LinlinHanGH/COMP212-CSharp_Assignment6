﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linlin_Han_Lab06_Ex01
{
    public partial class Assignment6_LinlinHan : Form
    {
        private long n1 = 0; // initialize with first Fibonacci number
        private long n2 = 1; // initialize with second Fibonacci number
        private int count = 1; // current Fibonacci number to display
        public Assignment6_LinlinHan()
        {
            InitializeComponent();
        }

        // start an async Task to calculate specified Fibonacci number
        private async void calculateButton_Click(object sender, EventArgs e)
        {
            // retrieve user's input as an integer
            int number = int.Parse(inputTextBox.Text);

            asyncResultLabel.Text = "Calculating...";

            // Task to perform Fibonacci calculation in separate thread
            Task<long> fibonacciTask = Task.Run(() => Factorial(number));

            // wait for Task in separate thread to complete
            await fibonacciTask;

            // display result after Task in separate thread completes
            asyncResultLabel.Text = fibonacciTask.Result.ToString();
        }

        // recursive method Fibonacci; calculates nth Fibonacci number
        public long Factorial(long n)
        {
            if (n <= 1)
            {
                Thread.Sleep(2000);
                return 1;
            }
            else {
                return n * Factorial(n - 1);
            } 
            
        }

        private void btnCheckEvenOdd_Click(object sender, EventArgs e)
        {
            // retrieve user's input as an integer
            int number = int.Parse(txbEvenOddInput.Text);

            if (number % 2 == 0)
            {
                lblEvenOddResult.Text = "Even";
            }
            else {
                lblEvenOddResult.Text = "Odd";
            }

        }
    }
}
