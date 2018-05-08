using CalcBMI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BMI_exercise
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ImperialPage : Page
    {
        private SolidColorBrush errorBrush = new SolidColorBrush(Windows.UI.Colors.Red);
        private Brush correctBrush = null;
        private double heightin;
        private double heightft;
        private double weight;

        public ImperialPage()
        {
            this.InitializeComponent();
            if (correctBrush == null)
                correctBrush = txtHeightFeet.Foreground;
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (isValid())
                {
                    //Demo using Properties of instantiated object
                    BMICalc c = new BMICalc((heightft * 12 + heightin), weight, SysOfUnits.Imperial);
                    lblBMIValue.Text = "BMI: " + c.bmi.ToString();
                    lblBMIClassification.Text = "Category: " + c.category;
                }
            }
            catch (ArgumentOutOfRangeException ax)
            {
                MainPage.ShowMessage("Calculation Error", ax.ParamName);
            }
            catch (Exception ex)
            {
                MainPage.ShowMessage("Calculation Error", ex.Message);
            }
        }

        private bool isValid()
        {

            bool validData = true;
            string errMessage = "Please fix the following errors:" + Environment.NewLine;
            if (String.IsNullOrEmpty(txtHeightFeet.Text))  //check in height ft
            {
                txtHeightFeet.Foreground = correctBrush;
                validData = false;
                errMessage += "-No height ft. entered" + Environment.NewLine;
            }
            else if (!double.TryParse(txtHeightFeet.Text, out heightft))
            {
                txtHeightFeet.Foreground = errorBrush;
                validData = false;
                errMessage += "-Invalid Height ft." + Environment.NewLine;
            }
            else if (heightft <= 0)
            {
                txtHeightFeet.Foreground = errorBrush;
                validData = false;
                errMessage += "-Height Ft. must be greater then zero" + Environment.NewLine;
            }
            else
            {
                txtHeightFeet.Foreground = correctBrush;
            }
            //Check height in
            if (String.IsNullOrEmpty(txtHeightInches.Text))
            {
                txtHeightInches.Foreground = correctBrush;
                validData = false;
                errMessage += "-No height inches entered" + Environment.NewLine;
            }
            else if (!double.TryParse(txtHeightFeet.Text, out heightin))
            {
                txtHeightInches.Foreground = errorBrush;
                validData = false;
                errMessage += "-Invalid Height inches" + Environment.NewLine;
            }
            else if (heightin <= 0)
            {
                txtHeightInches.Foreground = errorBrush;
                validData = false;
                errMessage += "-Height Ft. must be greater then zero" + Environment.NewLine;
            }
            else
            {
                txtHeightInches.Foreground = correctBrush;
            }
            //Check Weight
            if (String.IsNullOrEmpty(txtWeight.Text))
            {
                txtHeightFeet.Foreground = correctBrush;
                txtHeightInches.Foreground = correctBrush;
                validData = false;
                errMessage += "-No weight entered" + Environment.NewLine;
            }
            else if (!double.TryParse(txtWeight.Text, out weight))
            {
                txtWeight.Foreground = errorBrush;
                validData = false;
                errMessage += "-Invalid Weight" + Environment.NewLine;
            }
            else if (weight <= 0)
            {
                txtWeight.Foreground = errorBrush;
                validData = false;
                errMessage += "-Weight must be greater then zero" + Environment.NewLine;
            }
            else
            {
                txtWeight.Foreground = correctBrush;
            }
            if (!validData)
                MainPage.ShowMessage("Invalid Data", errMessage);
            return validData;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {

            lblBMIClassification.Text = "";
            lblBMIValue.Text = "";
            txtHeightFeet.Text = "";
            txtHeightInches.Text = "";
            txtWeight.Text = "";
            txtHeightFeet.Foreground = correctBrush;
            txtHeightInches.Foreground = correctBrush;
            txtWeight.Foreground = correctBrush;
        }

    }
}
