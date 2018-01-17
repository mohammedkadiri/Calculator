using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Declaration of variables to hold operands as well as a temporary variable
        private double operandOne, operandTwo, temp;
        //variable to check if the input box has a decimal
        private bool hasDecimal = false;
        private bool currentInput = true;
        //calcOperator holds the operator
        private string calcOperator;
        private double result;

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btnZero(object sender, RoutedEventArgs e)
        {   
            //Check the current input
            if(currentInput)
            {
                //Test if the input box is not empty 
                if(txt.Text.Length >= 1)
                {
                    txt.Text += Convert.ToString("0");
                    label.Content += Convert.ToString("0");
                }
            }
        }

        private void btnOne(object sender, RoutedEventArgs e)
        {
           //Check the current input
           if(currentInput)
            {
                txt.Text += Convert.ToString("1");
            }
           //The value is incorrect, set the value to the button
            else
            {
                txt.Text = Convert.ToString("1");
                //Set current input back to true
                currentInput = true;
            }

            label.Content += Convert.ToString("1"); 
        }

        private void btnTwo(object sender, RoutedEventArgs e)
        {
            //Check the current input
            if (currentInput)
            {
                txt.Text += Convert.ToString("2");
            }
            //The value is incorrect, set the value to the button
            else
            {
                txt.Text = Convert.ToString("2");
                //Set current input back to true
                currentInput = true;
            }

            label.Content += Convert.ToString("2");
        }

        private void btnThree(object sender, RoutedEventArgs e)
        {
            //Check the current input
            if (currentInput)
            {
                txt.Text += Convert.ToString("3");
            }
            //The value is incorrect, set the value to the button
            else
            {
                txt.Text = Convert.ToString("3");
                //Set current input back to true
                currentInput = true;
            }

            label.Content += Convert.ToString("3");
        }

        private void btnFour(object sender, RoutedEventArgs e)
        {
            //Check the current input
            if (currentInput)
            {
                txt.Text += Convert.ToString("4");
            }
            //The value is incorrect, set the value to the button
            else
            {
                txt.Text = Convert.ToString("4");
                //Set current input back to true
                currentInput = true;
            }

            label.Content += Convert.ToString("4");
        }

        private void btnFive(object sender, RoutedEventArgs e)
        {
            //Check the current input
            if (currentInput)
            {
                txt.Text += Convert.ToString("5");
            }
            //The value is incorrect, set the value to the button
            else
            {
                txt.Text = Convert.ToString("5");
                //Set current input back to true
                currentInput = true;
            }

            label.Content += Convert.ToString("5");
        }

        private void btnSix(object sender, RoutedEventArgs e)
        {
            //Check the current input
            if (currentInput)
            {
                txt.Text += Convert.ToString("6");
            }
            //The value is incorrect, set the value to the button
            else
            {
                txt.Text = Convert.ToString("6");
                //Set current input back to true
                currentInput = true;
            }
            
            label.Content += Convert.ToString("6");
        }

        private void btnSeven(object sender, RoutedEventArgs e)
        {
            //Check the current input
            if (currentInput)
            {
                txt.Text += Convert.ToString("7");
            }
            //The value is incorrect, set the value to the button
            else
            {
                txt.Text = Convert.ToString("7");
                //Set current input back to true
                currentInput = true;
            }

            label.Content += Convert.ToString("7");
        }

        private void btnEight(object sender, RoutedEventArgs e)
        {
            //Check the current input
            if (currentInput)
            {
                txt.Text += Convert.ToString("8");
            }
            //The value is incorrect, set the value to the button
            else
            {
                txt.Text = Convert.ToString("8");
                //Set current input back to true
                currentInput = true;
            }

            label.Content += Convert.ToString("8");
        }

        private void btnNine(object sender, RoutedEventArgs e)
        {
            //Check the current input
            if (currentInput)
            {
                txt.Text += Convert.ToString("9");
            }
            //The value is incorrect, set the value to the button
            else
            {
                txt.Text = Convert.ToString("9");
                //Set current input back to true
                currentInput = true;
            }

            label.Content += Convert.ToString("9");
        }

        private void decimalBtn(object sender, RoutedEventArgs e)
        {
            //Check the current input
            if(currentInput)
            {
                //Check if the user has already used a decimal
                if(!hasDecimal)
                {
                    //Check that the length is greater than 1 as a decimal can not be the first number
                    if(txt.Text.Length != 0)
                    {
                        //Ensure that the first number is not a zero
                        if(txt.Text != "0")
                        {
                            txt.Text += Convert.ToString(".");
                            label.Content += Convert.ToString(".");
                        }
                    }
                    //The length is not greater than 1
                    else
                    {
                        //Set the text to 0.
                        txt.Text = "0.";
                        label.Content += "0.";
                    }
                }
            }
        }

        private void percentageBtn(object sender, RoutedEventArgs e)
        {
            //Check if the input box has a value
            if (txt.Text.Length != 0)
            {
                //check the value 
                if (calcOperator == string.Empty)
                {
                    //Assign the value of the input box
                    operandOne = System.Double.Parse(txt.Text);
                    //Empty the input box
                    txt.Text = string.Empty;
                }
                else
                {
                    operandOne = System.Double.Parse(txt.Text);
                    //input check if it is not empty
                    txt.Text = string.Empty;
                    label.Content += " %";
                }
                //assign a value for the calcOperator
                calcOperator = "Perc";
                //Toggle the decimal flag
                hasDecimal = false;
            }
        }

        private void numToPowerBtn(object sender, RoutedEventArgs e)
        {
            //Check if the input box has a value
            if (txt.Text.Length != 0)
            {
                //check the value 
                if (calcOperator == string.Empty)
                {
                    //Assign the value of the input box
                    operandOne = System.Double.Parse(txt.Text);
                    //Empty the input box
                    txt.Text = string.Empty;
                }
                else
                {
                    label.Content = string.Empty;
                    operandOne = System.Double.Parse(txt.Text);
                    label.Content += Convert.ToString(operandOne) + " ^ ";
                    //input check if it is not empty
                    txt.Text = string.Empty;
                   
                }
                //assign a value for the calcOperator
                calcOperator = "pow";
                //Toggle the decimal flag
                hasDecimal = false;
            }
        }

        private void memoryClearBtn(object sender, RoutedEventArgs e)
        {
            operandOne = 0;
            txt.Text = operandOne.ToString();
        }

        private void memoryRegisterBtn(object sender, RoutedEventArgs e)
        {
            txt.Text = operandOne.ToString();
        }

        private void memoryStoreBtn(object sender, RoutedEventArgs e)
        {
            operandOne = Convert.ToDouble(txt.Text);
            
        }

        private void mPlusBtn(object sender, RoutedEventArgs e)
        {
            operandOne += Convert.ToDouble(txt.Text);
            txt.Text = operandOne.ToString();
        }

        private void mMinusBtn(object sender, RoutedEventArgs e)
        {
            operandOne -= Convert.ToDouble(txt.Text);
            txt.Text = operandOne.ToString();
        }

        private void numToPowerTwoBtn(object sender, RoutedEventArgs e)
        {
           
            //Check if the input box is empty
            if (txt.Text.Length != 0)
            {
                //Assign the value to the temp variable
                temp = System.Double.Parse(txt.Text);
                label.Content +=" ^ (2) ";
                //square the number
                temp = System.Math.Pow(temp, 2);
                //Display the result
                txt.Text = temp.ToString();
                //clear the decimal flag
                hasDecimal = false;
            }
        }

        private void sinBtn(object sender, RoutedEventArgs e)
        {
            //Check if the input box is empty
            if (txt.Text.Length != 0)
            {
                label.Content = "";
                //Assign the value to the temp variable
                temp = System.Double.Parse(txt.Text);
                label.Content += "sin" + "(" + Convert.ToString(temp) + ") ";
                //square the number
                temp = System.Math.Sin(temp);
                temp = System.Math.Round(temp);
                //Display the result
                txt.Text = temp.ToString();
                //clear the decimal flag
                hasDecimal = false;
            }
        }

        private void cosBtn(object sender, RoutedEventArgs e)
        {
            //Check if the input box is empty
            if (txt.Text.Length != 0)
            {
                label.Content = "";
                //Assign the value to the temp variable
                temp = System.Double.Parse(txt.Text);
                label.Content += "cos" + "(" + Convert.ToString(temp) + ") ";
                //square the number
                temp = System.Math.Cos(temp);
                temp = System.Math.Round(temp);
                //Display the result
                txt.Text = temp.ToString();
                //clear the decimal flag
                hasDecimal = false;
            }
        }

        private void tanBtn(object sender, RoutedEventArgs e)
        {
            //Check if the input box is empty
            if (txt.Text.Length != 0)
            {
                label.Content = "";
                //Assign the value to the temp variable
                temp = System.Double.Parse(txt.Text);
                label.Content += "tan" + "(" + Convert.ToString(temp) + ") ";
                //square the number
                temp = System.Math.Tan(temp);
                temp = System.Math.Round(temp);
                //Display the result
                txt.Text = temp.ToString();
                //clear the decimal flag
                hasDecimal = false;
            }
        }

        private void clearEntryBtn(object sender, RoutedEventArgs e)
        {
            //Empty the input box
            txt.Text = string.Empty;
            label.Content = string.Empty;
            //Toggle the decimal flag
            hasDecimal = false;
        }

        private void clearBtn(object sender, RoutedEventArgs e)
        {
            //Empty the input box
            txt.Text = string.Empty;
            label.Content = string.Empty;
            //Set the values of both operands to zero
            operandOne = 0;
            operandTwo = 0;
            //Set the calcOperator to empty
            calcOperator = string.Empty;
            //Toggle the decimal flag
            hasDecimal = false;
        }

        private void TenToPowerNumBtn(object sender, RoutedEventArgs e)
        {
            //Check if the input box is empty
            if (txt.Text.Length != 0)
            {
                label.Content = string.Empty;
                //Assign the value to the temp variable
                temp = System.Double.Parse(txt.Text);
                label.Content += "10" + "^(" + Convert.ToString(temp) + ") ";
                //square the number
                temp = System.Math.Pow(10, temp);
                //Display the result
                txt.Text = temp.ToString();
                //clear the decimal flag
                hasDecimal = false;
            }
        }

        private void piBtn(object sender, RoutedEventArgs e)
        {
            if(txt.Text.Length != 0)
            {
                txt.Text += Convert.ToString(System.Math.PI);
                operandOne = System.Math.PI;
                calcOperator = "Pi";
                label.Content = Convert.ToString(System.Math.PI);
            }
            else
            {
                txt.Text = Convert.ToString(System.Math.PI);
            }
        }

        private void squareRootBtn(object sender, RoutedEventArgs e)
        {
            //Check if the input box is empty
            if (txt.Text.Length != 0)
            {
                label.Content = string.Empty;
                //Assign the value to the temp variable
                temp = System.Double.Parse(txt.Text);
                label.Content += '√' + "(" + Convert.ToString(temp) + ")";
                //square the number
                temp = System.Math.Sqrt(temp);
                //Display the result
                txt.Text = temp.ToString();
                //clear the decimal flag
                hasDecimal = false;
            }
        }

        private void logBtn(object sender, RoutedEventArgs e)
        {
            //Check if the input box has a value
            if (txt.Text.Length != 0)
            {
                //check the value 
                if (calcOperator == string.Empty)
                {
                    //Assign the value of the input box
                    operandOne = System.Double.Parse(txt.Text);
                    //Empty the input box
                    txt.Text = string.Empty;
                }
                else
                {
                    label.Content = string.Empty;
                    operandOne = System.Double.Parse(txt.Text);
                    label.Content += "log" + "^(" + Convert.ToString(operandOne) + ")";
                    //input check if it is not empty
                    txt.Text = string.Empty;
                }
                //assign a value for the calcOperator
                calcOperator = "Log";
                //Toggle the decimal flag
                hasDecimal = false;
            }
            label.Content = "Invalid input";
        }

        private void lnBtn(object sender, RoutedEventArgs e)
        {
            //Check if the input box is empty
            if (txt.Text.Length != 0)
            {
                label.Content = string.Empty;
                //Assign the value to the temp variable
                temp = System.Double.Parse(txt.Text);
                label.Content += "ln" + "^(" + Convert.ToString(temp) + ")";
                //square the number
                temp = System.Math.Log(temp);
                //Display the result
                txt.Text = temp.ToString();
                //clear the decimal flag
                hasDecimal = false;
            }
        }

        private void modBtn(object sender, RoutedEventArgs e)
        {
            //Check if the input box has a value
            if (txt.Text.Length != 0)
            {
                //check the value 
                if (calcOperator == string.Empty)
                {
                    //Assign the value of the input box
                    operandOne = System.Double.Parse(txt.Text);
                    //Empty the input box
                    txt.Text = string.Empty;
                }
                else
                {
                    label.Content = string.Empty;
                    operandOne = System.Double.Parse(txt.Text);
                    label.Content += Convert.ToString(operandOne) + " Mod ";
                    //input check if it is not empty
                    txt.Text = string.Empty;
                }
                //assign a value for the calcOperator
                calcOperator = "Mod";
                //Toggle the decimal flag
                hasDecimal = false;
            }
        }

        private void offBtn(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void backspaceBtn(object sender, RoutedEventArgs e)
        {
            //Declare some local variables
            string str;
            int size;

            //Check that the length is greater than 1
            if(txt.Text.Length > 0)
            {
                //Get the last character
                str = txt.Text.Substring(txt.Text.Length - 1);
                //Check if its a decimal
                if(str == ".")
                {
                    //Toggle flag
                    hasDecimal = false;
                }
                //Get the length of the string
                size = txt.Text.Length;
                //remove last character by incrementing by 1
                txt.Text = txt.Text.Remove(size - 1, 1);
                label.Content = txt;
            }

            else
            {
                txt.Text = Convert.ToString(0);
                //Toggle flag
                hasDecimal = false;
            }
        }

        private void reciprocalBtn(object sender, RoutedEventArgs e)
        {
            //Check if the input box is empty
            if (txt.Text.Length != 0)
            {
                label.Content = string.Empty;
                //Assign the value to the temp variable
                temp = System.Double.Parse(txt.Text);
                label.Content += "1 / " + "^(" + Convert.ToString(temp) + ")";
                //square the number
                temp = 1 / temp;
                //Display the result
                txt.Text = temp.ToString();
                //clear the decimal flag
                hasDecimal = false;
            }
        }

        private void divide_Button(object sender, RoutedEventArgs e)
        {
            //Check if the input box has a value
            if (txt.Text.Length != 0)
            {
                //check the value 
                if (calcOperator == string.Empty)
                {
                    //Assign the value of the input box
                    operandOne = System.Double.Parse(txt.Text);
                    //Empty the input box
                    txt.Text = string.Empty;
                }
                else
                {
                    operandOne = System.Double.Parse(txt.Text);
                    label.Content += " ÷ ";
                    //input check if it is not empty
                    txt.Text = string.Empty;
                }
                //assign a value for the calcOperator
                calcOperator = "Div";
                //Toggle the decimal flag
                hasDecimal = false;
            }
        }

        private void multiply_Button(object sender, RoutedEventArgs e)
        {
            //Check if the input box has a value
            if (txt.Text.Length != 0)
            {
                //check the value 
                if (calcOperator == string.Empty)
                {
                    //Assign the value of the input box
                    operandOne = System.Double.Parse(txt.Text);
                    //Empty the input box
                    txt.Text = string.Empty;
                }
                else
                {
                  
                    operandOne = System.Double.Parse(txt.Text);
                    label.Content += " x ";
                    //input check if it is not empty
                    txt.Text = string.Empty;
                }
                //assign a value for the calcOperator
                calcOperator = "Mul";
                //Toggle the decimal flag
                hasDecimal = false;
            }
        }

        private void subtract_Button(object sender, RoutedEventArgs e)
        {
            //Check if the input box has a value
            if (txt.Text.Length != 0)
            {
                //check the value 
                if (calcOperator == string.Empty)
                {
                    //Assign the value of the input box
                    operandOne = System.Double.Parse(txt.Text);
                    //Empty the input box
                    txt.Text = string.Empty;
                }
                else
                {
                    operandOne = System.Double.Parse(txt.Text);
                    label.Content += " - ";
                    //input check if it is not empty
                    txt.Text = string.Empty;
                }
                //assign a value for the calcOperator
                calcOperator = "Sub";
                //Toggle the decimal flag
                hasDecimal = false;
            }
        }

        private void plus_Button(object sender, RoutedEventArgs e)
        {
            //Check if the input box has a value
            if(txt.Text.Length != 0)
            {
                //check the value 
                if(calcOperator == string.Empty)
                {
                    //Assign the value of the input box
                    operandOne = System.Double.Parse(txt.Text);
                    //Empty the input box
                    txt.Text = string.Empty;
                }
                else
                {
                    operandOne = System.Double.Parse(txt.Text);
                    label.Content += " + ";
                    //input check if it is not empty
                    txt.Text = string.Empty;
                }
                //assign a value for the calcOperator
                calcOperator = "Add";
                //Toggle the decimal flag
                hasDecimal = false;
            }
        }

        private void equalBtn(object sender, RoutedEventArgs e)
        {
            label.Content = string.Empty;
            calculateResult();
        }

        private void calculateResult()
        {
            operandTwo = System.Double.Parse(txt.Text);

            //check which calculation is required
            switch(calcOperator)
            {
                //Addition
                case "Add":
                    result = operandOne + operandTwo;
                    break;
                //Subtraction
                case "Sub":
                    result = operandOne - operandTwo;
                    break;
                //Multiplication
                case "Mul":
                    result = operandOne * operandTwo;
                    break;
                //Division
                case "Div":
                    result = operandOne / operandTwo;
                    break;
                //Power
                case "pow":
                  result = System.Math.Pow(operandOne,operandTwo);
                    break;
                //Percentage
                case "Perc":
                    result = (operandOne / operandTwo) * 100;
                    break;
                //Pi
                case "Pi":
                    result = System.Math.PI * operandTwo;
                    break;
                //Modulo
                case "Mod":
                    result = operandOne % operandTwo;
                    break;
                //Logarithm
                case "Log":
                    result = System.Math.Log(operandOne, operandTwo);
                    break;
            }

            txt.Text = result.ToString();
            currentInput = false;
        }
    }
}
