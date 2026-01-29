using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Calculator_WINUI3
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private const int MaxAmountOfCharacter = 30;
        private double currentValue = 0;
        private double storedValue = 0;
        private string currentOperation = "";
        private bool isNewEntry = true;

        public MainWindow()
        {
            InitializeComponent();

            // Set window size
            this.AppWindow.ResizeClient(new Windows.Graphics.SizeInt32(370, 500));
        }

        private bool IsValidAmountOfCharacter()
        {
            if (CalculatorViewBox.Text.Length > MaxAmountOfCharacter)
            {
                WarningInfoBar.Message = $"Can only accept {MaxAmountOfCharacter} inputs";
                WarningInfoBar.IsOpen = true;
                return false;
            }
            return true;
        }

        private void Percentage_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Percentage Button Clicked");
            if (double.TryParse(CalculatorViewBox.Text, out double value))
            {
                double result = value / 100;
                CalculatorViewBox.Text = result.ToString();
                currentValue = result;
            }
        }

        private void CE_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("CE Button Clicked");
            CalculatorViewBox.Text = "0";
            currentValue = 0;
            isNewEntry = true;
        }

        private void C_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("C Button Clicked");
            CalculatorViewBox.Text = "0";
            currentValue = 0;
            storedValue = 0;
            currentOperation = "";
            isNewEntry = true;
            WarningInfoBar.IsOpen = false;
        }

        private void Backspace_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Backspace Button Clicked");
            if (CalculatorViewBox.Text.Length > 0)
            {
                if (CalculatorViewBox.Text.Length == 1 || CalculatorViewBox.Text == "0")
                {
                    CalculatorViewBox.Text = "0";
                }
                else
                {
                    CalculatorViewBox.Text = CalculatorViewBox.Text.Substring(0, CalculatorViewBox.Text.Length - 1);
                }
            }
        }

        private void Recipropcal_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Reciprocal Button Clicked");
            if (double.TryParse(CalculatorViewBox.Text, out double value))
            {
                if (value != 0)
                {
                    double result = 1 / value;
                    CalculatorViewBox.Text = result.ToString();
                    currentValue = result;
                    isNewEntry = true;
                }
                else
                {
                    WarningInfoBar.Message = "Cannot divide by zero";
                    WarningInfoBar.IsOpen = true;
                }
            }
        }

        private void Power_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Power Button Clicked");
            if (double.TryParse(CalculatorViewBox.Text, out double value))
            {
                double result = Math.Pow(value, 2);
                CalculatorViewBox.Text = result.ToString();
                currentValue = result;
                isNewEntry = true;
            }
        }

        private void SquareRoot_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Square Root Button Clicked");
            if (double.TryParse(CalculatorViewBox.Text, out double value))
            {
                if (value >= 0)
                {
                    double result = Math.Sqrt(value);
                    CalculatorViewBox.Text = result.ToString();
                    currentValue = result;
                    isNewEntry = true;
                }
                else
                {
                    WarningInfoBar.Message = "Cannot calculate square root of negative number";
                    WarningInfoBar.IsOpen = true;
                }
            }
        }

        private void Division_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Division Button Clicked");
            PerformOperation();
            currentOperation = "÷";
            isNewEntry = true;
        }

        private void Seven_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Seven Button Clicked");
            AppendNumber("7");
        }

        private void Eight_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Eight Button Clicked");
            AppendNumber("8");
        }

        private void Nine_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Nine Button Clicked");
            AppendNumber("9");
        }

        private void Multiplication_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Multiplication Button Clicked");
            PerformOperation();
            currentOperation = "×";
            isNewEntry = true;
        }

        private void Four_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Four Button Clicked");
            AppendNumber("4");
        }

        private void Five_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Five Button Clicked");
            AppendNumber("5");
        }

        private void Six_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Six Button Clicked");
            AppendNumber("6");
        }

        private void Minus_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Minus Button Clicked");
            PerformOperation();
            currentOperation = "-";
            isNewEntry = true;
        }

        private void One_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("One Button Clicked");
            AppendNumber("1");
        }

        private void Two_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Two Button Clicked");
            AppendNumber("2");
        }

        private void Three_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Three Button Clicked");
            AppendNumber("3");
        }

        private void Plus_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Plus Button Clicked");
            PerformOperation();
            currentOperation = "+";
            isNewEntry = true;
        }

        private void Negative_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Negative Button Clicked");
            if (double.TryParse(CalculatorViewBox.Text, out double value))
            {
                value = -value;
                CalculatorViewBox.Text = value.ToString();
                currentValue = value;
            }
        }

        private void Zero_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Zero Button Clicked");
            if (!isNewEntry)
            {
                AppendNumber("0");
            }
        }
        private void Dot_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Dot Button Clicked");
            
            if (!CalculatorViewBox.Text.Contains("."))
            {
                if (isNewEntry)
                {
                    CalculatorViewBox.Text = "0.";
                    isNewEntry = false;
                }
                else
                {
                    CalculatorViewBox.Text = CalculatorViewBox.Text + ".";
                }
            }
        }

        private void Equals_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Equals Button Clicked");
            PerformOperation();
            currentOperation = "";
            isNewEntry = true;
        }

        private void PerformOperation()
        {
            if (double.TryParse(CalculatorViewBox.Text, out double value))
            {
                currentValue = value;

                if (!string.IsNullOrEmpty(currentOperation))
                {
                    double result = 0;
                    bool validOperation = true;

                    switch (currentOperation)
                    {
                        case "+":
                            result = storedValue + currentValue;
                            break;
                        case "-":
                            result = storedValue - currentValue;
                            break;
                        case "×":
                            result = storedValue * currentValue;
                            break;
                        case "÷":
                            if (currentValue != 0)
                            {
                                result = storedValue / currentValue;
                            }
                            else
                            {
                                WarningInfoBar.Message = "Cannot divide by zero";
                                WarningInfoBar.IsOpen = true;
                                validOperation = false;
                            }
                            break;
                    }

                    if (validOperation)
                    {
                        CalculatorViewBox.Text = result.ToString();
                        storedValue = result;
                        currentValue = result;
                    }
                }
                else
                {
                    storedValue = currentValue;
                }
            }
        }

        private void AppendNumber(string number)
        {
            if (!IsValidAmountOfCharacter())
                return;

            if (isNewEntry || CalculatorViewBox.Text == "0")
            {
                CalculatorViewBox.Text = number;
                isNewEntry = false;
            }
            else
            {
                CalculatorViewBox.Text = CalculatorViewBox.Text + number;
            }
        }
    }
}
