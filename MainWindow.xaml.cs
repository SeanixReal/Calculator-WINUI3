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
        public MainWindow()
        {
            InitializeComponent();

            // Set window size
            this.AppWindow.ResizeClient(new Windows.Graphics.SizeInt32(370, 500));
        }

        private void Percentage_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Percentage Button Clicked");
        }

        private void CE_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("CE Button Clicked");
        }

        private void C_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("C Button Clicked");
        }

        private void Backspace_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Backspace Button Clicked");
        }

        private void Recipropcal_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Reciprocal Button Clicked");
        }

        private void Power_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Power Button Clicked");
        }

        private void SquareRoot_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Square Root Button Clicked");
        }

        private void Division_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Division Button Clicked");
        }

        private void Seven_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Seven Button Clicked");
        }

        private void Eight_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Eight Button Clicked");
        }

        private void Nine_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Nine Button Clicked");
        }

        private void Multiplication_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Multiplication Button Clicked");
        }

        private void Four_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Four Button Clicked");
        }

        private void Five_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Five Button Clicked");
        }

        private void Six_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Six Button Clicked");
        }

        private void Minus_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Minus Button Clicked");
        }

        private void One_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("One Button Clicked");
        }

        private void Two_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Two Button Clicked");
        }

        private void Three_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Three Button Clicked");
        }

        private void Plus_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Plus Button Clicked");
        }

        private void Negative_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Negative Button Clicked");
        }

        private void Zero_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Zero Button Clicked");
        }

        private void Dot_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Dot Button Clicked");
        }

        private void Equals_Button(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Equals Button Clicked");
        }
    }
}
